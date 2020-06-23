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
    public partial class ImpresionDialog : Form
    {
        Facturador frmFacturador;
        public ImpresionDialog(Facturador frmFacturador)
        {
            this.frmFacturador = frmFacturador;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFacturador.imprimirFactura();
        }
    }
}
