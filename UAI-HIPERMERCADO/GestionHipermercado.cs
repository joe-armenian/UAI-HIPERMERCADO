using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;


namespace UAI_HIPERMERCADO
{
    public partial class GestionHipermercado : Form
    {
        public GestionHipermercado()
        {
            InitializeComponent();
           
            oBLLProd = new BLLProducto();
            oBEProducto= new BEProducto();
            oBLLPyme = new BLLPersonaPyme();
            oBLLPIndividuo = new BLLPersonaIndividuo();
            oBEPersonaIndividuo = new BEPersonaIndividuo();
            oBLLFactura=new BLLFactura();
            
        }



        #region ObjetosParaElFormulario
        
        BLLProducto oBLLProd;
        BEProducto oBEProducto;
        BLLPersonaPyme oBLLPyme;
        BLLPersonaIndividuo oBLLPIndividuo;
        BEPersonaIndividuo oBEPersonaIndividuo;
        BEPersonaPyme oBEPyme;
        BLLFactura oBLLFactura;
        BEFactura oBEFactura;
        #endregion


        #region ControlDeRadioButtons
        private void rbIndividuo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIndividuo.Checked)
            {
                gpPyme.Enabled = false;
                gpPersona.Enabled = true;
            }
        }

        private void rbPyme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPyme.Checked)
            {
                gpPersona.Enabled = false;
                gpPyme.Enabled = true;
            }


        }
        #endregion


        #region LimpiezaTxtParaPersona
        void LimpiarPyme()
        {
            txtCUIT.Text = string.Empty;
            txtRazonSocial.Text= string.Empty;  
        }

        void LimpiarIndividuo()
        {
            txtApellido.Text= string.Empty; 
            txtNombre.Text= string.Empty;
            txtCUIT.Text= string.Empty;
            txtCodigo.Text= string.Empty;
        }

        #endregion


        #region ReCargarDatos
        public void CargarPersonaIndData()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = oBLLPIndividuo.ListarTodo();
           

        }
        public void CargarPymeData()
        {
            dgvPyme.DataSource = null;
            dgvPyme.DataSource = oBLLPyme.ListarTodo();
        }

        void CargarFactura()
        {
            dgvFactura.DataSource = null;
            dgvFactura.DataSource = oBLLFactura.ListarTodo();
        }

        public void CargarProductoAdata()
        {
            cbProducto.DataSource = null;
            cbProducto.DataSource = oBLLProd.ListarTodo();
            cbProducto.Refresh();
        }
        #endregion


        #region LoadGestionHiperMercado

        private void GestionHipermercado_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Usted ingresara a la seccion de hipermercado,gracias por utilizar nuestro servicio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarProductoAdata();
            CargarPymeData();
            CargarPersonaIndData();
            CargarFactura();

        }
        #endregion



        #region AltaPersona
        private void btnAlta_Click(object sender, EventArgs e)
        {

            try
            {
               
                if (txtCUIT.Text == string.Empty)
                {
                    throw new ArgumentException("Por favor complete el campo CUIT.");
                }

                
                if (rbIndividuo.Checked)
                {
                  
                   if (txtApellido.Text == string.Empty || txtNombre.Text == string.Empty)
                   {
                      throw new ArgumentException("Por favor complete los campos nombre y apellido.");
                   }

                    
                       oBEPersonaIndividuo=new BEPersonaIndividuo();
                       oBEPersonaIndividuo.CUIT = Convert.ToInt64(txtCUIT.Text);
                       oBEPersonaIndividuo.Nombre = txtNombre.Text;
                       oBEPersonaIndividuo.Apellido = txtApellido.Text;
                       oBLLPIndividuo.Guardar(oBEPersonaIndividuo);

                  
                         CargarPersonaIndData();
                         LimpiarIndividuo();

                     
                      MessageBox.Show("Cliente Persona creado con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    }
                  
                    else if (rbPyme.Checked)
                    {
                     
                      if (txtRazonSocial.Text == string.Empty)
                       {
                           throw new ArgumentException("Por favor complete el campo razón social.");
                      }
                      
                             oBEPyme = new BEPersonaPyme();
                             oBEPyme.CUIT = Convert.ToInt64(txtCUIT.Text);
                             oBEPyme.RazonSocial = txtRazonSocial.Text;

                      
                           oBLLPyme.Guardar(oBEPyme);

                     
                       CargarPymeData();
                   
                        LimpiarPyme();
                 
                    MessageBox.Show("Cliente PYME creado con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error de validación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



        #region BajaPersona
        private void btnBaja_Click(object sender, EventArgs e)
        {

            DialogResult Respuesta;

            try
            {

              

                if (dgvPersonas.SelectedRows.Count > 0)
                {

                    Respuesta = MessageBox.Show("Se va a borrar el indivuo ", "borrar", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        AsignarIndivdual();
                        if (oBLLPIndividuo.Baja(oBEPersonaIndividuo))
                        {
                            CargarPersonaIndData();
                            LimpiarIndividuo();
                        }
                        else
                        {
                            throw new ArgumentException("No se ha podido eliminar a la persona");
                        }
                    }
                    

                }
                else if (dgvPyme.SelectedRows.Count > 0)
                {

                    Respuesta = MessageBox.Show("Se va a borrar la pyme ", "borrar", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        AsignarPyme();

                        if (oBLLPyme.Baja(oBEPyme))
                        {
                            CargarPymeData();
                            LimpiarPyme();
                        }
                        else
                        {
                            throw new ArgumentException("No se ha podido eliminar a la pyme");
                        }
                    }

                }

                else
                {
                    throw new ArgumentException("Debe seleccionar al menos un cliente");
                }
                
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }




        #endregion



        #region CellContentPersonas

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPyme.ClearSelection();
            oBEPersonaIndividuo = (BEPersonaIndividuo)dgvPersonas.CurrentRow.DataBoundItem;
            txtCodigo.Text = oBEPersonaIndividuo.Codigo.ToString();
            txtCUIT.Text = oBEPersonaIndividuo.CUIT.ToString();
            txtNombre.Text = oBEPersonaIndividuo.Nombre.ToString();
            txtApellido.Text = oBEPersonaIndividuo.Apellido.ToString();
            txtRazonSocial.Text = string.Empty;
            rbIndividuo.Checked = true;


        }

        private void dgvPyme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPersonas.ClearSelection();
            oBEPyme = (BEPersonaPyme)dgvPyme.CurrentRow.DataBoundItem;
            txtCodigo.Text = oBEPyme.Codigo.ToString();
            txtCUIT.Text = oBEPyme.CUIT.ToString();
            txtRazonSocial.Text = oBEPyme.RazonSocial.ToString();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            rbPyme.Checked = true;
        }
        #endregion


        #region AsignacionesParaABMPersonas
        void AsignarIndivdual()
        {
            oBEPersonaIndividuo.Codigo = Convert.ToInt32(txtCodigo.Text);
            oBEPersonaIndividuo.Nombre=txtNombre.Text;
            oBEPersonaIndividuo.Apellido=txtApellido.Text;
            oBEPersonaIndividuo.CUIT= Convert.ToInt64(txtCUIT.Text);
        }

        void AsignarPyme()
        {
            oBEPyme.Codigo = Convert.ToInt32(txtCodigo.Text);
            oBEPyme.RazonSocial = txtRazonSocial.Text;
            oBEPyme.CUIT= Convert.ToInt64(txtCUIT.Text);
        }
        #endregion


        #region ModificarPersona
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCUIT.Text == string.Empty)
                {
                    throw new ArgumentException("Por favor complete el campo cuit");
                }

                if (dgvPersonas.SelectedRows.Count > 0)
                {


                    if (txtApellido.Text == string.Empty && txtNombre.Text == string.Empty)
                    {
                        throw new ArgumentException("Debe completar los campos nombre y apellido");
                    }

                    AsignarIndivdual();
                    oBLLPIndividuo.Guardar(oBEPersonaIndividuo);
                    LimpiarIndividuo();
                    CargarPersonaIndData();
                }

                else if (dgvPyme.SelectedRows.Count > 0)
                {
                    if (txtRazonSocial.Text == string.Empty)
                   {
                        throw new ArgumentException("Debe completar el campo razon social");
                   }

                    AsignarPyme();
                    oBLLPyme.Guardar(oBEPyme);
                    LimpiarPyme();
                    CargarPymeData();
                
                }

                else
                {
                    throw new ArgumentException("Debe seleccionar al menos un cliente");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

            

        }

        void LimpiarProducto()
        {
            txtCantidad.Text= string.Empty; 
            txtPrecioProducto.Text= string.Empty;
            txtNombreProducto.Text= string.Empty;
            txtCodigoProducto.Text= string.Empty;   
        }


        #endregion


        #region AltaProducto
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProducto.Text == string.Empty || txtPrecioProducto.Text == string.Empty || txtCantidad.Text == string.Empty)
                {
                    throw new ArgumentException("Debe completar todos los campos para producto");
                }
                else
                {
                    oBEProducto=new BEProducto();
                    oBEProducto.Nombre=this.txtNombreProducto.Text;
                    oBEProducto.Precio = Convert.ToInt32(this.txtPrecioProducto.Text);
                    oBEProducto.Cantidad = Convert.ToInt32(this.txtCantidad.Text);

                    oBLLProd.Guardar(oBEProducto);
                    CargarProductoAdata();
                    LimpiarProducto();
                  MessageBox.Show("Producto creado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
           


        }

        #endregion


        #region AsociarProducto
        private void btnAsociarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = Convert.ToInt32(txtCantidadEspecifica.Text);

                if (dgvFactura.SelectedRows.Count > 0 && cbProducto.SelectedItem != null)
                {
                    oBEFactura = (BEFactura)dgvFactura.SelectedRows[0].DataBoundItem;
                    oBEProducto = (BEProducto)cbProducto.SelectedItem;

                    if (cantidad == 0)
                    {
                        throw new ArgumentException("Debe agregar una cantidad valida");
                    }

                    if (cantidad > oBEProducto.Cantidad)
                    {
                        throw new ArgumentException("Debe agregar una cantidad valida");
                    }

                    if (oBEProducto.Cantidad == 0)
                    {

                    }
                    if (cantidad > 0)
                    {
                        BEProducto productoAsociado = new BEProducto();
                        {
                            productoAsociado.Nombre = oBEProducto.Nombre;
                            productoAsociado.Precio = oBEProducto.Precio;
                            productoAsociado.Codigo = oBEProducto.Codigo;
                            productoAsociado.Cantidad = cantidad;
                        }

                        oBEProducto.Cantidad -= cantidad;
                        oBLLProd.Guardar(oBEProducto);
                        oBLLFactura.AsociarProducto(oBEFactura, productoAsociado);
                        CargarFactura();
                        CargarProductoAdata();
                    }
                } 
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }


        }
        #endregion



        #region CrearFactura
        private void btnCrearFactura_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
               {
                    oBEPersonaIndividuo = (BEPersonaIndividuo)dgvPersonas.CurrentRow.DataBoundItem;
                    oBEFactura = new BEFactura();
                    oBEFactura.Estado = "Asociado";
                    oBEFactura.FechaFactura=DateTime.Now;
                    oBEFactura.Persona = oBEPersonaIndividuo;
                    oBLLFactura.Guardar(oBEFactura);
                    CargarFactura();
                    dgvPersonas.ClearSelection();
               }
             else if (dgvPyme.SelectedRows.Count > 0)
             {
                    oBEPyme=(BEPersonaPyme)dgvPyme.CurrentRow.DataBoundItem;
                    oBEFactura=new BEFactura();
                    oBEFactura.Estado = "Asociado";
                    oBEFactura.FechaFactura = DateTime.Now;
                    oBEFactura.Persona=oBEPyme; 
                    oBLLFactura.Guardar (oBEFactura);
                    CargarFactura();
                    dgvPyme.ClearSelection();
             }
               else
                {
                    throw new ArgumentException("Debe seleccionar al menos un cliente para crear factura");
               }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }
        #endregion



        #region CellContentFactura
        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEFactura = (BEFactura)dgvFactura.CurrentRow.DataBoundItem;

            dgvFactProductos.DataSource = null;

            dgvFactProductos.DataSource = oBEFactura.ListaProductos;

            dgvFactProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (oBEFactura.Persona is BEPersonaIndividuo)
            {
                lblCuitCliente.Text =(oBLLPIndividuo.retonarCuit(oBEFactura.Persona)).ToString();
             
                if (oBEFactura.ListaProductos != null)
                {
                    lblImpuestos.Text = (oBLLPIndividuo.CalcularImpuestoPais(oBEFactura.ListaProductos).ToString());
                    lblTotalNormal.Text = (oBLLPIndividuo.CalcularPrecioNormal(oBEFactura.ListaProductos).ToString());
                    lblTotalConImpuestos.Text = (oBLLPIndividuo.CalcularPrecioCompra(oBEFactura.ListaProductos).ToString());


                }
                else
                {
                    lblImpuestos.Text=string.Empty;
                    lblTotalConImpuestos.Text = string.Empty;
                    lblTotalNormal.Text=string.Empty;
                }
            

            }
            else
            {

                lblCuitCliente.Text =(oBLLPyme.retonarCuit(oBEFactura.Persona)).ToString();
               
                if (oBEFactura.ListaProductos != null)
                {
                    lblImpuestos.Text = (oBLLPyme.CalcularImpuestoPais(oBEFactura.ListaProductos).ToString());
                    lblTotalNormal.Text = (oBLLPyme.CalcularPrecioNormal(oBEFactura.ListaProductos).ToString());
                    lblTotalConImpuestos.Text = (oBLLPyme.CalcularPrecioCompra(oBEFactura.ListaProductos).ToString());
                }
                else
                {
                    lblImpuestos.Text = string.Empty;
                    lblTotalNormal.Text = string.Empty;
                    lblTotalConImpuestos.Text = string.Empty;
                }
               
            }


        }
        #endregion


        #region PagarProducto
        private void btnPagarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFactura.SelectedRows.Count > 0)
                {

                    oBEFactura = (BEFactura)dgvFactura.CurrentRow.DataBoundItem;

                    if (oBEFactura.Persona is BEPersonaIndividuo)
                    {
                        double TraerTotal = 0;
                        TraerTotal = (oBLLPIndividuo.CalcularPrecioCompra(oBEFactura.ListaProductos));

                        if (Convert.ToDouble(txtAbonoFactura.Text) == TraerTotal)
                        {
                            oBLLFactura.FacturaAbonada(oBEFactura);
                            CargarFactura();
                            txtAbonoFactura.Text = string.Empty;
                            MessageBox.Show("Factura abonada con exito,muchas gracias", "Los esperamos nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("El monto ingresado no es correcto,recuerde que los decimales son con un punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (oBEFactura.Persona is BEPersonaPyme)
                    {
                        double TraerTotal = 0;
                        TraerTotal = (oBLLPyme.CalcularPrecioCompra(oBEFactura.ListaProductos));
                        if (Convert.ToDouble(txtAbonoFactura.Text) == TraerTotal)
                        {
                            oBLLFactura.FacturaAbonada(oBEFactura);
                            CargarFactura();
                            txtAbonoFactura.Text = string.Empty;
                            MessageBox.Show("Factura abonada con exito,muchas gracias", "Los esperamos nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("El monto ingresado no es correcto,recuerde que los decimales son con un punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una factura para poder abonar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            }
        #endregion


        #region BajaProducto
        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                AsignarProd();
                 Respuesta = MessageBox.Show("Se va a borrar el producto del combo", "borrar", MessageBoxButtons.YesNo);
                  if (Respuesta == DialogResult.Yes)
                {
                    if (oBLLProd.Baja(oBEProducto))
                    {
                        CargarProductoAdata();
                        LimpiarProducto();
                        MessageBox.Show("Producto borrado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new ArgumentException("No se ha podido eliminar el producto");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
           
        }
        #endregion


        #region AsignarProductoParaABM
        void AsignarProd()
        {
            oBEProducto.Codigo = Convert.ToInt32(txtCodigoProducto.Text);
            oBEProducto.Nombre=txtNombreProducto.Text;
            oBEProducto.Precio = Convert.ToInt32(txtPrecioProducto.Text);
            oBEProducto.Cantidad = Convert.ToInt32((txtCantidad.Text));
        }
        #endregion



        #region ModificarProducto
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                   if (txtNombreProducto.Text == string.Empty || txtCantidad.Text == string.Empty || txtPrecioProducto.Text == string.Empty)
                   {
                      throw new ArgumentException("Debe completar todos los campos para modificar!");
                   }

                  if (cbProducto.SelectedItem == null)
                  {
                        throw new ArgumentException("Debe seleccionar un producto!");
                  }

                AsignarProd();
                oBLLProd.Guardar(oBEProducto);
                CargarProductoAdata();
                LimpiarProducto();
                MessageBox.Show("Producto modificado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }


        }
        #endregion



        #region ProductoIndexChange(Para no tener errores con los txt)
        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            oBEProducto = (BEProducto)this.cbProducto.SelectedItem;

            if (oBEProducto != null)
            { txtCodigoProducto.Text = oBEProducto.Codigo.ToString();
                txtNombreProducto.Text = oBEProducto.Nombre.ToString();
                txtCantidad.Text=oBEProducto.Cantidad.ToString();
                txtPrecioProducto.Text=oBEProducto.Precio.ToString();
            }
        }
        #endregion



        #region Limpiezas
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCUIT.Text = string.Empty;
            txtRazonSocial.Text = string.Empty; 
            txtCodigo.Text = string.Empty;
            rbIndividuo.Checked = false;
            rbPyme.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtAbonoFactura_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
