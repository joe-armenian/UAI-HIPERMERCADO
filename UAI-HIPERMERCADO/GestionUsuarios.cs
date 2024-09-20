using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Seguridad;

namespace UAI_HIPERMERCADO
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
            oBLLUsuario=new BLLUsuario();
        }
        BEUsuario oBEUsuario;
        BLLUsuario oBLLUsuario;

        void Limpiar()
        {
            txt_Contrasenia.Clear();
            txt_Usuario.Clear();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {

            try
            {
                oBEUsuario = new BEUsuario();
                oBEUsuario.Usuario = txt_Usuario.Text;
                oBEUsuario.Contrasenia = Encripta.Encriptar(txt_Contrasenia.Text);
                oBLLUsuario.Guardar(oBEUsuario);
                Limpiar();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            oBEUsuario = new BEUsuario();
            oBEUsuario.Usuario=txt_Usuario.Text;
            oBLLUsuario.Baja(oBEUsuario);
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
