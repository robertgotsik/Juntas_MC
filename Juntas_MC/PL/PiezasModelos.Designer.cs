namespace Juntas_MC.PL
{
    partial class PiezasModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiezasModelos));
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbPiezasModelos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPiezaCodigo = new System.Windows.Forms.Label();
            this.txtPiezaCodigo = new System.Windows.Forms.TextBox();
            this.lblPiezaId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(132, 9);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(63, 20);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // cmbPiezasModelos
            // 
            this.cmbPiezasModelos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPiezasModelos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPiezasModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPiezasModelos.FormattingEnabled = true;
            this.cmbPiezasModelos.IntegralHeight = false;
            this.cmbPiezasModelos.Location = new System.Drawing.Point(136, 30);
            this.cmbPiezasModelos.Name = "cmbPiezasModelos";
            this.cmbPiezasModelos.Size = new System.Drawing.Size(274, 26);
            this.cmbPiezasModelos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(298, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 43);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPiezaCodigo
            // 
            this.lblPiezaCodigo.AutoSize = true;
            this.lblPiezaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezaCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblPiezaCodigo.Name = "lblPiezaCodigo";
            this.lblPiezaCodigo.Size = new System.Drawing.Size(90, 20);
            this.lblPiezaCodigo.TabIndex = 6;
            this.lblPiezaCodigo.Text = "Pieza Cod.";
            // 
            // txtPiezaCodigo
            // 
            this.txtPiezaCodigo.Enabled = false;
            this.txtPiezaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezaCodigo.Location = new System.Drawing.Point(16, 29);
            this.txtPiezaCodigo.Name = "txtPiezaCodigo";
            this.txtPiezaCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtPiezaCodigo.TabIndex = 7;
            // 
            // lblPiezaId
            // 
            this.lblPiezaId.AutoSize = true;
            this.lblPiezaId.Location = new System.Drawing.Point(13, 88);
            this.lblPiezaId.Name = "lblPiezaId";
            this.lblPiezaId.Size = new System.Drawing.Size(54, 17);
            this.lblPiezaId.TabIndex = 8;
            this.lblPiezaId.Text = "IdPieza";
            this.lblPiezaId.Visible = false;
            // 
            // PiezasModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 113);
            this.Controls.Add(this.lblPiezaId);
            this.Controls.Add(this.txtPiezaCodigo);
            this.Controls.Add(this.lblPiezaCodigo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPiezasModelos);
            this.Controls.Add(this.lblModelo);
            this.Name = "PiezasModelos";
            this.Text = "PiezasModelos";
            this.Load += new System.EventHandler(this.PiezasModelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbPiezasModelos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPiezaCodigo;
        private System.Windows.Forms.TextBox txtPiezaCodigo;
        private System.Windows.Forms.Label lblPiezaId;
    }
}