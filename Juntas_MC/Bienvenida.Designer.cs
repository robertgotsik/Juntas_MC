namespace Juntas_MC
{
    partial class Bienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGenFact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemActPrec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomotor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTipPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMateriales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProovedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnFacturar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFacturacion,
            this.menuAutomotor,
            this.menuPiezas,
            this.menuAdministracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFacturacion
            // 
            this.menuFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGenFact,
            this.menuItemActPrec});
            this.menuFacturacion.Name = "menuFacturacion";
            this.menuFacturacion.Size = new System.Drawing.Size(98, 24);
            this.menuFacturacion.Text = "Facturacion";
            // 
            // menuItemGenFact
            // 
            this.menuItemGenFact.Name = "menuItemGenFact";
            this.menuItemGenFact.Size = new System.Drawing.Size(209, 26);
            this.menuItemGenFact.Text = "Generar Factura";
            // 
            // menuItemActPrec
            // 
            this.menuItemActPrec.Name = "menuItemActPrec";
            this.menuItemActPrec.Size = new System.Drawing.Size(209, 26);
            this.menuItemActPrec.Text = "Actualizar Precios";
            // 
            // menuAutomotor
            // 
            this.menuAutomotor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMarcas,
            this.menuItemModelos});
            this.menuAutomotor.Name = "menuAutomotor";
            this.menuAutomotor.Size = new System.Drawing.Size(96, 24);
            this.menuAutomotor.Text = "Automotor";
            this.menuAutomotor.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // menuItemMarcas
            // 
            this.menuItemMarcas.Name = "menuItemMarcas";
            this.menuItemMarcas.Size = new System.Drawing.Size(159, 26);
            this.menuItemMarcas.Text = "Marcas...";
            this.menuItemMarcas.Click += new System.EventHandler(this.menuItemMarcas_Click);
            // 
            // menuItemModelos
            // 
            this.menuItemModelos.Name = "menuItemModelos";
            this.menuItemModelos.Size = new System.Drawing.Size(159, 26);
            this.menuItemModelos.Text = "Modelos...";
            this.menuItemModelos.Click += new System.EventHandler(this.menuItemModelos_Click);
            // 
            // menuPiezas
            // 
            this.menuPiezas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTipPiezas,
            this.menuItemPiezas,
            this.menuItemMateriales});
            this.menuPiezas.Name = "menuPiezas";
            this.menuPiezas.Size = new System.Drawing.Size(64, 24);
            this.menuPiezas.Text = "Piezas";
            // 
            // menuItemTipPiezas
            // 
            this.menuItemTipPiezas.Name = "menuItemTipPiezas";
            this.menuItemTipPiezas.Size = new System.Drawing.Size(224, 26);
            this.menuItemTipPiezas.Text = "Tipos de piezas...";
            this.menuItemTipPiezas.Click += new System.EventHandler(this.menuItemTipPiezas_Click);
            // 
            // menuItemPiezas
            // 
            this.menuItemPiezas.Name = "menuItemPiezas";
            this.menuItemPiezas.Size = new System.Drawing.Size(224, 26);
            this.menuItemPiezas.Text = "Piezas...";
            this.menuItemPiezas.Click += new System.EventHandler(this.menuItemPiezas_Click);
            // 
            // menuItemMateriales
            // 
            this.menuItemMateriales.Name = "menuItemMateriales";
            this.menuItemMateriales.Size = new System.Drawing.Size(224, 26);
            this.menuItemMateriales.Text = "Materiales...";
            this.menuItemMateriales.Click += new System.EventHandler(this.menuItemMateriales_Click);
            // 
            // menuAdministracion
            // 
            this.menuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemProovedores,
            this.menuItemClientes});
            this.menuAdministracion.Name = "menuAdministracion";
            this.menuAdministracion.Size = new System.Drawing.Size(123, 24);
            this.menuAdministracion.Text = "Administracion";
            // 
            // menuItemProovedores
            // 
            this.menuItemProovedores.Name = "menuItemProovedores";
            this.menuItemProovedores.Size = new System.Drawing.Size(184, 26);
            this.menuItemProovedores.Text = "Proovedores...";
            // 
            // menuItemClientes
            // 
            this.menuItemClientes.Name = "menuItemClientes";
            this.menuItemClientes.Size = new System.Drawing.Size(184, 26);
            this.menuItemClientes.Text = "Clientes...";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(180, 135);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(233, 31);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Calculando Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(388, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(527, 76);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Calculando Hora";
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::Juntas_MC.Properties.Resources.bill_128px;
            this.btnFacturar.Location = new System.Drawing.Point(292, 216);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(227, 227);
            this.btnFacturar.TabIndex = 13;
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bienvenida";
            this.Text = "JuntasMC";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem menuAutomotor;
        private System.Windows.Forms.ToolStripMenuItem menuPiezas;
        private System.Windows.Forms.ToolStripMenuItem menuItemGenFact;
        private System.Windows.Forms.ToolStripMenuItem menuItemActPrec;
        private System.Windows.Forms.ToolStripMenuItem menuItemMarcas;
        private System.Windows.Forms.ToolStripMenuItem menuItemModelos;
        private System.Windows.Forms.ToolStripMenuItem menuItemTipPiezas;
        private System.Windows.Forms.ToolStripMenuItem menuItemPiezas;
        private System.Windows.Forms.ToolStripMenuItem menuItemMateriales;
        private System.Windows.Forms.ToolStripMenuItem menuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem menuItemProovedores;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnFacturar;
    }
}

