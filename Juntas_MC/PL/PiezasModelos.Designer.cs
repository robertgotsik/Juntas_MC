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
            this.lblIdPieza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(12, 9);
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
            this.cmbPiezasModelos.Location = new System.Drawing.Point(15, 30);
            this.cmbPiezasModelos.Name = "cmbPiezasModelos";
            this.cmbPiezasModelos.Size = new System.Drawing.Size(395, 26);
            this.cmbPiezasModelos.TabIndex = 1;
            this.cmbPiezasModelos.SelectedIndexChanged += new System.EventHandler(this.cmbPiezasModelos_SelectedIndexChanged);
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
            // 
            // lblIdPieza
            // 
            this.lblIdPieza.AutoSize = true;
            this.lblIdPieza.Enabled = false;
            this.lblIdPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPieza.Location = new System.Drawing.Point(-1, 101);
            this.lblIdPieza.Name = "lblIdPieza";
            this.lblIdPieza.Size = new System.Drawing.Size(35, 13);
            this.lblIdPieza.TabIndex = 6;
            this.lblIdPieza.Text = "label1";
            // 
            // PiezasModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 113);
            this.Controls.Add(this.lblIdPieza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPiezasModelos);
            this.Controls.Add(this.lblModelo);
            this.Name = "PiezasModelos";
            this.Text = "PiezasModelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbPiezasModelos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdPieza;
    }
}