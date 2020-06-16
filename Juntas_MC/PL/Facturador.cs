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
    public partial class Facturador : Form
    {
        MercadosDAL oMercadosDAL;
        PiezasDAL oPiezasDAL;
        private DataTable dt;
        decimal importeTotal = 0;
        public Facturador()
        {
            InitializeComponent();
            oMercadosDAL = new MercadosDAL();
            oPiezasDAL = new PiezasDAL();
            llenadoDropDownMercados();
            llenadoDropDownPiezas();

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio unitario");
            dt.Columns.Add("Precio total");

            dvgFactura.DataSource = dt;
        }

        private void llenadoDropDownMercados()
        {
            cmbCliente.ValueMember = "Id";
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.DataSource = oMercadosDAL.mostrarMercados().Tables[0];
            cmbCliente.SelectedItem = null;
        }

        private void Seleccionado1(object sender, EventArgs e)
        {
            int mercado = Convert.ToInt32(cmbCliente.SelectedValue);
            txtPorcentaje.Text = oMercadosDAL.averiguarporcentaje(mercado);
        }

        private void llenadoDropDownPiezas()
        {
            cmbPieza.ValueMember = "Id";
            cmbPieza.DisplayMember = "Codigo";
            cmbPieza.DataSource = oPiezasDAL.mostrarPiezas2().Tables[0];
            cmbPieza.SelectedItem = null;
        }

        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            int porcentaje = Convert.ToInt32(txtPorcentaje.Text);
            int pieza = Convert.ToInt32(cmbPieza.SelectedValue);
            int cantidad = (int)nupCantidad.Value;

            //Calculo Precio de Lista + Porcentaje Cliente.
            decimal precioDeLista = Convert.ToDecimal(oPiezasDAL.averiguarPrecio(pieza));
            decimal precioPorPorcentaje = Math.Round(precioDeLista * porcentaje, 2);
            decimal precioDividido100 = Math.Round(precioPorPorcentaje / 100, 2);
            decimal valorMasPorcentaje = Math.Round(precioDeLista + precioDividido100, 2);
            
            decimal precioPorCantidad = Math.Round(valorMasPorcentaje * cantidad, 2);

            row["Codigo"] = cmbPieza.Text;          
            row["Cantidad"] = nupCantidad.Value;          
            row["Precio unitario"] = valorMasPorcentaje;
            row["Precio total"] = precioPorCantidad;

            dt.Rows.Add(row);

            precioDeLista = 0;
            precioPorPorcentaje = 0;
            precioDividido100 = 0;
            valorMasPorcentaje = 0;
            importeTotal += Math.Round(precioPorCantidad, 2);
            lblImporteTotal.Text = importeTotal.ToString(); ;
        }
    }
}
