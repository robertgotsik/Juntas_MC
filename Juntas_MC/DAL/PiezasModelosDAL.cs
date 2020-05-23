using Juntas_MC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.DAL
{
    public class PiezasModelosDAL
    {
        ConexionDAL conexion;
        public PiezasModelosDAL()
        {
            conexion = new ConexionDAL();
        }
        public bool agregar(PiezasModelosBLL oPiezasModelosBLL)
        {
            OleDbCommand oleDbComando = new OleDbCommand("Insert into PiezasModelos (Pieza, Modelo) values (@Pieza, @Modelo)");
            oleDbComando.Parameters.AddWithValue("@Pieza", SqlDbType.VarChar).Value = oPiezasModelosBLL.Pieza;
            oleDbComando.Parameters.AddWithValue("@Modelo", SqlDbType.VarChar).Value = oPiezasModelosBLL.Modelo;
            return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
        }

        public DataSet mostrarPiezasModelos(int PiezaId)
        {
            OleDbCommand sentencia = new OleDbCommand("Select MO.Id, MA.Id, MO.Nombre & " + " ' ['" + " & MA.Nombre & " + "']' " + "as ModeloMarca from (((PiezasModelos PM inner join Piezas PI on PI.Id = PM.Pieza) inner join Modelos MO on MO.Id = PM.Modelo) inner join Marcas MA on MA.Id = MO.Marca) where Pieza = " +PiezaId +" order by PM.Id");
            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(PiezasModelosBLL oPiezasModelosBLL)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM PiezasModelos where Pieza= " + oPiezasModelosBLL.Pieza +"and Modelo = " + oPiezasModelosBLL.Modelo);

            return 1;
        }

    }
}
