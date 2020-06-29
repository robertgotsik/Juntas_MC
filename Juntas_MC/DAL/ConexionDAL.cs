using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Diagnostics;

namespace Juntas_MC.DAL
{
    public class ConexionDAL
    {
        //private string cadenaDeConexion = "Data Source = LAPTOP-B8SR8G56\\SQLEXPRESS; Initial Catalog = Juntas_MC; Integrated Security = True";
        //SqlConnection Conexion; //Obj Conexion

        //public SqlConnection establecerConexion()
        //{
        //    this.Conexion = new SqlConnection(cadenaDeConexion); //Constuye el obj Conexion
        //    return this.Conexion; //Retorna el objeto Conexion
        //}

        //Metodo INSERT, DELETE, UPDATE
        //public bool ejecutarMetodoSinRetornoDatos(string strComando)
        //{
        //    try
        //    {
        //        SqlCommand Comando = new SqlCommand();
        //        Comando.CommandText = strComando;
        //        Comando.Connection = this.establecerConexion();
        //        Conexion.Open();
        //        Comando.ExecuteNonQuery();
        //        Conexion.Close();
        //        return true;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No se pudo establecer conexion con la base de datos");
        //        return false;
        //    }
        //}
        ////Sobrecarga
        //public bool ejecutarMetodoSinRetornoDatos(SqlCommand SQLComando)
        //{
        //    try
        //    {
        //        SqlCommand Comando = SQLComando;
        //        Comando.Connection = this.establecerConexion();
        //        Conexion.Open();
        //        Comando.ExecuteNonQuery();
        //        Conexion.Close();
        //        return true;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No se pudo establecer conexion con la base de datos");
        //        return false;
        //    }
        //}


        //Metodo Retorno de datos (SELECT)
        //public DataSet ejecutarSentencia(SqlCommand sqlComando)
        //{
        //    DataSet DS = new DataSet();
        //    SqlDataAdapter Adaptador = new SqlDataAdapter();

        //    try
        //    {
        //        SqlCommand Comando = new SqlCommand();
        //        Comando = sqlComando;
        //        Comando.Connection = establecerConexion();
        //        Adaptador.SelectCommand = Comando;
        //        Conexion.Open();
        //        Adaptador.Fill(DS);
        //        Conexion.Close();
        //        return DS;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No se pudo establecer conexion con la base de datos");
        //        return DS;
        //    }
        //}



        //Conexion mediante ACCES
        //private string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\BackUp BD\Juntas_MC.accdb;Persist Security Info=False;";
        private string cadenaDeConexion = ConfigurationManager.ConnectionStrings["MS Access 12"].ConnectionString;
        OleDbConnection Conexion;
        StackTrace stackTrace = new StackTrace(); 

        public OleDbConnection establecerConexion()
        {
            this.Conexion = new OleDbConnection(cadenaDeConexion); //Constuye el obj Conexion
            return this.Conexion; //Retorna el objeto Conexion
        }

        //Metodo Retorno de datos (SELECT)
        public DataSet ejecutarSentencia(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" +ex);
                return DS;
            }
        }

        public bool ejecutarMetodoSinRetornoDatos(string strComando)
        {
            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando.CommandText = strComando;
                Comando.Connection = this.establecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" +ex);
                return false;
            }
        }
        //Sobrecarga
        public bool ejecutarMetodoSinRetornoDatos(OleDbCommand oleDbComando)
        {
            try
            {
                OleDbCommand Comando = oleDbComando;
                Comando.Connection = this.establecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" +ex);
                return false;
            }
        }

        public int ejecutarMetodoContador(OleDbCommand oleDbComando)
        {
            try
            {
                OleDbCommand Comando = oleDbComando;
                Comando.Connection = this.establecerConexion();
                Conexion.Open();
                int cantidadDeFilasAfectadas = Comando.ExecuteNonQuery();
                Conexion.Close();
                return cantidadDeFilasAfectadas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                return -1;
            }
        }

        public string ejecutarSentencia2(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Porcentaje"].ToString();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }

        public string ejecutarSentencia3(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Precio"].ToString();
                //value = value.Replace(",", ".");
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }

        public string ejecutarSentencia4(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Precio"].ToString();
                //value = value.Replace(",", ".");
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }

        public string ejecutarSentencia5(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Detalles"].ToString();
                //value = value.Replace(",", ".");
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }

        public string ejecutarSentencia6(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Id"].ToString();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }

        public string consultarNombreEmpresa(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Id"].ToString();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }

        public string MetodoString(OleDbCommand oleDbComando)
        {
            DataSet DS = new DataSet();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string value;

            try
            {
                OleDbCommand Comando = new OleDbCommand();
                Comando = oleDbComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                value = DS.Tables[0].Rows[0]["Valor"].ToString();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos" + ex);
                value = "Hubo una falla";
                return value;
            }
        }
    }
}
