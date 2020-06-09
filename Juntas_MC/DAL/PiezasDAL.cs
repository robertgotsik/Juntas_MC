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
            OleDbCommand sentencia = new OleDbCommand("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen, Switch(Estado = 0, 'Suspendido', Estado = 1, 'Activo') as Estado from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) order by PI.Codigo");
            return conexion.ejecutarSentencia(sentencia);
        }
        public DataSet mostrarPiezas2()
        {
            OleDbCommand sentencia = new OleDbCommand("Select * from Piezas order by Codigo");
            return conexion.ejecutarSentencia(sentencia);
        }

        public DataSet mostrarPiezasConFiltros(string codigo, string precioDesde, string precioHasta, int material, int modComp, int tipoDePieza, int estado)
        {
            if (modComp != 0)
            {
                System.Text.StringBuilder strSQL = new System.Text.StringBuilder();
                OleDbCommand sentencia = new OleDbCommand(Convert.ToString(strSQL));


                strSQL.Append("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen, Switch(Estado = 0, 'Suspendido', Estado = 1, 'Activo') as Estado from (((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) inner join PiezasModelos PM on PM.Pieza = PI.ID) ");
                if (codigo != "" | precioDesde != "" | precioHasta != "" | material != 0 | modComp != 0 | tipoDePieza != 0 | estado != -1)
                {
                    strSQL.Append("WHERE ");
                    string whereClause = "";
                    if (modComp != 0) whereClause += "PM.Modelo = " + modComp;
                    if (codigo != "") whereClause += (whereClause != "" ? " and " : "") + "codigo = '" + codigo + "'";
                    if (material != 0) whereClause += (whereClause != "" ? " and " : "") + "PI.Material = " + material;
                    if (tipoDePieza != 0) whereClause += (whereClause != "" ? " and " : "") + "PI.PiezaTipo = " + tipoDePieza;
                    if (precioDesde != "") whereClause += (whereClause != "" ? " and " : "") + "PI.Precio >= " + precioDesde;
                    if (precioHasta != "") whereClause += (whereClause != "" ? " and " : "") + "PI.Precio <= " + precioHasta;
                    if (estado != -1) whereClause += (whereClause != "" ? " and " : "") + "PI.Estado = " + estado;
                    strSQL.Append(whereClause);
                    strSQL.Append(" Order by  PI.Codigo");
                }

                sentencia.CommandText = (Convert.ToString(strSQL));
                return conexion.ejecutarSentencia(sentencia);
            }
            else
            {
                System.Text.StringBuilder strSQL = new System.Text.StringBuilder();
                OleDbCommand sentencia = new OleDbCommand(Convert.ToString(strSQL));

                strSQL.Append("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen, Switch(Estado = 0, 'Suspendido', Estado = 1, 'Activo') as Estado from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) ");
                if (codigo != "" | precioDesde != "" | precioHasta != "" | material != 0 | modComp != 0 | tipoDePieza != 0 | estado != -1)
                {
                    strSQL.Append("WHERE ");
                    string whereClause = "";
                    if (codigo != "") whereClause += "codigo = '" + codigo + "'";
                    if (material != 0) whereClause += (whereClause != "" ? " and " : "") + "PI.Material = " + material;
                    if (tipoDePieza != 0) whereClause += (whereClause != "" ? " and " : "") + "PI.PiezaTipo = " + tipoDePieza;
                    if (precioDesde != "") whereClause += (whereClause != "" ? " and " : "") + "PI.Precio >= " + precioDesde;
                    if (precioHasta != "") whereClause += (whereClause != "" ? " and " : "") + "PI.Precio <= " + precioHasta;
                    if (estado != -1) whereClause += (whereClause != "" ? " and " : "") + "PI.Estado = " + estado;
                    strSQL.Append(whereClause);
                    strSQL.Append(" Order by  PI.Codigo");
                }

                sentencia.CommandText = (Convert.ToString(strSQL));
                return conexion.ejecutarSentencia(sentencia);
            }
        }

        public DataSet actualizadorPreciosConFiltros(int codigo, int tipoDePieza, int material)
        {
            System.Text.StringBuilder strSQL = new System.Text.StringBuilder();
            OleDbCommand sentencia = new OleDbCommand(Convert.ToString(strSQL));

            strSQL.Append("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen, Switch(Estado = 0, 'Suspendido', Estado = 1, 'Activo') as Estado from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) ");
            if (codigo != 0 | material != 0 | tipoDePieza != 0 )
            {
                strSQL.Append("WHERE ");
                string whereClause = "";
                if (codigo != 0) whereClause += "PI.Id = " + codigo;
                if (material != 0) whereClause += (whereClause != "" ? " and " : "") + "PI.Material = " + material;
                if (tipoDePieza != 0) whereClause += (whereClause != "" ? " and " : "") + "PI.PiezaTipo = " + tipoDePieza;
                strSQL.Append(whereClause);
                strSQL.Append(" Order by  PI.Codigo");
            }

            sentencia.CommandText = (Convert.ToString(strSQL));
            return conexion.ejecutarSentencia(sentencia);
        }

        public bool agregar(PiezasBLL oPiezasBLL)
        {
            if ((oPiezasBLL.Codigo != "") & Convert.ToBoolean(Convert.ToString(oPiezasBLL.Precio != 0)) & (oPiezasBLL.Estado != -1))
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Piezas (Codigo, Precio, PiezaTipo, Material, Detalles, Imagen, Estado) VALUES ('" + oPiezasBLL.Codigo + "', '" + oPiezasBLL.Precio + "', " + oPiezasBLL.PiezaTipo + ", " + oPiezasBLL.Material + ", '" + oPiezasBLL.Detalles + "', '" + oPiezasBLL.Imagen + "'," + oPiezasBLL.Estado + ")");

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

        public int eliminar(PiezasBLL oPiezasBLL)
        {
            conexion.ejecutarMetodoSinRetornoDatos("DELETE FROM Piezas where Id= " + oPiezasBLL.Id);

            return 1;
        }

        public bool modificar(PiezasBLL oPiezasBLL)
        {
            if ((oPiezasBLL.Codigo != "") & Convert.ToBoolean(Convert.ToString(oPiezasBLL.Precio != 0)))
            {
                ModificacionDialogTrue oModificacionDialog = new ModificacionDialogTrue();
                oModificacionDialog.ShowDialog();
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Piezas SET Codigo = '" + oPiezasBLL.Codigo + "'" + ",Precio ='" + oPiezasBLL.Precio + "',PiezaTipo =" + oPiezasBLL.PiezaTipo + ",Material =" + oPiezasBLL.Material + ",Detalles = '" + oPiezasBLL.Detalles + "',Imagen = '" + oPiezasBLL.Imagen + "', Estado = " +oPiezasBLL.Estado +" where Id=" + oPiezasBLL.Id);
            }
            else
            {
                ModificacionDialogFalse oModificacionDialog = new ModificacionDialogFalse();
                oModificacionDialog.ShowDialog();
                return false;
            }
        }

        public bool modificarPreciosMasivo(string operando, string operador)
        {
            if (operando != "" & operador != "")
            {
                //ModificacionDialogTrue oModificacionDialog = new ModificacionDialogTrue();
                //oModificacionDialog.ShowDialog();
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Piezas SET Precio = Precio " +operador +" " +operando);
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
