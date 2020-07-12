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
    public partial class Mercados : Form
    {
        MercadosDAL oMercadosDAL;
        DAL.PreciosMercadosDAL oPreciosMercadosDAL;
        BusquedaMercado busquedaMercado;
        MercadosReplicar mercadosClonar;
        public Mercados()
        {
            oMercadosDAL = new MercadosDAL();
            oPreciosMercadosDAL = new DAL.PreciosMercadosDAL();
            busquedaMercado = new BusquedaMercado(this);
            mercadosClonar = new MercadosReplicar();
            InitializeComponent();
            llenadoComboBoxProvincias();
        }

        public void llenarGridMercados()
        {
            dvgMercados.DataSource = oMercadosDAL.mostrarMercados().Tables[0];
            this.dvgMercados.Columns["Id"].Visible = false;
            this.dvgMercados.Columns["IdTipo"].Visible = false;
            this.dvgMercados.Columns["Localidad"].Visible = false;
            this.dvgMercados.Columns["Email"].Visible = false;
            this.dvgMercados.Columns["Web"].Visible = false;
            this.dvgMercados.Columns["Direccion"].Visible = false;
            this.dvgMercados.Columns["Provincia"].Visible = false;
        }

        public void llenarGridMercadosConFiltros(string nombre, int tipo)
        {
            dvgMercados.DataSource = oMercadosDAL.mostrarMercadosConFiltos(nombre, tipo).Tables[0];
        }

        public void llenarGridMercadosPrecios(int IdMercado)
        {
            dvgMercadosPrecios.DataSource = oPreciosMercadosDAL.mostrarPreciosMercadosFull(IdMercado).Tables[0];
            this.dvgMercadosPrecios.Columns["PiezaId"].Visible = false;
        }

        private void llenadoComboBoxProvincias()
        {
            cmbProv.ValueMember = "Id";
            cmbProv.DisplayMember = "Nombre";
            cmbProv.DataSource = oMercadosDAL.mostrarProvincias().Tables[0];
            cmbProv.SelectedItem = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oMercadosDAL.agregar(recuperarInformacionMercados());
            //ultimoMercadoInsertado.Text = oMercadosDAL.buscarUltimoIdInsertado();
            //oPreciosMercadosDAL.insertarPreciosListaNuevosMercados(ultimoMercadoInsertado.Text);
            llenarGridMercados();
        }
        private MercadosBLL recuperarInformacionMercados()
        {
            MercadosBLL oMercados = new MercadosBLL();
            oMercados.Id = Convert.ToInt32(lblIdMercado.Text);
            oMercados.Nombre = txtNombre.Text;
            oMercados.Tipo = Convert.ToInt32(lbTipo.SelectedIndex);
            oMercados.Telefono1 = txtTelefono1.Text;
            oMercados.Porcentaje = Convert.ToInt32(nudPorcentaje.Value);
            oMercados.Email = txtEmail.Text;
            oMercados.Web = txtWeb.Text;
            oMercados.Direccion = txtDireccion.Text;
            oMercados.Localidad = txtLocalidad.Text;
            if (cmbProv.SelectedIndex == -1) { oMercados.Provincia = 1; }
            else { oMercados.Provincia = Convert.ToInt32(cmbProv.SelectedValue); }
            
            return oMercados;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            

            dvgMercados.ClearSelection();
            if (indice >= 0)
            {
                
                lblIdMercado.Text = dvgMercados.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dvgMercados.Rows[indice].Cells[1].Value.ToString();
                lbTipo.SelectedItem = dvgMercados.Rows[indice].Cells[3].Value.ToString();
                nudPorcentaje.Value = Convert.ToDecimal(dvgMercados.Rows[indice].Cells[5].Value.ToString());
                txtTelefono1.Text = dvgMercados.Rows[indice].Cells[4].Value.ToString();
                txtEmail.Text = dvgMercados.Rows[indice].Cells[6].Value.ToString();
                txtWeb.Text = dvgMercados.Rows[indice].Cells[7].Value.ToString();
                txtDireccion.Text = dvgMercados.Rows[indice].Cells[8].Value.ToString();
                txtLocalidad.Text = dvgMercados.Rows[indice].Cells[9].Value.ToString();
                cmbProv.SelectedValue = dvgMercados.Rows[indice].Cells[10].Value.ToString();


                int IdMercado = Convert.ToInt32(lblIdMercado.Text);
                llenarGridMercadosPrecios(IdMercado);

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busquedaMercado.ShowDialog();
        }
        public void abrirBuscador()
        {
            busquedaMercado.ShowDialog();
        }

        private void btnReplicar_Click(object sender, EventArgs e)
        {
            mercadosClonar.ShowDialog();
            int IdMercado = Convert.ToInt32(lblIdMercado.Text);
            llenarGridMercadosPrecios(IdMercado);
        }

        public static string MercadoId = "";
        public static string MercadoNombre = "";
        private void btnAgregarPieza_Click(object sender, EventArgs e)
        {
            MercadoId = lblIdMercado.Text;
            MercadoNombre = txtNombre.Text;
            MercadosPiezas oMercadosPiezas = new MercadosPiezas();
            oMercadosPiezas.ShowDialog();
        }

        private void btnQuitarPieza_Click(object sender, EventArgs e)
        {
            oPreciosMercadosDAL.eliminar(recuperarInformacionPreciosMercados());
            int IdMercado = Convert.ToInt32(lblIdMercado.Text);
            llenarGridMercadosPrecios(IdMercado);
            btnQuitarPieza.Enabled = false;
        }

        private PreciosMercadosBLL recuperarInformacionPreciosMercados()
        {
            PreciosMercadosBLL oPreciosMercadosBLL = new PreciosMercadosBLL();
            oPreciosMercadosBLL.Mercado = Convert.ToInt32(lblIdMercado.Text);
            oPreciosMercadosBLL.PiezaId = Convert.ToInt32(lblPiezaId.Text);

            return oPreciosMercadosBLL;
        }

        private void SeleccionarPrecioMercado(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dvgMercadosPrecios.ClearSelection();
            if (indice >= 0)
            {
                lblPiezaId.Text = dvgMercadosPrecios.Rows[indice].Cells[0].Value.ToString();
                btnQuitarPieza.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oMercadosDAL.modificar(recuperarInformacionMercados());
            llenarGridMercados();
            limpiarEntradas();
            btnLimpiar.Hide();
        }

        private void ActivarPorcentaje(object sender, EventArgs e)
        {
            if(lbTipo.SelectedIndex == 0)
            {
                lblPorcentaje.Enabled = true;
                lblPorciento.Enabled = true;
                nudPorcentaje.Enabled = true;
            }
            else
            {
                lblPorcentaje.Enabled = false;
                lblPorciento.Enabled = false;
                nudPorcentaje.Enabled = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lblIdMercado.Text != Convert.ToString(0)) && (tabControl1.SelectedTab == tabPage2) && (lbTipo.SelectedIndex == 1))
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if ((tabControl1.SelectedTab == tabPage2) && (lblIdMercado.Text == Convert.ToString(0)) | ((lbTipo.SelectedIndex == 0) | (lbTipo.SelectedIndex == -1)))
            {
                tabControl1.SelectedTab = tabPage1;
                string error = "No se ha selecionado Proveedor.";
                string img = "attention";
                ErrorDialogGenerico errorDialogGenerico = new ErrorDialogGenerico(error, img);
                errorDialogGenerico.ShowDialog();
            }
        }

        private void limpiarEntradas()
        {
            lblIdMercado.Text = Convert.ToString("0");
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono1.Clear();
            txtWeb.Clear();
            txtLocalidad.Clear();
            cmbProv.SelectedItem = null;
            nudPorcentaje.Value = 0;
            lbTipo.SelectedItem = null;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimpiar.Visible = false;
            btnAgregar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oMercadosDAL.eliminar(recuperarInformacionMercados());
            limpiarEntradas();
            btnLimpiar.Hide();
            llenarGridMercados();
        }
    }
}
