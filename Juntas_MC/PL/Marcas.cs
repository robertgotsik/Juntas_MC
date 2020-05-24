using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juntas_MC.DAL;
using Juntas_MC.BLL;

namespace Juntas_MC.PL
{
    public partial class Marcas : Form
    {
        MarcasDAL oMarcasDAL;
        
        public Marcas()
        {
            oMarcasDAL = new MarcasDAL();
            InitializeComponent();
            llenarGrid();
            limpiarEntradas();

            this.dgvMarcas.Columns["Id"].Visible = false;

            btnLimpiar.Hide();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {

        }

        private MarcasBLL recuperarInformacionAgregarMarca()
        {
            MarcasBLL oMarca = new MarcasBLL();
            oMarca.Nombre = txtNombre.Text;

            return oMarca;
        }

        private MarcasBLL recuperarInformacionMarca()
        {
            MarcasBLL oMarca = new MarcasBLL();
            oMarca.Id = Convert.ToInt32(lblIdMarca.Text);
            oMarca.Nombre = txtNombre.Text;

            return oMarca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(recuperarInformacionMarca());
            oMarcasDAL.agregar(recuperarInformacionAgregarMarca());
            borrarInput();
            llenarGrid();
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvMarcas.ClearSelection();
            if (indice >=0)
            {
                lblIdMarca.Text = dgvMarcas.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvMarcas.Rows[indice].Cells[1].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oMarcasDAL.eliminar(recuperarInformacionMarca());
            txtNombre.Clear();
            llenarGrid();
            limpiarEntradas(); 
            btnLimpiar.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oMarcasDAL.modificar(recuperarInformacionMarca());
            borrarInput();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
        }

        public void llenarGrid()
        {
            dgvMarcas.DataSource = oMarcasDAL.mostrarMarcas().Tables[0];
        }

        public void limpiarEntradas()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        public void borrarInput()
        {
            txtNombre.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimpiar.Hide();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
