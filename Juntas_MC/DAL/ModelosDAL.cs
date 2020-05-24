using Juntas_MC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juntas_MC.PL;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Juntas_MC.DAL
{
    class ModelosDAL
    {
        ConexionDAL conexion;
        public ModelosDAL()
        {
            conexion = new ConexionDAL();
        }

        //public DataSet consultarMarcas()
        //{
        //    SqlCommand sentencia = new SqlCommand("Select * from Marcas order by nombre");
        //    return conexion.ejecutarSentencia(sentencia);
        //}

        //public bool agregar(ModelosBLL oModelosBLL)
        //{
        //    if (oModelosBLL.Nombre != "")
        //    {
        //        SqlCommand SQLComando = new SqlCommand("Insert into Modelos VALUES(@Nombre,@Marca)");
        //        SQLComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oModelosBLL.Nombre;
        //        SQLComando.Parameters.Add("@Marca", SqlDbType.Int).Value = oModelosBLL.Marca;
        //        return conexion.ejecutarMetodoSinRetornoDatos(SQLComando);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se ingresaron datos en el campo Nombre.");
        //        return false;
        //    }
        //}

        //public DataSet mostrarModelos()
        //{
        //    SqlCommand sentencia = new SqlCommand("Select Mo.Id as MoID, MO.Nombre as Modelo,MO.Marca as MaID, MA.Nombre as Marca from Modelos MO inner join Marcas MA on MA.id = MO.Marca order by MO.Nombre");
        //    return conexion.ejecutarSentencia(sentencia);
        //}

        //public int eliminar(ModelosBLL oModelosBLL)
        //{
        //    conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Modelos where Id= " + oModelosBLL.Id );

        //    return 1;
        //}

        //public bool modificar(ModelosBLL oModelosBLL)
        //{
        //    if (oModelosBLL.Nombre != "")
        //    {
        //        return conexion.ejecutarMetodoSinRetornoDatos("UPDATE MODELOS SET NOMBRE = '" + oModelosBLL.Nombre + "'" + ",MARCA =" + oModelosBLL.Marca + "where Id=" + oModelosBLL.Id);
        //    }
        //    else
        //    {
        //        MessageBox.Show("El campo nombre debe ser completado.");
        //        return false;
        //    }
        //}



        //Conexion mediante ACCES

        public bool agregar(ModelosBLL oModelosBLL)
        {
            if (oModelosBLL.Nombre != "")
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Modelos (Nombre, Marca) VALUES(@Nombre,@Marca)");
                oleDbComando.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = oModelosBLL.Nombre;
                oleDbComando.Parameters.AddWithValue("@Marca", SqlDbType.Int).Value = oModelosBLL.Marca;

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

        public DataSet mostrarModelos()
        {
            OleDbCommand sentencia = new OleDbCommand("Select Mo.Id as MoID, MO.Nombre as Modelo,MO.Marca as MaID, MA.Nombre as Marca from Modelos MO inner join Marcas MA on MA.id = MO.Marca order by MO.Nombre");
            return conexion.ejecutarSentencia(sentencia);
        }

        public DataSet mostrarModelosCmb()
        {
            OleDbCommand sentencia = new OleDbCommand("SELECT MO.Id, MO.Nombre & " +" ' ['" +" & MA.Nombre & " +"']' " +"as NombreModeloMarca from Modelos MO inner join Marcas MA on MO.Marca = MA.Id order by Mo.Nombre");
            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(ModelosBLL oModelosBLL)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Modelos where Id= " + oModelosBLL.Id);

            return 1;
        }

        public bool modificar(ModelosBLL oModelosBLL)
        {
            if (oModelosBLL.Nombre != "")
            {
                ModificacionDialogTrue oAgregadoDialog = new ModificacionDialogTrue();
                oAgregadoDialog.ShowDialog();
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE MODELOS SET NOMBRE = '" + oModelosBLL.Nombre + "'" + ",MARCA =" + oModelosBLL.Marca + " where Id=" + oModelosBLL.Id);
            }
            else
            {
                ModificacionDialogFalse oAgregadoDialog = new ModificacionDialogFalse();
                oAgregadoDialog.ShowDialog();

                return false;
            }
        }
    }
}
