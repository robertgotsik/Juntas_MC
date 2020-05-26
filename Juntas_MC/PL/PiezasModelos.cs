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
    public partial class PiezasModelos : Form
    {

        ModelosDAL oModelosDAL;
        PiezasModelosDAL oPiezasModelosDAL;

        Piezas obj = (Piezas)Application.OpenForms["Piezas"];

        public PiezasModelos()
        {
            oModelosDAL = new ModelosDAL();
            oPiezasModelosDAL = new PiezasModelosDAL();
            InitializeComponent();
            iniciarLlenadoDropDown();
        }


        private void iniciarLlenadoDropDown()
        {
            cmbPiezasModelos.ValueMember = "MO.Id";
            cmbPiezasModelos.DisplayMember = "NombreModeloMarca";
            cmbPiezasModelos.DataSource = oModelosDAL.mostrarModelosCmb().Tables[0];
        }

        private void PiezasModelos_Load(object sender, EventArgs e)
        {
            txtPiezaCodigo.Text = Piezas.PiezaCodigo;
            lblPiezaId.Text = Piezas.PiezaId;
        }

        private PiezasModelosBLL recuperarInformacionPiezaModelo()
        {
            PiezasModelosBLL piezasModelosBLL = new PiezasModelosBLL();
            piezasModelosBLL.Pieza = Convert.ToInt32(lblPiezaId.Text);
            piezasModelosBLL.Modelo = Convert.ToInt32(cmbPiezasModelos.SelectedValue);

            return piezasModelosBLL;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oPiezasModelosDAL.agregar(recuperarInformacionPiezaModelo());
            obj.llenarGridPiezasModelos();
        }
    }
}
