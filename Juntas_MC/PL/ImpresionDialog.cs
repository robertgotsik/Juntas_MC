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
    public partial class ImpresionDialog : Form
    {
        Facturador frmFacturador;
        FacturasDAL oFacturasDAL;
        FacturasItemsDAL oFacturasItemsDAL;
        
        public ImpresionDialog(Facturador frmFacturador)
        {
            this.frmFacturador = frmFacturador;
            oFacturasDAL = new FacturasDAL();
            oFacturasItemsDAL = new FacturasItemsDAL();


            InitializeComponent();
            //llenarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void button2_Click(object sender, EventArgs e)
        {
            llenarGrid();
            //frmFacturador.imprimirFacturaDGVPrinter();
            FacturasBLL ObjetoFactura = constuirFactura();
            if (ObjetoFactura != null)
            {
                imprimirFacturaCrystalReports();
            }
            this.Close();

        }

        public void llenarGrid()
        {
            int FacturaId = Convert.ToInt32(oFacturasDAL.buscarUltimoIdInsertado());
            facturasBLLBindingSource.DataSource = oFacturasDAL.mostrarFactura(FacturaId).Tables[0];
        }
        private FacturasBLL constuirFactura() //Construye DataGrid a Objecto FacturaBLL
        {
            FacturasBLL oFacturasBLL = new FacturasBLL();
            oFacturasBLL.Id = Convert.ToInt32(dgvFacturasItems.Rows[0].Cells[0].Value);
            oFacturasBLL.Numero = Convert.ToInt32(dgvFacturasItems.Rows[0].Cells[1].Value);
            oFacturasBLL.Cliente = Convert.ToInt32(dgvFacturasItems.Rows[0].Cells[2].Value);
            oFacturasBLL.ImporteTotal = Convert.ToDecimal(dgvFacturasItems.Rows[0].Cells[3].Value);
            oFacturasBLL.FechaEmision = Convert.ToDateTime(dgvFacturasItems.Rows[0].Cells[4].Value.ToString()); //string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyy"));

            return oFacturasBLL;
        }

        private void imprimirFacturaCrystalReports()
        {
            int FacturaId = Convert.ToInt32(oFacturasDAL.buscarUltimoIdInsertado());
            FacturasBLL ObjetoFactura = constuirFactura();
            List<FacturasItemsBLL> list = oFacturasDAL.detalleFactura(FacturaId);
            VistaPreviaFactura frmVistapreviaFactura = new VistaPreviaFactura(ObjetoFactura, list);
            frmVistapreviaFactura.ShowDialog();
        }
    }
}
