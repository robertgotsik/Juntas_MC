using Juntas_MC.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juntas_MC.PL
{
    public partial class Estadisticas : Form
    {
        FacturasDAL facturasDAL;
        FacturasItemsDAL facturasItemsDAL;

        public Estadisticas()
        {
            facturasDAL = new FacturasDAL();
            facturasItemsDAL = new FacturasItemsDAL();
            InitializeComponent();
            FormatearFecha();
        }


        public void FormatearFecha()
        {
            // Set the Format type and the CustomFormat string.
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dd/MM/yyy";

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd/MM/yyy";
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string FechaDesde = dtpDesde.Text;
            string FechaHasta = dtpHasta.Text;

            //Calculo de total de ventas en $
            lblVentas.Text = facturasDAL.TotalVentas(FechaDesde, FechaHasta);

            //Calculo cantidad de piezas vendidas
            lblCantPiezas.Text = facturasItemsDAL.CantPiezasVendidas(FechaDesde, FechaHasta);

            //Grafico de barras


            //Grafico de torta
        }

        private void CantPiezasVendidas()
        {

        }
    }
}
