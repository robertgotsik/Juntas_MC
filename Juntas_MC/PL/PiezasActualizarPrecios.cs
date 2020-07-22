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
        ModificacionDialogFalse frmModificacionDialogFalse;
        MercadosDAL oMercadosDAL;
        PreciosMercadosDAL oPreciosMercadosDAL;


        public PiezasActualizarPrecios()
        {
            InitializeComponent();
            oPiezasDAL = new PiezasDAL();
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            oMaterialesDAL = new MaterialesDAL();
            frmModificacionDialogFalse = new ModificacionDialogFalse();
            oMercadosDAL = new MercadosDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            llenadoComboBoxTdPiezas();
            llenadoComboBoxMateriales();
            llenadoComboBoxMercados();
        }

        public void llenarGridPiezas()
        {
            dgvPiezas.DataSource = oPiezasDAL.mostrarPiezas().Tables[0];
            quitarColumnasSobrantes();
        }

        public void quitarColumnasSobrantes()
        {
            if (dgvPiezas.Columns.Contains("PI.Id")) { this.dgvPiezas.Columns["PI.Id"].Visible = false; }
            if (dgvPiezas.Columns.Contains("TipoDePieza")) { this.dgvPiezas.Columns["TipoDePieza"].Visible = false; }
            if (dgvPiezas.Columns.Contains("Material")) { this.dgvPiezas.Columns["Material"].Visible = false; }
            if (dgvPiezas.Columns.Contains("Detalles")) { this.dgvPiezas.Columns["Detalles"].Visible = false; }
            if (dgvPiezas.Columns.Contains("PiezaTipo")) { this.dgvPiezas.Columns["PiezaTipo"].Visible = false; }
            if (dgvPiezas.Columns.Contains("Detalles")) { this.dgvPiezas.Columns["Detalles"].Visible = false; }
            if (dgvPiezas.Columns.Contains("PiMaterial")) { this.dgvPiezas.Columns["PiMaterial"].Visible = false; }
            if (dgvPiezas.Columns.Contains("PT.Id")) { this.dgvPiezas.Columns["PT.Id"].Visible = false; }
            if (dgvPiezas.Columns.Contains("MA.Id")) { this.dgvPiezas.Columns["MA.Id"].Visible = false; }
            if (dgvPiezas.Columns.Contains("Imagen")) { this.dgvPiezas.Columns["Imagen"].Visible = false; }
            if (dgvPiezas.Columns.Contains("Estad")) { this.dgvPiezas.Columns["Estad"].Visible = false; }
            if (dgvPiezas.Columns.Contains("CodProveedor")){ this.dgvPiezas.Columns["CodProveedor"].Visible = false; }
            if (dgvPiezas.Columns.Contains("Observaciones")) { this.dgvPiezas.Columns["Observaciones"].Visible = false; }
            if (dgvPiezas.Columns.Contains("PiezaId")) { this.dgvPiezas.Columns["PiezaId"].Visible = false; }
        }

        //Paso 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPrecioDeLista.Checked == true)
            {
                cbTodasPiezas.Enabled = true;
                txtCodigo.Enabled = false;
                cbCodigo.Enabled = true;
                cmbPiezaTipo.Enabled = false;
                cbTipoPieza.Enabled = true;
                cmbMaterial.Enabled = false;
                cbMaterial.Enabled = true;
            }
            else
            {
                cmbOperando.SelectedItem = null;
                txtValorOperando.Text = null;
                cmbOperando.Enabled = false;
                txtValorOperando.Enabled = false;
            }
        }
        private void rdMercado_CheckedChanged(object sender, EventArgs e)
        {
            if(rdMercado.Checked == true) 
            { 
                cmbMercado.Enabled = true;

                cbTodasPiezas.Enabled = false;
                cbTodasPiezas.Checked = true;
                cbMaterial.Checked = false;
                cbTipoPieza.Checked = false;
                cbCodigo.Checked = false;
                txtCodigo.Enabled = false;
                cbCodigo.Enabled = false;
                cmbPiezaTipo.Enabled = false;
                cbTipoPieza.Enabled = false;
                cmbMaterial.Enabled = false;
                cbMaterial.Enabled = false;
            }
            else 
            { 
                cmbMercado.Enabled = false; 
                cmbMercado.SelectedItem = null; 
                dgvPiezas.DataSource = null;

                cmbOperando.Enabled = false;
                txtValorOperando.Enabled = false;
                cmbOperando.SelectedItem = null;
                txtValorOperando.Text = null;
                cbTodasPiezas.Checked = false;
            }
        }

        private void seleccionMercado(object sender, EventArgs e)
        {
            int mercado = Convert.ToInt32(cmbMercado.SelectedValue);
            dgvPiezas.DataSource = oPreciosMercadosDAL.mostrarPreciosMercadosFull(mercado).Tables[0];
            quitarColumnasSobrantes();
            cbTodasPiezas.Checked = true;
            cbTodasPiezas.Enabled = false;
            txtCodigo.Enabled = false;
            cbCodigo.Enabled = false;
            cmbPiezaTipo.Enabled = false;
            cbTipoPieza.Enabled = false;
            cmbMaterial.Enabled = false;
            cbMaterial.Enabled = false;
            cmbOperando.Enabled = true;
            txtValorOperando.Enabled = true;
        }


        //Paso 2

        private void TodasPiezasCheckeado(object sender, EventArgs e)
        {
            if(rdPrecioDeLista.Checked ==true & cbTodasPiezas.Checked == true)
            {
                txtCodigo.Enabled = false;
                cbCodigo.Enabled = false;
                cmbPiezaTipo.Enabled = false;
                cbTipoPieza.Enabled = false;
                cmbMaterial.Enabled = false;
                cbMaterial.Enabled = false;
                txtCodigo.Text = null;
                cmbPiezaTipo.SelectedItem = null;
                cmbMaterial.SelectedItem = null;
                cbMaterial.Checked = false;
                cbCodigo.Checked = false;
                cbTipoPieza.Checked = false;
                llenarGridPiezas();
                enablePaso3();
            }
            else if (rdMercado.Checked == true & cbTodasPiezas.Checked == true)
            {
                int mercado = Convert.ToInt32(cmbMercado.SelectedValue);

            }
            else
            {
                cbTodasPiezas.Enabled = true;
                txtCodigo.Enabled = false;
                cbCodigo.Enabled = true;
                cmbPiezaTipo.Enabled = false;
                cbTipoPieza.Enabled = true;
                cmbMaterial.Enabled = false;
                cbMaterial.Enabled = true;
                dgvPiezas.DataSource = null;
                ningunCheckBoxCheckeado();
            }
        }

        //Lenado de ComboBoxes
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
        private void llenadoComboBoxMercados()
        {
            cmbMercado.ValueMember = "Id";
            cmbMercado.DisplayMember = "Nombre";
            cmbMercado.DataSource = oMercadosDAL.mostrarMercados().Tables[0];
            cmbMercado.SelectedItem = null;
        }


        private void cbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCodigo.Checked == true) 
            { 
                txtCodigo.Enabled = true; 
                btnBuscarPorCodigo.Enabled = true;
                cbTodasPiezas.Enabled = false;
                cbTipoPieza.Enabled = false;
                cmbPiezaTipo.Enabled = false;
                cbMaterial.Enabled = false;
                enablePaso3();

            }
            else if (cbCodigo.Checked == false)
            { 
                dgvPiezas.DataSource = null; 
                txtCodigo.Enabled = false; 
                txtCodigo.Text = ""; 
                btnBuscarPorCodigo.Enabled = false;
                ningunCheckBoxCheckeado();
            }
        }


        private void cbTipoPieza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTipoPieza.Checked == true) 
            { 
                cmbPiezaTipo.Enabled = true;
                cbCodigo.Enabled = false;
                cbTodasPiezas.Enabled = false;
            }
            else
            { 
                dgvPiezas.DataSource = null; 
                cmbPiezaTipo.Enabled = false; 
                cmbPiezaTipo.SelectedItem = null;

                if ((cmbMaterial.SelectedItem != null) & (cbMaterial.Checked == true))
                {
                    cmbPiezaTipo.Enabled = false; cmbPiezaTipo.SelectedItem = null;
                    string codigo = txtCodigo.Text;
                    int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
                    int material = Convert.ToInt32(cmbMaterial.SelectedValue);
                    dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, tipoDePieza, material).Tables[0];
                    quitarColumnasSobrantes();
                }

                ningunCheckBoxCheckeado();
            }
        }

        private void cbMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaterial.Checked == true) 
            { 
                cmbMaterial.Enabled = true;
                cbCodigo.Enabled = false;
                cbTodasPiezas.Enabled = false;
            }
            else
            { 
                dgvPiezas.DataSource = null;
                cmbMaterial.Enabled = false; 
                cmbMaterial.SelectedItem = null;

                if ((cmbPiezaTipo.SelectedItem != null) & (cbTipoPieza.Checked == true))
                {
                    cmbMaterial.Enabled = false; cmbMaterial.SelectedItem = null;
                    string codigo = txtCodigo.Text;
                    int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
                    int material = Convert.ToInt32(cmbMaterial.SelectedValue);
                    dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, tipoDePieza).Tables[0];
                    quitarColumnasSobrantes();
                }

                ningunCheckBoxCheckeado();
            }
        }

        private void ningunCheckBoxCheckeado()
        {
            if (cbTodasPiezas.Checked == false & cbCodigo.Checked == false & cbTipoPieza.Checked == false & cbMaterial.Checked == false)
            {
                cbTodasPiezas.Enabled = true;
                cbCodigo.Enabled = true;
                txtCodigo.Text = null;
                cbTipoPieza.Enabled = true;
                cmbPiezaTipo.SelectedItem = null;
                cbMaterial.Enabled = true;
                cmbMaterial.SelectedItem = null;
                cmbOperando.SelectedItem = null;
                cmbOperando.Enabled = false;
                txtValorOperando.Enabled = false;
                txtValorOperando.Text = null;
            }
        }

        private void enablePaso3()
        {
            if(cbTodasPiezas.Checked == true | cbCodigo.Checked == true | cmbPiezaTipo.SelectedIndex != -1 | cmbMaterial.SelectedIndex != -1 )
            { 
                cmbOperando.Enabled = true; 
                txtValorOperando.Enabled = true; 
            }
            else { cmbOperando.Enabled = false; txtValorOperando.Enabled = false; }
        }

        private void SeleccionMaterial(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, tipoDePieza).Tables[0];
            quitarColumnasSobrantes();
            enablePaso3();
        }

        private void SeleccionTipoDePieza(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            int tipoDePieza = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, tipoDePieza).Tables[0];
            quitarColumnasSobrantes();
            enablePaso3();
        }



        //PASO 3



        //Resto de codigo

        private void limpiarEntradas()
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string operador;
            string codigo = txtCodigo.Text;
            int material = Convert.ToInt32(cmbMaterial.SelectedValue);
            int piezaTipo = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            int mercado = Convert.ToInt32(cmbMercado.SelectedValue);


            if (cmbOperando.SelectedIndex == 0){ operador = "+"; }
            else if (cmbOperando.SelectedIndex == 1) { operador = "-"; }
            else if (cmbOperando.SelectedIndex == 2) { operador = "*"; }
            else if (cmbOperando.SelectedIndex == 3) { operador = "/"; }
            else { operador = ""; }

            if(txtValorOperando.Text != "") { txtValorOperando.Text = (txtValorOperando.Text).Replace(",", "."); }
            string operando = txtValorOperando.Text;


            if(rdPrecioDeLista.Checked == true & cbTodasPiezas.Checked == true)
            {
                oPiezasDAL.modificarPreciosMasivo(operando, operador);
                txtValorOperando.Text = null;
                llenarGridPiezas();
            }
            else if ((rdPrecioDeLista.Checked == true) & ((cbCodigo.Checked == true & txtCodigo.Text != "") | (cbTipoPieza.Checked == true & cmbPiezaTipo.SelectedItem != null) | (cbMaterial.Checked == true & cmbMaterial.SelectedItem != null)))
            {
                if ((cbTipoPieza.Checked == true & cmbPiezaTipo.SelectedItem != null) & (cbMaterial.Checked == true & cmbMaterial.SelectedItem != null))
                {
                    oPiezasDAL.modificarPreciosConFiltros(operando, operador, codigo, material, piezaTipo);
                    dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, piezaTipo).Tables[0];
                    quitarColumnasSobrantes();
                }
                else if (((cbTipoPieza.Checked == true & cmbPiezaTipo.SelectedItem != null) & (cbMaterial.Checked == true & cmbMaterial.SelectedItem == null)) | ((cbTipoPieza.Checked == true & cmbPiezaTipo.SelectedItem == null) &(cbMaterial.Checked == true & cmbMaterial.SelectedItem != null)))
                {
                    frmModificacionDialogFalse.ShowDialog();
                }
                else if (cbCodigo.Checked == true & txtCodigo.Text != "")
                {
                    oPiezasDAL.modificarPreciosConFiltros(operando, operador, codigo, material, piezaTipo);
                    dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, piezaTipo).Tables[0];
                    quitarColumnasSobrantes();
                }
                else if (cbTipoPieza.Checked == true & cmbPiezaTipo.SelectedItem != null)
                {
                    oPiezasDAL.modificarPreciosConFiltros(operando, operador, codigo, material, piezaTipo);
                    dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, piezaTipo).Tables[0];
                    quitarColumnasSobrantes();
                }
                else if (cbMaterial.Checked == true & cmbMaterial.SelectedItem != null)
                {
                    oPiezasDAL.modificarPreciosConFiltros(operando, operador, codigo, material, piezaTipo);
                    dgvPiezas.DataSource = oPiezasDAL.actualizadorPreciosConFiltros(codigo, material, piezaTipo).Tables[0];
                    quitarColumnasSobrantes();
                }
            }
            else if (rdMercado.Checked == true & cmbMercado.SelectedIndex != -1)
            {
                if(cmbOperando.SelectedIndex != -1 & txtValorOperando.Text != "")
                {
                    oPreciosMercadosDAL.actualizarPreciosMercados(mercado, operando, operador);
                    dgvPiezas.DataSource = oPreciosMercadosDAL.mostrarPreciosMercadosFull(mercado).Tables[0];
                }
            }
            else
            {
                frmModificacionDialogFalse.ShowDialog();
            }
            txtValorOperando.Text = null;
            cmbOperando.SelectedItem = null;
        }

        private void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                string codigo = txtCodigo.Text;
                string precioDesde = "";
                string precioHasta = "";
                int material = 0;
                int modComp = 0;
                int tipoDePieza = 0;
                int estado = 1;
                string codigoProveedor = null;
                dgvPiezas.DataSource = oPiezasDAL.mostrarPiezasConFiltros(codigo, precioDesde, precioHasta, material, modComp, tipoDePieza, estado, codigoProveedor).Tables[0];
                quitarColumnasSobrantes();
            }
        }
    }
}
