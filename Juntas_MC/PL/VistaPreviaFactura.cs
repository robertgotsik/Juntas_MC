using Juntas_MC.BLL;
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
    public partial class VistaPreviaFactura : Form
    {
        List<FacturasItemsBLL> _list;
        FacturasBLL _facturasBLL;

        public VistaPreviaFactura(FacturasBLL facturas, List<FacturasItemsBLL> list)
        {
            InitializeComponent();
            _facturasBLL = facturas;
            _list = list;
        }

        private void VistaPreviaFactura_Load(object sender, EventArgs e)
        {
            rptFactura1.SetDataSource(_list);
            rptFactura1.SetParameterValue("pFactura", _facturasBLL.Numero);
            rptFactura1.SetParameterValue("pImporteTotal", _facturasBLL.ImporteTotal);
            rptFactura1.SetParameterValue("pFecha", _facturasBLL.FechaEmision);
            crystalReportViewer.ReportSource = rptFactura1;
            crystalReportViewer.Refresh();
        }
    }
}
