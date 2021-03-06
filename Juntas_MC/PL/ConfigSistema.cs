﻿using Juntas_MC.BLL;
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
    public partial class ConfigSistema : Form
    {
        EmpresasDAL oEmpresasDAL;
        public ConfigSistema()
        {
            InitializeComponent();
            oEmpresasDAL = new EmpresasDAL();
            llenarInfo();
        }

        public void llenarInfo()
        {
            dvgEmpresa.DataSource = oEmpresasDAL.mostrarEmpresa().Tables[0];
            txtNombre.Text = dvgEmpresa.Rows[0].Cells[1].Value.ToString();
            txtTelefono1.Text = dvgEmpresa.Rows[0].Cells[2].Value.ToString();
            txtEmail.Text = dvgEmpresa.Rows[0].Cells[3].Value.ToString();
            txtWeb.Text = dvgEmpresa.Rows[0].Cells[4].Value.ToString();
            txtDireccion.Text = dvgEmpresa.Rows[0].Cells[5].Value.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            oEmpresasDAL.modificar(recuperarInformacionEmpresa());
            this.Close();
        }

        public EmpresasBLL recuperarInformacionEmpresa()
        {
            EmpresasBLL empresasBLL = new EmpresasBLL();
            empresasBLL.Id = 1;
            empresasBLL.Nombre = txtNombre.Text;
            empresasBLL.Telefono = txtTelefono1.Text;
            empresasBLL.Email = txtEmail.Text;
            empresasBLL.Web = txtWeb.Text;
            empresasBLL.Direccion = txtDireccion.Text;

            return empresasBLL;
        }
    }
}
