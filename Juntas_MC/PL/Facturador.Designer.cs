﻿namespace Juntas_MC.PL
{
    partial class Facturador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dvgFactura = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPieza = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPiezaId = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.CheckBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ultimaFacturaInsertada = new System.Windows.Forms.Label();
            this.btnAgregarModelo = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Factura:";
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(576, 12);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(231, 36);
            this.txtFactura.TabIndex = 1;
            this.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(88, 18);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 24);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.Seleccionado1);
            // 
            // dvgFactura
            // 
            this.dvgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFactura.Location = new System.Drawing.Point(6, 112);
            this.dvgFactura.Name = "dvgFactura";
            this.dvgFactura.RowHeadersWidth = 51;
            this.dvgFactura.RowTemplate.Height = 24;
            this.dvgFactura.Size = new System.Drawing.Size(918, 274);
            this.dvgFactura.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 222);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 39);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(43, 261);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(87, 39);
            this.lblImporteTotal.TabIndex = 7;
            this.lblImporteTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pieza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Porcentaje Dto:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.Location = new System.Drawing.Point(546, 14);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(59, 23);
            this.txtPorcentaje.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // cmbPieza
            // 
            this.cmbPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPieza.FormattingEnabled = true;
            this.cmbPieza.Location = new System.Drawing.Point(88, 60);
            this.cmbPieza.Name = "cmbPieza";
            this.cmbPieza.Size = new System.Drawing.Size(152, 24);
            this.cmbPieza.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(615, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad:";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad.Location = new System.Drawing.Point(689, 60);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(74, 23);
            this.nupCantidad.TabIndex = 18;
            this.nupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPiezaId);
            this.groupBox2.Controls.Add(this.cbProveedor);
            this.groupBox2.Controls.Add(this.cmbProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbPieza);
            this.groupBox2.Controls.Add(this.nupCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAgregarModelo);
            this.groupBox2.Controls.Add(this.dvgFactura);
            this.groupBox2.Location = new System.Drawing.Point(207, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 392);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // lblPiezaId
            // 
            this.lblPiezaId.AutoSize = true;
            this.lblPiezaId.Location = new System.Drawing.Point(160, 38);
            this.lblPiezaId.Name = "lblPiezaId";
            this.lblPiezaId.Size = new System.Drawing.Size(54, 17);
            this.lblPiezaId.TabIndex = 21;
            this.lblPiezaId.Text = "PiezaId";
            this.lblPiezaId.Visible = false;
            // 
            // cbProveedor
            // 
            this.cbProveedor.AutoSize = true;
            this.cbProveedor.Location = new System.Drawing.Point(312, 60);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(96, 21);
            this.cbProveedor.TabIndex = 20;
            this.cbProveedor.Text = "Proveedor";
            this.cbProveedor.UseVisualStyleBackColor = true;
            this.cbProveedor.CheckedChanged += new System.EventHandler(this.habilitaProveedor);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Enabled = false;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(414, 60);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(151, 24);
            this.cmbProveedor.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPorcentaje);
            this.groupBox1.Location = new System.Drawing.Point(207, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 50);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "$";
            // 
            // ultimaFacturaInsertada
            // 
            this.ultimaFacturaInsertada.AutoSize = true;
            this.ultimaFacturaInsertada.Location = new System.Drawing.Point(854, 23);
            this.ultimaFacturaInsertada.Name = "ultimaFacturaInsertada";
            this.ultimaFacturaInsertada.Size = new System.Drawing.Size(152, 17);
            this.ultimaFacturaInsertada.TabIndex = 22;
            this.ultimaFacturaInsertada.Text = "ultimaFacturaInsertada";
            this.ultimaFacturaInsertada.Visible = false;
            // 
            // btnAgregarModelo
            // 
            this.btnAgregarModelo.Image = global::Juntas_MC.Properties.Resources.iconfinder_Button_Add_58476;
            this.btnAgregarModelo.Location = new System.Drawing.Point(814, 45);
            this.btnAgregarModelo.Name = "btnAgregarModelo";
            this.btnAgregarModelo.Size = new System.Drawing.Size(50, 50);
            this.btnAgregarModelo.TabIndex = 17;
            this.btnAgregarModelo.UseVisualStyleBackColor = true;
            this.btnAgregarModelo.Click += new System.EventHandler(this.btnAgregarPieza_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::Juntas_MC.Properties.Resources.actualizarPrecios;
            this.btnFacturar.Location = new System.Drawing.Point(11, 417);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(181, 79);
            this.btnFacturar.TabIndex = 16;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juntas_MC.Properties.Resources.cashbox1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Facturador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ultimaFacturaInsertada);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturador";
            ((System.ComponentModel.ISupportInitialize)(this.dvgFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dvgFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPieza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnAgregarModelo;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblPiezaId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ultimaFacturaInsertada;
        private System.Windows.Forms.Button button1;
    }
}