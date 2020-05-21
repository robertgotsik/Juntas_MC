using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ConexionBase
    {
        private string CadenaConexion = "Data Source = LAPTOP-B8SR8G56\\SQLEXPRESS; Initial Catalog = Juntas_MC; Integrated Security = True";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }

        //Metodo Insert, Delete, Update
        public bool ejecutarComandoSinRetornoDatos(string strComenado)
        {
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComenado;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Select (Retorno Datos)
    }
}
