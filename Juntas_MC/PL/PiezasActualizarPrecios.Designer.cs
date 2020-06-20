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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiezasActualizarPrecios));
            this.label1 = new System.Windows.Forms.Label();
            this.rdPrecioDeLista = new System.Windows.Forms.RadioButton();
            this.rdMercado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMercado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoPieza = new System.Windows.Forms.CheckBox();
            this.btnBuscarPorCodigo = new System.Windows.Forms.Button();
            this.cmbPiezaTipo = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.CheckBox();
            this.cbTodasPiezas = new System.Windows.Forms.CheckBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbCodigo = new System.Windows.Forms.CheckBox();
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
            this.rdPrecioDeLista.Location = new System.Drawing.Point(129, 62);
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
            this.rdMercado.Enabled = false;
            this.rdMercado.Location = new System.Drawing.Point(237, 62);
            this.rdMercado.Name = "rdMercado";
            this.rdMercado.Size = new System.Drawing.Size(84, 21);
            this.rdMercado.TabIndex = 2;
            this.rdMercado.Text = "Mercado";
            this.rdMercado.UseVisualStyleBackColor = true;
            this.rdMercado.Visible = false;
            this.rdMercado.CheckedChanged += new System.EventHandler(this.rdMercado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMercado);
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
            // cmbMercado
            // 
            this.cmbMercado.Enabled = false;
            this.cmbMercado.FormattingEnabled = true;
            this.cmbMercado.Location = new System.Drawing.Point(200, 89);
            this.cmbMercado.Name = "cmbMercado";
            this.cmbMercado.Size = new System.Drawing.Size(180, 24);
            this.cmbMercado.TabIndex = 3;
            this.cmbMercado.Visible = false;
            this.cmbMercado.SelectionChangeCommitted += new System.EventHandler(this.seleccionMercado);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbTipoPieza);
            this.groupBox2.Controls.Add(this.btnBuscarPorCodigo);
            this.groupBox2.Controls.Add(this.cmbPiezaTipo);
            this.groupBox2.Controls.Add(this.cbMaterial);
            this.groupBox2.Controls.Add(this.cbTodasPiezas);
            this.groupBox2.Controls.Add(this.cmbMaterial);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.cbCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 258);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paso 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(43, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "---------------------------- o ----------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(43, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "---------------------------- o ----------------------------";
            // 
            // cbTipoPieza
            // 
            this.cbTipoPieza.AutoSize = true;
            this.cbTipoPieza.Enabled = false;
            this.cbTipoPieza.Location = new System.Drawing.Point(6, 184);
            this.cbTipoPieza.Name = "cbTipoPieza";
            this.cbTipoPieza.Size = new System.Drawing.Size(117, 21);
            this.cbTipoPieza.TabIndex = 6;
            this.cbTipoPieza.Text = "Tipo de Pieza";
            this.cbTipoPieza.UseVisualStyleBackColor = true;
            this.cbTipoPieza.CheckedChanged += new System.EventHandler(this.cbTipoPieza_CheckedChanged);
            // 
            // btnBuscarPorCodigo
            // 
            this.btnBuscarPorCodigo.Enabled = false;
            this.btnBuscarPorCodigo.Location = new System.Drawing.Point(327, 112);
            this.btnBuscarPorCodigo.Name = "btnBuscarPorCodigo";
            this.btnBuscarPorCodigo.Size = new System.Drawing.Size(41, 29);
            this.btnBuscarPorCodigo.TabIndex = 9;
            this.btnBuscarPorCodigo.Text = ">";
            this.btnBuscarPorCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarPorCodigo.Click += new System.EventHandler(this.btnBuscarPorCodigo_Click);
            // 
            // cmbPiezaTipo
            // 
            this.cmbPiezaTipo.Enabled = false;
            this.cmbPiezaTipo.FormattingEnabled = true;
            this.cmbPiezaTipo.Location = new System.Drawing.Point(129, 181);
            this.cmbPiezaTipo.Name = "cmbPiezaTipo";
            this.cmbPiezaTipo.Size = new System.Drawing.Size(239, 24);
            this.cmbPiezaTipo.TabIndex = 2;
            this.cmbPiezaTipo.SelectionChangeCommitted += new System.EventHandler(this.SeleccionTipoDePieza);
            // 
            // cbMaterial
            // 
            this.cbMaterial.AutoSize = true;
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Location = new System.Drawing.Point(6, 223);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(80, 21);
            this.cbMaterial.TabIndex = 7;
            this.cbMaterial.Text = "Material";
            this.cbMaterial.UseVisualStyleBackColor = true;
            this.cbMaterial.CheckedChanged += new System.EventHandler(this.cbMaterial_CheckedChanged);
            // 
            // cbTodasPiezas
            // 
            this.cbTodasPiezas.AutoSize = true;
            this.cbTodasPiezas.Enabled = false;
            this.cbTodasPiezas.Location = new System.Drawing.Point(6, 62);
            this.cbTodasPiezas.Name = "cbTodasPiezas";
            this.cbTodasPiezas.Size = new System.Drawing.Size(137, 21);
            this.cbTodasPiezas.TabIndex = 1;
            this.cbTodasPiezas.Text = "Todas las piezas";
            this.cbTodasPiezas.UseVisualStyleBackColor = true;
            this.cbTodasPiezas.CheckedChanged += new System.EventHandler(this.TodasPiezasCheckeado);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Enabled = false;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(129, 223);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(239, 24);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectionChangeCommitted += new System.EventHandler(this.SeleccionMaterial);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(129, 116);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // cbCodigo
            // 
            this.cbCodigo.AutoSize = true;
            this.cbCodigo.Enabled = false;
            this.cbCodigo.Location = new System.Drawing.Point(6, 117);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(74, 21);
            this.cbCodigo.TabIndex = 5;
            this.cbCodigo.Text = "Codigo";
            this.cbCodigo.UseVisualStyleBackColor = true;
            this.cbCodigo.CheckedChanged += new System.EventHandler(this.cbCodigo_CheckedChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
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
            this.dgvPiezas.Size = new System.Drawing.Size(373, 518);
            this.dgvPiezas.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Juntas_MC.Properties.Resources.check2;
            this.btnAceptar.Location = new System.Drawing.Point(425, 536);
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
            this.btnCancelar.Location = new System.Drawing.Point(275, 536);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPiezas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PiezasActualizarPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnBuscarPorCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMercado;
    }
}