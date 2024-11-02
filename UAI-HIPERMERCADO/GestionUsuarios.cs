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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;
using System.Threading;

namespace UAI_HIPERMERCADO
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
            oBLLUsuario=new BLLUsuario();
            oBEUsuario = new BEUsuario();
        }
        BEUsuario oBEUsuario;
        BLLUsuario oBLLUsuario;

        DataSet Ds;
        DataRow Dr;
        SqlDataAdapter Da;

        SqlConnection oCnn = new SqlConnection(@"Data Source=.\;Initial Catalog=UAI-HIPERMERCADO;Integrated Security=True");

        
        void Limpiar()
        {
            txt_Contrasenia.Clear();
            txt_Usuario.Clear();
        }
        public static bool ValidarEntradaALFoSIM(string linea)
        {
            return Regex.IsMatch(linea, @"^[A-Za-z]+$|^[0-9]+$|^[A-Za-z0-9]+$");
        }


        private void btn_Generar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Usuario.Text==string.Empty || txt_Contrasenia.Text==string.Empty || !ValidarEntradaALFoSIM(txt_Usuario.Text) || !ValidarEntradaALFoSIM(txt_Contrasenia.Text))
                {
                    throw new ArgumentException("Debe completar los campos correctamente");
                }

                Dr = Ds.Tables[0].NewRow();
                Dr ["Username"] = txt_Usuario.Text.ToString();
                Dr["Password"] = Encripta.Encriptar(txt_Contrasenia.Text);

                Ds.Tables[0].Rows.Add(Dr);
                Limpiar();
            }
            catch (ArgumentException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Desea borrarlo?", "?",MessageBoxButtons.YesNo);
                    {
                        ((DataRowView)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Row.Delete();

                        MessageBox.Show("Borrado correctamente");

                    }

                }
                Limpiar();
            }

            catch (ArgumentException ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void CargarGrilla()
        {
            Ds = new DataSet();
            Ds=oBEUsuario.ListarDS();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Ds.Tables[0];
            
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            cbIdioma.DataSource = Enum.GetValues(typeof(Idioma));
        }

        


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Da = new SqlDataAdapter("Select*From Usuarios",oCnn);

            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
            Da.UpdateCommand=Cb.GetUpdateCommand();
            Da.DeleteCommand=Cb.GetDeleteCommand();
            Da.InsertCommand=Cb.GetInsertCommand();
            Da.ContinueUpdateOnError = true;

            Da.Update(Ds.Tables[0]);

            MessageBox.Show("Guardado correctammente","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_Usuario.Text= dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Contrasenia.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Usuario.Text == string.Empty || txt_Contrasenia.Text == string.Empty || !ValidarEntradaALFoSIM(txt_Usuario.Text) || !ValidarEntradaALFoSIM(txt_Contrasenia.Text))
                {
                    throw new ArgumentException("Debe completar los campos correctamente");
                }
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    Dr = ((DataRowView)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Row;
                    //MODIFICAMOS LOS CAMPOS EN EL DATAROW QUE HABIAMOS OBTENIDO SELECCIONANDO LA FILA DE LA GRILLA
                    Dr["Username"] = txt_Usuario.Text.ToString();
                    Dr["Password"] = Encripta.Encriptar(txt_Contrasenia.Text);

                    MessageBox.Show("Modificado con exito");
                }
                Limpiar();
            }
            catch (ArgumentException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        enum Idioma
        {
            Español,
            Armenio,
            Ingles
        }

        void CambiarIdioma(string Cultura)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Cultura);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Cultura);

            groupBox2.Text = Recursos.Recurso.GroupBoxGestion;
            lblUsuarioGestion.Text = Recursos.Recurso.NombreUsuarioGestion;
            lblContraGestion.Text = Recursos.Recurso.ContraUsuarioGestion;
            btn_Generar.Text = Recursos.Recurso.BotonAltaGestion;
            btn_Baja.Text = Recursos.Recurso.BotonBajaGestion;
            btnModificar.Text = Recursos.Recurso.BotonCancelarGestion;
            btnCancelar.Text = Recursos.Recurso.BotonModificarGestion;
            btnGrabar.Text = Recursos.Recurso.BotonGrabarCambios;
            lblMensaje.Text = Recursos.Recurso.LblMensaje;




        }

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(cbIdioma.SelectedIndex.ToString());

            switch (A)
            {
                case 0:
                    CambiarIdioma("es-AR");
                    break;
                case 1:
                    CambiarIdioma("hy-AM");
                    break;
                case 2:
                    CambiarIdioma("en-US");
                    break;
            }
        }
    }
}
