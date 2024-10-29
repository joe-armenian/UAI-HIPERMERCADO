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

        private void btn_Generar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Usuario.Text==string.Empty || txt_Contrasenia.Text==string.Empty)
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
    }
}
