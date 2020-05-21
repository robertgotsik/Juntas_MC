using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.DAL
{
    class PreciosMercadosDAL
    {
        ConexionDAL conexion;
        public PreciosMercadosDAL()
        {
            conexion = new ConexionDAL();
        }

        //public DataSet mostrarPreciosMercados(int PiezaId, int MercadoId1, int MercadoId2, int MercadoId3, int MercadoId4)
        //{
        //    SqlCommand sentencia = new SqlCommand("Select Precio from PreciosMercados where Mercado in(" +MercadoId1 +"," +MercadoId2 +"," +MercadoId3 +"," + MercadoId4 +") and PiezaId=" +PiezaId );
        //    return conexion.ejecutarSentencia(sentencia);
        //}


        //Conexion mediante ACCES
        public DataSet mostrarPreciosMercados(int PiezaId, int MercadoId1, int MercadoId2, int MercadoId3, int MercadoId4)
        {
            OleDbCommand sentencia = new OleDbCommand("Select ME.Nombre as Mercado, PM.Precio from PreciosMercados PM inner join Mercados ME on ME.ID = PM.Mercado where Mercado in(" + MercadoId1 + "," + MercadoId2 + "," + MercadoId3 + "," + MercadoId4 + ") and PiezaId=" + PiezaId);
            return conexion.ejecutarSentencia(sentencia);
        }
    }
}
