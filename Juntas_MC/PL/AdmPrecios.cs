using System;
using System.Windows.Forms;

namespace Juntas_MC.PL
{
    public partial class AdmPrecios : Form
    {
        MercadosReplicar mercadosReplicar;
        PiezasActualizarPrecios actualizarPrecios;
        public AdmPrecios()
        {
            mercadosReplicar = new MercadosReplicar();
            actualizarPrecios = new PiezasActualizarPrecios();
            InitializeComponent();
        }

        private void btnReplicar_Click(object sender, EventArgs e)
        {
            mercadosReplicar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizarPrecios.ShowDialog();
        }
    }
}
