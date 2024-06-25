using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAI_HIPERMERCADO
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        public GestionHipermercado oGestionHipermercado;
        

        private void uAIHIPERMERCADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oGestionHipermercado == null)
            {
                oGestionHipermercado = new GestionHipermercado();
                oGestionHipermercado.MdiParent = this;
                oGestionHipermercado.Show();
            }
        }

        private void cERRARAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
