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
    class MercadosDAL
    {
        ConexionDAL conexion;
        public MercadosDAL()
        {
            conexion = new ConexionDAL();
        }



        //public DataSet mostrarMercados()
        //{
        //    SqlCommand sentencia = new SqlCommand("Select * from Mercados");
        //    return conexion.ejecutarSentencia(sentencia);
        //}



        //Conexion mediante ACCES
        public DataSet mostrarMercados()
        {
            OleDbCommand sentencia = new OleDbCommand("Select * from Mercados");
            return conexion.ejecutarSentencia(sentencia);
        }

    }
}
