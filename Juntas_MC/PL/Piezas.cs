using Juntas_MC.BLL;
using Juntas_MC.DAL;
using System;
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
        BusquedaPieza busquedaPieza;
        public Piezas()
        {
            oPiezasDAL = new PiezasDAL();
            oClientesDAL = new MercadosDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            oMaterialesDAL = new MaterialesDAL();
            oPiezasModelosDAL = new PiezasModelosDAL();
            busquedaPieza = new BusquedaPieza(this);
            InitializeComponent();
            iniciarLlenadoDropDown1();
            iniciarLlenadoDropDown2();
            iniciarLlenadoDropDown3();
            iniciarLlenadoDropDown4();
            llenadoComboBoxTdPiezas();
            llenadoComboBoxMateriales();
            cmbPiezaTipo.SelectedItem = null;
            cmbMaterial.SelectedItem = null;
            cmbCP2.Enabled = false;
            cmbCP3.Enabled = false;
            cmbCP4.Enabled = false;
            btnQuitarModelo.Enabled = false;
            btnLimpiar.Hide();
        }

        public void llenarGridMercados(int Pieza, int Mercado1, int Mercado2, int Mercado3, int Mercado4)
        {
            dgvPreciosMercados.DataSource = oPreciosMercadosDAL.mostrarPreciosMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4).Tables[0];
        }

        public void llenarGridPiezas()
        {
            dgvPiezas.DataSource = oPiezasDAL.mostrarPiezas().Tables[0];
            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            this.dgvPiezas.Columns["Imagen"].Visible = false;
        }

        public void llenarGridPiezasConFiltros(string codigo, string precioDesde, string precioHasta, int material, int modComp, int tipoDePieza)
        {
            dgvPiezas.DataSource = oPiezasDAL.mostrarPiezasConFiltros(codigo, precioDesde, precioHasta, material, modComp, tipoDePieza).Tables[0];
            this.dgvPiezas.Columns["PI.Id"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiezaTipo"].Visible = false;
            this.dgvPiezas.Columns["Detalles"].Visible = false;
            this.dgvPiezas.Columns["PiMaterial"].Visible = false;
            this.dgvPiezas.Columns["PT.Id"].Visible = false;
            this.dgvPiezas.Columns["MA.Id"].Visible = false;
            this.dgvPiezas.Columns["Imagen"].Visible = false;
        }

        private void iniciarLlenadoDropDown1()
        {

            cmbCP1.ValueMember = "Id";
            cmbCP1.DisplayMember = "Nombre";
            cmbCP1.DataSource = oClientesDAL.mostrarMercados().Tables[0];
            cmbCP1.SelectedItem = null;
        }

        private void iniciarLlenadoDropDown2()
        {
            cmbCP2.ValueMember = "Id";
            cmbCP2.DisplayMember = "Nombre";
            cmbCP2.DataSource = oClientesDAL.mostrarMercados().Tables[0];
            cmbCP2.SelectedItem = null;
        }

        private void iniciarLlenadoDropDown3()
        {
            cmbCP3.ValueMember = "Id";
            cmbCP3.DisplayMember = "Nombre";
            cmbCP3.DataSource = oClientesDAL.mostrarMercados().Tables[0];
            cmbCP3.SelectedItem = null;
        }

        private void iniciarLlenadoDropDown4()
        {
            cmbCP4.ValueMember = "Id";
            cmbCP4.DisplayMember = "Nombre";
            cmbCP4.DataSource = oClientesDAL.mostrarMercados().Tables[0];
            cmbCP4.SelectedItem = null;
        }

        //Cuando se selecciona otra pieza > limpiar la grilla de PreciosMercados
        //El seleccionado de Clientes/Proovedores debe ser secuencial
        private void Seleccionado1(object sender, EventArgs e)
        {
            cmbCP2.Enabled = true;
            int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
            int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
            int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
            int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
        }
        private void Seleccionado2(object sender, EventArgs e)
        {
            cmbCP3.Enabled = true;
            int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
            int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
            int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
            int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
        }

        private void Seleccionado3(object sender, EventArgs e)
        {
            cmbCP4.Enabled = true;
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


        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvPiezas.ClearSelection();
            if (indice >= 0)
            {
                lblIdPieza.Text = dgvPiezas.Rows[indice].Cells[0].Value.ToString();
                txtCodigo.Text = dgvPiezas.Rows[indice].Cells[1].Value.ToString();
                txtPrecio.Text = dgvPiezas.Rows[indice].Cells[2].Value.ToString();
                txtDetalles.Text = dgvPiezas.Rows[indice].Cells[5].Value.ToString();
                cmbPiezaTipo.SelectedValue = dgvPiezas.Rows[indice].Cells[3].Value.ToString();
                cmbMaterial.SelectedValue = dgvPiezas.Rows[indice].Cells[4].Value.ToString();
                txtRutaImagen.Text = dgvPiezas.Rows[indice].Cells[10].Value.ToString();
                obtenerImagen();
                llenadoComboBoxTdPiezas();
                llenadoComboBoxMateriales();
                llenarGridPiezasModelos();

                if ((cmbCP1.SelectedValue != null) | (cmbCP2.SelectedValue != null) | (cmbCP3.SelectedValue != null) | (cmbCP4.SelectedValue != null))
                {
                    int Mercado1 = Convert.ToInt32(cmbCP1.SelectedValue);
                    int Mercado2 = Convert.ToInt32(cmbCP2.SelectedValue);
                    int Mercado3 = Convert.ToInt32(cmbCP3.SelectedValue);
                    int Mercado4 = Convert.ToInt32(cmbCP4.SelectedValue);
                    int Pieza = Convert.ToInt32(lblIdPieza.Text);
                    llenarGridMercados(Pieza, Mercado1, Mercado2, Mercado3, Mercado4);
                }


                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
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

        public static string PiezaId = "";
        public static string PiezaCodigo = "";
        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            PiezaId = lblIdPieza.Text;
            PiezaCodigo = txtCodigo.Text;
            PiezasModelos piezasModelos = new PiezasModelos();

            piezasModelos.ShowDialog();
        }

        public void llenarGridPiezasModelos()
        {
            int Pieza = Convert.ToInt32(lblIdPieza.Text);
            dvgPiezasModelos.DataSource = oPiezasModelosDAL.mostrarPiezasModelos(Pieza).Tables[0];
            this.dvgPiezasModelos.Columns["MO.Id"].Visible = false;
            this.dvgPiezasModelos.Columns["MA.Id"].Visible = false;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Todos (*.*)|*.*|JPG /JPEG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imgPieza.ImageLocation = getImage.FileName;
                txtRutaImagen.Text = getImage.FileName;
            }
        }

        private void obtenerImagen()
        {
            if (txtRutaImagen.Text != null)
            {
                imgPieza.ImageLocation = Convert.ToString(txtRutaImagen.Text);
            }
            else
            {
                imgPieza.Image = null;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oPiezasDAL.agregar(recuperarInformacionAgregarPieza());
            //limpiarEntradas();
            llenarGridPiezas();
        }
        private PiezasBLL recuperarInformacionAgregarPieza()
        {
            PiezasBLL oPieza = new PiezasBLL();
            oPieza.Codigo = txtCodigo.Text;
            if (txtPrecio.Text != "")
            {
                txtPrecio.Text = (txtPrecio.Text).Replace(".", ",");
                oPieza.Precio = Convert.ToDecimal(txtPrecio.Text);
            }
            else { oPieza.Precio = 0; }
            oPieza.PiezaTipo = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            oPieza.Material = Convert.ToInt32(cmbMaterial.SelectedValue);
            oPieza.Detalles = txtDetalles.Text;
            oPieza.Imagen = txtRutaImagen.Text;

            return oPieza;
        }

        private void btnQuitarModelo_Click(object sender, EventArgs e)
        {
            oPiezasModelosDAL.eliminar(recuperarInformacionPiezasModelos());
            lblIdModelo.Text = "0";
            btnQuitarModelo.Enabled = false;
            llenarGridPiezasModelos();
        }

        private PiezasBLL recuperarInformacionPieza()
        {
            PiezasBLL oPiezas = new PiezasBLL();
            oPiezas.Id = Convert.ToInt32(lblIdPieza.Text);
            oPiezas.Codigo = txtCodigo.Text;
            oPiezas.Detalles = txtDetalles.Text;
            oPiezas.Precio = Decimal.Parse(txtPrecio.Text);
            oPiezas.Imagen = txtRutaImagen.Text;
            oPiezas.PiezaTipo = Convert.ToInt32(cmbPiezaTipo.SelectedValue);
            oPiezas.Material = Convert.ToInt32(cmbMaterial.SelectedValue);

            return oPiezas;
        }

        private PiezasModelosBLL recuperarInformacionPiezasModelos()
        {
            PiezasModelosBLL oPiezasModelos = new PiezasModelosBLL();
            oPiezasModelos.Modelo = Convert.ToInt32(lblIdModelo.Text);
            oPiezasModelos.Pieza = Convert.ToInt32(lblIdPieza.Text);

            return oPiezasModelos;
        }

        private void SeleccionarPiezaModelo(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dvgPiezasModelos.ClearSelection();
            if (indice >= 0)
            {
                lblIdModelo.Text = dvgPiezasModelos.Rows[indice].Cells[0].Value.ToString();
                btnQuitarModelo.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oPiezasDAL.eliminar(recuperarInformacionPieza());
            txtCodigo.Clear();
            llenarGridPiezas();
            limpiarEntradas();
            btnLimpiar.Hide();
        }
        public void limpiarEntradas()
        {
            tabControl1.SelectedTab = tabPage1;
            txtPrecio.Clear();
            txtDetalles.Clear();
            txtCodigo.Clear();
            txtRutaImagen.Clear();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            lblIdPieza.Text = Convert.ToString(0);
            imgPieza.Image = null;
            cmbCP1.SelectedItem = null;
            cmbCP2.SelectedItem = null;
            cmbCP2.Enabled = false;
            cmbCP3.SelectedItem = null;
            cmbCP3.Enabled = false;
            cmbCP4.SelectedItem = null;
            cmbCP4.Enabled = false;
            cmbPiezaTipo.SelectedItem = null;
            cmbMaterial.SelectedItem = null;
            btnLimpiar.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oPiezasDAL.modificar(recuperarInformacionPieza());
            llenarGridPiezas();
            limpiarEntradas();
            btnLimpiar.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busquedaPieza.ShowDialog();
        }

        public void abrirBuscador() {
        busquedaPieza.ShowDialog();
        }
    }
}
