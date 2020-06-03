namespace Juntas_MC.PL
{
    partial class Piezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piezas));
            this.lblPiezaTipo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbPiezaTipo = new System.Windows.Forms.ComboBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPiezas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCP4 = new System.Windows.Forms.ComboBox();
            this.cmbCP3 = new System.Windows.Forms.ComboBox();
            this.cmbCP2 = new System.Windows.Forms.ComboBox();
            this.cmbCP1 = new System.Windows.Forms.ComboBox();
            this.dgvPreciosMercados = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.gbModelosCompatibles = new System.Windows.Forms.GroupBox();
            this.btnQuitarModelo = new System.Windows.Forms.Button();
            this.dvgPiezasModelos = new System.Windows.Forms.DataGridView();
            this.btnAgregarModelo = new System.Windows.Forms.Button();
            this.lblSignoMoneda = new System.Windows.Forms.Label();
            this.lblIdPieza = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.imgPieza = new System.Windows.Forms.PictureBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosMercados)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbModelosCompatibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPiezasModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPiezaTipo
            // 
            this.lblPiezaTipo.AutoSize = true;
            this.lblPiezaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezaTipo.Location = new System.Drawing.Point(195, 79);
            this.lblPiezaTipo.Name = "lblPiezaTipo";
            this.lblPiezaTipo.Size = new System.Drawing.Size(88, 20);
            this.lblPiezaTipo.TabIndex = 4;
            this.lblPiezaTipo.Text = "Pieza Tipo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(502, 9);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(63, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(508, 29);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(135, 34);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(195, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(200, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 34);
            this.txtCodigo.TabIndex = 3;
            // 
            // cmbPiezaTipo
            // 
            this.cmbPiezaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPiezaTipo.FormattingEnabled = true;
            this.cmbPiezaTipo.Location = new System.Drawing.Point(199, 100);
            this.cmbPiezaTipo.Name = "cmbPiezaTipo";
            this.cmbPiezaTipo.Size = new System.Drawing.Size(264, 24);
            this.cmbPiezaTipo.TabIndex = 5;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(197, 137);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(59, 17);
            this.lblDetalles.TabIndex = 10;
            this.lblDetalles.Text = "Detalles";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(502, 79);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(69, 20);
            this.lblMaterial.TabIndex = 12;
            this.lblMaterial.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(506, 100);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(264, 24);
            this.cmbMaterial.TabIndex = 13;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalles.Location = new System.Drawing.Point(200, 157);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(570, 26);
            this.txtDetalles.TabIndex = 11;
            this.txtDetalles.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 309);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 279);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPiezas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPiezas
            // 
            this.dgvPiezas.AllowUserToAddRows = false;
            this.dgvPiezas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiezas.Location = new System.Drawing.Point(6, 6);
            this.dgvPiezas.MultiSelect = false;
            this.dgvPiezas.Name = "dgvPiezas";
            this.dgvPiezas.ReadOnly = true;
            this.dgvPiezas.RowHeadersWidth = 51;
            this.dgvPiezas.RowTemplate.Height = 24;
            this.dgvPiezas.Size = new System.Drawing.Size(738, 238);
            this.dgvPiezas.TabIndex = 0;
            this.dgvPiezas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mercado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCP4);
            this.groupBox1.Controls.Add(this.cmbCP3);
            this.groupBox1.Controls.Add(this.cmbCP2);
            this.groupBox1.Controls.Add(this.cmbCP1);
            this.groupBox1.Controls.Add(this.dgvPreciosMercados);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 237);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes/Proovedores";
            // 
            // cmbCP4
            // 
            this.cmbCP4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCP4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCP4.FormattingEnabled = true;
            this.cmbCP4.Location = new System.Drawing.Point(548, 21);
            this.cmbCP4.Name = "cmbCP4";
            this.cmbCP4.Size = new System.Drawing.Size(170, 24);
            this.cmbCP4.TabIndex = 12;
            this.cmbCP4.SelectedIndexChanged += new System.EventHandler(this.Seleccionado4);
            // 
            // cmbCP3
            // 
            this.cmbCP3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCP3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCP3.FormattingEnabled = true;
            this.cmbCP3.Location = new System.Drawing.Point(372, 21);
            this.cmbCP3.Name = "cmbCP3";
            this.cmbCP3.Size = new System.Drawing.Size(170, 24);
            this.cmbCP3.TabIndex = 11;
            this.cmbCP3.SelectedIndexChanged += new System.EventHandler(this.Seleccionado3);
            // 
            // cmbCP2
            // 
            this.cmbCP2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCP2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCP2.FormattingEnabled = true;
            this.cmbCP2.Location = new System.Drawing.Point(196, 21);
            this.cmbCP2.Name = "cmbCP2";
            this.cmbCP2.Size = new System.Drawing.Size(170, 24);
            this.cmbCP2.TabIndex = 10;
            this.cmbCP2.SelectedIndexChanged += new System.EventHandler(this.Seleccionado2);
            // 
            // cmbCP1
            // 
            this.cmbCP1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCP1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCP1.FormattingEnabled = true;
            this.cmbCP1.Location = new System.Drawing.Point(20, 21);
            this.cmbCP1.Name = "cmbCP1";
            this.cmbCP1.Size = new System.Drawing.Size(170, 24);
            this.cmbCP1.TabIndex = 9;
            this.cmbCP1.SelectedIndexChanged += new System.EventHandler(this.Seleccionado1);
            // 
            // dgvPreciosMercados
            // 
            this.dgvPreciosMercados.AllowUserToAddRows = false;
            this.dgvPreciosMercados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreciosMercados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreciosMercados.Location = new System.Drawing.Point(179, 69);
            this.dgvPreciosMercados.MultiSelect = false;
            this.dgvPreciosMercados.Name = "dgvPreciosMercados";
            this.dgvPreciosMercados.ReadOnly = true;
            this.dgvPreciosMercados.RowHeadersWidth = 51;
            this.dgvPreciosMercados.RowTemplate.Height = 24;
            this.dgvPreciosMercados.Size = new System.Drawing.Size(382, 146);
            this.dgvPreciosMercados.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblIdModelo);
            this.tabPage3.Controls.Add(this.gbModelosCompatibles);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(750, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mod. Compatibles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdModelo.Location = new System.Drawing.Point(731, 234);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(13, 13);
            this.lblIdModelo.TabIndex = 17;
            this.lblIdModelo.Text = "0";
            // 
            // gbModelosCompatibles
            // 
            this.gbModelosCompatibles.Controls.Add(this.btnQuitarModelo);
            this.gbModelosCompatibles.Controls.Add(this.dvgPiezasModelos);
            this.gbModelosCompatibles.Controls.Add(this.btnAgregarModelo);
            this.gbModelosCompatibles.Location = new System.Drawing.Point(167, 6);
            this.gbModelosCompatibles.Name = "gbModelosCompatibles";
            this.gbModelosCompatibles.Size = new System.Drawing.Size(441, 238);
            this.gbModelosCompatibles.TabIndex = 16;
            this.gbModelosCompatibles.TabStop = false;
            this.gbModelosCompatibles.Text = "Modelos compatibles";
            // 
            // btnQuitarModelo
            // 
            this.btnQuitarModelo.Image = global::Juntas_MC.Properties.Resources.iconfinder_Button_White_Remove_58498;
            this.btnQuitarModelo.Location = new System.Drawing.Point(369, 143);
            this.btnQuitarModelo.Name = "btnQuitarModelo";
            this.btnQuitarModelo.Size = new System.Drawing.Size(50, 50);
            this.btnQuitarModelo.TabIndex = 2;
            this.btnQuitarModelo.UseVisualStyleBackColor = true;
            this.btnQuitarModelo.Click += new System.EventHandler(this.btnQuitarModelo_Click);
            // 
            // dvgPiezasModelos
            // 
            this.dvgPiezasModelos.AllowUserToAddRows = false;
            this.dvgPiezasModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPiezasModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPiezasModelos.Location = new System.Drawing.Point(6, 21);
            this.dvgPiezasModelos.MultiSelect = false;
            this.dvgPiezasModelos.Name = "dvgPiezasModelos";
            this.dvgPiezasModelos.ReadOnly = true;
            this.dvgPiezasModelos.RowHeadersWidth = 51;
            this.dvgPiezasModelos.RowTemplate.Height = 24;
            this.dvgPiezasModelos.Size = new System.Drawing.Size(348, 211);
            this.dvgPiezasModelos.TabIndex = 1;
            this.dvgPiezasModelos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarPiezaModelo);
            // 
            // btnAgregarModelo
            // 
            this.btnAgregarModelo.Image = global::Juntas_MC.Properties.Resources.iconfinder_Button_Add_58476;
            this.btnAgregarModelo.Location = new System.Drawing.Point(369, 66);
            this.btnAgregarModelo.Name = "btnAgregarModelo";
            this.btnAgregarModelo.Size = new System.Drawing.Size(50, 50);
            this.btnAgregarModelo.TabIndex = 0;
            this.btnAgregarModelo.UseVisualStyleBackColor = true;
            this.btnAgregarModelo.Click += new System.EventHandler(this.btnAgregarModelo_Click);
            // 
            // lblSignoMoneda
            // 
            this.lblSignoMoneda.AutoSize = true;
            this.lblSignoMoneda.BackColor = System.Drawing.SystemColors.Window;
            this.lblSignoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoMoneda.Location = new System.Drawing.Point(510, 32);
            this.lblSignoMoneda.Name = "lblSignoMoneda";
            this.lblSignoMoneda.Size = new System.Drawing.Size(26, 29);
            this.lblSignoMoneda.TabIndex = 22;
            this.lblSignoMoneda.Text = "$";
            // 
            // lblIdPieza
            // 
            this.lblIdPieza.AutoSize = true;
            this.lblIdPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPieza.Location = new System.Drawing.Point(773, 583);
            this.lblIdPieza.Name = "lblIdPieza";
            this.lblIdPieza.Size = new System.Drawing.Size(8, 7);
            this.lblIdPieza.TabIndex = 23;
            this.lblIdPieza.Text = "0";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(16, 155);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(87, 26);
            this.btnExaminar.TabIndex = 24;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.AllowDrop = true;
            this.txtRutaImagen.Enabled = false;
            this.txtRutaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaImagen.Location = new System.Drawing.Point(13, 190);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(174, 19);
            this.txtRutaImagen.TabIndex = 25;
            this.txtRutaImagen.Visible = false;
            this.txtRutaImagen.WordWrap = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Juntas_MC.Properties.Resources.iconfinder_Search_58605;
            this.btnBuscar.Location = new System.Drawing.Point(12, 223);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 58);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Juntas_MC.Properties.Resources.empty_icon;
            this.btnLimpiar.Location = new System.Drawing.Point(180, 223);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(58, 58);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Juntas_MC.Properties.Resources.trash_Icon;
            this.btnBorrar.Location = new System.Drawing.Point(649, 223);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(123, 58);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Juntas_MC.Properties.Resources.pencil_edit;
            this.btnModificar.Location = new System.Drawing.Point(520, 223);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 58);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Juntas_MC.Properties.Resources.Add_Icon;
            this.btnAgregar.Location = new System.Drawing.Point(391, 223);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 58);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // imgPieza
            // 
            this.imgPieza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPieza.Location = new System.Drawing.Point(12, 9);
            this.imgPieza.Name = "imgPieza";
            this.imgPieza.Size = new System.Drawing.Size(175, 175);
            this.imgPieza.TabIndex = 9;
            this.imgPieza.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(706, 36);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(18, 17);
            this.cbEstado.TabIndex = 28;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Estado";
            // 
            // Piezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblSignoMoneda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.lblIdPieza);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.imgPieza);
            this.Controls.Add(this.cmbPiezaTipo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPiezaTipo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Piezas";
            this.Text = "Piezas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreciosMercados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gbModelosCompatibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPiezasModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPieza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPiezaTipo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbPiezaTipo;
        private System.Windows.Forms.PictureBox imgPieza;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCP4;
        private System.Windows.Forms.ComboBox cmbCP3;
        private System.Windows.Forms.ComboBox cmbCP2;
        private System.Windows.Forms.ComboBox cmbCP1;
        private System.Windows.Forms.DataGridView dgvPreciosMercados;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbModelosCompatibles;
        private System.Windows.Forms.DataGridView dvgPiezasModelos;
        private System.Windows.Forms.Button btnAgregarModelo;
        private System.Windows.Forms.DataGridView dgvPiezas;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSignoMoneda;
        public System.Windows.Forms.Label lblIdPieza;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Button btnQuitarModelo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label1;
    }
}