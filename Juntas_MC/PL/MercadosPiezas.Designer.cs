namespace Juntas_MC.PL
{
    partial class MercadosPiezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MercadosPiezas));
            this.txtMercado = new System.Windows.Forms.TextBox();
            this.lblMercadoNombre = new System.Windows.Forms.Label();
            this.cmbPiezas = new System.Windows.Forms.ComboBox();
            this.lblPieza = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMercadoId = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodigoProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMercado
            // 
            this.txtMercado.Enabled = false;
            this.txtMercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMercado.Location = new System.Drawing.Point(103, 15);
            this.txtMercado.Name = "txtMercado";
            this.txtMercado.Size = new System.Drawing.Size(207, 26);
            this.txtMercado.TabIndex = 12;
            // 
            // lblMercadoNombre
            // 
            this.lblMercadoNombre.AutoSize = true;
            this.lblMercadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercadoNombre.Location = new System.Drawing.Point(12, 18);
            this.lblMercadoNombre.Name = "lblMercadoNombre";
            this.lblMercadoNombre.Size = new System.Drawing.Size(74, 20);
            this.lblMercadoNombre.TabIndex = 11;
            this.lblMercadoNombre.Text = "Mercado";
            // 
            // cmbPiezas
            // 
            this.cmbPiezas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPiezas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPiezas.FormattingEnabled = true;
            this.cmbPiezas.IntegralHeight = false;
            this.cmbPiezas.Location = new System.Drawing.Point(103, 59);
            this.cmbPiezas.Name = "cmbPiezas";
            this.cmbPiezas.Size = new System.Drawing.Size(151, 26);
            this.cmbPiezas.TabIndex = 9;
            this.cmbPiezas.SelectionChangeCommitted += new System.EventHandler(this.cmbPiezas_SelectionChangeCommitted);
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieza.Location = new System.Drawing.Point(12, 61);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(51, 20);
            this.lblPieza.TabIndex = 8;
            this.lblPieza.Text = "Pieza";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(205, 198);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 43);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMercadoId
            // 
            this.lblMercadoId.AutoSize = true;
            this.lblMercadoId.Location = new System.Drawing.Point(12, 224);
            this.lblMercadoId.Name = "lblMercadoId";
            this.lblMercadoId.Size = new System.Drawing.Size(16, 17);
            this.lblMercadoId.TabIndex = 13;
            this.lblMercadoId.Text = "0";
            this.lblMercadoId.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 144);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(103, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "$";
            // 
            // cmbCodigoProveedor
            // 
            this.cmbCodigoProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCodigoProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoProveedor.FormattingEnabled = true;
            this.cmbCodigoProveedor.IntegralHeight = false;
            this.cmbCodigoProveedor.Location = new System.Drawing.Point(103, 103);
            this.cmbCodigoProveedor.Name = "cmbCodigoProveedor";
            this.cmbCodigoProveedor.Size = new System.Drawing.Size(151, 26);
            this.cmbCodigoProveedor.TabIndex = 18;
            this.cmbCodigoProveedor.SelectionChangeCommitted += new System.EventHandler(this.cmbCodigoProveedor_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cod. Prov";
            // 
            // MercadosPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 253);
            this.Controls.Add(this.cmbCodigoProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMercadoId);
            this.Controls.Add(this.txtMercado);
            this.Controls.Add(this.lblMercadoNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPiezas);
            this.Controls.Add(this.lblPieza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MercadosPiezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadosPiezas";
            this.Load += new System.EventHandler(this.MercadosPiezas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMercado;
        private System.Windows.Forms.Label lblMercadoNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbPiezas;
        private System.Windows.Forms.Label lblPieza;
        private System.Windows.Forms.Label lblMercadoId;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodigoProveedor;
        private System.Windows.Forms.Label label2;
    }
}