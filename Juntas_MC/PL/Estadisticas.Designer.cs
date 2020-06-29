namespace Juntas_MC.PL
{
    partial class Estadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.gbPiezas = new System.Windows.Forms.GroupBox();
            this.chartPiezas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbCantVentas = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblCantPiezas = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.gbVentas.SuspendLayout();
            this.gbPiezas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPiezas)).BeginInit();
            this.gbCantVentas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.lblDesde);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chartVentas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentas.Legends.Add(legend1);
            this.chartVentas.Location = new System.Drawing.Point(6, 21);
            this.chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVentas.Series.Add(series1);
            this.chartVentas.Size = new System.Drawing.Size(488, 328);
            this.chartVentas.TabIndex = 1;
            this.chartVentas.Text = "chart1";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(315, 21);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(109, 22);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(506, 21);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(109, 22);
            this.dtpHasta.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(256, 26);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(53, 17);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(451, 26);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(49, 17);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.chartVentas);
            this.gbVentas.Location = new System.Drawing.Point(10, 237);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(500, 355);
            this.gbVentas.TabIndex = 2;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // gbPiezas
            // 
            this.gbPiezas.Controls.Add(this.chartPiezas);
            this.gbPiezas.Location = new System.Drawing.Point(516, 237);
            this.gbPiezas.Name = "gbPiezas";
            this.gbPiezas.Size = new System.Drawing.Size(500, 355);
            this.gbPiezas.TabIndex = 3;
            this.gbPiezas.TabStop = false;
            this.gbPiezas.Text = "Piezas";
            // 
            // chartPiezas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPiezas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPiezas.Legends.Add(legend2);
            this.chartPiezas.Location = new System.Drawing.Point(6, 21);
            this.chartPiezas.Name = "chartPiezas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPiezas.Series.Add(series2);
            this.chartPiezas.Size = new System.Drawing.Size(488, 328);
            this.chartPiezas.TabIndex = 1;
            this.chartPiezas.Text = "chart2";
            // 
            // gbCantVentas
            // 
            this.gbCantVentas.Controls.Add(this.lblVentas);
            this.gbCantVentas.Controls.Add(this.pictureBox1);
            this.gbCantVentas.Location = new System.Drawing.Point(40, 83);
            this.gbCantVentas.Name = "gbCantVentas";
            this.gbCantVentas.Size = new System.Drawing.Size(200, 148);
            this.gbCantVentas.TabIndex = 4;
            this.gbCantVentas.TabStop = false;
            this.gbCantVentas.Text = "Total $ Ventas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCantPiezas);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(288, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 148);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cant Piezas Vendidas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblClientes);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Location = new System.Drawing.Point(540, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 148);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clientes Alcanzados";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblModelo);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Location = new System.Drawing.Point(788, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 148);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modelo mas vendido";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Juntas_MC.Properties.Resources.iconfinder_small_car_64675;
            this.pictureBox4.Location = new System.Drawing.Point(144, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 43);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Juntas_MC.Properties.Resources.iconfinder_Users_58625;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(144, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 43);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Juntas_MC.Properties.Resources.iconfinder_Box_58473;
            this.pictureBox2.Location = new System.Drawing.Point(144, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 43);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juntas_MC.Properties.Resources.iconfinder_Money_58588;
            this.pictureBox1.Location = new System.Drawing.Point(144, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Juntas_MC.Properties.Resources.find2;
            this.btnBuscar.Location = new System.Drawing.Point(686, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 38);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(26, 87);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(27, 29);
            this.lblVentas.TabIndex = 8;
            this.lblVentas.Text = "#";
            // 
            // lblCantPiezas
            // 
            this.lblCantPiezas.AutoSize = true;
            this.lblCantPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPiezas.Location = new System.Drawing.Point(33, 87);
            this.lblCantPiezas.Name = "lblCantPiezas";
            this.lblCantPiezas.Size = new System.Drawing.Size(27, 29);
            this.lblCantPiezas.TabIndex = 9;
            this.lblCantPiezas.Text = "#";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(32, 87);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(27, 29);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "#";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(32, 87);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(27, 29);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "#";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 604);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCantVentas);
            this.Controls.Add(this.gbPiezas);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.gbVentas.ResumeLayout(false);
            this.gbPiezas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPiezas)).EndInit();
            this.gbCantVentas.ResumeLayout(false);
            this.gbCantVentas.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.GroupBox gbPiezas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPiezas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbCantVentas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblCantPiezas;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblModelo;
    }
}