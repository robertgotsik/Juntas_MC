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
    public partial class ZoomImgPiezas : Form
    {
        public ZoomImgPiezas()
        {
            InitializeComponent();
        }

        public void enviarDataZoomImg(string PiezaCodigo, string PiezaRutaImg, string PiezaDetalle)
        {
            imgPieza.ImageLocation = PiezaRutaImg;
            lblPiezaCodigo.Text = PiezaCodigo;
            txtDetalles.Text = PiezaDetalle;
        }
    }
}
