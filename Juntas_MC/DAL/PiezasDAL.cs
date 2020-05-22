using Juntas_MC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OleDbCommand sentencia = new OleDbCommand("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) order by PI.Codigo");
            return conexion.ejecutarSentencia(sentencia);
        }

        public bool agregar(PiezasBLL oPiezasBLL)
        {
            if (oPiezasBLL.Codigo != "")
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Piezas (Codigo, Precio, PiezaTipo, Material, Detalles, Imagen) VALUES(@Codigo, @Precio, @PiezaTipo, @Material, @Detalles, @Imagen)");
                oleDbComando.Parameters.AddWithValue("@Codigo", SqlDbType.VarChar).Value = oPiezasBLL.Codigo;
                oleDbComando.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = oPiezasBLL.Precio;
                oleDbComando.Parameters.AddWithValue("@PiezaTipo", SqlDbType.Int).Value = oPiezasBLL.PiezaTipo;
                oleDbComando.Parameters.AddWithValue("@Material", SqlDbType.Int).Value = oPiezasBLL.Material;
                oleDbComando.Parameters.AddWithValue("@Detalles", SqlDbType.VarChar).Value = oPiezasBLL.Detalles;
                oleDbComando.Parameters.AddWithValue("@Imagen", SqlDbType.VarChar).Value = oPiezasBLL.Imagen;
                return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
            }
            else
            {
                MessageBox.Show("No se ingresaron datos en el campo Codigo.");
                return false;
            }
        }
    }
}
