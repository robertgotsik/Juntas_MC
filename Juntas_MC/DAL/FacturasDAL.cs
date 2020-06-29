using Juntas_MC.BLL;
using Juntas_MC.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.DAL
{
    public class FacturasDAL
    {
        ConexionDAL conexion;
        public FacturasDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool agregar(FacturasBLL oFacturasBLL)
        {
            if (oFacturasBLL.Cliente != -1)
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Facturas (Numero, Cliente, ImporteTotal, FechaEmision) VALUES(" +
                    "'" +oFacturasBLL.Numero
                    +"', " + oFacturasBLL.Cliente 
                    + ", '" + oFacturasBLL.ImporteTotal
                    + "', '" + DateTime.Now.Date.ToString("dd/MM/yyy") +"')");

                return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
            }
            else
            {
                AgregadoDialogFalse oAgregadoDialog = new AgregadoDialogFalse();
                oAgregadoDialog.ShowDialog();
                return false;
            }
        }

        public string buscarUltimoIdInsertado()
        {
            OleDbCommand sentencia = new OleDbCommand("Select TOP 1 Id FROM Facturas ORDER BY Id DESC");
            return conexion.ejecutarSentencia6(sentencia);
        }

        

        public DataSet mostrarFactura(int FacturaId)
        {
             OleDbCommand sentencia = new OleDbCommand("SELECT Id, Numero, Cliente, Round (ImporteTotal, 2) as ImporteTotal, FechaEmision FROM Facturas where Id = " + FacturaId);
            return conexion.ejecutarSentencia(sentencia);
        }


        
        
        public List<FacturasItemsBLL> detalleFactura(int FacturaId)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT * FROM Facturas F inner join FacturasItems FI on F.Id = FI.FacturaId where F.Id = " + FacturaId);
            
            List<FacturasItemsBLL> factItemsList = conexion.ejecutarSentencia(sentencia).Tables[0].AsEnumerable()
                        .Select(dataRow => new FacturasItemsBLL
                        {
                            Id = dataRow.Field<int>("FI.Id"),
                            FacturaId = dataRow.Field<int>("FacturaId"),
                            PiezaCodigo = dataRow.Field<string>("PiezaCodigo"),
                            PiezaId = dataRow.Field<int>("PiezaId"),
                            Descripcion = dataRow.Field<string>("Descripcion"),
                            Cantidad = dataRow.Field<int>("Cantidad"),
                            PrecioUnitario = dataRow.Field<decimal>("PrecioUnitario"),
                            Bonificacion = dataRow.Field<decimal>("Bonificacion"),
                            ItemImporteTotal = dataRow.Field<decimal>("ItemImporteTotal")
                        }).ToList();

             return factItemsList;
        }

        public DataSet buscarTodasFacturas(string FechaDesde, string FechaHasta, int Cliente)
        {
            System.Text.StringBuilder strSQL = new System.Text.StringBuilder();
            OleDbCommand sentencia = new OleDbCommand(Convert.ToString(strSQL));

            strSQL.Append("SELECT F.Id, F.Numero, F.FechaEmision, C.Nombre AS Cliente, F.Cliente as ClienteId, F.ImporteTotal FROM Facturas F INNER JOIN Mercados C on C.Id = F.Cliente ");
            if (FechaDesde != null | FechaHasta != null | Cliente != 0)
            {
                strSQL.Append("WHERE ");
                string whereClause = "";
                if (FechaDesde != null) whereClause += "F.FechaEmision >= '" + FechaDesde + "'";
                if (FechaHasta != null) whereClause += (whereClause != "" ? " and " : "") + "F.FechaEmision <= '" + FechaHasta + "'";
                if (Cliente != 0) whereClause += (whereClause != "" ? " and " : "") + "F.Cliente = " + Cliente;
                strSQL.Append(whereClause);
                strSQL.Append(" Order by F.Id");
            }

            sentencia.CommandText = (Convert.ToString(strSQL));
            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(int facturaId)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Facturas where Id= " + facturaId);

            return 1;
        }

        public string TotalVentas(string FechaDesde, string FechaHasta)
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT SUM (ImporteTotal) as Valor from Facturas where FechaEmision >= '" + FechaDesde + "' and FechaEmision <= '" + FechaHasta +"'");
            return conexion.MetodoString(sentencia);
        }
    }
}
