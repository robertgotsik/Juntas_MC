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
    class FacturasDAL
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
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Facturas (Numero, Cliente, ImporteTotal) VALUES(@Numero, @Cliente, @ImporteTotal)");
                oleDbComando.Parameters.AddWithValue("@Numero", SqlDbType.VarChar).Value = oFacturasBLL.Numero;
                oleDbComando.Parameters.AddWithValue("@Cliente", SqlDbType.Int).Value = oFacturasBLL.Cliente;
                oleDbComando.Parameters.AddWithValue("@ImporteTotal", SqlDbType.Decimal).Value = oFacturasBLL.ImporteTotal;

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
    }
}
