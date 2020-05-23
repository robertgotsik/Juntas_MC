using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juntas_MC.BLL;
using Juntas_MC.DAL;

namespace Juntas_MC.PL
{
    public partial class Modelos : Form
    {
        MarcasDAL oMarcasDAL;
        ModelosDAL oModelosDAL;

        public string seleccion = "";

        public Modelos()
        {
            oModelosDAL = new ModelosDAL();
            oMarcasDAL = new MarcasDAL();
            InitializeComponent();
            iniciarLlenadoDropDown();
            llenarGrid();
            this.dgvModelos.Columns["MoID"].Visible = false;
            this.dgvModelos.Columns["MaID"].Visible = false;

            btnLimpiar.Hide();

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
        }

        //Funcion que recolecta info del formulario para agregar
        private ModelosBLL recuperarInformacionAgregarModelo()
        {
            ModelosBLL oModelo = new ModelosBLL();
            oModelo.Nombre = txtNombre.Text;
            oModelo.Marca = Convert.ToInt32(dropMarca.SelectedValue);

            return oModelo;
        }

        //Funcion que recolecta info del formulario para modificar/borrar
        private ModelosBLL recuperarInformacionModelo()
        {
            ModelosBLL oModelo = new ModelosBLL();
            oModelo.Id = Convert.ToInt32(lblIdModelo.Text);
            oModelo.Nombre = txtNombre.Text;
            oModelo.Marca = Convert.ToInt32(dropMarca.SelectedValue);

            return oModelo;
        }


        private void iniciarLlenadoDropDown()
        {
            dropMarca.ValueMember = "Id";
            dropMarca.DisplayMember = "Nombre";
            dropMarca.DataSource = oMarcasDAL.mostrarMarcas().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oModelosDAL.agregar(recuperarInformacionAgregarModelo());
            llenarGrid();
            AgregadoDialog oAgregadoDialog = new AgregadoDialog();
            oAgregadoDialog.ShowDialog();
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvModelos.ClearSelection();
            if (indice >= 0)
            {
                lblIdModelo.Text = dgvModelos.Rows[indice].Cells[0].Value.ToString();
                lblIdMarca.Text = dgvModelos.Rows[indice].Cells[2].Value.ToString();
                txtNombre.Text = dgvModelos.Rows[indice].Cells[1].Value.ToString();
                dropMarca.SelectedValue = dgvModelos.Rows[indice].Cells[2].Value.ToString();
                //seleccion = dgvModelos.Rows[indice].Cells[1].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();
        }

        public void llenarGrid()
        {
            dgvModelos.DataSource = oModelosDAL.mostrarModelos().Tables[0];
        }

        private void dropMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oModelosDAL.eliminar(recuperarInformacionModelo());
            txtNombre.Clear();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
        }

        public void limpiarEntradas()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimpiar.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oModelosDAL.modificar(recuperarInformacionModelo());
            ModificacionDialog oModificacionDialog = new ModificacionDialog();
            oModificacionDialog.ShowDialog();
            borrarInput();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
        }

        public void borrarInput()
        {
            txtNombre.Text = string.Empty;
        }
    }
}
