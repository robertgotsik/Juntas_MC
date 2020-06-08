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
    public partial class BusquedaMercado : Form
    {
        Mercados frmMercados;
        public BusquedaMercado(Mercados frmMercados)
        {
            this.frmMercados = frmMercados;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text != "") | (lbTipo.SelectedIndex != -1))
            {
                string nombre = txtNombre.Text;
                int tipo = lbTipo.SelectedIndex;
                frmMercados.llenarGridMercadosConFiltros(nombre, tipo);

            }
            else
            {
                frmMercados.llenarGridMercados();
            }

            txtNombre.Text = null;
            lbTipo.SelectedIndex = -1;

            this.Close();
        }
    }
}
