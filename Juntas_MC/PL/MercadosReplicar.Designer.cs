namespace Juntas_MC.PL
{
    partial class MercadosReplicar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAReplicar = new System.Windows.Forms.Label();
            this.txtExplicacion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbReferencia = new System.Windows.Forms.ComboBox();
            this.radPdL = new System.Windows.Forms.RadioButton();
            this.radMercado = new System.Windows.Forms.RadioButton();
            this.cmbReplicar = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAReplicar);
            this.groupBox1.Controls.Add(this.txtExplicacion);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbReferencia);
            this.groupBox1.Controls.Add(this.radPdL);
            this.groupBox1.Controls.Add(this.radMercado);
            this.groupBox1.Controls.Add(this.cmbReplicar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reglas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Referencia:";
            // 
            // lblAReplicar
            // 
            this.lblAReplicar.AutoSize = true;
            this.lblAReplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAReplicar.Location = new System.Drawing.Point(162, 34);
            this.lblAReplicar.Name = "lblAReplicar";
            this.lblAReplicar.Size = new System.Drawing.Size(130, 17);
            this.lblAReplicar.TabIndex = 6;
            this.lblAReplicar.Text = "Mercado a replicar:";
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.Location = new System.Drawing.Point(48, 112);
            this.txtExplicacion.Multiline = true;
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.ReadOnly = true;
            this.txtExplicacion.Size = new System.Drawing.Size(399, 41);
            this.txtExplicacion.TabIndex = 0;
            this.txtExplicacion.TabStop = false;
            this.txtExplicacion.Text = "Los precios de [] seran identicos al de la referencia seleccionada debajo.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juntas_MC.Properties.Resources.attention;
            this.pictureBox1.Location = new System.Drawing.Point(6, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmbReferencia
            // 
            this.cmbReferencia.Enabled = false;
            this.cmbReferencia.FormattingEnabled = true;
            this.cmbReferencia.Location = new System.Drawing.Point(79, 232);
            this.cmbReferencia.Name = "cmbReferencia";
            this.cmbReferencia.Size = new System.Drawing.Size(297, 24);
            this.cmbReferencia.TabIndex = 4;
            // 
            // radPdL
            // 
            this.radPdL.AutoSize = true;
            this.radPdL.Location = new System.Drawing.Point(242, 195);
            this.radPdL.Name = "radPdL";
            this.radPdL.Size = new System.Drawing.Size(118, 21);
            this.radPdL.TabIndex = 3;
            this.radPdL.TabStop = true;
            this.radPdL.Text = "Precio de lista";
            this.radPdL.UseVisualStyleBackColor = true;
            this.radPdL.CheckedChanged += new System.EventHandler(this.radPdL_CheckedChanged);
            // 
            // radMercado
            // 
            this.radMercado.AutoSize = true;
            this.radMercado.Location = new System.Drawing.Point(122, 195);
            this.radMercado.Name = "radMercado";
            this.radMercado.Size = new System.Drawing.Size(84, 21);
            this.radMercado.TabIndex = 2;
            this.radMercado.TabStop = true;
            this.radMercado.Text = "Mercado";
            this.radMercado.UseVisualStyleBackColor = true;
            this.radMercado.CheckedChanged += new System.EventHandler(this.radMercado_CheckedChanged);
            // 
            // cmbReplicar
            // 
            this.cmbReplicar.FormattingEnabled = true;
            this.cmbReplicar.Location = new System.Drawing.Point(79, 54);
            this.cmbReplicar.Name = "cmbReplicar";
            this.cmbReplicar.Size = new System.Drawing.Size(297, 24);
            this.cmbReplicar.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Juntas_MC.Properties.Resources.failed;
            this.btnCancelar.Location = new System.Drawing.Point(102, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 58);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Juntas_MC.Properties.Resources.check2;
            this.btnAceptar.Location = new System.Drawing.Point(254, 307);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 58);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MercadosReplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 383);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "MercadosReplicar";
            this.Text = "MercadosClonar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExplicacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbReferencia;
        private System.Windows.Forms.RadioButton radPdL;
        private System.Windows.Forms.RadioButton radMercado;
        private System.Windows.Forms.ComboBox cmbReplicar;
        private System.Windows.Forms.Label lblAReplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}