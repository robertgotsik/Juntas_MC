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
    public partial class PiezasActualizarPrecios : Form
    {
        PiezasDAL oPiezasDAL;
        TiposDePiezasDAL oTiposDePiezasDAL;
        MaterialesDAL oMaterialesDAL;
        

        public PiezasActualizarPrecios()
        {
            InitializeComponent();
            oPiezasDAL = new PiezasDAL();
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            oMaterialesDAL = new MaterialesDAL();
            llenadoComboBoxTdPiezas();
            llenadoComboBoxMateriales();
            llenadoComboBoxPiezasCodigo();
        }

        public void llenarGridPiezas()
        {
            dgvPiezas.DataSource = oPiezasDAL.mostrarPiezas().Tables[0];
            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
            this.dgvPiezas.Columns["Material"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            this.dgvPiezas.Columns["Imagen"].Visible = false;
            this.dgvPiezas.Columns["Estado"].Visible = false;
        }

        //Paso 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cbTodasPiezas.Enabled = true;
            cmbCodigo.Enabled = false;
            cbCodigo.Enabled = true;
            cmbPiezaTipo.Enabled = false;
            cbTipoPieza.Enabled = true;
            cmbMaterial.Enabled = false;
            cbMaterial.Enabled = true;
        }


        //Paso 2

        private void TodasPiezasCheckeado(object sender, EventArgs e)
        {
            if(cbTodasPiezas.Checked == true)
            {
                cmbCodigo.Enabled = false;
                cbCodigo.Enabled = false;
                cmbPiezaTipo.Enabled = false;
                cbTipoPieza.Enabled = false;
                cmbMaterial.Enabled = false;
                cbMaterial.Enabled = false;
                cmbCodigo.SelectedItem = null;
                cmbPiezaTipo.SelectedItem = null;
                cmbMaterial.SelectedItem = null;
                cbMaterial.Checked = false;
                cbCodigo.Checked = false;
                cbTipoPieza.Checked = false;
                llenarGridPiezas();
                enablePaso3();
            }
            else
            {
                cbTodasPiezas.Enabled = true;
                cmbCodigo.Enabled = false;
                cbCodigo.Enabled = true;
                cmbPiezaTipo.Enabled = false;
                cbTipoPieza.Enabled = true;
                cmbMaterial.Enabled = false;
                cbMaterial.Enabled = true;
                dgvPiezas.DataSource = null;
            }
        }

        //Lenado de ComboBoxes
        private void llenadoComboBoxPiezasCodigo()
        {
            cmbCodigo.ValueMember = "Id";
            cmbCodigo.DisplayMember = "Codigo";
            cmbCodigo.DataSource = oPiezasDAL.mostrarPiezas2().Tables[0];
            cmbCodigo.SelectedItem = null;
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


        private void cbCodigo_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCodigo.Checked == true) { cmbCodigo.Enabled = true; }
            else if ((cbMaterial.Checked == false) & (cbCodigo.Checked == false) & (cbTipoPieza.Checked == false))
            { dgvPiezas.DataSource = null; cmbCodigo.Enabled = false; cmbCodigo.SelectedItem = null; }
            else { cmbCodigo.Enabled = false; cmbCodigo.SelectedItem = null;
                int codigo = Convert.ToInt32(cmbCodigo.SelectedValue);
                int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
                int material = Convert.ToInt32(cmbMaterial.SelectedValue);
                dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
                this.dgvPiezas.Columns["PI.Id"].Visible = false;
                this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
                this.dgvPiezas.Columns["Material"].Visible = false;
                this.dgvPiezas.Columns["Detalles"].Visible = false;
                this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
                this.dgvPiezas.Columns["Detalles"].Visible = false;
                this.dgvPiezas.Columns["PiMaterial"].Visible = false;
                this.dgvPiezas.Columns["PT.Id"].Visible = false;
                this.dgvPiezas.Columns["MA.Id"].Visible = false;
                this.dgvPiezas.Columns["Imagen"].Visible = false;
                this.dgvPiezas.Columns["Estado"].Visible = false;
            }
        }


        private void cbTipoPieza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTipoPieza.Checked == true) { cmbPiezaTipo.Enabled = true; }
            else if ((cbMaterial.Checked == false) & (cbCodigo.Checked == false) & (cbTipoPieza.Checked == false))
            { dgvPiezas.DataSource = null; cmbPiezaTipo.Enabled = false; cmbPiezaTipo.SelectedItem = null; }
            else { cmbPiezaTipo.Enabled = false; cmbPiezaTipo.SelectedItem = null;
                int codigo = Convert.ToInt32(cmbCodigo.SelectedValue);
                int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
                int material = Convert.ToInt32(cmbMaterial.SelectedValue);
                dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
                this.dgvPiezas.Columns["PI.Id"].Visible = false;
                this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
                this.dgvPiezas.Columns["Material"].Visible = false;
                this.dgvPiezas.Columns["Detalles"].Visible = false;
                this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
                this.dgvPiezas.Columns["Detalles"].Visible = false;
                this.dgvPiezas.Columns["PiMaterial"].Visible = false;
                this.dgvPiezas.Columns["PT.Id"].Visible = false;
                this.dgvPiezas.Columns["MA.Id"].Visible = false;
                this.dgvPiezas.Columns["Imagen"].Visible = false;
                this.dgvPiezas.Columns["Estado"].Visible = false;
            }
        }

        private void cbMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaterial.Checked == true) { cmbMaterial.Enabled = true; }
            else if ((cbMaterial.Checked == false) & (cbCodigo.Checked == false) & (cbTipoPieza.Checked == false))
            { 
                dgvPiezas.DataSource = null;
                cmbMaterial.Enabled = false; 
                cmbMaterial.SelectedItem = null;
            }
            else { cmbMaterial.Enabled = false; cmbMaterial.SelectedItem = null;
                int codigo = Convert.ToInt32(cmbCodigo.SelectedValue);
                int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
                int material = Convert.ToInt32(cmbMaterial.SelectedValue);
                dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
                this.dgvPiezas.Columns["PI.Id"].Visible = false;
                this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
                this.dgvPiezas.Columns["Material"].Visible = false;
                this.dgvPiezas.Columns["Detalles"].Visible = false;
                this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
                this.dgvPiezas.Columns["Detalles"].Visible = false;
                this.dgvPiezas.Columns["PiMaterial"].Visible = false;
                this.dgvPiezas.Columns["PT.Id"].Visible = false;
                this.dgvPiezas.Columns["MA.Id"].Visible = false;
                this.dgvPiezas.Columns["Imagen"].Visible = false;
                this.dgvPiezas.Columns["Estado"].Visible = false;
            }
        }

        private void enablePaso3()
        {
            if(cbTodasPiezas.Checked == true | cmbCodigo.SelectedIndex != -1 | cmbPiezaTipo.SelectedIndex != -1 | cmbMaterial.SelectedIndex != -1 )
            { 
                cmbOperando.Enabled = true; 
                txtValorOperando.Enabled = true; 
            }
            else { cmbOperando.Enabled = false; txtValorOperando.Enabled = false; }
        }



        private void SeleccionCodigo(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cmbCodigo.SelectedValue);
            int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
            this.dgvPiezas.Columns["Material"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            this.dgvPiezas.Columns["Imagen"].Visible = false;
            this.dgvPiezas.Columns["Estado"].Visible = false;
            enablePaso3();
        }

        private void SeleccionMaterial(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cmbCodigo.SelectedValue);
            int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
            this.dgvPiezas.Columns["Material"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            this.dgvPiezas.Columns["Imagen"].Visible = false;
            this.dgvPiezas.Columns["Estado"].Visible = false;
            enablePaso3();
        }

        private void SeleccionTipoDePieza(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cmbCodigo.SelectedValue);
            int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["TipoDePieza"].Visible = false;
            this.dgvPiezas.Columns["Material"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            this.dgvPiezas.Columns["Imagen"].Visible = false;
            this.dgvPiezas.Columns["Estado"].Visible = false;
            enablePaso3();
        }



        //PASO 3



        //Resto de codigo
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string operador;
            if (cmbOperando.SelectedIndex == 0){ operador = "+"; }
            else if (cmbOperando.SelectedIndex == 1) { operador = "-"; }
            else if (cmbOperando.SelectedIndex == 2) { operador = "*"; }
            else { operador = "/"; }
            if(txtValorOperando.Text != "") { txtValorOperando.Text = (txtValorOperando.Text).Replace(",", "."); }
            string operando = txtValorOperando.Text;
            if(rdPrecioDeLista.Checked == true & cbTodasPiezas.Checked == true)
            {
                oPiezasDAL.modificarPreciosMasivo(operando, operador);
                llenarGridPiezas();
            }
        }
    }
}
