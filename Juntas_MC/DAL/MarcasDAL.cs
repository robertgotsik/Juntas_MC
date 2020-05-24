using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Juntas_MC.BLL;
using System.Data.OleDb;
using Juntas_MC.PL;

namespace Juntas_MC.DAL
{
    class MarcasDAL
    {
        ConexionDAL conexion;
        public MarcasDAL()
        {
            conexion = new ConexionDAL();
        }

        //public bool agregar(MarcasBLL oMarcasBLL)
        //{
        //    SqlCommand SQLComando = new SqlCommand("Insert into Marcas VALUES(@Nombre)");
        //    SQLComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value=oMarcasBLL.Nombre;
        //    return conexion.ejecutarMetodoSinRetornoDatos(SQLComando);
        //    //return conexion.ejecutarMetodoSinRetornoDatos("INSERT INTO [dbo].[Marcas]([Nombre])VALUES('" +oMarcasBLL.Nombre +"')");
        //}

        //public DataSet mostrarMarcas()
        //{
        //    SqlCommand sentencia = new SqlCommand("Select * from Marcas order by Nombre");
        //    return conexion.ejecutarSentencia(sentencia);
        //}

        //public int eliminar(MarcasBLL oMarcasBLL)
        //{
        //    conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Marcas where Id = " +oMarcasBLL.Id);

        //    return 1;
        //}

        //public bool modificar(MarcasBLL oMarcasBLL)
        //{
        //    return conexion.ejecutarMetodoSinRetornoDatos("UPDATE MARCAS SET NOMBRE = '" +oMarcasBLL.Nombre +"' where Id =" +oMarcasBLL.Id);
        //}

        //Implementacion con ACCES
        public bool agregar(MarcasBLL oMarcasBLL)
        {
            if (oMarcasBLL.Nombre != "")
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Marcas (Nombre) values (@Nombre)");
                oleDbComando.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = oMarcasBLL.Nombre;

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

        public DataSet mostrarMarcas()
        {
            OleDbCommand sentencia = new OleDbCommand("Select * from Marcas order by Nombre");
            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(MarcasBLL oMarcasBLL)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Marcas where Id = " + oMarcasBLL.Id);

            return 1;
        }

        public bool modificar(MarcasBLL oMarcasBLL)
        {
            if(oMarcasBLL.Nombre != "")
            {
                ModificacionDialogTrue oModificacionDialog = new ModificacionDialogTrue();
                oModificacionDialog.ShowDialog();
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Marcas SET NOMBRE = '" + oMarcasBLL.Nombre + "' where Id =" + oMarcasBLL.Id);
            }
            else
            {
                ModificacionDialogFalse oModificacionDialog = new ModificacionDialogFalse();
                oModificacionDialog.ShowDialog();
                return false;
            }
        }
    }
}
