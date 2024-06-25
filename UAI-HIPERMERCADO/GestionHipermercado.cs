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
using UAI_HIPERMERCADO.Facturacion;

namespace UAI_HIPERMERCADO
{
    public partial class GestionHipermercado : Form
    {
        public GestionHipermercado()
        {
            InitializeComponent();
            LstPersonasIndividuos = new List<PersonaIndividuo>();
            LstPymes = new List<PersonaPyme>();
            LstProductos = new List<Producto>();
            LstFacturas = new List<Factura>();
            
           
        }

        List<PersonaIndividuo> LstPersonasIndividuos;
        List<PersonaPyme> LstPymes;
        List<Producto> LstProductos;
        List<Factura> LstFacturas;


        #region ObjetosParaElFormulario
        PersonaIndividuo oPersonaIndividuo;
        PersonaPyme oPersonaPyme;
        Producto oProducto;
        Factura oFactura;
       

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

        private void GestionHipermercado_Load(object sender, EventArgs e)
        {
            cbNombreProducto.DataSource = Enum.GetValues(typeof(EnumParaProductos.ProductosVarios));
            MessageBox.Show("Usted ingresara a la seccion de hipermercado,gracias por utilizar nuestro servicio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region AltaPersona
        private void btnAlta_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar que el campo CUIT no esté vacío
                if (txtCUIT.Text == string.Empty)
                {
                    throw new ArgumentException("Por favor complete el campo CUIT.");
                }

                // Si se seleccionó la opción Individuo
                if (rbIndividuo.Checked)
                {
                    // Verificar que se hayan ingresado nombre y apellido
                    if (txtApellido.Text == string.Empty || txtNombre.Text == string.Empty)
                    {
                        throw new ArgumentException("Por favor complete los campos nombre y apellido.");
                    }

                    // Crear una nueva instancia de PersonaIndividuo
                    oPersonaIndividuo = new PersonaIndividuo();
                    oPersonaIndividuo.CUIT = Convert.ToInt64(txtCUIT.Text);
                    oPersonaIndividuo.Nombre = txtNombre.Text;
                    oPersonaIndividuo.Apellido = txtApellido.Text;

                    // Agregar la persona individuo a la lista correspondiente
                    LstPersonasIndividuos.Add(oPersonaIndividuo);

                    // Actualizar los datos en el DataGridView
                    CargarPersonaIndData();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Cliente Persona creado con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos de entrada
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtCUIT.Clear();
                }
                // Si se seleccionó la opción PYME
                else if (rbPyme.Checked)
                {
                    // Verificar que se haya ingresado la razón social
                    if (txtRazonSocial.Text == string.Empty)
                    {
                        throw new ArgumentException("Por favor complete el campo razón social.");
                    }

                    // Crear una nueva instancia de PersonaPyme
                    oPersonaPyme = new PersonaPyme();
                    oPersonaPyme.CUIT = Convert.ToInt64(txtCUIT.Text);
                    oPersonaPyme.RazonSocial = txtRazonSocial.Text;

                    // Agregar la persona pyme a la lista correspondiente
                    LstPymes.Add(oPersonaPyme);

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Cliente PYME creado con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar los datos en el DataGridView
                    CargarPymeData();

                    // Limpiar los campos de entrada
                    txtCUIT.Clear();
                    txtRazonSocial.Clear();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: Por favor ingrese un número válido para el CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        #region CargarDatosAData
        public void CargarPymeData()
        {
            dgvPyme.DataSource = null;
            dgvPyme.DataSource = LstPymes;
        }
        public void CargarPersonaIndData()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = LstPersonasIndividuos;
            dgvPersonas.Refresh();

        }

        public void CargarProductoAdata()
        {
            cbProducto.DataSource = null;
            cbProducto.DataSource = LstProductos;
            cbProducto.Refresh();
        }

        public void CargarFacturaAdata()
        {
            dgvFactura.DataSource = null;
            dgvFactura.DataSource = LstFacturas;
            //propiedad de la grilla para autosize de columnas
            this.dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        #endregion




        #region BajaPersona
        private void btnBaja_Click(object sender, EventArgs e)
        {

            DialogResult Respuesta;

            try
            {

                if (txtCUIT.Text == string.Empty)
                {
                    throw new ArgumentException("Por favor complete el campo cuit");
                }

                long cuit = Convert.ToInt64(txtCUIT.Text);

                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    foreach (PersonaIndividuo item in LstPersonasIndividuos)
                    {
                        if (cuit == item.CUIT)
                        {
                            Respuesta = MessageBox.Show("Se va a borrar el elemento de la lista", "borrar", MessageBoxButtons.YesNo);

                            if (Respuesta == DialogResult.Yes)
                            {
                                LstPersonasIndividuos.Remove(item);
                                MessageBox.Show("Cliente persona borrado de la lista con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }

                     
                    }

                   


                    CargarPersonaIndData();
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtCUIT.Clear();
                   



                }
                else if (dgvPyme.SelectedRows.Count > 0)
                {
                    foreach (PersonaPyme item in LstPymes)
                    {
                        if (cuit == item.CUIT)
                        {
                            Respuesta = MessageBox.Show("Se va a borrar el elemento de la lista", "borrar", MessageBoxButtons.YesNo);

                            if (Respuesta == DialogResult.Yes)
                            {
                                LstPymes.Remove(item);
                                MessageBox.Show("Cliente PYME borrado de la lista con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        
                    }


                    CargarPymeData();
                    txtCUIT.Clear();
                    txtRazonSocial.Clear();
                    
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

                    oPersonaIndividuo = new PersonaIndividuo();
                    oPersonaIndividuo.CUIT = Convert.ToInt64(txtCUIT.Text);
                    oPersonaIndividuo.Nombre = txtNombre.Text;
                    oPersonaIndividuo.Apellido = txtApellido.Text;

                    bool busqueda = false;

                    foreach (PersonaIndividuo item in LstPersonasIndividuos)
                    {
                        if (oPersonaIndividuo.CUIT == item.CUIT)
                        {
                            item.Nombre = oPersonaIndividuo.Nombre;
                            item.Apellido = oPersonaIndividuo.Apellido;
                            MessageBox.Show("Cliente Persona modificado de la lista con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            busqueda = true;
                            break;
                        }
                        
                    }

                    if (busqueda == false) 
                    {
                        throw new ClienteNoEncontrado();
                    }

                    CargarPersonaIndData();

                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtCUIT.Clear();
                }
                else if (dgvPyme.SelectedRows.Count > 0)
                {
                    if (txtRazonSocial.Text == string.Empty)
                    {
                        throw new ArgumentException("Debe completar el campo razon social");
                    }

                    oPersonaPyme = new PersonaPyme();
                    oPersonaPyme.CUIT = Convert.ToInt64(txtCUIT.Text);
                    oPersonaPyme.RazonSocial = txtRazonSocial.Text;

                    bool busqueda = false; 

                    foreach (PersonaPyme item in LstPymes)
                    {
                        if (oPersonaPyme.CUIT == item.CUIT)
                        {
                            item.RazonSocial = oPersonaPyme.RazonSocial;
                            MessageBox.Show("Cliente PYME modificado de la lista con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            busqueda = true;
                            break;
                        }
                       
                    }

                    if (busqueda == false)
                    {
                        throw new ClienteNoEncontrado();
                    }

                    CargarPymeData();
                    txtRazonSocial.Clear();
                    txtCUIT.Clear();
                }

                else
                {
                    throw new ArgumentException("Debe seleccionar al menos un cliente");
                }
            }

            catch (ClienteNoEncontrado ex)
            {
                MessageBox.Show($"{ex.Message}");
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

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProducto.Text == string.Empty || txtPrecioProducto.Text == string.Empty || txtCantidad.Text == string.Empty)
                {
                    throw new ArgumentException("Debe completar todos los campos para producto");
                }
                else
                {
                    oProducto = new Producto(Convert.ToInt32(txtCodigoProducto.Text), cbNombreProducto.SelectedItem.ToString(), Convert.ToDouble(txtPrecioProducto.Text), Convert.ToInt32(txtCantidad.Text));
                    LstProductos.Add(oProducto);

                    CargarProductoAdata();
                    txtPrecioProducto.Clear();
                    txtCodigoProducto.Clear();
                    txtCantidad.Clear();
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

        private void btnAsociarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = Convert.ToInt32(txtCantidadEspecifica.Text);

                if (dgvFactura.SelectedRows.Count > 0 && cbProducto.SelectedItem != null)
                {
                    oFactura = (Factura)dgvFactura.SelectedRows[0].DataBoundItem;
                    oProducto = (Producto)cbProducto.SelectedItem;

                    if (cantidad == 0)
                    {
                        throw new ArgumentException("Debe agregar una cantidad valida");
                    }

                    if (oFactura.Persona == oPersonaIndividuo)
                    {

                        if (cantidad > 0)
                        {
                            if (cantidad > oProducto.Cantidad)
                            {
                                throw new ArgumentException("No hay sufiente cantidad en stock");
                            }
                            if (oProducto.Cantidad == 0)
                            {
                                LstProductos.Remove(oProducto);
                                CargarProductoAdata();
                            }
                            oProducto.Cantidad -= cantidad;

                            Producto productoAsociado = new Producto();
                            {
                                productoAsociado.Nombre = oProducto.Nombre;
                                productoAsociado.Precio = oProducto.Precio;
                                productoAsociado.Codigo = oProducto.Codigo;
                                productoAsociado.Cantidad = cantidad;
                            }
                            CargarProductoAdata();
                            LstFacturas.Remove(oFactura);
                            oFactura.Estado = "Pendiente de pago";
                            oFactura.ListaProductos.Add(productoAsociado);
                            LstFacturas.Add(oFactura);
                            CargarFacturaAdata();
                        }


                    }

                    else if (oFactura.Persona == oPersonaPyme)
                    {

                        if (cantidad > 0)
                        {
                            if (cantidad > oProducto.Cantidad)
                            {
                                throw new ArgumentException("No hay sufiente cantidad en stock");
                            }
                            if (oProducto.Cantidad == 0)
                            {
                                LstProductos.Remove(oProducto);
                                CargarProductoAdata();
                            }
                            oProducto.Cantidad -= cantidad;
                            Producto productoAsociado = new Producto();
                            {
                                productoAsociado.Nombre = oProducto.Nombre;
                                productoAsociado.Precio = oProducto.Precio;
                                productoAsociado.Codigo = oProducto.Codigo;
                                productoAsociado.Cantidad = cantidad;
                            }
                            CargarProductoAdata();
                            LstFacturas.Remove(oFactura);
                            oFactura.Estado = "Pendiente de pago";
                            oFactura.ListaProductos.Add(productoAsociado);
                            LstFacturas.Add(oFactura);
                            CargarFacturaAdata();
                       
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Debe seleccionar una factura y un producto para asociar");
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

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    oPersonaIndividuo = (PersonaIndividuo)dgvPersonas.SelectedRows[0].DataBoundItem;

                    oFactura = new Factura(oPersonaIndividuo, "Asociado sin productos");


                    LstFacturas.Add(oFactura);

                    CargarFacturaAdata();
                    dgvPersonas.ClearSelection();
                }
                else if (dgvPyme.SelectedRows.Count > 0)
                {
                    oPersonaPyme = (PersonaPyme)dgvPyme.SelectedRows[0].DataBoundItem;

                    oFactura = new Factura(oPersonaPyme, "Asociado sin productos");

                    LstFacturas.Add(oFactura);
                    CargarFacturaAdata();

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

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPyme.ClearSelection();
        }

        private void dgvPyme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPersonas.ClearSelection();
        }
        

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oFactura = (Factura)dgvFactura.CurrentRow.DataBoundItem;

            dgvFactProductos.DataSource = null;

            dgvFactProductos.DataSource = oFactura.ListaProductos;

            dgvFactProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            if (oFactura.Persona is ITCalculable oPersona)
            {
                lblImpuestos.Text = oFactura.Persona.CalcularImpuestoPais(oFactura.ListaProductos).ToString();
                oPersona.CalcularTotalSinImpuesto(oFactura.ListaProductos);
                lblTotalSImpuestos.Text = oPersona.Total.ToString();
                lblCuitCliente.Text = oFactura.Persona.retonarCuit().ToString();
            }



        }

        private void btnPagarProducto_Click(object sender, EventArgs e)
        {
           
            if (dgvFactura.SelectedRows.Count > 0 && oFactura.ListaProductos != null)
            {

                oFactura = (Factura)dgvFactura.SelectedRows[0].DataBoundItem;

                if (oFactura.Persona == oPersonaIndividuo)
                {

                    LstFacturas.Remove(oFactura);
                    oFactura.Estado = "Pagado";
                    LstFacturas.Add(oFactura);
                    CargarFacturaAdata();
                }

                else if (oFactura.Persona == oPersonaPyme)
                {
                    LstFacturas.Remove(oFactura);
                    oFactura.Estado = "Pagado";
                    LstFacturas.Add(oFactura);
                    CargarFacturaAdata();
                }

            }
        }

        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;

                if (txtCodigoProducto.Text == string.Empty)
                {
                    throw new ArgumentException("Debe completar el campo codigo!");
                }

                int cod = Convert.ToInt32(txtCodigoProducto.Text);

                if (cbProducto.SelectedItem != null)
                {
                    foreach (Producto item in LstProductos)
                    {
                        if (cod == item.Codigo)
                        {
                            Respuesta = MessageBox.Show("Se va a borrar el producto del combo", "borrar", MessageBoxButtons.YesNo);

                            if (Respuesta == DialogResult.Yes)
                            {
                                LstProductos.Remove(item);
                                break;
                            }
                        }
                    }

                    CargarProductoAdata();
                    txtPrecioProducto.Clear();
                    txtCodigoProducto.Clear();
                    txtCantidad.Clear();

                    MessageBox.Show("Producto borrado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    throw new ArgumentException("Por favor seleccione al menos un producto");
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

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProducto.Text == string.Empty || txtCantidad.Text == string.Empty || txtPrecioProducto.Text == string.Empty)
                {
                    throw new ArgumentException("Debe completar todos los campos para modificar!");
                }

                if (cbProducto.SelectedItem == null)
                {
                    throw new ArgumentException("Debe seleccionar un producto!");
                }

                int cod = Convert.ToInt32(txtCodigoProducto.Text);
                oProducto = new Producto();
                oProducto.Nombre = cbNombreProducto.Text;
                oProducto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                oProducto.Precio = Convert.ToDouble(txtPrecioProducto.Text);

                bool busqueda = false;
                if (cbProducto.SelectedItem != null)
                {
                    foreach (Producto item in LstProductos)
                    {
                        if (cod == item.Codigo)
                        {
                            item.Nombre = oProducto.Nombre;
                            item.Cantidad = oProducto.Cantidad;
                            item.Precio = oProducto.Precio;
                            MessageBox.Show("Producto modificado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            busqueda = true;
                            break;
                        }
                    }


                    if (busqueda == false)
                    {
                        throw new ProductoNoEncontrado();
                    }

                    CargarProductoAdata();
                    txtPrecioProducto.Clear();
                    txtCodigoProducto.Clear();
                    txtCantidad.Clear();

                }
            }
            catch (ProductoNoEncontrado ex)
            {
                MessageBox.Show($"{ex.Message}");
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

        private void btnClonar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProducto.SelectedItem != null)
                {
                    oProducto = (Producto)cbProducto.SelectedItem;
                    cbProductoClon.Items.Add(oProducto.Clone());
                    MessageBox.Show("Producto clonado con exito");

                }
                else
                {
                    throw new ArgumentException("Debe haber algun producto para clonar");
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
    }
}
