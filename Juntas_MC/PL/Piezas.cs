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
    public partial class Piezas : Form
    {
        PiezasDAL oPiezasDAL;
        MercadosDAL oClientesDAL;
        PreciosMercadosDAL oPreciosMercadosDAL;
        TiposDePiezasDAL oTiposDePiezasDAL;
        MaterialesDAL oMaterialesDAL;
        PiezasModelosDAL oPiezasModelosDAL;
        public Piezas()
        {
            oPiezasDAL = new PiezasDAL();
            oClientesDAL = new MercadosDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            oMaterialesDAL = new MaterialesDAL();
            oPiezasModelosDAL = new PiezasModelosDAL();
            InitializeComponent();
            llenarGridPiezas();
            iniciarLlenadoDropDown1();
            iniciarLlenadoDropDown2();
            iniciarLlenadoDropDown3();
            iniciarLlenadoDropDown4();
            llenadoComboBoxTdPiezas();
            llenadoComboBoxMateriales();

            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            cmbCP2.Enabled = false;
            cmbCP3.Enabled = false;
            cmbCP4.Enabled = false;
        }

        public void llenarGridMercados(int Pieza, int Mercado1, int Mercado2, int Mercado3, int Mercado4)
        {
            dgvPreciosMercados.DataSource = oPreciosMercadosDAL.mostrarPreciosMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4).Tables[0];
        }

        private void iniciarLlenadoDropDown1()
        {
            cmbCP1.ValueMember = "Id";
            cmbCP1.DisplayMember = "Nombre";
            cmbCP1.DataSource = oClientesDAL.mostrarMercados().Tables[0];
        }

        private void iniciarLlenadoDropDown2()
        {
            cmbCP2.ValueMember = "Id";
            cmbCP2.DisplayMember = "Nombre";
            cmbCP2.DataSource = oClientesDAL.mostrarMercados().Tables[0];
        }

        private void iniciarLlenadoDropDown3()
        {
            cmbCP3.ValueMember = "Id";
            cmbCP3.DisplayMember = "Nombre";
            cmbCP3.DataSource = oClientesDAL.mostrarMercados().Tables[0];
        }

        private void iniciarLlenadoDropDown4()
        {
            cmbCP4.ValueMember = "Id";
            cmbCP4.DisplayMember = "Nombre";
            cmbCP4.DataSource = oClientesDAL.mostrarMercados().Tables[0];
        }

        //Cuando se selecciona otra pieza > limpiar la grilla de PreciosMercados
        //El seleccionado de Clientes/Proovedores debe ser secuencial
        private void Seleccionado1(object sender, EventArgs e)
        {
            if(cmbCP1.SelectedValue.ToString() != null)
            {
                cmbCP2.Enabled = true;
            }
            int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
            int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
            int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
            int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
        }
        private void Seleccionado2(object sender, EventArgs e)
        {
            if (cmbCP2.SelectedValue.ToString() != null)
            {
                cmbCP3.Enabled = true;
            }
            int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
            int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
            int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
            int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
        }

        private void Seleccionado3(object sender, EventArgs e)
        {
            if (cmbCP3.SelectedValue.ToString() != null)
            {
                cmbCP4.Enabled = true;
            }
            int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
            int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
            int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
            int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
        }
        private void Seleccionado4(object sender, EventArgs e)
        {
            int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
            int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
            int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
            int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
        }

        public void llenarGridPiezas()
        {
            dgvPiezas.DataSource = oPiezasDAL.mostrarPiezas().Tables[0];
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvPiezas.ClearSelection();
            if (indice >= 0)
            {
                lblIdModelo.Text = dgvPiezas.Rows[indice].Cells[0].Value.ToString();
                lblIdPieza.Text = dgvPiezas.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvPiezas.Rows[indice].Cells[2].Value.ToString();
                txtCodigo.Text = dgvPiezas.Rows[indice].Cells[1].Value.ToString();
                txtPrecio.Text = dgvPiezas.Rows[indice].Cells[3].Value.ToString();
                txtDetalles.Text = dgvPiezas.Rows[indice].Cells[6].Value.ToString();
                cmbPiezaTipo.SelectedValue = dgvPiezas.Rows[indice].Cells[4].Value.ToString();
                cmbMaterial.SelectedValue = dgvPiezas.Rows[indice].Cells[5].Value.ToString();
                llenadoComboBoxTdPiezas();
                llenadoComboBoxMateriales();
                llenarGridPiezasModelos();




                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDetalles.Clear();
            txtCodigo.Clear();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            lblIdPieza.Text = Convert.ToString(0);
            tabControl1.SelectedTab = tabPage1;
            btnLimpiar.Hide();
        }

        private void llenadoComboBoxTdPiezas()
        {
            cmbPiezaTipo.ValueMember = "Id";
            cmbPiezaTipo.DisplayMember = "Nombre";
            cmbPiezaTipo.DataSource = oTiposDePiezasDAL.mostrarResultados().Tables[0];
        }

        private void llenadoComboBoxMateriales()
        {
            cmbMaterial.ValueMember = "Id";
            cmbMaterial.DisplayMember = "Nombre";
            cmbMaterial.DataSource = oMaterialesDAL.mostrarMateriales().Tables[0];
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Checkeo si el usuario selecciono Pieza para Mostrar tab 2

            if ((lblIdPieza.Text != Convert.ToString(0)) && (tabControl1.SelectedTab == tabPage2))
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if ((lblIdPieza.Text == Convert.ToString(0)) && (tabControl1.SelectedTab == tabPage2))
            {
                MessageBox.Show("Falta seleccionar Pieza.");
                tabControl1.SelectedTab = tabPage1;
            }

            // Checkeo si el usuario selecciono Pieza para Mostrar tab 3

            if ((lblIdPieza.Text != Convert.ToString(0)) && (tabControl1.SelectedTab == tabPage3))
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else if ((lblIdPieza.Text == Convert.ToString(0)) && (tabControl1.SelectedTab == tabPage3))
            {
                MessageBox.Show("Falta seleccionar Pieza.");
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            PiezasModelos piezasModelos = new PiezasModelos();
            piezasModelos.Show();
        }

        public void llenarGridPiezasModelos()
        {
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            dvgPiezasModelos.DataSource = oPiezasModelosDAL.mostrarPiezasModelos(Pieza).Tables[0];
            this.dvgPiezasModelos.Columns["MO.Id"].Visible = false;
            this.dvgPiezasModelos.Columns["MA.Id"].Visible = false;
        }

        public void enviarPiezaId(int PiezaId)
        {
            PiezaId = Convert.ToInt32(lblIdPieza.Text);
        }
    }
}
