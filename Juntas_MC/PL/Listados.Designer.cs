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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblDto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDto = new System.Windows.Forms.TextBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.piezasBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrecioDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Destinatario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piezasBLLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AutoGenerateColumns = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.detallesDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.Foto,
            this.PrecioDeVenta});
            this.dgvListado.DataSource = this.piezasBLLBindingSource;
            this.dgvListado.Location = new System.Drawing.Point(5, 17);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListado.RowTemplate.Height = 50;
            this.dgvListado.Size = new System.Drawing.Size(892, 523);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAumento);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Destinatario);
            this.groupBox1.Controls.Add(this.lblDto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDto);
            this.groupBox1.Controls.Add(this.txtGanancia);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(767, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(723, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(723, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(723, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "%";
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(690, 109);
            this.txtAumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(50, 20);
            this.txtAumento.TabIndex = 13;
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
            this.groupBox4.Location = new System.Drawing.Point(178, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(496, 118);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Piezas";
            // 
            // cbMarca
            // 
            this.cbMarca.AutoSize = true;
            this.cbMarca.Enabled = false;
            this.cbMarca.Location = new System.Drawing.Point(275, 52);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(56, 17);
            this.cbMarca.TabIndex = 7;
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
            this.cmbModelo.Location = new System.Drawing.Point(339, 76);
            this.cmbModelo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(141, 21);
            this.cmbModelo.TabIndex = 10;
            // 
            // cbModelo
            // 
            this.cbModelo.AutoSize = true;
            this.cbModelo.Enabled = false;
            this.cbModelo.Location = new System.Drawing.Point(275, 75);
            this.cbModelo.Margin = new System.Windows.Forms.Padding(2);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(61, 17);
            this.cbModelo.TabIndex = 9;
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
            this.cmbMarca.Location = new System.Drawing.Point(339, 50);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(141, 21);
            this.cmbMarca.TabIndex = 8;
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.ActualizarModelos);
            // 
            // cbTodasPiezas
            // 
            this.cbTodasPiezas.AutoSize = true;
            this.cbTodasPiezas.Checked = true;
            this.cbTodasPiezas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTodasPiezas.Location = new System.Drawing.Point(200, 15);
            this.cbTodasPiezas.Margin = new System.Windows.Forms.Padding(2);
            this.cbTodasPiezas.Name = "cbTodasPiezas";
            this.cbTodasPiezas.Size = new System.Drawing.Size(105, 17);
            this.cbTodasPiezas.TabIndex = 2;
            this.cbTodasPiezas.Text = "Todas las piezas";
            this.cbTodasPiezas.UseVisualStyleBackColor = true;
            this.cbTodasPiezas.CheckedChanged += new System.EventHandler(this.cbTodasPiezas_CheckedChanged);
            // 
            // cbTipoPieza
            // 
            this.cbTipoPieza.AutoSize = true;
            this.cbTipoPieza.Enabled = false;
            this.cbTipoPieza.Location = new System.Drawing.Point(4, 53);
            this.cbTipoPieza.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoPieza.Name = "cbTipoPieza";
            this.cbTipoPieza.Size = new System.Drawing.Size(91, 17);
            this.cbTipoPieza.TabIndex = 3;
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
            this.cmbMaterial.Location = new System.Drawing.Point(97, 76);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(141, 21);
            this.cmbMaterial.TabIndex = 6;
            // 
            // cbMaterial
            // 
            this.cbMaterial.AutoSize = true;
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Location = new System.Drawing.Point(4, 76);
            this.cbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(63, 17);
            this.cbMaterial.TabIndex = 5;
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
            this.cmbPiezaTipo.Location = new System.Drawing.Point(97, 50);
            this.cmbPiezaTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPiezaTipo.Name = "cmbPiezaTipo";
            this.cmbPiezaTipo.Size = new System.Drawing.Size(141, 21);
            this.cmbPiezaTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Aumento:";
            // 
            // Destinatario
            // 
            this.Destinatario.Controls.Add(this.label6);
            this.Destinatario.Controls.Add(this.lblPorcentaje);
            this.Destinatario.Controls.Add(this.lblCliente);
            this.Destinatario.Controls.Add(this.txtPorcentaje);
            this.Destinatario.Controls.Add(this.cmbCliente);
            this.Destinatario.Location = new System.Drawing.Point(5, 17);
            this.Destinatario.Margin = new System.Windows.Forms.Padding(2);
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.Padding = new System.Windows.Forms.Padding(2);
            this.Destinatario.Size = new System.Drawing.Size(162, 118);
            this.Destinatario.TabIndex = 31;
            this.Destinatario.TabStop = false;
            this.Destinatario.Text = "Destinatario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(109, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "%";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(4, 88);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(61, 13);
            this.lblPorcentaje.TabIndex = 31;
            this.lblPorcentaje.Text = "Procentaje:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(4, 34);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 28;
            this.lblCliente.Text = "Cliente";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(69, 85);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.ReadOnly = true;
            this.txtPorcentaje.Size = new System.Drawing.Size(56, 20);
            this.txtPorcentaje.TabIndex = 30;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(6, 50);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(152, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.SeleccionCliente);
            // 
            // lblDto
            // 
            this.lblDto.AutoSize = true;
            this.lblDto.Location = new System.Drawing.Point(692, 57);
            this.lblDto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDto.Name = "lblDto";
            this.lblDto.Size = new System.Drawing.Size(35, 13);
            this.lblDto.TabIndex = 35;
            this.lblDto.Text = "Desc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ganancia:";
            // 
            // txtDto
            // 
            this.txtDto.Location = new System.Drawing.Point(690, 71);
            this.txtDto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDto.Name = "txtDto";
            this.txtDto.Size = new System.Drawing.Size(50, 20);
            this.txtDto.TabIndex = 12;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(690, 32);
            this.txtGanancia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(50, 20);
            this.txtGanancia.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListado);
            this.groupBox2.Location = new System.Drawing.Point(9, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(902, 544);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grilla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Location = new System.Drawing.Point(781, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(130, 140);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::Juntas_MC.Properties.Resources.printer;
            this.btnImprimir.Location = new System.Drawing.Point(19, 80);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 47);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Juntas_MC.Properties.Resources.iconfinder_Search_58605;
            this.btnAceptar.Location = new System.Drawing.Point(19, 17);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 47);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Filtrar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // piezasBLLBindingSource
            // 
            this.piezasBLLBindingSource.DataSource = typeof(Juntas_MC.BLL.PiezasBLL);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 4;
            this.Codigo.Name = "Codigo";
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "Detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "Detalles";
            this.detallesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.Width = 270;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 80;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Picture";
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 150;
            // 
            // PrecioDeVenta
            // 
            this.PrecioDeVenta.DataPropertyName = "PrecioDeVenta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioDeVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioDeVenta.HeaderText = "PrecioVenta";
            this.PrecioDeVenta.MinimumWidth = 6;
            this.PrecioDeVenta.Name = "PrecioDeVenta";
            this.PrecioDeVenta.Width = 80;
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 709);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Destinatario.ResumeLayout(false);
            this.Destinatario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piezasBLLBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDeVenta;
    }
}