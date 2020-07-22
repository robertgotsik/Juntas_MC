using Juntas_MC.BLL;
using Juntas_MC.PL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.DAL
{
    class FacturasItemsDAL
    {
        ConexionDAL conexion;
        public FacturasItemsDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool insertarFacturasItems(int FacturaId, int PiezaId, string PiezaCodigo, int Cantidad, string Descripcion, decimal PrecioUnitario, decimal Bonificacion, decimal ItemImporteTotal, string porcBonif)
        {
            if (FacturaId != 0)
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into FacturasItems (FacturaId, PiezaId, PiezaCodigo, Cantidad, Descripcion, PrecioUnitario, Bonificacion, ItemImporteTotal, PorcBonif) VALUES(" +
                    FacturaId +", " +
                    +PiezaId +", '" +
                    PiezaCodigo +"', " +
                    Cantidad +", '" +
                    Descripcion +"', '" +
                    PrecioUnitario + "', '" +
                    Bonificacion +"', '" +
                    ItemImporteTotal +"', '"+
                    porcBonif +"')");

                return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
            }
            else
            {
                AgregadoDialogFalse oAgregadoDialog = new AgregadoDialogFalse();
                oAgregadoDialog.ShowDialog();
                return false;
            }
        }

        public int eliminar(int facturaId)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM FacturasItems where FacturaId= " + facturaId);

            return 1;
        }

        public string CantPiezasVendidas(string FechaDesde, string FechaHasta)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT IIf(IsNull(SUM (Cantidad)),0, (SUM (Cantidad))) as Valor FROM FacturasItems FI INNER JOIN Facturas F ON F.Id = FI.FacturaId where FechaEmision BETWEEN #" + FechaDesde + "# and #" + FechaHasta +"#");
            return conexion.MetodoString(sentencia);
        }


        public List<FacturasItemsBLL> CodigoPiezaTopVentas(string FechaDesde, string FechaHasta)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT TOP 5 FI.PiezaCodigo, SUM (Cantidad) as Cant FROM Facturas F INNER JOIN FacturasItems FI ON FI.FacturaId = F.Id WHERE F.FechaEmision BETWEEN #" + FechaDesde + "# AND #" + FechaHasta + "# GROUP BY PiezaCodigo ORDER BY SUM (Cantidad) DESC");

            List<FacturasItemsBLL> factItemsList = conexion.ejecutarSentencia(sentencia).Tables[0].AsEnumerable()
                        .Select(dataRow => new FacturasItemsBLL
                        {
                            PiezaCodigo = dataRow.Field<string>("PiezaCodigo"),
                            Cantidad = Convert.ToInt32(dataRow.Field<double>("Cant")),
                        }).ToList();

            return factItemsList;
        }
        public List<FacturasItemsBLL> GananciasPorPieza(string FechaDesde, string FechaHasta)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT TOP 5 FI.PiezaCodigo, SUM (ItemImporteTotal) as Importe FROM Facturas F INNER JOIN FacturasItems FI ON FI.FacturaId = F.Id WHERE F.FechaEmision BETWEEN #" + FechaDesde + "# AND #" + FechaHasta + "# GROUP BY PiezaCodigo");

            List<FacturasItemsBLL> factItemsList = conexion.ejecutarSentencia(sentencia).Tables[0].AsEnumerable()
                        .Select(dataRow => new FacturasItemsBLL
                        {
                            PiezaCodigo = dataRow.Field<string>("PiezaCodigo"),
                            ItemImporteTotal = dataRow.Field<decimal>("Importe")
                        }).ToList();

            return factItemsList;
        }

        public string ClientesAlcanzados(string FechaDesde, string FechaHasta)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT COUNT (*) AS Valor FROM (SELECT DISTINCT Cliente FROM Facturas where FechaEmision BETWEEN #" + FechaDesde + "# and #" + FechaHasta + "# )");
            return conexion.MetodoString(sentencia);
        }

        public string PiezaTipoMasVendido(string FechaDesde, string FechaHasta)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT TOP 1 PT.Nombre as Valor FROM ( SELECT PT.Nombre, SUM (Cantidad) as Cant FROM ((Facturas F INNER JOIN FacturasItems FI on FI.FacturaId = F.Id) INNER JOIN Piezas P ON P.Id = FI.PiezaId) INNER JOIN PiezasTipos PT ON PT.Id = P.PiezaTipo WHERE FechaEmision BETWEEN #" + FechaDesde + "# and #" + FechaHasta + "# GROUP BY PT.Nombre ORDER BY SUM (Cantidad) DESC)");
            return conexion.MetodoString(sentencia);
        }
    }
}
