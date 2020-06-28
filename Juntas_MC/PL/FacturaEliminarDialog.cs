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
    public partial class FacturaEliminarDialog : Form
    {
        FacturasHistorial obj = (FacturasHistorial)Application.OpenForms["FacturasHistorial"];
        FacturasItemsDAL facturasItemsDAL;
        FacturasDAL facturasDAL;
        int FacturaId;
        public FacturaEliminarDialog()
        {
            InitializeComponent();
            facturasItemsDAL = new FacturasItemsDAL();
            facturasDAL = new FacturasDAL();
        }

        
        public string Advertencia(string FacturaNumero)
        {
            return lblAdvertencia.Text = "¿Desea eliminar la Factura/Remito: " +FacturaNumero + " ?";
        }

        private void FacturaEliminarDialog_Load(object sender, EventArgs e)
        {
            FacturaNumero = FacturasHistorial.FacturaNumero;
            FacturaId = FacturasHistorial.FacturaId;
            Advertencia(FacturaNumero);
        }
        string FacturaNumero;

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            facturasItemsDAL.eliminar(FacturaId);
            facturasDAL.eliminar(FacturaId);
            this.Close();
        }
    }
}
