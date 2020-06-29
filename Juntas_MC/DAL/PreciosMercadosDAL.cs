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
    class PreciosMercadosDAL
    {
        ConexionDAL conexion;
        public PreciosMercadosDAL()
        {
            conexion = new ConexionDAL();
        }

        //public DataSet mostrarPreciosMercados(int PiezaId, int MercadoId1, int MercadoId2, int MercadoId3, int MercadoId4)
        //{
        //    SqlCommand sentencia = new SqlCommand("Select Precio from PreciosMercados where Mercado in(" +MercadoId1 +"," +MercadoId2 +"," +MercadoId3 +"," + MercadoId4 +") and PiezaId=" +PiezaId );
        //    return conexion.ejecutarSentencia(sentencia);
        //}


        //Conexion mediante ACCES
        public DataSet mostrarPreciosMercados(int PiezaId, int MercadoId1, int MercadoId2, int MercadoId3, int MercadoId4)
        {
            OleDbCommand sentencia = new OleDbCommand("Select ME.Nombre as Mercado, Round (PM.Precio, 2) as Precio from PreciosMercados PM inner join Mercados ME on ME.ID = PM.Mercado where Mercado in(" + MercadoId1 + "," + MercadoId2 + "," + MercadoId3 + "," + MercadoId4 + ") and PiezaId=" + PiezaId);
            return conexion.ejecutarSentencia(sentencia);
        }

        public DataSet mostrarPreciosMercadosFull(int IdMercado)
        {
            OleDbCommand sentencia = new OleDbCommand("Select PM.PiezaId, PI.Codigo as Pieza, Round (PM.Precio, 2) as Precio from PreciosMercados PM inner join Piezas PI on PI.ID = PM.PiezaId where Mercado = " + IdMercado);
            return conexion.ejecutarSentencia(sentencia);
        }

        public int borrarPreciosMercadosExistentes(int aReplicar)
        {
            //Primero deleteo los registros
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM PreciosMercados WHERE Mercado = " + aReplicar);
            return 1;
        }


        public bool replicarPreciosMercados(int aReplicar, int referencia)
        {
            //Luego inserto la replicacion
            OleDbCommand oleDbComando = new OleDbCommand("INSERT INTO PreciosMercados ( PiezaId, Mercado, Precio, Estado ) SELECT PiezaId, " + aReplicar + ", Precio, Estado FROM PreciosMercados WHERE Mercado = " + referencia);

            AgregadoDialogTrue oAgregadoDialog = new AgregadoDialogTrue();
            oAgregadoDialog.ShowDialog();

            return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
        }


        
        public void insertarPreciosListaAMercados(int aReplicar)
        {
            //Cuando agrego un nuevo Mercado le inserto los precios de lista (provenientes de tabla piezas)
            OleDbCommand oleDbComando = new OleDbCommand("INSERT INTO PreciosMercados ( PiezaId, Mercado, Precio, Estado ) SELECT Id,"+ aReplicar + ", Precio, Estado FROM Piezas");

            conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
        }

        public bool agregar(PreciosMercadosBLL oPreciosMercadosBLL)
        {
            OleDbCommand oleDbComando = new OleDbCommand("Insert into PreciosMercados (PiezaId, Mercado, Precio, Estado) values (@Pieza, @Mercado, @Precio, 1)");
            oleDbComando.Parameters.AddWithValue("@Pieza", SqlDbType.Int).Value = oPreciosMercadosBLL.PiezaId;
            oleDbComando.Parameters.AddWithValue("@Mercado", SqlDbType.Int).Value = oPreciosMercadosBLL.Mercado;
            oleDbComando.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = oPreciosMercadosBLL.Precio;
            //oleDbComando.Parameters.AddWithValue("@Estado", SqlDbType.Int).Value = oPreciosMercadosBLL.Estado;
            return conexion.ejecutarMetodoSinRetornoDatos(oleDbComando);
        }

        public int eliminar(PreciosMercadosBLL oPreciosMercadosBLL)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM PreciosMercados where Mercado= " + oPreciosMercadosBLL.Mercado +" and PiezaId = " +oPreciosMercadosBLL.PiezaId);

            return 1;
        }

        public string buscarPrecioProveedorPieza(int MercadoId, int PiezaId)
        {
            OleDbCommand sentencia = new OleDbCommand("Select ME.Nombre as Mercado, Round (PM.Precio, 2) as Precio from PreciosMercados PM inner join Mercados ME on ME.ID = PM.Mercado where Mercado = "+ MercadoId + " and PiezaId=" + PiezaId);
            return conexion.ejecutarSentencia4(sentencia);
        }
    }
}
