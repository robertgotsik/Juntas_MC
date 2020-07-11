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
            this.emitirRemitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemGenFact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomotor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemTipPiezas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMateriales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProovedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizarPreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFacturacion,
            this.menuAutomotor,
            this.menuPiezas,
            this.menuAdministracion,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFacturacion
            // 
            this.menuFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirRemitoToolStripMenuItem,
            this.toolStripSeparator5,
            this.menuItemGenFact});
            this.menuFacturacion.Name = "menuFacturacion";
            this.menuFacturacion.Size = new System.Drawing.Size(98, 24);
            this.menuFacturacion.Text = "Facturacion";
            // 
            // emitirRemitoToolStripMenuItem
            // 
            this.emitirRemitoToolStripMenuItem.Name = "emitirRemitoToolStripMenuItem";
            this.emitirRemitoToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.emitirRemitoToolStripMenuItem.Text = "Emitir Remito";
            this.emitirRemitoToolStripMenuItem.Click += new System.EventHandler(this.emitirRemitoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            // 
            // menuItemGenFact
            // 
            this.menuItemGenFact.Name = "menuItemGenFact";
            this.menuItemGenFact.Size = new System.Drawing.Size(183, 26);
            this.menuItemGenFact.Text = "Historial";
            this.menuItemGenFact.Click += new System.EventHandler(this.menuItemGenFact_Click);
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
            this.menuItemMarcas.Size = new System.Drawing.Size(150, 26);
            this.menuItemMarcas.Text = "Marcas";
            this.menuItemMarcas.Click += new System.EventHandler(this.menuItemMarcas_Click);
            // 
            // menuItemModelos
            // 
            this.menuItemModelos.Name = "menuItemModelos";
            this.menuItemModelos.Size = new System.Drawing.Size(150, 26);
            this.menuItemModelos.Text = "Modelos";
            this.menuItemModelos.Click += new System.EventHandler(this.menuItemModelos_Click);
            // 
            // menuPiezas
            // 
            this.menuPiezas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPiezas,
            this.toolStripSeparator4,
            this.listadosToolStripMenuItem,
            this.toolStripSeparator2,
            this.menuItemTipPiezas,
            this.menuItemMateriales});
            this.menuPiezas.Name = "menuPiezas";
            this.menuPiezas.Size = new System.Drawing.Size(64, 24);
            this.menuPiezas.Text = "Piezas";
            // 
            // menuItemPiezas
            // 
            this.menuItemPiezas.Name = "menuItemPiezas";
            this.menuItemPiezas.Size = new System.Drawing.Size(195, 26);
            this.menuItemPiezas.Text = "Piezas";
            this.menuItemPiezas.Click += new System.EventHandler(this.menuItemPiezas_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.listadosToolStripMenuItem.Text = "Listados";
            this.listadosToolStripMenuItem.Click += new System.EventHandler(this.listadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // menuItemTipPiezas
            // 
            this.menuItemTipPiezas.Name = "menuItemTipPiezas";
            this.menuItemTipPiezas.Size = new System.Drawing.Size(195, 26);
            this.menuItemTipPiezas.Text = "Tipos de piezas";
            this.menuItemTipPiezas.Click += new System.EventHandler(this.menuItemTipPiezas_Click);
            // 
            // menuItemMateriales
            // 
            this.menuItemMateriales.Name = "menuItemMateriales";
            this.menuItemMateriales.Size = new System.Drawing.Size(195, 26);
            this.menuItemMateriales.Text = "Materiales";
            this.menuItemMateriales.Click += new System.EventHandler(this.menuItemMateriales_Click);
            // 
            // menuAdministracion
            // 
            this.menuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemProovedores,
            this.toolStripSeparator3,
            this.actualizarPreciosToolStripMenuItem});
            this.menuAdministracion.Name = "menuAdministracion";
            this.menuAdministracion.Size = new System.Drawing.Size(123, 24);
            this.menuAdministracion.Text = "Administracion";
            // 
            // menuItemProovedores
            // 
            this.menuItemProovedores.Name = "menuItemProovedores";
            this.menuItemProovedores.Size = new System.Drawing.Size(232, 26);
            this.menuItemProovedores.Text = "Clientes/Proveedores";
            this.menuItemProovedores.Click += new System.EventHandler(this.menuItemProovedores_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // actualizarPreciosToolStripMenuItem
            // 
            this.actualizarPreciosToolStripMenuItem.Name = "actualizarPreciosToolStripMenuItem";
            this.actualizarPreciosToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.actualizarPreciosToolStripMenuItem.Text = "Actualizar Precios";
            this.actualizarPreciosToolStripMenuItem.Click += new System.EventHandler(this.actualizarPreciosToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laEmpresaToolStripMenuItem,
            this.toolStripSeparator1,
            this.acercaDeToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // laEmpresaToolStripMenuItem
            // 
            this.laEmpresaToolStripMenuItem.Name = "laEmpresaToolStripMenuItem";
            this.laEmpresaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.laEmpresaToolStripMenuItem.Text = "La empresa";
            this.laEmpresaToolStripMenuItem.Click += new System.EventHandler(this.laEmpresaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(238, 135);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(233, 31);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Calculando Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(319, 48);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(200, 76);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "##:##";
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juntas_MC.Properties.Resources.mc_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(92, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuntasMC";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem menuAutomotor;
        private System.Windows.Forms.ToolStripMenuItem menuPiezas;
        private System.Windows.Forms.ToolStripMenuItem menuItemGenFact;
        private System.Windows.Forms.ToolStripMenuItem menuItemMarcas;
        private System.Windows.Forms.ToolStripMenuItem menuItemModelos;
        private System.Windows.Forms.ToolStripMenuItem menuItemTipPiezas;
        private System.Windows.Forms.ToolStripMenuItem menuItemPiezas;
        private System.Windows.Forms.ToolStripMenuItem menuItemMateriales;
        private System.Windows.Forms.ToolStripMenuItem menuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem menuItemProovedores;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem actualizarPreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirRemitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

