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
    public partial class MercadosReplicar : Form
    {
        MercadosDAL oMercadosDAL;
        PreciosMercadosDAL oPreciosMercadosDAL;
        public MercadosReplicar()
        {
            oMercadosDAL = new MercadosDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            InitializeComponent();
            llenadoComboBoxMercados();
        }

        private void llenadoComboBoxMercados()
        {
            cmbReplicar.ValueMember = "Id";
            cmbReplicar.DisplayMember = "Nombre";
            cmbReplicar.DataSource = oMercadosDAL.mostrarMercados().Tables[0];
            cmbReplicar.SelectedItem = null;

            cmbReferencia.ValueMember = "Id";
            cmbReferencia.DisplayMember = "Nombre";
            cmbReferencia.DataSource = oMercadosDAL.mostrarMercados().Tables[0];
            cmbReferencia.SelectedItem = null;
        }

        private void radMercado_CheckedChanged(object sender, EventArgs e)
        {
            cmbReferencia.Enabled = true;
        }

        private void radPdL_CheckedChanged(object sender, EventArgs e)
        {
            cmbReferencia.Enabled = false;
            cmbReferencia.SelectedItem = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (radMercado.Checked ==true)
            {
                if ((cmbReferencia.SelectedItem != null) & (cmbReplicar.SelectedItem != null) & (cmbReferencia.SelectedItem != cmbReplicar.SelectedItem))
                {
                    int aReplicar = Convert.ToInt32(cmbReplicar.SelectedValue);
                    int referencia = Convert.ToInt32(cmbReferencia.SelectedValue);
                    oPreciosMercadosDAL.borrarPreciosMercadosExistentes(aReplicar);
                    oPreciosMercadosDAL.replicarPreciosMercados(aReplicar, referencia);
                    this.Close();
                }
            }
            else if (radPdL.Checked == true)
            {
                if (cmbReplicar.SelectedItem != null)
                {
                    int aReplicar = Convert.ToInt32(cmbReplicar.SelectedValue);
                    oPreciosMercadosDAL.borrarPreciosMercadosExistentes(aReplicar);
                    oPreciosMercadosDAL.insertarPreciosListaAMercados(aReplicar);
                }
            }
        }
    }
}
