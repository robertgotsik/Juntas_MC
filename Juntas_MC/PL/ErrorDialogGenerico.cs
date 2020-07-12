using Juntas_MC.Properties;
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
    public partial class ErrorDialogGenerico : Form
    {
        public ErrorDialogGenerico(string error, string imagenResource)
        {
            InitializeComponent();
            lblMensaje.Text = error;
            imagen.Image = (Image)Properties.Resources.ResourceManager.GetObject(imagenResource);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
