namespace UAI_HIPERMERCADO
{
    partial class MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uAIHIPERMERCADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONUSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARAPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uAIHIPERMERCADOToolStripMenuItem,
            this.gESTIONUSUARIOSToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.cERRARAPPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uAIHIPERMERCADOToolStripMenuItem
            // 
            this.uAIHIPERMERCADOToolStripMenuItem.Name = "uAIHIPERMERCADOToolStripMenuItem";
            this.uAIHIPERMERCADOToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.uAIHIPERMERCADOToolStripMenuItem.Text = "GESTION UAI HIPERMERCADO";
            this.uAIHIPERMERCADOToolStripMenuItem.Click += new System.EventHandler(this.uAIHIPERMERCADOToolStripMenuItem_Click);
            // 
            // gESTIONUSUARIOSToolStripMenuItem
            // 
            this.gESTIONUSUARIOSToolStripMenuItem.Name = "gESTIONUSUARIOSToolStripMenuItem";
            this.gESTIONUSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.gESTIONUSUARIOSToolStripMenuItem.Text = "GESTION USUARIOS";
            this.gESTIONUSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.gESTIONUSUARIOSToolStripMenuItem_Click);
            // 
            // cERRARAPPToolStripMenuItem
            // 
            this.cERRARAPPToolStripMenuItem.Name = "cERRARAPPToolStripMenuItem";
            this.cERRARAPPToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.cERRARAPPToolStripMenuItem.Text = "CERRAR APP";
            this.cERRARAPPToolStripMenuItem.Click += new System.EventHandler(this.cERRARAPPToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            this.iNFORMESToolStripMenuItem.Click += new System.EventHandler(this.iNFORMESToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1292, 1055);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uAIHIPERMERCADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARAPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONUSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
    }
}

