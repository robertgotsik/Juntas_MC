namespace Juntas_MC.PL
{
    partial class BusquedaPieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaPieza));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTdP = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblModComp = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecioDesde = new System.Windows.Forms.TextBox();
            this.txtPrecioHasta = new System.Windows.Forms.TextBox();
            this.cmbTdP = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbModComp = new System.Windows.Forms.ComboBox();
            this.txtGuion = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 63);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblTdP
            // 
            this.lblTdP.AutoSize = true;
            this.lblTdP.Location = new System.Drawing.Point(20, 113);
            this.lblTdP.Name = "lblTdP";
            this.lblTdP.Size = new System.Drawing.Size(99, 17);
            this.lblTdP.TabIndex = 2;
            this.lblTdP.Text = "Tipo de Pieza:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(20, 163);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(62, 17);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "Material:";
            // 
            // lblModComp
            // 
            this.lblModComp.AutoSize = true;
            this.lblModComp.Location = new System.Drawing.Point(20, 213);
            this.lblModComp.Name = "lblModComp";
            this.lblModComp.Size = new System.Drawing.Size(130, 17);
            this.lblModComp.TabIndex = 4;
            this.lblModComp.Text = "Modelo compatible:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 28;
            // 
            // txtPrecioDesde
            // 
            this.txtPrecioDesde.Location = new System.Drawing.Point(20, 83);
            this.txtPrecioDesde.Name = "txtPrecioDesde";
            this.txtPrecioDesde.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioDesde.TabIndex = 29;
            this.txtPrecioDesde.Leave += new System.EventHandler(this.autoCompletarPrecioHasta);
            // 
            // txtPrecioHasta
            // 
            this.txtPrecioHasta.Location = new System.Drawing.Point(141, 83);
            this.txtPrecioHasta.Name = "txtPrecioHasta";
            this.txtPrecioHasta.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioHasta.TabIndex = 30;
            // 
            // cmbTdP
            // 
            this.cmbTdP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTdP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTdP.FormattingEnabled = true;
            this.cmbTdP.Location = new System.Drawing.Point(20, 133);
            this.cmbTdP.Name = "cmbTdP";
            this.cmbTdP.Size = new System.Drawing.Size(233, 24);
            this.cmbTdP.TabIndex = 31;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(20, 183);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(233, 24);
            this.cmbMaterial.TabIndex = 32;
            // 
            // cmbModComp
            // 
            this.cmbModComp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModComp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModComp.FormattingEnabled = true;
            this.cmbModComp.Location = new System.Drawing.Point(20, 233);
            this.cmbModComp.Name = "cmbModComp";
            this.cmbModComp.Size = new System.Drawing.Size(233, 24);
            this.cmbModComp.TabIndex = 33;
            // 
            // txtGuion
            // 
            this.txtGuion.AutoSize = true;
            this.txtGuion.Location = new System.Drawing.Point(122, 86);
            this.txtGuion.Name = "txtGuion";
            this.txtGuion.Size = new System.Drawing.Size(13, 17);
            this.txtGuion.TabIndex = 34;
            this.txtGuion.Text = "-";
            // 
            // lbEstado
            // 
            this.lbEstado.FormattingEnabled = true;
            this.lbEstado.ItemHeight = 16;
            this.lbEstado.Items.AddRange(new object[] {
            "Suspendido",
            "Activo"});
            this.lbEstado.Location = new System.Drawing.Point(141, 19);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(120, 36);
            this.lbEstado.TabIndex = 35;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Juntas_MC.Properties.Resources.iconfinder_Search_58605;
            this.btnBuscar.Location = new System.Drawing.Point(78, 283);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 58);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BusquedaPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 367);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txtGuion);
            this.Controls.Add(this.cmbModComp);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbTdP);
            this.Controls.Add(this.txtPrecioHasta);
            this.Controls.Add(this.txtPrecioDesde);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblModComp);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblTdP);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaPieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTdP;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblModComp;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecioDesde;
        private System.Windows.Forms.TextBox txtPrecioHasta;
        private System.Windows.Forms.ComboBox cmbTdP;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbModComp;
        private System.Windows.Forms.Label txtGuion;
        private System.Windows.Forms.ListBox lbEstado;
    }
}