namespace UAI_HIPERMERCADO
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            this.btn_Baja = new System.Windows.Forms.Button();
            this.lblContraGestion = new System.Windows.Forms.Label();
            this.lblUsuarioGestion = new System.Windows.Forms.Label();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Baja
            // 
            this.btn_Baja.BackColor = System.Drawing.Color.Red;
            this.btn_Baja.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Baja.Location = new System.Drawing.Point(268, 374);
            this.btn_Baja.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(109, 27);
            this.btn_Baja.TabIndex = 11;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = false;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // lblContraGestion
            // 
            this.lblContraGestion.AutoSize = true;
            this.lblContraGestion.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblContraGestion.Location = new System.Drawing.Point(92, 257);
            this.lblContraGestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraGestion.Name = "lblContraGestion";
            this.lblContraGestion.Size = new System.Drawing.Size(76, 16);
            this.lblContraGestion.TabIndex = 10;
            this.lblContraGestion.Text = "Contraseña";
            // 
            // lblUsuarioGestion
            // 
            this.lblUsuarioGestion.AutoSize = true;
            this.lblUsuarioGestion.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUsuarioGestion.Location = new System.Drawing.Point(92, 211);
            this.lblUsuarioGestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioGestion.Name = "lblUsuarioGestion";
            this.lblUsuarioGestion.Size = new System.Drawing.Size(54, 16);
            this.lblUsuarioGestion.TabIndex = 9;
            this.lblUsuarioGestion.Text = "Usuario";
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(183, 253);
            this.txt_Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(132, 22);
            this.txt_Contrasenia.TabIndex = 8;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(183, 207);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(132, 22);
            this.txt_Usuario.TabIndex = 7;
            // 
            // btn_Generar
            // 
            this.btn_Generar.BackColor = System.Drawing.Color.Red;
            this.btn_Generar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Generar.Location = new System.Drawing.Point(83, 374);
            this.btn_Generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(107, 27);
            this.btn_Generar.TabIndex = 6;
            this.btn_Generar.Text = "Alta";
            this.btn_Generar.UseVisualStyleBackColor = false;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(754, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCancelar.Location = new System.Drawing.Point(268, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 31);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(445, 133);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(398, 248);
            this.dgvUsuarios.TabIndex = 17;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.Red;
            this.btnGrabar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGrabar.Location = new System.Drawing.Point(535, 431);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(189, 45);
            this.btnGrabar.TabIndex = 18;
            this.btnGrabar.Text = "Grabar cambios en BD";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 307);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(11, 16);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.Text = "-";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Red;
            this.btnModificar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnModificar.Location = new System.Drawing.Point(81, 439);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 27);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Brown;
            this.groupBox2.Controls.Add(this.cbIdioma);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(43, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 56);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "-";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(109, 21);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(131, 24);
            this.cbIdioma.TabIndex = 0;
            this.cbIdioma.SelectedIndexChanged += new System.EventHandler(this.cbIdioma_SelectedIndexChanged);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(871, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.lblContraGestion);
            this.Controls.Add(this.lblUsuarioGestion);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.btn_Generar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Label lblContraGestion;
        private System.Windows.Forms.Label lblUsuarioGestion;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbIdioma;
    }
}