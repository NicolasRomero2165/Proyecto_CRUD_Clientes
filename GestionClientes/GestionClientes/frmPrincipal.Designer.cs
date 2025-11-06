namespace GestionClientes
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            altaClienteToolStripMenuItem = new ToolStripMenuItem();
            listaClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dgvClientes = new DataGridView();
            btnRegistrar = new Button();
            txtCalle = new TextBox();
            cbxLocalidad = new ComboBox();
            cbxProvincia = new ComboBox();
            mtbTelefono = new MaskedTextBox();
            txtRazonSocial = new TextBox();
            lblCalle = new Label();
            lblLocalidad = new Label();
            lblProvincia = new Label();
            lblTelefono = new Label();
            lblRazonSocial = new Label();
            lblCuit = new Label();
            gbxAltaCliente = new GroupBox();
            btnModificarOk = new Button();
            mtbCuit = new MaskedTextBox();
            cbxBuscar = new ComboBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnArgentina = new Button();
            btnModificar = new Button();
            imageList1 = new ImageList(components);
            btnEliminar = new Button();
            gbxBusqueda = new GroupBox();
            lblIndice = new Label();
            lblNumIndice = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbxAltaCliente.SuspendLayout();
            gbxBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { altaClienteToolStripMenuItem, listaClientesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // altaClienteToolStripMenuItem
            // 
            altaClienteToolStripMenuItem.Image = Properties.Resources.add;
            altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            altaClienteToolStripMenuItem.Size = new Size(96, 20);
            altaClienteToolStripMenuItem.Text = "Alta Cliente";
            altaClienteToolStripMenuItem.ToolTipText = "Registrar un cliente";
            altaClienteToolStripMenuItem.Click += altaClienteToolStripMenuItem_Click;
            // 
            // listaClientesToolStripMenuItem
            // 
            listaClientesToolStripMenuItem.Image = Properties.Resources.refresh;
            listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            listaClientesToolStripMenuItem.ShortcutKeys = Keys.F5;
            listaClientesToolStripMenuItem.Size = new Size(104, 20);
            listaClientesToolStripMenuItem.Text = "Lista Clientes";
            listaClientesToolStripMenuItem.ToolTipText = "Actualizar lista de clientes = F5";
            listaClientesToolStripMenuItem.Click += listaClientesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = Properties.Resources.Close;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            salirToolStripMenuItem.Size = new Size(57, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.ToolTipText = "Cerrar Sesión = Alt + F4";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 27);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(945, 389);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellContentClick += dgvClientes_CellsClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Location = new Point(95, 257);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(108, 23);
            btnRegistrar.TabIndex = 27;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(95, 217);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(195, 23);
            txtCalle.TabIndex = 26;
            // 
            // cbxLocalidad
            // 
            cbxLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLocalidad.Enabled = false;
            cbxLocalidad.FormattingEnabled = true;
            cbxLocalidad.ImeMode = ImeMode.NoControl;
            cbxLocalidad.Location = new Point(95, 178);
            cbxLocalidad.Name = "cbxLocalidad";
            cbxLocalidad.Size = new Size(195, 23);
            cbxLocalidad.Sorted = true;
            cbxLocalidad.TabIndex = 25;
            // 
            // cbxProvincia
            // 
            cbxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProvincia.FormattingEnabled = true;
            cbxProvincia.ImeMode = ImeMode.NoControl;
            cbxProvincia.Items.AddRange(new object[] { "GBA Norte", "GBA Oeste", "GBA Sur", "CABA", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán" });
            cbxProvincia.Location = new Point(95, 139);
            cbxProvincia.Name = "cbxProvincia";
            cbxProvincia.Size = new Size(195, 23);
            cbxProvincia.TabIndex = 24;
            cbxProvincia.SelectedIndexChanged += cbxProvincia_SelectedIndexChanged;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(95, 100);
            mtbTelefono.Mask = "9999999999";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(121, 23);
            mtbTelefono.TabIndex = 23;
            mtbTelefono.ValidatingType = typeof(int);
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(95, 61);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(195, 23);
            txtRazonSocial.TabIndex = 22;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(13, 225);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 20;
            lblCalle.Text = "Calle:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(13, 186);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 19;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(13, 147);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(59, 15);
            lblProvincia.TabIndex = 18;
            lblProvincia.Text = "Provincia:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(13, 108);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 17;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(13, 69);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(76, 15);
            lblRazonSocial.TabIndex = 16;
            lblRazonSocial.Text = "Razón Social:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(13, 30);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(36, 15);
            lblCuit.TabIndex = 15;
            lblCuit.Text = "CUIT:";
            // 
            // gbxAltaCliente
            // 
            gbxAltaCliente.Controls.Add(btnModificarOk);
            gbxAltaCliente.Controls.Add(mtbCuit);
            gbxAltaCliente.Controls.Add(btnRegistrar);
            gbxAltaCliente.Controls.Add(lblCuit);
            gbxAltaCliente.Controls.Add(txtCalle);
            gbxAltaCliente.Controls.Add(lblRazonSocial);
            gbxAltaCliente.Controls.Add(cbxLocalidad);
            gbxAltaCliente.Controls.Add(lblTelefono);
            gbxAltaCliente.Controls.Add(cbxProvincia);
            gbxAltaCliente.Controls.Add(lblProvincia);
            gbxAltaCliente.Controls.Add(mtbTelefono);
            gbxAltaCliente.Controls.Add(lblLocalidad);
            gbxAltaCliente.Controls.Add(txtRazonSocial);
            gbxAltaCliente.Controls.Add(lblCalle);
            gbxAltaCliente.Location = new Point(12, 27);
            gbxAltaCliente.Name = "gbxAltaCliente";
            gbxAltaCliente.Size = new Size(314, 297);
            gbxAltaCliente.TabIndex = 28;
            gbxAltaCliente.TabStop = false;
            gbxAltaCliente.Text = "Alta Cliente";
            gbxAltaCliente.Visible = false;
            // 
            // btnModificarOk
            // 
            btnModificarOk.BackColor = SystemColors.Info;
            btnModificarOk.Cursor = Cursors.Hand;
            btnModificarOk.FlatStyle = FlatStyle.Popup;
            btnModificarOk.Location = new Point(95, 257);
            btnModificarOk.Name = "btnModificarOk";
            btnModificarOk.Size = new Size(108, 23);
            btnModificarOk.TabIndex = 40;
            btnModificarOk.Text = "Modificar";
            btnModificarOk.UseVisualStyleBackColor = false;
            btnModificarOk.Visible = false;
            btnModificarOk.Click += btnModificarOk_Click;
            // 
            // mtbCuit
            // 
            mtbCuit.Location = new Point(95, 22);
            mtbCuit.Mask = "99-99999999-9";
            mtbCuit.Name = "mtbCuit";
            mtbCuit.Size = new Size(121, 23);
            mtbCuit.TabIndex = 28;
            mtbCuit.ValidatingType = typeof(int);
            // 
            // cbxBuscar
            // 
            cbxBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Items.AddRange(new object[] { "CUIT", "Razón Social", "Teléfono", "Provincia", "Localidad", "Calle" });
            cbxBuscar.Location = new Point(6, 20);
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(134, 23);
            cbxBuscar.TabIndex = 29;
            cbxBuscar.SelectedIndexChanged += cbxBuscar_SelectedIndexChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Enabled = false;
            txtBuscar.Location = new Point(146, 20);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(300, 23);
            txtBuscar.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(452, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 23);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnArgentina
            // 
            btnArgentina.BackgroundImage = Properties.Resources.TeamArgentina;
            btnArgentina.FlatStyle = FlatStyle.Flat;
            btnArgentina.Location = new Point(11, 323);
            btnArgentina.Name = "btnArgentina";
            btnArgentina.Size = new Size(315, 93);
            btnArgentina.TabIndex = 32;
            btnArgentina.UseVisualStyleBackColor = true;
            btnArgentina.Visible = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Enabled = false;
            btnModificar.ImageIndex = 0;
            btnModificar.ImageList = imageList1;
            btnModificar.Location = new Point(562, 19);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(40, 24);
            btnModificar.TabIndex = 33;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "editar.jpg");
            imageList1.Images.SetKeyName(1, "eliminar.jpg");
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Enabled = false;
            btnEliminar.ImageIndex = 1;
            btnEliminar.ImageList = imageList1;
            btnEliminar.Location = new Point(608, 19);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(40, 24);
            btnEliminar.TabIndex = 34;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // gbxBusqueda
            // 
            gbxBusqueda.Controls.Add(lblIndice);
            gbxBusqueda.Controls.Add(lblNumIndice);
            gbxBusqueda.Controls.Add(cbxBuscar);
            gbxBusqueda.Controls.Add(btnEliminar);
            gbxBusqueda.Controls.Add(txtBuscar);
            gbxBusqueda.Controls.Add(btnModificar);
            gbxBusqueda.Controls.Add(btnBuscar);
            gbxBusqueda.Location = new Point(12, 422);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Size = new Size(945, 56);
            gbxBusqueda.TabIndex = 35;
            gbxBusqueda.TabStop = false;
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Location = new Point(654, 23);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(119, 15);
            lblIndice.TabIndex = 37;
            lblIndice.Text = "Cliente seleccionado:";
            // 
            // lblNumIndice
            // 
            lblNumIndice.AutoSize = true;
            lblNumIndice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumIndice.Location = new Point(779, 20);
            lblNumIndice.Name = "lblNumIndice";
            lblNumIndice.Size = new Size(27, 20);
            lblNumIndice.TabIndex = 36;
            lblNumIndice.Text = "___";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 485);
            Controls.Add(gbxBusqueda);
            Controls.Add(btnArgentina);
            Controls.Add(gbxAltaCliente);
            Controls.Add(dgvClientes);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbxAltaCliente.ResumeLayout(false);
            gbxAltaCliente.PerformLayout();
            gbxBusqueda.ResumeLayout(false);
            gbxBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem altaClienteToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem listaClientesToolStripMenuItem;
        private Button btnRegistrar;
        private TextBox txtCalle;
        private ComboBox cbxLocalidad;
        private ComboBox cbxProvincia;
        private MaskedTextBox mtbTelefono;
        private TextBox txtRazonSocial;
        private Label lblCalle;
        private Label lblLocalidad;
        private Label lblProvincia;
        private Label lblTelefono;
        private Label lblRazonSocial;
        private Label lblCuit;
        private GroupBox gbxAltaCliente;
        private MaskedTextBox mtbCuit;
        private ComboBox cbxBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnArgentina;
        public DataGridView dgvClientes;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox gbxBusqueda;
        private ImageList imageList1;
        private Label lblNumIndice;
        private Label lblIndice;
        private Button btnModificarOk;
    }
}