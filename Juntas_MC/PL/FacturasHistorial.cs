using Juntas_MC.BLL;
using Juntas_MC.DAL;
using System;
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
    public partial class FacturasHistorial : Form
    {
        MercadosDAL mercadosDAL;
        FacturasBLL facturasBLL;
        FacturasDAL facturasDAL;
        int indice;
        public FacturasHistorial()
        {
            mercadosDAL = new MercadosDAL();
            facturasBLL = new FacturasBLL();
            facturasDAL = new FacturasDAL();
            InitializeComponent();
            llenarDropDownClientes();
            FormatearFecha();
        }

        private void llenarDropDownClientes()
        {
            cmbCliente.ValueMember = "Id";
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.DataSource = mercadosDAL.mostrarClientes().Tables[0];
            cmbCliente.SelectedItem = null;
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
            int Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
            dgvFacturas.DataSource = facturasDAL.buscarTodasFacturas(FechaDesdeFormat, FechaHastaFormat, Cliente).Tables[0];
            this.dgvFacturas.Columns["Id"].Visible = false;
            this.dgvFacturas.Columns["ClienteId"].Visible = false;

            
            //lblFactura.Text = dgvFacturas.Rows[0].Cells[0].Value.ToString();
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;

            dgvFacturas.ClearSelection();
            if (indice >= 0)
            {
                lblFactura.Text = dgvFacturas.Rows[indice].Cells[0].Value.ToString();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FacturasBLL ObjetoFactura = constuirFactura();
            if (ObjetoFactura != null)
            {
                int FacturaId = Convert.ToInt32(dgvFacturas.Rows[indice].Cells[0].Value);
                List<FacturasItemsBLL> list = facturasDAL.detalleFactura(FacturaId);
                VistaPreviaFactura frmVistapreviaFactura = new VistaPreviaFactura(ObjetoFactura, list);
                frmVistapreviaFactura.ShowDialog();
            }
        }

        private FacturasBLL constuirFactura() //Construye DataGrid a Objecto FacturaBLL
        {
            FacturasBLL oFacturasBLL = new FacturasBLL();
            oFacturasBLL.Id = Convert.ToInt32(dgvFacturas.Rows[indice].Cells[0].Value);
            oFacturasBLL.Numero = Convert.ToInt32(dgvFacturas.Rows[indice].Cells[1].Value);
            oFacturasBLL.Cliente = Convert.ToInt32(dgvFacturas.Rows[indice].Cells[4].Value);
            oFacturasBLL.ImporteTotal = Convert.ToDecimal(dgvFacturas.Rows[indice].Cells[5].Value);
            oFacturasBLL.FechaEmision = Convert.ToDateTime(dgvFacturas.Rows[indice].Cells[2].Value.ToString()); //string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyy"));

            return oFacturasBLL;
        }

        public static string FacturaNumero = "";
        public static int FacturaId = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FacturaId = Convert.ToInt32(dgvFacturas.Rows[indice].Cells[0].Value);
            FacturaNumero = dgvFacturas.Rows[indice].Cells[1].Value.ToString();
            FacturaEliminarDialog facturaEliminarDialog = new FacturaEliminarDialog();

            facturaEliminarDialog.ShowDialog();
        }

        private void CheckTodos(object sender, EventArgs e)
        {
            if (cbTodos.Checked == false)
            {
                cmbCliente.Enabled = true;
            }
            else
            {
                cmbCliente.Enabled = false;
                cmbCliente.SelectedItem = null;
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.Show();
        }
    }
}
