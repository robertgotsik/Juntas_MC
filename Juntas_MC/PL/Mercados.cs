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
        PreciosMercadosDAL oPreciosMercadosDAL;
        BusquedaMercado busquedaMercado;
        MercadosReplicar mercadosClonar;
        public Mercados()
        {
            oMercadosDAL = new MercadosDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
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
            this.dvgMercados.Columns["Telefono2"].Visible = false;
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
            llenarGridMercados();
        }
        private MercadosBLL recuperarInformacionMercados()
        {
            MercadosBLL oMercados = new MercadosBLL();
            oMercados.Nombre = txtNombre.Text;
            oMercados.Tipo = Convert.ToInt32(lbTipo.SelectedIndex);
            oMercados.Telefono1 = txtTelefono1.Text;
            oMercados.Telefono2 = txtTelefono2.Text;
            oMercados.Email = txtEmail.Text;
            oMercados.Web = txtWeb.Text;
            oMercados.Direccion = txtDireccion.Text;
            oMercados.Localidad = txtLocalidad.Text;
            oMercados.Provincia = Convert.ToInt32(cmbProv.SelectedValue);

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
    }
}
