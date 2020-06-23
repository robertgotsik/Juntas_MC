using DGVPrinterHelper;
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
    public partial class Facturador : Form
    {
        MercadosDAL oMercadosDAL;
        PiezasDAL oPiezasDAL;
        private DataTable dt;
        decimal importeTotal = 0;
        PreciosMercadosDAL oPreciosMercadosDAL;
        FacturasDAL oFacturasDAL;
        FacturasItemsDAL oFacturasItemsDAL;
        ImpresionDialog frmImpresionDialog;
        public Facturador()
        {
            InitializeComponent();
            oMercadosDAL = new MercadosDAL();
            oPiezasDAL = new PiezasDAL();
            oPreciosMercadosDAL = new PreciosMercadosDAL();
            oFacturasDAL = new FacturasDAL();
            oFacturasItemsDAL = new FacturasItemsDAL();
            frmImpresionDialog = new ImpresionDialog(this);
            llenadoDropDownClientes();
            llenadoDropDownPiezas();
            llenadoDropDownProveedores();

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio unit");
            //dt.Columns.Add("Precio x cant");
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

            int porcentaje;
            if (txtPorcentaje.Text != "")
            {
                porcentaje = Convert.ToInt32(txtPorcentaje.Text);
            }
            else
            {
                porcentaje = -1;
            }
            int pieza = Convert.ToInt32(cmbPieza.SelectedValue);
            int cantidad = (int)nupCantidad.Value;
            string descripcion = oPiezasDAL.averiguarDetalles(pieza);
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
            if (porcentaje != -1)
            {
                decimal precioPorPorcentaje = Math.Round(precioPorCantidad * porcentaje, 2);
                decimal precioDividido100 = Math.Round(precioPorPorcentaje / 100, 2);
                decimal valorMenosPorcentaje = Math.Round(precioPorCantidad - precioDividido100, 2);

                row["Codigo"] = cmbPieza.Text;
                row["Descripcion"] = descripcion;
                row["Cantidad"] = nupCantidad.Value;
                row["Precio unit"] = precio;
                //row["Precio x cant"] = precioPorCantidad;
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
            else
            {
                row["Codigo"] = cmbPieza.Text;
                row["Descripcion"] = descripcion;
                row["Cantidad"] = nupCantidad.Value;
                row["Precio unit"] = precio;
                //row["Precio x cant"] = precioPorCantidad;
                row["Bonificacion"] = "";
                row["Importe total"] = precioPorCantidad;

                dt.Rows.Add(row);
                importeTotal += Math.Round(precioPorCantidad, 2);
                lblImporteTotal.Text = importeTotal.ToString(); ;
                precio = 0;
            }
            
            
        }

        private void habilitaProveedor(object sender, EventArgs e)
        {
            if(cbProveedor.Checked == true)
            {
                cmbProveedor.Enabled = true;
            }
            else { cmbProveedor.Enabled = true; cmbProveedor.SelectedItem = null; }
            
        }

        private FacturasBLL recuperarInformacionFactura()
        {
            FacturasBLL oFacturasBLL = new FacturasBLL();
            //oMercados.Id = Convert.ToInt32(lblIdMercado.Text);
            oFacturasBLL.Numero = txtFactura.Text;
            oFacturasBLL.Cliente = Convert.ToInt32(cmbCliente.SelectedValue);
            oFacturasBLL.ImporteTotal = Convert.ToDecimal(lblImporteTotal.Text);

            return oFacturasBLL;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            oFacturasDAL.agregar(recuperarInformacionFactura());

            decimal Bonificacion;
            for (int i = 0; i < dvgFactura.Rows.Count -1; i++)
            {
                ultimaFacturaInsertada.Text = oFacturasDAL.buscarUltimoIdInsertado();
                int FacturaId = Convert.ToInt32(ultimaFacturaInsertada.Text);
                string PiezaCodigo = dvgFactura.Rows[i].Cells[0].Value.ToString();
                string Descripcion = dvgFactura.Rows[i].Cells[1].Value.ToString();
                int Cantidad = Convert.ToInt32(dvgFactura.Rows[i].Cells[2].Value);
                decimal PrecioUnitario = Convert.ToDecimal(dvgFactura.Rows[i].Cells[3].Value);
                if (dvgFactura.Rows[i].Cells[4].Value.ToString() == "")
                { Bonificacion = 0; }
                else { Bonificacion = Convert.ToDecimal(dvgFactura.Rows[i].Cells[4].Value); }
                decimal ItemImporteTotal = Convert.ToDecimal(dvgFactura.Rows[i].Cells[5].Value);
                oFacturasItemsDAL.insertarFacturasItems(FacturaId, PiezaCodigo, Cantidad, Descripcion,PrecioUnitario, Bonificacion, ItemImporteTotal);
            }

            
            frmImpresionDialog.ShowDialog();
        }

        public void imprimirFactura()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Juntas MARCELO";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyy"));
            printer.SubTitle = string.Format("Telefono: 1136579253");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = lblImporteTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dvgFactura);
        }
    }
}
