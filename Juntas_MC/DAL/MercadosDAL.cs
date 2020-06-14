using Juntas_MC.BLL;
using Juntas_MC.PL;
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
            OleDbCommand sentencia = new OleDbCommand("Select Id, Nombre, IdTipo, Switch(IdTipo = 0, 'Cliente', IdTipo = 1, 'Proveedor') as Tipo, Telefono1, Telefono2, Email, Web, Direccion, Localidad, Provincia from Mercados order by Nombre");
            return conexion.ejecutarSentencia(sentencia);
        }

        public DataSet mostrarMercadosConFiltos(string nombre, int tipo)
        {

            System.Text.StringBuilder strSQL = new System.Text.StringBuilder();
            OleDbCommand sentencia = new OleDbCommand(Convert.ToString(strSQL));


            strSQL.Append("Select Id, Nombre, IdTipo, Switch(IdTipo = 0, 'Cliente', IdTipo = 1, 'Proveedor') as Tipo, Telefono1, Telefono2, Email, Web, Direccion, Localidad, Provincia from Mercados ");
            if (nombre != "" | tipo != -1)
            {
                strSQL.Append("WHERE ");
                string whereClause = "";
                if (nombre != "") whereClause += "Nombre = '" + nombre + "'";
                if (tipo != -1) whereClause += (whereClause != "" ? " and " : "") + "IdTipo = " + tipo;
                strSQL.Append(whereClause);
                strSQL.Append(" order by Nombre");
            }

            sentencia.CommandText = (Convert.ToString(strSQL));
            return conexion.ejecutarSentencia(sentencia);
        }

        public DataSet mostrarProvincias()
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT * FROM Provincias ORDER BY Id");
            return conexion.ejecutarSentencia(sentencia);
        }


        public bool agregar(MercadosBLL oMercadosBLL)
        {
            if ((oMercadosBLL.Nombre != "") & Convert.ToBoolean(Convert.ToInt32(oMercadosBLL.Tipo != -1)) & Convert.ToBoolean(Convert.ToInt32(oMercadosBLL.Provincia != 0)))
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Mercados (Nombre, IdTipo, Telefono1, Telefono2, Email, Web, Direccion, Localidad, Provincia) VALUES(@Nombre, @IdTipo, @Telefono1, @Telefono2, @Email, @Web, @Direccion, @Localidad, @Provincia)");
                oleDbComando.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = oMercadosBLL.Nombre;
                oleDbComando.Parameters.AddWithValue("@IdTipo", SqlDbType.Int).Value = oMercadosBLL.Tipo;
                oleDbComando.Parameters.AddWithValue("@Telefono1", SqlDbType.VarChar).Value = oMercadosBLL.Telefono1;
                oleDbComando.Parameters.AddWithValue("@Telefono2", SqlDbType.VarChar).Value = oMercadosBLL.Telefono2;
                oleDbComando.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = oMercadosBLL.Email;
                oleDbComando.Parameters.AddWithValue("@Web", SqlDbType.VarChar).Value = oMercadosBLL.Web;
                oleDbComando.Parameters.AddWithValue("@Direccion", SqlDbType.VarChar).Value = oMercadosBLL.Direccion;
                oleDbComando.Parameters.AddWithValue("@Localidad", SqlDbType.VarChar).Value = oMercadosBLL.Localidad;
                oleDbComando.Parameters.AddWithValue("@Provincia", SqlDbType.Int).Value = oMercadosBLL.Provincia;

                AgregadoDialogTrue oAgregadoDialog = new AgregadoDialogTrue();
                oAgregadoDialog.ShowDialog();

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
            OleDbCommand sentencia = new OleDbCommand("Select TOP 1 Id FROM Mercados ORDER BY Id DESC");
            return conexion.ejecutarSentencia2(sentencia);
        }
    }
}
