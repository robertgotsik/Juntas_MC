﻿using Juntas_MC.BLL;
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
            OleDbCommand sentencia = new OleDbCommand("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) order by PI.Codigo");
            return conexion.ejecutarSentencia(sentencia);
        }

        public DataSet mostrarPiezasConFiltros(string codigo, string precioDesde, string precioHasta, int material, int modComp, int tipoDePieza)
        {
            OleDbCommand sentencia = new OleDbCommand("Select PI.Id, PI.Codigo, PI.Precio, PI.PiezaTipo, PI.Material as PiMaterial, PI.Detalles, PT.Id, PT.Nombre as TipoDePieza, MA.Id, MA.Nombre as Material, PI.Imagen from ((Piezas PI inner join PiezasTipos PT on PI.PiezaTipo = PT.Id) inner join Materiales MA on MA.Id = PI.Material) where codigo = '" +@codigo + "' and PT.Id =" + @tipoDePieza +" order by PI.Codigo");
            sentencia.Parameters.AddWithValue("@Codigo", SqlDbType.VarChar);
            sentencia.Parameters.AddWithValue("@tipoDePieza", SqlDbType.Int);
            return conexion.ejecutarSentencia(sentencia);
        }

        public bool agregar(PiezasBLL oPiezasBLL)
        {
            if ((oPiezasBLL.Codigo != "") & Convert.ToBoolean(Convert.ToString(oPiezasBLL.Precio != 0)))
            {
                OleDbCommand oleDbComando = new OleDbCommand("Insert into Piezas (Codigo, Precio, PiezaTipo, Material, Detalles, Imagen) VALUES(@Codigo, @Precio, @PiezaTipo, @Material, @Detalles, @Imagen)");
                oleDbComando.Parameters.AddWithValue("@Codigo", SqlDbType.VarChar).Value = oPiezasBLL.Codigo;
                oleDbComando.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = oPiezasBLL.Precio;
                oleDbComando.Parameters.AddWithValue("@PiezaTipo", SqlDbType.Int).Value = oPiezasBLL.PiezaTipo;
                oleDbComando.Parameters.AddWithValue("@Material", SqlDbType.Int).Value = oPiezasBLL.Material;
                oleDbComando.Parameters.AddWithValue("@Detalles", SqlDbType.VarChar).Value = oPiezasBLL.Detalles;
                oleDbComando.Parameters.AddWithValue("@Imagen", SqlDbType.VarChar).Value = oPiezasBLL.Imagen;

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
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Piezas SET Codigo = '" + oPiezasBLL.Codigo + "'" + ",Precio ='" + oPiezasBLL.Precio + "',PiezaTipo =" + oPiezasBLL.PiezaTipo + ",Material =" + oPiezasBLL.Material + ",Detalles = '" + oPiezasBLL.Detalles + "',Imagen = '" + oPiezasBLL.Imagen + "' where Id=" + oPiezasBLL.Id);
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
