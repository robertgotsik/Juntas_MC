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
        PiezasModelos oPiezasModelosDAL;
        ModelosDAL oModelosDAL;
        PiezasDAL oPiezasDAL;
        public PiezasModelos()
        {
            //oPiezasModelosDAL = new PiezasModelos();
            oModelosDAL = new ModelosDAL();
            InitializeComponent();
            iniciarLlenadoDropDown();
        }

        private void cmbPiezasModelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void iniciarLlenadoDropDown()
        { 
            cmbPiezasModelos.ValueMember = "Id";
            cmbPiezasModelos.DisplayMember = "NombreModeloMarca";
            cmbPiezasModelos.DataSource = oModelosDAL.mostrarModelosCmb().Tables[0];
        }

        //private PiezasModelosBLL recuperarInformacionAgregarModelo()
        //{
        //    PiezasModelosBLL oPiezasModelosBLL = new PiezasModelosBLL();
        //    oPiezasModelosBLL.Modelo = Convert.ToInt32(cmbPiezasModelos.SelectedValue);

        //    return oPiezasModelosBLL;
        //}
    }
}
