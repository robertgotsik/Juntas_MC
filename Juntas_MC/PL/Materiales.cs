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
    public partial class Materiales : Form
    {
        MaterialesDAL oMaterialesDAL;
        public Materiales()
        {
            oMaterialesDAL = new MaterialesDAL();
            InitializeComponent();
            llenarGrid();

            btnLimpiar.Hide();

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;

            this.dgvMateriales.Columns["Id"].Visible = false;
        }

        private MaterialesBLL recuperarInformacionMaterial()
        {
            MaterialesBLL oMaterial = new MaterialesBLL();
            oMaterial.Id = Convert.ToInt32(lblIdMaterial.Text);
            oMaterial.Nombre = txtNombre.Text;

            return oMaterial;
        }

        private MaterialesBLL recuperarInformacionAgregarMaterial()
        {
            MaterialesBLL oMaterial = new MaterialesBLL();
            oMaterial.Nombre = txtNombre.Text;

            return oMaterial;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(recuperarInformacionMarca());
            oMaterialesDAL.agregar(recuperarInformacionAgregarMaterial());
            borrarInput();
            llenarGrid();
            AgregadoDialog oAgregadoDialog = new AgregadoDialog();
            oAgregadoDialog.ShowDialog();
        }

        public void llenarGrid()
        {
            dgvMateriales.DataSource = oMaterialesDAL.mostrarMateriales().Tables[0];
        }

        public void borrarInput()
        {
            txtNombre.Text = string.Empty;
        }


        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvMateriales.ClearSelection();
            if (indice >= 0)
            {
                lblIdMaterial.Text = dgvMateriales.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvMateriales.Rows[indice].Cells[1].Value.ToString();
                //seleccion = dgvModelos.Rows[indice].Cells[1].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();

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
            oMaterialesDAL.modificar(recuperarInformacionMaterial());
            ModificacionDialog oModificacionDialog = new ModificacionDialog();
            oModificacionDialog.ShowDialog();
            borrarInput();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oMaterialesDAL.eliminar(recuperarInformacionMaterial());
            txtNombre.Clear();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
        }
    }
}
