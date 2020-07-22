using DGVPrinterHelper;
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
    public partial class Listados : Form
    {
        PiezasDAL piezasDAL;
        MercadosDAL mercadosDAL;
        MaterialesDAL oMaterialesDAL;
        TiposDePiezasDAL oTiposDePiezasDAL;
        MarcasDAL marcasDAL;
        ModelosDAL modelosDAL;
        EmpresasDAL empresasDAL;
        public Listados()
        {
            InitializeComponent();
            piezasDAL = new PiezasDAL();
            mercadosDAL = new MercadosDAL();
            oMaterialesDAL = new MaterialesDAL();
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            marcasDAL = new MarcasDAL();
            modelosDAL = new ModelosDAL();
            empresasDAL = new EmpresasDAL();
            llenarComboBoxClientes();
            llenadoComboBoxTdPiezas();
            llenadoComboBoxMateriales();
            llenadoComboBoxMarcas();
            llenadoComboBoxModelos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string operando = txtDto.Text;
            string ganancia = txtGanancia.Text;
            string aumento = txtAumento.Text;
            if (operando == "") { operando = "0"; }
            if (ganancia == "") { ganancia = "0"; }
            if (aumento == "") { aumento = "0"; }
            int piezaTipo = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            int marca = Convert.ToInt32(cmbMarca.SelectedValue);
            int modelo = Convert.ToInt32(cmbModelo.SelectedValue);

            piezasBLLBindingSource.DataSource = piezasDAL.mostrarPiezasListado(ganancia, operando, aumento, piezaTipo, material, marca, modelo);

            if (aumento == "0") { this.dgvListado.Columns["PrecioDeVenta"].Visible = false; }
            else 
            { 
                this.dgvListado.Columns["PrecioDeVenta"].Visible = true;
                this.dgvListado.Columns["PrecioDeVenta"].DefaultCellStyle.BackColor = Color.Yellow; 
            }

            btnImprimir.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimirListadoDGVPrinter();
        }

        private void cbTodasPiezas_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTodasPiezas.Checked == false)
            {
                cbTipoPieza.Enabled = true;
                cbMarca.Enabled = true;
                cbMaterial.Enabled = true;
                cbModelo.Enabled = true;
            }
            else
            {
                cbTipoPieza.Enabled = false;
                cbTipoPieza.Checked = false;
                cbMarca.Checked = false;
                cbMarca.Enabled = false;
                cbModelo.Checked = false;
                cbModelo.Enabled = false;
                cbMaterial.Checked = false;
                cbMaterial.Enabled = false;
                cmbMarca.Enabled = false;
                cmbModelo.Enabled = false;
                cmbPiezaTipo.SelectedItem = null;
                cmbMaterial.SelectedItem = null;
                cmbMarca.SelectedItem = null;
                cmbModelo.SelectedItem = null;
            }
        }

        private void checkeaChecks()
        {
            if (cbTipoPieza.Checked == false & cbMaterial.Checked == false & cbMarca.Checked == false & cbModelo.Checked == false)
            { cbTodasPiezas.Checked = true; }
        }

        private void cbTipoPieza_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTipoPieza.Checked == true)
            { cmbPiezaTipo.Enabled = true; }
            else { cmbPiezaTipo.Enabled = false; cmbPiezaTipo.SelectedItem = null; checkeaChecks(); }
        }

        private void cbMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMaterial.Checked == true)
            { cmbMaterial.Enabled = true; }
            else { cmbMaterial.Enabled = false; cmbMaterial.SelectedItem = null; checkeaChecks(); }
        }
        private void cbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMarca.Checked == true)
            { cmbMarca.Enabled = true; }
            else { cmbMarca.Enabled = false; cmbMarca.SelectedItem = null; llenadoComboBoxModelos(); checkeaChecks(); }
        }

        private void cbModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModelo.Checked == true)
            { 
                if(cmbMarca.SelectedItem != null)
                {
                    int marca = Convert.ToInt32(cmbMarca.SelectedValue);
                    cmbModelo.ValueMember = "Mo.Id";
                    cmbModelo.DisplayMember = "Nombre";
                    cmbModelo.DataSource = modelosDAL.mostrarModelosCmb3(marca).Tables[0];
                    cmbModelo.SelectedItem = null;
                    cmbModelo.Enabled = true;
                }
                else
                {
                    cmbModelo.Enabled = true;
                }
            }
            else { cmbModelo.Enabled = false; cmbModelo.SelectedItem = null; checkeaChecks(); }
        }

        private void llenarComboBoxClientes()
        {
            cmbCliente.ValueMember = "Id";
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.DataSource = mercadosDAL.mostrarClientes().Tables[0];
            cmbCliente.SelectedItem = null;
        }
        private void llenadoComboBoxTdPiezas()
        {
            cmbPiezaTipo.ValueMember = "Id";
            cmbPiezaTipo.DisplayMember = "Nombre";
            cmbPiezaTipo.DataSource = oTiposDePiezasDAL.mostrarResultados().Tables[0];
            cmbPiezaTipo.SelectedItem = null;
        }
        private void llenadoComboBoxMateriales()
        {
            cmbMaterial.ValueMember = "Id";
            cmbMaterial.DisplayMember = "Nombre";
            cmbMaterial.DataSource = oMaterialesDAL.mostrarMateriales().Tables[0];
            cmbMaterial.SelectedItem = null;
        }

        private void llenadoComboBoxMarcas()
        {
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.DataSource = marcasDAL.mostrarMarcas().Tables[0];
            cmbMarca.SelectedItem = null;
        }
        private void llenadoComboBoxModelos()
        {
            cmbModelo.ValueMember = "Mo.Id";
            cmbModelo.DisplayMember = "Nombre";
            cmbModelo.DataSource = modelosDAL.mostrarModelosCmb2().Tables[0];
            cmbModelo.SelectedItem = null;
        }

        private void SeleccionCliente(object sender, EventArgs e)
        {
            int mercado = Convert.ToInt32(cmbCliente.SelectedValue);
            txtDto.Text = mercadosDAL.averiguarporcentaje(mercado);
        }

        public void imprimirListadoDGVPrinter()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = empresasDAL.NombreEmpresa().ToString();
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = string.Format("Telefono: " + (empresasDAL.TelefonoEmpresa().ToString())); /*lblImporteTotal.Text;*/
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dgvListado);
        }

        private void ActualizarModelos(object sender, EventArgs e)
        {
            int marca = Convert.ToInt32(cmbMarca.SelectedValue);
            cmbModelo.ValueMember = "Mo.Id";
            cmbModelo.DisplayMember = "Nombre";
            cmbModelo.DataSource = modelosDAL.mostrarModelosCmb3(marca).Tables[0];
            cmbModelo.SelectedItem = null;
        }
    }
}
