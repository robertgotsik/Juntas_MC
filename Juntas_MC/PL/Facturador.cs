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
        PreciosMercadosDAL oPreciosMercadosDAL;
        public Facturador()
        {
            InitializeComponent();
            oMercadosDAL = new MercadosDAL();
            oPiezasDAL = new PiezasDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            llenadoDropDownClientes();
            llenadoDropDownPiezas();
            llenadoDropDownProveedores();

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio unit");
            dt.Columns.Add("Precio x cant");
            dt.Columns.Add("Bonificacion");
            dt.Columns.Add("Importe total");

            dvgFactura.DataSource = dt;
        }

        private void llenadoDropDownClientes()
        {
            cmbCliente.ValueMember = "Id";
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.DataSource = oMercadosDAL.mostrarClientes().Tables[0];
            cmbCliente.SelectedItem = null;
        }
        private void llenadoDropDownProveedores()
        {
            cmbProveedor.ValueMember = "Id";
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.DataSource = oMercadosDAL.mostrarProveedores().Tables[0];
            cmbProveedor.SelectedItem = null;
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


        private void btnAgregarPieza_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            int porcentaje = Convert.ToInt32(txtPorcentaje.Text);
            int pieza = Convert.ToInt32(cmbPieza.SelectedValue);
            int cantidad = (int)nupCantidad.Value;
            decimal precio = 0;

            //Calculo Precio de Lista + Porcentaje Cliente.
            if (cbProveedor.Checked == true & cmbProveedor.SelectedValue != null)
            {
                int mercado = Convert.ToInt32(cmbProveedor.SelectedValue);
                precio = Convert.ToDecimal(oPreciosMercadosDAL.buscarPrecioProveedorPieza(mercado, pieza)); //Trae el Precio del Proveedor (Precios Mercados)
            }
            else
            {
                precio = Convert.ToDecimal(oPiezasDAL.averiguarPrecio(pieza)); //Trae el precio de lista (Piezas)
            }
            decimal precioPorCantidad = Math.Round(precio * cantidad, 2);
            decimal precioPorPorcentaje = Math.Round(precioPorCantidad * porcentaje, 2);
            decimal precioDividido100 = Math.Round(precioPorPorcentaje / 100, 2);
            decimal valorMenosPorcentaje = Math.Round(precioPorCantidad - precioDividido100, 2);
            
            

            row["Codigo"] = cmbPieza.Text;          
            row["Cantidad"] = nupCantidad.Value;          
            row["Precio unit"] = precio;
            row["Precio x cant"] = precioPorCantidad;
            row["Bonificacion"] = precioDividido100;
            row["Importe total"] = valorMenosPorcentaje;

            dt.Rows.Add(row);

            precio = 0;
            precioPorPorcentaje = 0;
            precioDividido100 = 0;
            importeTotal += Math.Round(valorMenosPorcentaje, 2);
            lblImporteTotal.Text = importeTotal.ToString(); ;
            valorMenosPorcentaje = 0;
        }

        private void habilitaProveedor(object sender, EventArgs e)
        {
            if(cbProveedor.Checked == true)
            {
                cmbProveedor.Enabled = true;
            }
            else { cmbProveedor.Enabled = true; cmbProveedor.SelectedItem = null; }
            
        }
    }
}
