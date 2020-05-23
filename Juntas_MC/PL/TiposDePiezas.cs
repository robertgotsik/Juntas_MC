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
    public partial class TiposDePiezas : Form
    {
        TiposDePiezasDAL oTiposDePiezasDAL;
        public TiposDePiezas()
        {
            oTiposDePiezasDAL = new TiposDePiezasDAL();
            InitializeComponent();
            llenarGrid();
            limpiarEntradas();

            this.dgvTiposDePiezas.Columns["Id"].Visible = false;

            btnLimpiar.Hide();
        }

        private TiposDePiezasBLL recuperarInformacionAgregarTiposDePiezas()
        {
            TiposDePiezasBLL oTiposDePiezas = new TiposDePiezasBLL();
            oTiposDePiezas.Nombre = txtNombre.Text;

            return oTiposDePiezas;
        }

        private TiposDePiezasBLL recuperarInformacionTiposDePiezas()
        {
            TiposDePiezasBLL oTiposDePiezas = new TiposDePiezasBLL();
            oTiposDePiezas.Id = Convert.ToInt32(lblIdTdP.Text);
            oTiposDePiezas.Nombre = txtNombre.Text;

            return oTiposDePiezas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oTiposDePiezasDAL.agregar(recuperarInformacionAgregarTiposDePiezas());
            borrarInput();
            llenarGrid();
            AgregadoDialog oAgregadoDialog = new AgregadoDialog();
            oAgregadoDialog.ShowDialog();
        }

        public void llenarGrid()
        {
            dgvTiposDePiezas.DataSource = oTiposDePiezasDAL.mostrarResultados().Tables[0];
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

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvTiposDePiezas.ClearSelection();
            if (indice >= 0)
            {
                lblIdTdP.Text = dgvTiposDePiezas.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvTiposDePiezas.Rows[indice].Cells[1].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnLimpiar.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oTiposDePiezasDAL.eliminar(recuperarInformacionTiposDePiezas());
            txtNombre.Clear();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
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
            oTiposDePiezasDAL.modificar(recuperarInformacionTiposDePiezas());
            ModificacionDialog oModificacionDialog = new ModificacionDialog();
            oModificacionDialog.ShowDialog();
            borrarInput();
            llenarGrid();
            limpiarEntradas();
            btnLimpiar.Hide();
        }
    }
}
