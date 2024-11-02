namespace UAI_HIPERMERCADO
{
    partial class LoGin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoGin));
            this.uC_LOGIN1 = new UAI_HIPERMERCADO.UC_LOGIN();
            this.SuspendLayout();
            // 
            // uC_LOGIN1
            // 
            this.uC_LOGIN1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_LOGIN1.Location = new System.Drawing.Point(40, 33);
            this.uC_LOGIN1.Name = "uC_LOGIN1";
            this.uC_LOGIN1.Size = new System.Drawing.Size(563, 343);
            this.uC_LOGIN1.TabIndex = 0;
            this.uC_LOGIN1.Load += new System.EventHandler(this.uC_LOGIN1_Load_1);
            // 
            // LoGin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(678, 415);
            this.Controls.Add(this.uC_LOGIN1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoGin";
            this.Text = "LoGin";
            this.Load += new System.EventHandler(this.LoGin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_LOGIN uC_LOGIN1;
    }
}