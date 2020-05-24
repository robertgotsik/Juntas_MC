using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juntas_MC.BLL;
using Juntas_MC.DAL;
using Juntas_MC.PL;

namespace Juntas_MC.DAL
{
    class MaterialesDAL
    {
        ConexionDAL conexion;
        public MaterialesDAL()
        {
            conexion = new ConexionDAL();
        }

        //public bool agregar(MaterialesBLL oMaterialBLL)
        //{
        //    if (oMaterialBLL.Nombre != "")
        //    {
        //        SqlCommand SQLComando = new SqlCommand("Insert into Materiales VALUES(@Nombre)");
        //        SQLComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oMaterialBLL.Nombre;
        //        return conexion.ejecutarMetodoSinRetornoDatos(SQLComando);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se ingresaron datos en el campo Nombre.");
        //        return false;
        //    }
        //}

        //public DataSet mostrarMateriales()
        //{
        //    SqlCommand sentencia = new SqlCommand("Select * from Materiales order by Nombre");
        //    return conexion.ejecutarSentencia(sentencia);
        //}

        //public bool modificar(MaterialesBLL oMaterialBLL)
        //{
        //    if (oMaterialBLL.Nombre != "")
        //    {
        //        return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Materiales SET NOMBRE = '" + oMaterialBLL.Nombre + "'" + "where Id=" + oMaterialBLL.Id);
        //    }
        //    else
        //    {
        //        MessageBox.Show("El campo nombre debe ser completado.");
        //        return false;
        //    }
        //}

        //public int eliminar(MaterialesBLL oMaterialBLL)
        //{
        //    conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Materiales WHERE Id= " + oMaterialBLL.Id);

        //    return 1;
        //}


        //Implementacion con ACCES
        public bool agregar(MaterialesBLL oMaterialBLL)
        {
            if (oMaterialBLL.Nombre != "")
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Materiales (Nombre) VALUES(@Nombre)");
                oleDbComando.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = oMaterialBLL.Nombre;

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

        public DataSet mostrarMateriales()
        {
            OleDbCommand sentencia = new OleDbCommand("Select * from Materiales order by Nombre");
            return conexion.ejecutarSentencia(sentencia);
        }

        public bool modificar(MaterialesBLL oMaterialBLL)
        {
            if (oMaterialBLL.Nombre != "")
            {
                ModificacionDialogTrue oAgregadoDialog = new ModificacionDialogTrue();
                oAgregadoDialog.ShowDialog();
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Materiales SET NOMBRE = '" + oMaterialBLL.Nombre + "'" + "where Id=" + oMaterialBLL.Id);
            }
            else
            {
                ModificacionDialogFalse oAgregadoDialog = new ModificacionDialogFalse();
                oAgregadoDialog.ShowDialog();
                return false;
            }
        }

        public int eliminar(MaterialesBLL oMaterialBLL)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Materiales WHERE Id= " + oMaterialBLL.Id);

            return 1;
        }
    }
}
