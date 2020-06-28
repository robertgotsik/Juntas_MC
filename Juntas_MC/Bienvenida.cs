using Juntas_MC.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juntas_MC
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItemMarcas_Click(object sender, EventArgs e)
        {
            Marcas frmMarcas = new Marcas();
            frmMarcas.Show();
        }

        private void menuItemModelos_Click(object sender, EventArgs e)
        {
            Modelos frmModelos = new Modelos();
            frmModelos.Show();
        }

        private void menuItemMateriales_Click(object sender, EventArgs e)
        {
            Materiales frmMateriales = new Materiales();
            frmMateriales.Show();
        }

        private void menuItemTipPiezas_Click(object sender, EventArgs e)
        {
            TiposDePiezas frmTiposDePiezas = new TiposDePiezas();
            frmTiposDePiezas.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm",CultureInfo.CreateSpecificCulture("fr-FR"));
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void menuItemPiezas_Click(object sender, EventArgs e)
        {
            Piezas piezas = new Piezas();
            piezas.Show();
            piezas.abrirBuscador();
        }

        private void menuItemProovedores_Click(object sender, EventArgs e)
        {
            Mercados mercados = new Mercados();
            mercados.Show();
            mercados.abrirBuscador();
        }

        private void esquemasComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mercados mercados = new Mercados();
            mercados.Show();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Facturador facturador = new Facturador();
            facturador.Show();
        }

        private void laEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigSistema configSistema = new ConfigSistema();
            configSistema.Show();
        }

        private void actualizarPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmPrecios actualizadorPrecios = new AdmPrecios();
            actualizadorPrecios.Show();
        }

        private void menuItemGenFact_Click(object sender, EventArgs e)
        {
            FacturasHistorial facturasHistorial = new FacturasHistorial();
            facturasHistorial.Show();
        }
    }
}
