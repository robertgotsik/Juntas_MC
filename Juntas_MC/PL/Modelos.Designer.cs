namespace Juntas_MC.PL
{
    partial class Modelos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.dropMarca = new System.Windows.Forms.ComboBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(99, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(12, 151);
            this.dgvModelos.MultiSelect = false;
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.ReadOnly = true;
            this.dgvModelos.RowHeadersWidth = 51;
            this.dgvModelos.RowTemplate.Height = 24;
            this.dgvModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelos.Size = new System.Drawing.Size(396, 377);
            this.dgvModelos.TabIndex = 2;
            this.dgvModelos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Juntas_MC.Properties.Resources.trash24px;
            this.btnBorrar.Location = new System.Drawing.Point(297, 105);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 43);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 25);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // dropMarca
            // 
            this.dropMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropMarca.FormattingEnabled = true;
            this.dropMarca.Location = new System.Drawing.Point(99, 47);
            this.dropMarca.Name = "dropMarca";
            this.dropMarca.Size = new System.Drawing.Size(237, 30);
            this.dropMarca.TabIndex = 8;
            this.dropMarca.SelectedIndexChanged += new System.EventHandler(this.dropMarca_SelectedIndexChanged);
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.Location = new System.Drawing.Point(361, 531);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(47, 13);
            this.lblIdMarca.TabIndex = 9;
            this.lblIdMarca.Text = "IDMarca";
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdModelo.Location = new System.Drawing.Point(329, 531);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(53, 13);
            this.lblIdModelo.TabIndex = 10;
            this.lblIdModelo.Text = "IDModelo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Juntas_MC.Properties.Resources.cross2;
            this.btnLimpiar.Location = new System.Drawing.Point(343, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(54, 50);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Juntas_MC.Properties.Resources.iconfinder_Modify_132500;
            this.btnModificar.Location = new System.Drawing.Point(179, 105);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 43);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Juntas_MC.Properties.Resources.iconfinder_floppy_285657;
            this.btnAgregar.Location = new System.Drawing.Point(61, 105);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 43);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 545);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblIdModelo);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.dropMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Modelos";
            this.Text = "frmModelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox dropMarca;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}