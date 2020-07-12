using Juntas_MC.BLL;
using Juntas_MC.DAL;
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

namespace Juntas_MC.PL
{
    public partial class MercadosPiezas : Form
    {
        PiezasDAL oPiezasDAL;
        PreciosMercadosDAL oPreciosMercadosDAL;
        CultureInfo oCultureInfo;

        Mercados obj = (Mercados)Application.OpenForms["Mercados"];
        public MercadosPiezas()
        {
            InitializeComponent();
            oPiezasDAL = new PiezasDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            oCultureInfo = new CultureInfo("en-US");
            iniciarLlenadoDropDown();
        }

        

        private void MercadosPiezas_Load(object sender, EventArgs e)
        {
            txtMercado.Text = Mercados.MercadoNombre;
            lblMercadoId.Text = Mercados.MercadoId;
        }

        private void iniciarLlenadoDropDown()
        {
            cmbPiezas.ValueMember = "Id";
            cmbPiezas.DisplayMember = "Codigo";
            cmbPiezas.DataSource = oPiezasDAL.mostrarPiezas2().Tables[0];
            cmbPiezas.SelectedItem = null;
        }

        private PreciosMercadosBLL recuperarInformacionMercadoPieza()
        {
            PreciosMercadosBLL oPreciosMercadosBLL = new PreciosMercadosBLL();
            oPreciosMercadosBLL.PiezaId = Convert.ToInt32(cmbPiezas.SelectedValue);
            oPreciosMercadosBLL.Mercado = Convert.ToInt32(lblMercadoId.Text);
            if (txtPrecio.Text != "") { txtPrecio.Text = (txtPrecio.Text).Replace(",", "."); oPreciosMercadosBLL.Precio = Convert.ToDecimal(txtPrecio.Text, oCultureInfo); }

            return oPreciosMercadosBLL;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(lblMercadoId.Text != "0" & txtPrecio.Text !="")
            {
                oPreciosMercadosDAL.agregar(recuperarInformacionMercadoPieza());
                int mercadoId = Convert.ToInt32(lblMercadoId.Text);
                obj.llenarGridMercadosPrecios(mercadoId);
            }
            else
            {
                string error = "El campo Precio esta vacío.";
                string imagen = "attention";
                ErrorDialogGenerico errorDialogGenerico = new ErrorDialogGenerico(error, imagen);
                errorDialogGenerico.ShowDialog();
            }
        }
    }
}
