namespace Juntas_MC.PL
{
    partial class PiezasActualizarPrecios
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdPrecioDeLista = new System.Windows.Forms.RadioButton();
            this.rdMercado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaterial = new System.Windows.Forms.CheckBox();
            this.cbTipoPieza = new System.Windows.Forms.CheckBox();
            this.cbCodigo = new System.Windows.Forms.CheckBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbPiezaTipo = new System.Windows.Forms.ComboBox();
            this.cbTodasPiezas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValorOperando = new System.Windows.Forms.TextBox();
            this.cmbOperando = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPiezas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio:";
            // 
            // rdPrecioDeLista
            // 
            this.rdPrecioDeLista.AutoSize = true;
            this.rdPrecioDeLista.Location = new System.Drawing.Point(46, 76);
            this.rdPrecioDeLista.Name = "rdPrecioDeLista";
            this.rdPrecioDeLista.Size = new System.Drawing.Size(118, 21);
            this.rdPrecioDeLista.TabIndex = 1;
            this.rdPrecioDeLista.Text = "Precio de lista";
            this.rdPrecioDeLista.UseVisualStyleBackColor = true;
            this.rdPrecioDeLista.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdMercado
            // 
            this.rdMercado.AutoSize = true;
            this.rdMercado.Location = new System.Drawing.Point(202, 76);
            this.rdMercado.Name = "rdMercado";
            this.rdMercado.Size = new System.Drawing.Size(154, 21);
            this.rdMercado.TabIndex = 2;
            this.rdMercado.Text = "Esquema Comercial";
            this.rdMercado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdMercado);
            this.groupBox1.Controls.Add(this.rdPrecioDeLista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaterial);
            this.groupBox2.Controls.Add(this.cbTipoPieza);
            this.groupBox2.Controls.Add(this.cbCodigo);
            this.groupBox2.Controls.Add(this.cmbCodigo);
            this.groupBox2.Controls.Add(this.cmbMaterial);
            this.groupBox2.Controls.Add(this.cmbPiezaTipo);
            this.groupBox2.Controls.Add(this.cbTodasPiezas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paso 2";
            // 
            // cbMaterial
            // 
            this.cbMaterial.AutoSize = true;
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Location = new System.Drawing.Point(6, 177);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(80, 21);
            this.cbMaterial.TabIndex = 7;
            this.cbMaterial.Text = "Material";
            this.cbMaterial.UseVisualStyleBackColor = true;
            this.cbMaterial.CheckedChanged += new System.EventHandler(this.cbMaterial_CheckedChanged);
            // 
            // cbTipoPieza
            // 
            this.cbTipoPieza.AutoSize = true;
            this.cbTipoPieza.Enabled = false;
            this.cbTipoPieza.Location = new System.Drawing.Point(6, 137);
            this.cbTipoPieza.Name = "cbTipoPieza";
            this.cbTipoPieza.Size = new System.Drawing.Size(117, 21);
            this.cbTipoPieza.TabIndex = 6;
            this.cbTipoPieza.Text = "Tipo de Pieza";
            this.cbTipoPieza.UseVisualStyleBackColor = true;
            this.cbTipoPieza.CheckedChanged += new System.EventHandler(this.cbTipoPieza_CheckedChanged);
            // 
            // cbCodigo
            // 
            this.cbCodigo.AutoSize = true;
            this.cbCodigo.Enabled = false;
            this.cbCodigo.Location = new System.Drawing.Point(6, 93);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(74, 21);
            this.cbCodigo.TabIndex = 5;
            this.cbCodigo.Text = "Codigo";
            this.cbCodigo.UseVisualStyleBackColor = true;
            this.cbCodigo.CheckedChanged += new System.EventHandler(this.cbCodigo_CheckedChanged);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.Enabled = false;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(140, 93);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(232, 24);
            this.cmbCodigo.TabIndex = 4;
            this.cmbCodigo.SelectionChangeCommitted += new System.EventHandler(this.SeleccionCodigo);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Enabled = false;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(140, 177);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(232, 24);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectionChangeCommitted += new System.EventHandler(this.SeleccionMaterial);
            // 
            // cmbPiezaTipo
            // 
            this.cmbPiezaTipo.Enabled = false;
            this.cmbPiezaTipo.FormattingEnabled = true;
            this.cmbPiezaTipo.Location = new System.Drawing.Point(140, 137);
            this.cmbPiezaTipo.Name = "cmbPiezaTipo";
            this.cmbPiezaTipo.Size = new System.Drawing.Size(232, 24);
            this.cmbPiezaTipo.TabIndex = 2;
            this.cmbPiezaTipo.SelectionChangeCommitted += new System.EventHandler(this.SeleccionTipoDePieza);
            // 
            // cbTodasPiezas
            // 
            this.cbTodasPiezas.AutoSize = true;
            this.cbTodasPiezas.Enabled = false;
            this.cbTodasPiezas.Location = new System.Drawing.Point(111, 58);
            this.cbTodasPiezas.Name = "cbTodasPiezas";
            this.cbTodasPiezas.Size = new System.Drawing.Size(137, 21);
            this.cbTodasPiezas.TabIndex = 1;
            this.cbTodasPiezas.Text = "Todas las piezas";
            this.cbTodasPiezas.UseVisualStyleBackColor = true;
            this.cbTodasPiezas.CheckedChanged += new System.EventHandler(this.TodasPiezasCheckeado);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtros:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValorOperando);
            this.groupBox3.Controls.Add(this.cmbOperando);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 116);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paso 3";
            // 
            // txtValorOperando
            // 
            this.txtValorOperando.Enabled = false;
            this.txtValorOperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOperando.Location = new System.Drawing.Point(202, 71);
            this.txtValorOperando.Name = "txtValorOperando";
            this.txtValorOperando.Size = new System.Drawing.Size(100, 23);
            this.txtValorOperando.TabIndex = 2;
            // 
            // cmbOperando
            // 
            this.cmbOperando.Enabled = false;
            this.cmbOperando.FormattingEnabled = true;
            this.cmbOperando.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.cmbOperando.Location = new System.Drawing.Point(46, 70);
            this.cmbOperando.Name = "cmbOperando";
            this.cmbOperando.Size = new System.Drawing.Size(121, 24);
            this.cmbOperando.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Operando:";
            // 
            // dgvPiezas
            // 
            this.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiezas.Location = new System.Drawing.Point(415, 12);
            this.dgvPiezas.Name = "dgvPiezas";
            this.dgvPiezas.RowHeadersWidth = 51;
            this.dgvPiezas.RowTemplate.Height = 24;
            this.dgvPiezas.Size = new System.Drawing.Size(373, 474);
            this.dgvPiezas.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Juntas_MC.Properties.Resources.check2;
            this.btnAceptar.Location = new System.Drawing.Point(427, 517);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 58);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Juntas_MC.Properties.Resources.failed;
            this.btnCancelar.Location = new System.Drawing.Point(275, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 58);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PiezasActualizarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPiezas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PiezasActualizarPrecios";
            this.Text = "PiezasActualizarPrecios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdPrecioDeLista;
        private System.Windows.Forms.RadioButton rdMercado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbPiezaTipo;
        private System.Windows.Forms.CheckBox cbTodasPiezas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtValorOperando;
        private System.Windows.Forms.ComboBox cmbOperando;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPiezas;
        private System.Windows.Forms.CheckBox cbMaterial;
        private System.Windows.Forms.CheckBox cbTipoPieza;
        private System.Windows.Forms.CheckBox cbCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}