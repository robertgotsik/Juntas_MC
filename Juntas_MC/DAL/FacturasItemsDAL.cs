using Juntas_MC.BLL;
using Juntas_MC.PL;
using System;
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

        public bool insertarFacturasItems(int FacturaId, int PiezaId, string PiezaCodigo, int Cantidad, string Descripcion, decimal PrecioUnitario, decimal Bonificacion, decimal ItemImporteTotal)
        {
            if (FacturaId != 0)
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into FacturasItems (FacturaId, PiezaId, PiezaCodigo, Cantidad, Descripcion, PrecioUnitario, Bonificacion, ItemImporteTotal) VALUES(" +
                    FacturaId +", " +
                    +PiezaId +", '" +
                    PiezaCodigo +"', " +
                    Cantidad +", '" +
                    Descripcion +"', '" +
                    PrecioUnitario + "', '" +
                    Bonificacion +"', '" +
                    ItemImporteTotal +"')");
                //oleDbComando.Parameters.AddWithValue("@FacturaId", SqlDbType.Int).Value = FacturaId;
                //oleDbComando.Parameters.AddWithValue("@PiezaId", SqlDbType.Int).Value = PiezaId;
                //oleDbComando.Parameters.AddWithValue("@PiezaCodigo", SqlDbType.VarChar).Value = PiezaCodigo;
                //oleDbComando.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = Cantidad;
                //oleDbComando.Parameters.AddWithValue("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
                //oleDbComando.Parameters.AddWithValue("@PrecioUnitario", SqlDbType.Decimal).Value = PrecioUnitario;
                //oleDbComando.Parameters.AddWithValue("@Bonificacion", SqlDbType.Decimal).Value = Bonificacion;
                //oleDbComando.Parameters.AddWithValue("@ItemImporteTotal", SqlDbType.Decimal).Value = ItemImporteTotal;

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
    }
}
