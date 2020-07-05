namespace Juntas_MC.PL
{
    partial class Listados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrecioDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piezasBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.CheckBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.CheckBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cbTodasPiezas = new System.Windows.Forms.CheckBox();
            this.cbTipoPieza = new System.Windows.Forms.CheckBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.CheckBox();
            this.cmbPiezaTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Destinatario = new System.Windows.Forms.GroupBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblDto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDto = new System.Windows.Forms.TextBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezasBLLBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Destinatario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AutoGenerateColumns = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.PrecioDeVenta});
            this.dgvListado.DataSource = this.piezasBLLBindingSource;
            this.dgvListado.Location = new System.Drawing.Point(7, 21);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListado.RowTemplate.Height = 50;
            this.dgvListado.Size = new System.Drawing.Size(1189, 562);
            this.dgvListado.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "Detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "Detalles";
            this.detallesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.Width = 200;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 80;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Foto";
            this.pictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pictureDataGridViewImageColumn.Width = 125;
            // 
            // PrecioDeVenta
            // 
            this.PrecioDeVenta.DataPropertyName = "PrecioDeVenta";
            this.PrecioDeVenta.HeaderText = "PrecioDeVenta";
            this.PrecioDeVenta.MinimumWidth = 6;
            this.PrecioDeVenta.Name = "PrecioDeVenta";
            this.PrecioDeVenta.Width = 80;
            // 
            // piezasBLLBindingSource
            // 
            this.piezasBLLBindingSource.DataSource = typeof(Juntas_MC.BLL.PiezasBLL);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAumento);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Destinatario);
            this.groupBox1.Controls.Add(this.lblDto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDto);
            this.groupBox1.Controls.Add(this.txtGanancia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(920, 134);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(65, 22);
            this.txtAumento.TabIndex = 37;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMarca);
            this.groupBox4.Controls.Add(this.cmbModelo);
            this.groupBox4.Controls.Add(this.cbModelo);
            this.groupBox4.Controls.Add(this.cmbMarca);
            this.groupBox4.Controls.Add(this.cbTodasPiezas);
            this.groupBox4.Controls.Add(this.cbTipoPieza);
            this.groupBox4.Controls.Add(this.cmbMaterial);
            this.groupBox4.Controls.Add(this.cbMaterial);
            this.groupBox4.Controls.Add(this.cmbPiezaTipo);
            this.groupBox4.Location = new System.Drawing.Point(238, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(662, 145);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Piezas";
            // 
            // cbMarca
            // 
            this.cbMarca.AutoSize = true;
            this.cbMarca.Enabled = false;
            this.cbMarca.Location = new System.Drawing.Point(367, 64);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(69, 21);
            this.cbMarca.TabIndex = 14;
            this.cbMarca.Text = "Marca";
            this.cbMarca.UseVisualStyleBackColor = true;
            this.cbMarca.CheckedChanged += new System.EventHandler(this.cbMarca_CheckedChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModelo.Enabled = false;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(452, 93);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(187, 24);
            this.cmbModelo.TabIndex = 13;
            // 
            // cbModelo
            // 
            this.cbModelo.AutoSize = true;
            this.cbModelo.Enabled = false;
            this.cbModelo.Location = new System.Drawing.Point(367, 92);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(76, 21);
            this.cbModelo.TabIndex = 15;
            this.cbModelo.Text = "Modelo";
            this.cbModelo.UseVisualStyleBackColor = true;
            this.cbModelo.CheckedChanged += new System.EventHandler(this.cbModelo_CheckedChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarca.Enabled = false;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(452, 62);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(187, 24);
            this.cmbMarca.TabIndex = 12;
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.ActualizarModelos);
            // 
            // cbTodasPiezas
            // 
            this.cbTodasPiezas.AutoSize = true;
            this.cbTodasPiezas.Checked = true;
            this.cbTodasPiezas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTodasPiezas.Location = new System.Drawing.Point(266, 19);
            this.cbTodasPiezas.Name = "cbTodasPiezas";
            this.cbTodasPiezas.Size = new System.Drawing.Size(137, 21);
            this.cbTodasPiezas.TabIndex = 0;
            this.cbTodasPiezas.Text = "Todas las piezas";
            this.cbTodasPiezas.UseVisualStyleBackColor = true;
            this.cbTodasPiezas.CheckedChanged += new System.EventHandler(this.cbTodasPiezas_CheckedChanged);
            // 
            // cbTipoPieza
            // 
            this.cbTipoPieza.AutoSize = true;
            this.cbTipoPieza.Enabled = false;
            this.cbTipoPieza.Location = new System.Drawing.Point(6, 65);
            this.cbTipoPieza.Name = "cbTipoPieza";
            this.cbTipoPieza.Size = new System.Drawing.Size(117, 21);
            this.cbTipoPieza.TabIndex = 10;
            this.cbTipoPieza.Text = "Tipo de Pieza";
            this.cbTipoPieza.UseVisualStyleBackColor = true;
            this.cbTipoPieza.CheckedChanged += new System.EventHandler(this.cbTipoPieza_CheckedChanged);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterial.Enabled = false;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(129, 93);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(187, 24);
            this.cmbMaterial.TabIndex = 9;
            // 
            // cbMaterial
            // 
            this.cbMaterial.AutoSize = true;
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Location = new System.Drawing.Point(6, 93);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(80, 21);
            this.cbMaterial.TabIndex = 11;
            this.cbMaterial.Text = "Material";
            this.cbMaterial.UseVisualStyleBackColor = true;
            this.cbMaterial.CheckedChanged += new System.EventHandler(this.cbMaterial_CheckedChanged);
            // 
            // cmbPiezaTipo
            // 
            this.cmbPiezaTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPiezaTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPiezaTipo.Enabled = false;
            this.cmbPiezaTipo.FormattingEnabled = true;
            this.cmbPiezaTipo.Location = new System.Drawing.Point(129, 62);
            this.cmbPiezaTipo.Name = "cmbPiezaTipo";
            this.cmbPiezaTipo.Size = new System.Drawing.Size(187, 24);
            this.cmbPiezaTipo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Aumento:";
            // 
            // Destinatario
            // 
            this.Destinatario.Controls.Add(this.lblPorcentaje);
            this.Destinatario.Controls.Add(this.lblCliente);
            this.Destinatario.Controls.Add(this.txtPorcentaje);
            this.Destinatario.Controls.Add(this.cmbCliente);
            this.Destinatario.Location = new System.Drawing.Point(7, 21);
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.Size = new System.Drawing.Size(216, 145);
            this.Destinatario.TabIndex = 31;
            this.Destinatario.TabStop = false;
            this.Destinatario.Text = "Destinatario";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(63, 87);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.lblPorcentaje.TabIndex = 31;
            this.lblPorcentaje.Text = "Procentaje";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 28;
            this.lblCliente.Text = "Cliente";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(66, 107);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(65, 22);
            this.txtPorcentaje.TabIndex = 30;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(9, 45);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(201, 24);
            this.cmbCliente.TabIndex = 29;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.SeleccionCliente);
            // 
            // lblDto
            // 
            this.lblDto.AutoSize = true;
            this.lblDto.Location = new System.Drawing.Point(922, 70);
            this.lblDto.Name = "lblDto";
            this.lblDto.Size = new System.Drawing.Size(44, 17);
            this.lblDto.TabIndex = 35;
            this.lblDto.Text = "Desc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ganancia:";
            // 
            // txtDto
            // 
            this.txtDto.Location = new System.Drawing.Point(920, 87);
            this.txtDto.Name = "txtDto";
            this.txtDto.Size = new System.Drawing.Size(65, 22);
            this.txtDto.TabIndex = 34;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(920, 39);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(65, 22);
            this.txtGanancia.TabIndex = 33;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Juntas_MC.Properties.Resources.iconfinder_Search_58605;
            this.btnAceptar.Location = new System.Drawing.Point(25, 21);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 58);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Filtrar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListado);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1202, 542);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grilla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Location = new System.Drawing.Point(1041, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 172);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::Juntas_MC.Properties.Resources.printer;
            this.btnImprimir.Location = new System.Drawing.Point(25, 98);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 58);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 744);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezasBLLBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Destinatario.ResumeLayout(false);
            this.Destinatario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTodasPiezas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTipoPieza;
        private System.Windows.Forms.ComboBox cmbPiezaTipo;
        private System.Windows.Forms.CheckBox cbMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource piezasBLLBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox Destinatario;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDto;
        private System.Windows.Forms.TextBox txtDto;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMarca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.CheckBox cbModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDeVenta;
    }
}