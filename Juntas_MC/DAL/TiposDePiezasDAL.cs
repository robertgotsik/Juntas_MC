using Juntas_MC.BLL;
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
    public class TiposDePiezasDAL
    {
        ConexionDAL conexion;

        public TiposDePiezasDAL()
        {
            conexion = new ConexionDAL();
        }

        //public bool agregar(TiposDePiezasBLL oTiposDePiezas)
        //{
        //    SqlCommand SQLComando = new SqlCommand("Insert into TiposDePiezas VALUES(@Nombre)");
        //    SQLComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oTiposDePiezas.Nombre;
        //    return conexion.ejecutarMetodoSinRetornoDatos(SQLComando);
        //}

        //public DataSet mostrarResultados()
        //{
        //    SqlCommand sentencia = new SqlCommand("SELECT * FROM PiezasTipos ORDER BY Nombre");
        //    return conexion.ejecutarSentencia(sentencia);
        //}

        //public int eliminar(TiposDePiezasBLL oTiposDePiezas)
        //{
        //    conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM TiposDePiezas where Id = " + oTiposDePiezas.Id);

        //    return 1;
        //}

        //public bool modificar(TiposDePiezasBLL oTiposDePiezas)
        //{
        //    return conexion.ejecutarMetodoSinRetornoDatos("UPDATE TiposDePiezas SET NOMBRE = '" + oTiposDePiezas.Nombre + "' WHERE Id =" + oTiposDePiezas.Id);
        //}



        //Conexion mediante ACCES
        public bool agregar(TiposDePiezasBLL oTiposDePiezas)
        {
            OleDbCommand oleDbComando = new OleDbCommand("Insert into PiezasTipos (Nombre) VALUES(@Nombre)");
            oleDbComando.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = oTiposDePiezas.Nombre;
            return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
        }

        public DataSet mostrarResultados()
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT * FROM PiezasTipos ORDER BY Nombre");
            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(TiposDePiezasBLL oTiposDePiezas)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM PiezasTipos where Id = " + oTiposDePiezas.Id);

            return 1;
        }

        public bool modificar(TiposDePiezasBLL oTiposDePiezas)
        {
            return conexion.ejecutarMetodoSinRetornoDatos("UPDATE PiezasTipos SET NOMBRE = '" + oTiposDePiezas.Nombre + "' WHERE Id =" + oTiposDePiezas.Id);
        }
    }
}
