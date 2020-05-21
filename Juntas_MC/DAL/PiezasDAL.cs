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

    class PiezasDAL
    {
        ConexionDAL conexion;
        public PiezasDAL()
        {
            conexion = new ConexionDAL();
        }

        //public DataSet mostrarPiezas()
        //{
        //    SqlCommand sentencia = new SqlCommand("Select PI.Id, PI.Codigo, PI.Nombre, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as 'Tipo de Pieza', MA.Id, MA.Nombre as Material from Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id inner join Materiales MA on MA.Id = PI.Material order by PI.Codigo");
        //    return conexion.ejecutarSentencia(sentencia);
        //}

        //Conexion mediante ACCES
        public DataSet mostrarPiezas()
        {
            OleDbCommand sentencia = new OleDbCommand("Select PI.Id, PI.Codigo, PI.Nombre, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as 'Tipo de Pieza', MA.Id, MA.Nombre as Material from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) order by PI.Codigo");
            return conexion.ejecutarSentencia(sentencia);
        }
    }
}
