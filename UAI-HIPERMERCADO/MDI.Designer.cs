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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uAIHIPERMERCADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARAPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uAIHIPERMERCADOToolStripMenuItem,
            this.cERRARAPPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uAIHIPERMERCADOToolStripMenuItem
            // 
            this.uAIHIPERMERCADOToolStripMenuItem.Name = "uAIHIPERMERCADOToolStripMenuItem";
            this.uAIHIPERMERCADOToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.uAIHIPERMERCADOToolStripMenuItem.Text = "GESTION UAI HIPERMERCADO";
            this.uAIHIPERMERCADOToolStripMenuItem.Click += new System.EventHandler(this.uAIHIPERMERCADOToolStripMenuItem_Click);
            // 
            // cERRARAPPToolStripMenuItem
            // 
            this.cERRARAPPToolStripMenuItem.Name = "cERRARAPPToolStripMenuItem";
            this.cERRARAPPToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cERRARAPPToolStripMenuItem.Text = "CERRAR APP";
            this.cERRARAPPToolStripMenuItem.Click += new System.EventHandler(this.cERRARAPPToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 607);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI ";
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
    }
}

