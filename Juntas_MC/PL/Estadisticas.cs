using Juntas_MC.BLL;
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
            DateTime FechaDesde = DateTime.Parse(dtpDesde.Text);
            string FechaDesdeFormat = FechaDesde.ToString("M/d/yyy");
            DateTime FechaHasta = DateTime.Parse(dtpHasta.Text);
            string FechaHastaFormat = FechaHasta.ToString("M/d/yyy");

            //Calculo de total de ventas en $
            lblVentas.Text = facturasDAL.TotalVentas(FechaDesdeFormat, FechaHastaFormat);

            //Calculo cantidad de piezas vendidas
            lblCantPiezas.Text = facturasItemsDAL.CantPiezasVendidas(FechaDesdeFormat, FechaHastaFormat);

            //Calculo clientes alcanzados
            lblClientes.Text = facturasItemsDAL.ClientesAlcanzados(FechaDesdeFormat, FechaHastaFormat);

            //Calculo Tipo Pieza mas vendido
            lblPiezaTipo.Text = facturasItemsDAL.PiezaTipoMasVendido(FechaDesdeFormat, FechaHastaFormat);

            //Grafico de barras
            chartCantPiezas.DataSource = facturasItemsDAL.CodigoPiezaTopVentas(FechaDesdeFormat, FechaHastaFormat);
            chartCantPiezas.Series["Pieza"].XValueMember = "PiezaCodigo";
            chartCantPiezas.Series["Pieza"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartCantPiezas.Series["Pieza"].YValueMembers = "Cantidad";
            chartCantPiezas.Series["Pieza"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //Grafico de torta
            chartGananciaPorPieza.DataSource = facturasItemsDAL.GananciasPorPieza(FechaDesdeFormat, FechaHastaFormat);
            chartGananciaPorPieza.Series["Ganancia"].XValueMember = "PiezaCodigo";
            chartGananciaPorPieza.Series["Ganancia"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartGananciaPorPieza.Series["Ganancia"].YValueMembers = "ItemImporteTotal";
            chartGananciaPorPieza.Series["Ganancia"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
    }
}
