namespace UAI_HIPERMERCADO
{
    partial class Reportes_Informess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes_Informess));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFacturasEmitidas = new System.Windows.Forms.Label();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.lblFacturasAbonadas = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIndividuosRegistrados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPymesRegistradas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFacturaR = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPiramide = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtFacturasEmitidas = new System.Windows.Forms.TextBox();
            this.txtFacturasAbonadas = new System.Windows.Forms.TextBox();
            this.txtPymes = new System.Windows.Forms.TextBox();
            this.txtIndividios = new System.Windows.Forms.TextBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPiramide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Brown;
            this.btnActualizarDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarDatos.Location = new System.Drawing.Point(214, 394);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(143, 60);
            this.btnActualizarDatos.TabIndex = 16;
            this.btnActualizarDatos.Text = "Actualizar ultimo resumen";
            this.btnActualizarDatos.UseVisualStyleBackColor = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Facturas emitidas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Facturas abonadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Recaudado:";
            // 
            // lblFacturasEmitidas
            // 
            this.lblFacturasEmitidas.AutoSize = true;
            this.lblFacturasEmitidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturasEmitidas.Location = new System.Drawing.Point(256, 41);
            this.lblFacturasEmitidas.Name = "lblFacturasEmitidas";
            this.lblFacturasEmitidas.Size = new System.Drawing.Size(19, 25);
            this.lblFacturasEmitidas.TabIndex = 20;
            this.lblFacturasEmitidas.Text = "-";
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudado.Location = new System.Drawing.Point(256, 305);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(19, 25);
            this.lblTotalRecaudado.TabIndex = 22;
            this.lblTotalRecaudado.Text = "-";
            // 
            // lblFacturasAbonadas
            // 
            this.lblFacturasAbonadas.AutoSize = true;
            this.lblFacturasAbonadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturasAbonadas.Location = new System.Drawing.Point(256, 94);
            this.lblFacturasAbonadas.Name = "lblFacturasAbonadas";
            this.lblFacturasAbonadas.Size = new System.Drawing.Size(19, 25);
            this.lblFacturasAbonadas.TabIndex = 21;
            this.lblFacturasAbonadas.Text = "-";
            this.lblFacturasAbonadas.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(256, 143);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(19, 25);
            this.lblProductos.TabIndex = 24;
            this.lblProductos.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Productos en stock:";
            // 
            // lblIndividuosRegistrados
            // 
            this.lblIndividuosRegistrados.AutoSize = true;
            this.lblIndividuosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividuosRegistrados.Location = new System.Drawing.Point(256, 260);
            this.lblIndividuosRegistrados.Name = "lblIndividuosRegistrados";
            this.lblIndividuosRegistrados.Size = new System.Drawing.Size(19, 25);
            this.lblIndividuosRegistrados.TabIndex = 28;
            this.lblIndividuosRegistrados.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Individuos registrados:";
            // 
            // lblPymesRegistradas
            // 
            this.lblPymesRegistradas.AutoSize = true;
            this.lblPymesRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPymesRegistradas.Location = new System.Drawing.Point(256, 199);
            this.lblPymesRegistradas.Name = "lblPymesRegistradas";
            this.lblPymesRegistradas.Size = new System.Drawing.Size(19, 25);
            this.lblPymesRegistradas.TabIndex = 26;
            this.lblPymesRegistradas.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pymes registradas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalRecaudado);
            this.groupBox1.Controls.Add(this.lblIndividuosRegistrados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFacturasEmitidas);
            this.groupBox1.Controls.Add(this.lblPymesRegistradas);
            this.groupBox1.Controls.Add(this.lblFacturasAbonadas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblProductos);
            this.groupBox1.Location = new System.Drawing.Point(118, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 350);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informes";
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.BackColor = System.Drawing.Color.Brown;
            this.btnGuardarXML.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarXML.Location = new System.Drawing.Point(720, 470);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(143, 50);
            this.btnGuardarXML.TabIndex = 31;
            this.btnGuardarXML.Text = "Guardar ultimo resumen en XML";
            this.btnGuardarXML.UseVisualStyleBackColor = false;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(720, 388);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcion.TabIndex = 32;
            // 
            // dtpFacturaR
            // 
            this.dtpFacturaR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFacturaR.Location = new System.Drawing.Point(720, 427);
            this.dtpFacturaR.Name = "dtpFacturaR";
            this.dtpFacturaR.Size = new System.Drawing.Size(100, 22);
            this.dtpFacturaR.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha referencia";
            // 
            // chartProductos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProductos.Legends.Add(legend1);
            this.chartProductos.Location = new System.Drawing.Point(52, 548);
            this.chartProductos.Name = "chartProductos";
            this.chartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartProductos.Series.Add(series1);
            this.chartProductos.Size = new System.Drawing.Size(563, 335);
            this.chartProductos.TabIndex = 36;
            this.chartProductos.Text = "chart1";
            this.chartProductos.Click += new System.EventHandler(this.chartProductos_Click);
            // 
            // chartPiramide
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPiramide.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPiramide.Legends.Add(legend2);
            this.chartPiramide.Location = new System.Drawing.Point(922, 559);
            this.chartPiramide.Name = "chartPiramide";
            this.chartPiramide.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chartPiramide.Series.Add(series2);
            this.chartPiramide.Size = new System.Drawing.Size(533, 335);
            this.chartPiramide.TabIndex = 37;
            this.chartPiramide.Text = "chart1";
            // 
            // txtFacturasEmitidas
            // 
            this.txtFacturasEmitidas.Location = new System.Drawing.Point(967, 391);
            this.txtFacturasEmitidas.Name = "txtFacturasEmitidas";
            this.txtFacturasEmitidas.Size = new System.Drawing.Size(100, 22);
            this.txtFacturasEmitidas.TabIndex = 38;
            // 
            // txtFacturasAbonadas
            // 
            this.txtFacturasAbonadas.Location = new System.Drawing.Point(967, 429);
            this.txtFacturasAbonadas.Name = "txtFacturasAbonadas";
            this.txtFacturasAbonadas.Size = new System.Drawing.Size(100, 22);
            this.txtFacturasAbonadas.TabIndex = 39;
            // 
            // txtPymes
            // 
            this.txtPymes.Location = new System.Drawing.Point(1231, 431);
            this.txtPymes.Name = "txtPymes";
            this.txtPymes.Size = new System.Drawing.Size(100, 22);
            this.txtPymes.TabIndex = 41;
            // 
            // txtIndividios
            // 
            this.txtIndividios.Location = new System.Drawing.Point(1231, 387);
            this.txtIndividios.Name = "txtIndividios";
            this.txtIndividios.Size = new System.Drawing.Size(100, 22);
            this.txtIndividios.TabIndex = 40;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(1474, 388);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(100, 22);
            this.txtProductos.TabIndex = 42;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1474, 423);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(832, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Facturas Abonadas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(845, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Facturas Emitidas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1083, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Pymes Registradas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1345, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Productos en Stock";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1086, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "Individuos registrados";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1345, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 49;
            this.label14.Text = "TotalRecaudado";
            // 
            // dgvInformes
            // 
            this.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformes.Location = new System.Drawing.Point(520, 25);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.RowHeadersWidth = 51;
            this.dgvInformes.RowTemplate.Height = 24;
            this.dgvInformes.Size = new System.Drawing.Size(1058, 350);
            this.dgvInformes.TabIndex = 50;
            this.dgvInformes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformes_CellContentClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(515, 407);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(458, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "Codigo";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Brown;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(933, 470);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 50);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar resumen en XML";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1129, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "Eliminar resumen en XML";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes_Informess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1590, 885);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvInformes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.txtPymes);
            this.Controls.Add(this.txtIndividios);
            this.Controls.Add(this.txtFacturasAbonadas);
            this.Controls.Add(this.txtFacturasEmitidas);
            this.Controls.Add(this.chartPiramide);
            this.Controls.Add(this.chartProductos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFacturaR);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes_Informess";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPiramide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFacturasEmitidas;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.Label lblFacturasAbonadas;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIndividuosRegistrados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPymesRegistradas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFacturaR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPiramide;
        private System.Windows.Forms.TextBox txtFacturasEmitidas;
        private System.Windows.Forms.TextBox txtFacturasAbonadas;
        private System.Windows.Forms.TextBox txtPymes;
        private System.Windows.Forms.TextBox txtIndividios;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvInformes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
    }
}