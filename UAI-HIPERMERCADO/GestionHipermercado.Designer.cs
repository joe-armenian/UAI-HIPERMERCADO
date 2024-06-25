namespace UAI_HIPERMERCADO
{
    partial class GestionHipermercado
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.gpPersona = new System.Windows.Forms.GroupBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpPyme = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.rbPyme = new System.Windows.Forms.RadioButton();
            this.rbIndividuo = new System.Windows.Forms.RadioButton();
            this.gpClientes = new System.Windows.Forms.GroupBox();
            this.dgvPyme = new System.Windows.Forms.DataGridView();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbNombreProducto = new System.Windows.Forms.ComboBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnBajaProducto = new System.Windows.Forms.Button();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvFactProductos = new System.Windows.Forms.DataGridView();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnPagarProducto = new System.Windows.Forms.Button();
            this.btnAsociarProducto = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalSImpuestos = new System.Windows.Forms.Label();
            this.btnClonar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbProductoClon = new System.Windows.Forms.ComboBox();
            this.txtCantidadEspecifica = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpPersona.SuspendLayout();
            this.gpPyme.SuspendLayout();
            this.gpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPyme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.gpPersona);
            this.groupBox1.Controls.Add(this.gpPyme);
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.lblCUIT);
            this.groupBox1.Controls.Add(this.rbPyme);
            this.groupBox1.Controls.Add(this.rbIndividuo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModificar.Location = new System.Drawing.Point(211, 227);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 24);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBaja.Location = new System.Drawing.Point(130, 229);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(65, 24);
            this.btnBaja.TabIndex = 11;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAlta.Location = new System.Drawing.Point(36, 229);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(60, 24);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // gpPersona
            // 
            this.gpPersona.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gpPersona.Controls.Add(this.lblApellido);
            this.gpPersona.Controls.Add(this.lblNombre);
            this.gpPersona.Controls.Add(this.txtApellido);
            this.gpPersona.Controls.Add(this.txtNombre);
            this.gpPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPersona.ForeColor = System.Drawing.Color.Black;
            this.gpPersona.Location = new System.Drawing.Point(6, 85);
            this.gpPersona.Name = "gpPersona";
            this.gpPersona.Size = new System.Drawing.Size(155, 138);
            this.gpPersona.TabIndex = 8;
            this.gpPersona.TabStop = false;
            this.gpPersona.Text = "Persona";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(16, 106);
            this.txtApellido.MaxLength = 12;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(113, 22);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 39);
            this.txtNombre.MaxLength = 12;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(113, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // gpPyme
            // 
            this.gpPyme.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gpPyme.Controls.Add(this.txtRazonSocial);
            this.gpPyme.Controls.Add(this.lblRazon);
            this.gpPyme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPyme.ForeColor = System.Drawing.Color.Black;
            this.gpPyme.Location = new System.Drawing.Point(179, 85);
            this.gpPyme.Name = "gpPyme";
            this.gpPyme.Size = new System.Drawing.Size(122, 94);
            this.gpPyme.TabIndex = 9;
            this.gpPyme.TabStop = false;
            this.gpPyme.Text = "Pyme";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(14, 44);
            this.txtRazonSocial.MaxLength = 12;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(92, 22);
            this.txtRazonSocial.TabIndex = 13;
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Location = new System.Drawing.Point(11, 25);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(87, 16);
            this.lblRazon.TabIndex = 13;
            this.lblRazon.Text = "Razon Social";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT.Location = new System.Drawing.Point(90, 50);
            this.txtCUIT.MaxLength = 12;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(120, 22);
            this.txtCUIT.TabIndex = 7;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(126, 27);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(50, 20);
            this.lblCUIT.TabIndex = 2;
            this.lblCUIT.Text = "CUIT:";
            // 
            // rbPyme
            // 
            this.rbPyme.AutoSize = true;
            this.rbPyme.Location = new System.Drawing.Point(6, 55);
            this.rbPyme.Name = "rbPyme";
            this.rbPyme.Size = new System.Drawing.Size(66, 24);
            this.rbPyme.TabIndex = 1;
            this.rbPyme.Text = "Pyme";
            this.rbPyme.UseVisualStyleBackColor = true;
            this.rbPyme.CheckedChanged += new System.EventHandler(this.rbPyme_CheckedChanged);
            // 
            // rbIndividuo
            // 
            this.rbIndividuo.AutoSize = true;
            this.rbIndividuo.Location = new System.Drawing.Point(6, 25);
            this.rbIndividuo.Name = "rbIndividuo";
            this.rbIndividuo.Size = new System.Drawing.Size(90, 24);
            this.rbIndividuo.TabIndex = 0;
            this.rbIndividuo.Text = "Individuo";
            this.rbIndividuo.UseVisualStyleBackColor = true;
            this.rbIndividuo.CheckedChanged += new System.EventHandler(this.rbIndividuo_CheckedChanged);
            // 
            // gpClientes
            // 
            this.gpClientes.BackColor = System.Drawing.Color.DarkGray;
            this.gpClientes.Controls.Add(this.dgvPyme);
            this.gpClientes.Controls.Add(this.dgvPersonas);
            this.gpClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpClientes.ForeColor = System.Drawing.Color.Black;
            this.gpClientes.Location = new System.Drawing.Point(373, 12);
            this.gpClientes.Name = "gpClientes";
            this.gpClientes.Size = new System.Drawing.Size(616, 273);
            this.gpClientes.TabIndex = 2;
            this.gpClientes.TabStop = false;
            this.gpClientes.Text = "Listado de clientes";
            // 
            // dgvPyme
            // 
            this.dgvPyme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPyme.Location = new System.Drawing.Point(23, 143);
            this.dgvPyme.Name = "dgvPyme";
            this.dgvPyme.ReadOnly = true;
            this.dgvPyme.Size = new System.Drawing.Size(566, 114);
            this.dgvPyme.TabIndex = 3;
            this.dgvPyme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPyme_CellContentClick);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(23, 23);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.Size = new System.Drawing.Size(566, 114);
            this.dgvPersonas.TabIndex = 2;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.cbNombreProducto);
            this.groupBox2.Controls.Add(this.btnModificarProducto);
            this.groupBox2.Controls.Add(this.btnBajaProducto);
            this.groupBox2.Controls.Add(this.btnAltaProducto);
            this.groupBox2.Controls.Add(this.txtPrecioProducto);
            this.groupBox2.Controls.Add(this.txtCodigoProducto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargar Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(80, 122);
            this.txtCantidad.MaxLength = 12;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 21);
            this.txtCantidad.TabIndex = 20;
            // 
            // cbNombreProducto
            // 
            this.cbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombreProducto.FormattingEnabled = true;
            this.cbNombreProducto.Location = new System.Drawing.Point(81, 58);
            this.cbNombreProducto.Name = "cbNombreProducto";
            this.cbNombreProducto.Size = new System.Drawing.Size(120, 23);
            this.cbNombreProducto.TabIndex = 19;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModificarProducto.Location = new System.Drawing.Point(158, 159);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(69, 25);
            this.btnModificarProducto.TabIndex = 13;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnBajaProducto
            // 
            this.btnBajaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaProducto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBajaProducto.Location = new System.Drawing.Point(102, 159);
            this.btnBajaProducto.Name = "btnBajaProducto";
            this.btnBajaProducto.Size = new System.Drawing.Size(50, 25);
            this.btnBajaProducto.TabIndex = 13;
            this.btnBajaProducto.Text = "Baja";
            this.btnBajaProducto.UseVisualStyleBackColor = true;
            this.btnBajaProducto.Click += new System.EventHandler(this.btnBajaProducto_Click);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAltaProducto.Location = new System.Drawing.Point(44, 159);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(52, 25);
            this.btnAltaProducto.TabIndex = 13;
            this.btnAltaProducto.Text = "Alta";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(81, 93);
            this.txtPrecioProducto.MaxLength = 12;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(120, 21);
            this.txtPrecioProducto.TabIndex = 18;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(81, 30);
            this.txtCodigoProducto.MaxLength = 12;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(120, 21);
            this.txtCodigoProducto.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.cbProducto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(6, 25);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(271, 21);
            this.cbProducto.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.dgvFactProductos);
            this.groupBox4.Controls.Add(this.dgvFactura);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(373, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(662, 290);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Facturas";
            // 
            // dgvFactProductos
            // 
            this.dgvFactProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactProductos.Location = new System.Drawing.Point(11, 155);
            this.dgvFactProductos.Name = "dgvFactProductos";
            this.dgvFactProductos.Size = new System.Drawing.Size(650, 119);
            this.dgvFactProductos.TabIndex = 1;
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(6, 23);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(650, 106);
            this.dgvFactura.TabIndex = 0;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            // 
            // btnPagarProducto
            // 
            this.btnPagarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPagarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarProducto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPagarProducto.Location = new System.Drawing.Point(285, 422);
            this.btnPagarProducto.Name = "btnPagarProducto";
            this.btnPagarProducto.Size = new System.Drawing.Size(70, 53);
            this.btnPagarProducto.TabIndex = 23;
            this.btnPagarProducto.Text = "Pagar producto";
            this.btnPagarProducto.UseVisualStyleBackColor = false;
            this.btnPagarProducto.Click += new System.EventHandler(this.btnPagarProducto_Click);
            // 
            // btnAsociarProducto
            // 
            this.btnAsociarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAsociarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociarProducto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAsociarProducto.Location = new System.Drawing.Point(285, 353);
            this.btnAsociarProducto.Name = "btnAsociarProducto";
            this.btnAsociarProducto.Size = new System.Drawing.Size(70, 53);
            this.btnAsociarProducto.TabIndex = 22;
            this.btnAsociarProducto.Text = "Asociar producto";
            this.btnAsociarProducto.UseVisualStyleBackColor = false;
            this.btnAsociarProducto.Click += new System.EventHandler(this.btnAsociarProducto_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.DarkGray;
            this.btnCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCrearFactura.Location = new System.Drawing.Point(285, 286);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(70, 53);
            this.btnCrearFactura.TabIndex = 24;
            this.btnCrearFactura.Text = "Crear factura";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "IMPUESTOS TOTALES:";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(475, 27);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(11, 15);
            this.lblImpuestos.TabIndex = 26;
            this.lblImpuestos.Text = "-";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lblCuitCliente);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblTotalSImpuestos);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lblImpuestos);
            this.groupBox5.Location = new System.Drawing.Point(323, 607);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(717, 57);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos de la compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "CUIT:";
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitCliente.Location = new System.Drawing.Point(578, 27);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(11, 15);
            this.lblCuitCliente.TabIndex = 30;
            this.lblCuitCliente.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "PRECIO DE LA COMPRA:";
            // 
            // lblTotalSImpuestos
            // 
            this.lblTotalSImpuestos.AutoSize = true;
            this.lblTotalSImpuestos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSImpuestos.Location = new System.Drawing.Point(220, 27);
            this.lblTotalSImpuestos.Name = "lblTotalSImpuestos";
            this.lblTotalSImpuestos.Size = new System.Drawing.Size(11, 15);
            this.lblTotalSImpuestos.TabIndex = 28;
            this.lblTotalSImpuestos.Text = "-";
            // 
            // btnClonar
            // 
            this.btnClonar.BackColor = System.Drawing.Color.LightYellow;
            this.btnClonar.Location = new System.Drawing.Point(48, 565);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(204, 25);
            this.btnClonar.TabIndex = 28;
            this.btnClonar.Text = "Clonar producto";
            this.btnClonar.UseVisualStyleBackColor = false;
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox6.Controls.Add(this.cbProductoClon);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 597);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(285, 67);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Producto";
            // 
            // cbProductoClon
            // 
            this.cbProductoClon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductoClon.FormattingEnabled = true;
            this.cbProductoClon.Location = new System.Drawing.Point(6, 25);
            this.cbProductoClon.Name = "cbProductoClon";
            this.cbProductoClon.Size = new System.Drawing.Size(271, 21);
            this.cbProductoClon.TabIndex = 0;
            // 
            // txtCantidadEspecifica
            // 
            this.txtCantidadEspecifica.Location = new System.Drawing.Point(303, 517);
            this.txtCantidadEspecifica.Name = "txtCantidadEspecifica";
            this.txtCantidadEspecifica.Size = new System.Drawing.Size(32, 20);
            this.txtCantidadEspecifica.TabIndex = 29;
            // 
            // GestionHipermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 676);
            this.Controls.Add(this.txtCantidadEspecifica);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnClonar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnPagarProducto);
            this.Controls.Add(this.btnAsociarProducto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionHipermercado";
            this.Text = "GestionHipermercado";
            this.Load += new System.EventHandler(this.GestionHipermercado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpPersona.ResumeLayout(false);
            this.gpPersona.PerformLayout();
            this.gpPyme.ResumeLayout(false);
            this.gpPyme.PerformLayout();
            this.gpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPyme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.GroupBox gpPersona;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpPyme;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.RadioButton rbPyme;
        private System.Windows.Forms.RadioButton rbIndividuo;
        private System.Windows.Forms.GroupBox gpClientes;
        private System.Windows.Forms.DataGridView dgvPyme;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbNombreProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnBajaProducto;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPagarProducto;
        private System.Windows.Forms.Button btnAsociarProducto;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.DataGridView dgvFactProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalSImpuestos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbProductoClon;
        private System.Windows.Forms.TextBox txtCantidadEspecifica;
    }
}