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
    public partial class BusquedaPieza : Form
    {
        Piezas frmPiezas;
        TiposDePiezasDAL oTiposDePiezasDAL;
        MaterialesDAL oMaterialesDAL;
        ModelosDAL oModelosDAL;
        public BusquedaPieza(Piezas frmPiezas)
        {
            this.frmPiezas = frmPiezas;
            InitializeComponent();
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            oMaterialesDAL = new MaterialesDAL();
            oModelosDAL = new ModelosDAL();
            llenadoComboBoxTdPiezas();
            llenadoComboBoxMateriales();
            iniciarLlenadoDropDown();
        }

        private void llenadoComboBoxTdPiezas()
        {
            cmbTdP.ValueMember = "Id";
            cmbTdP.DisplayMember = "Nombre";
            cmbTdP.DataSource = oTiposDePiezasDAL.mostrarResultados().Tables[0];
            cmbTdP.SelectedItem = null;
        }

        private void llenadoComboBoxMateriales()
        {
            cmbMaterial.ValueMember = "Id";
            cmbMaterial.DisplayMember = "Nombre";
            cmbMaterial.DataSource = oMaterialesDAL.mostrarMateriales().Tables[0];
            cmbMaterial.SelectedItem = null;
        }

        private void iniciarLlenadoDropDown()
        {
            cmbModComp.ValueMember = "MO.Id";
            cmbModComp.DisplayMember = "NombreModeloMarca";
            cmbModComp.DataSource = oModelosDAL.mostrarModelosCmb().Tables[0];
            cmbModComp.SelectedItem = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text != "") | (txtPrecioDesde.Text != "" & txtPrecioHasta.Text != "") | (cmbMaterial.SelectedValue != null) | 
                (cmbModComp.SelectedValue != null) | (cmbTdP.SelectedValue != null))
            {
                string codigo = txtCodigo.Text;
                string precioDesde = txtPrecioDesde.Text;
                string precioHasta = txtPrecioHasta.Text;
                int material = Convert.ToInt32(cmbMaterial.SelectedValue);
                int modComp = Convert.ToInt32(cmbModComp.SelectedValue);
                int tipoDePieza = Convert.ToInt32(cmbTdP.SelectedValue);
                frmPiezas.llenarGridPiezasConFiltros(codigo, precioDesde, precioHasta, material, modComp, tipoDePieza);
            }
            else
            {
                frmPiezas.llenarGridPiezas();
            }

            txtCodigo.Text = null;
            cmbTdP.SelectedItem = null;
            cmbMaterial.SelectedItem = null;
            cmbModComp.SelectedItem = null;

            this.Close();
        }
    }
}
