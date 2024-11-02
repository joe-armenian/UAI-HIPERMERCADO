using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using BE;
using BLL;


namespace UAI_HIPERMERCADO
{
    public partial class Reportes_Informess : Form
    {


        #region ObjetosInformes
        List<BEFactura> oBeFacturas;
       BLLFactura oBLLFactura;
       List<BEProducto> oBeProductos;
        BLLProducto oBLLProducto;
        List<BEPersonaIndividuo> oBEPersonaIndividuo;
        BLLPersonaIndividuo oBLLPersonaIndividuo;
        List<BEPersonaPyme> oBEPersonaPyme;
        BLLPersonaPyme oBLLPersonaPyme;
        BLLPersona oBLLPersona;

        BEResumenInformes oBEResumenActual;
        BLLInforme oBLLResumen;



        #endregion


        public Reportes_Informess()
        {
            InitializeComponent();
            oBLLFactura= new BLLFactura();  
            oBeFacturas= new List<BEFactura>();
            oBeProductos=new List<BEProducto>();
            oBLLProducto= new BLLProducto();
            oBLLPersonaIndividuo=new BLLPersonaIndividuo();
            oBLLPersonaPyme=new BLLPersonaPyme();
            InicializarGrafico();
            ActualizarChartProducto();
            InicializarGraficoPiramide();
            ActualizarChartPiramide();
            oBLLResumen = new BLLInforme();

            ActualizarDgvXML();



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       



        private void  ActualizarDatos()
        {
            oBeFacturas = oBLLFactura.ListarTodo();
            oBeProductos = oBLLProducto.ListarTodo();
            oBEPersonaIndividuo = oBLLPersonaIndividuo.ListarTodo();
            oBEPersonaPyme=oBLLPersonaPyme.ListarTodo();

            int facturasemitidas = 0;
            int facturasabonadas = 0;
            int productosenStock = 0;
            int personaspymesreg = 0;
            int personasindividuosreg = 0;

            double totalRecaudado = 0;

            foreach (var factura in oBeFacturas)
            {
                if (factura.Estado == "Asociado" || factura.Estado=="Abonado")
                { 
                    facturasemitidas++;
                }

                if (factura.Estado == "Abonado")
                {
                    facturasabonadas++;
                    if (factura.Persona is BEPersonaIndividuo)
                    {
                        totalRecaudado += oBLLPersonaIndividuo.CalcularPrecioCompra(factura.ListaProductos);
                    }
                    else
                    {
                        totalRecaudado += oBLLPersonaPyme.CalcularPrecioCompra(factura.ListaProductos);
                    }
                }

            }

            foreach (var producto in oBeProductos)
            {
                if (producto.Cantidad > 1)
                {
                    productosenStock++;
                }
            }

            


            lblFacturasAbonadas.Text = facturasabonadas.ToString();
            lblFacturasEmitidas.Text = facturasemitidas.ToString();
            lblProductos.Text = productosenStock.ToString();
            lblPymesRegistradas.Text=oBEPersonaPyme.Count.ToString();   
            lblIndividuosRegistrados.Text=oBEPersonaIndividuo.Count.ToString();
            lblTotalRecaudado.Text=totalRecaudado.ToString();


            txtFacturasEmitidas.Text = facturasemitidas.ToString();
            txtFacturasAbonadas.Text = facturasabonadas.ToString();
            txtProductos.Text = productosenStock.ToString();
            txtPymes.Text = oBEPersonaPyme.Count.ToString();
            txtIndividios.Text = oBEPersonaIndividuo.Count.ToString();
            txtTotal.Text = totalRecaudado.ToString();
            

            






        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarDatos();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            ActualizarDatos();

        }

        public static bool ValidarEntradaALFoSIM(string linea)
        {
            return Regex.IsMatch(linea, @"^[A-Za-z]+$|^[0-9]+$|^[A-Za-z0-9]+$");
        }


        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            try
            {
                oBEResumenActual = new BEResumenInformes();
             

                if (txtDescripcion.Text == string.Empty || dtpFacturaR.Text == string.Empty || !ValidarEntradaALFoSIM(txtDescripcion.Text) || !ValidarEntradaALFoSIM(txtCodigo.Text))
                {
                    throw new ArgumentException("Error en el ingreso de datos");
                }

                //para agregarle mass sentido al XML le agrego estas 2 propiedades adicionales.. 
                oBEResumenActual.Codigo = Convert.ToInt32(txtCodigo.Text); 
                oBEResumenActual.Descripcion = txtDescripcion.Text;
                oBEResumenActual.FechaReferencia=dtpFacturaR.Text.Trim();
                oBEResumenActual.FacturasEmitidas = Convert.ToInt32(txtFacturasEmitidas.Text);
                oBEResumenActual.FacturasAbonadas = Convert.ToInt32(txtFacturasAbonadas.Text);
                oBEResumenActual.ProductosEnStock = Convert.ToInt32(txtProductos.Text);
                oBEResumenActual.PymesRegistradas = Convert.ToInt32(txtPymes.Text);
                oBEResumenActual.IndividuosRegistrados = Convert.ToInt32(txtIndividios.Text);
                oBEResumenActual.TotalRecaudado = Convert.ToInt32(txtTotal.Text);

                oBLLResumen.AgregarXML(oBEResumenActual);
                ActualizarDgvXML();

                MessageBox.Show("Resumen guardado exitosamente.");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ActualizarDgvXML()
        {
            dgvInformes.DataSource = null;
            dgvInformes.DataSource = oBLLResumen.LeerXML();
        }

        private void InicializarGrafico()
        {
            chartProductos.Titles.Clear();
            chartProductos.ChartAreas.Clear();
            chartProductos.Series.Clear();

            Title titulo = new Title("Distribución de Productos en Stock");
            titulo.Font = new Font("Calibri", 14, FontStyle.Bold);
            chartProductos.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chartProductos.ChartAreas.Add(area);
        }

        private void ActualizarChartProducto()
        {
           
            var productos = oBLLProducto.ListarTodo();

            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Pie;

            
            foreach (var producto in productos)
            {
                if (producto.Cantidad > 0)  
                {
                    serie.Points.AddXY(producto.Nombre, producto.Cantidad);
                }
            }

            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "{P0}"; 

            chartProductos.Series.Add(serie);
        }

        private void ActualizarChartPiramide()
        {

            oBeFacturas = oBLLFactura.ListarTodo();
            oBeProductos = oBLLProducto.ListarTodo();
            oBEPersonaIndividuo = oBLLPersonaIndividuo.ListarTodo();
            oBEPersonaPyme = oBLLPersonaPyme.ListarTodo();

            int facturasemitidas = 0;
            int facturasabonadas = 0;
            int productosenStock = 0;
            int personaspymesreg = 0;
            int personasindividuosreg = 0;


            foreach (var factura in oBeFacturas)
            {
                if (factura.Estado == "Asociado" || factura.Estado == "Abonado")
                {
                    facturasemitidas++;
                }

                if (factura.Estado == "Abonado")
                {
                    facturasabonadas++;
                }

            }

            foreach (var producto in oBeProductos)
            {
                if (producto.Cantidad > 1)
                {
                    productosenStock++;
                }
            }

            personaspymesreg = oBEPersonaPyme.Count;
            personasindividuosreg = oBEPersonaIndividuo.Count;

            CargarDatosPiramide(new Dictionary<string, int>
            {
                { "Facturas Emitidas", facturasemitidas },
                { "Facturas Abonadas", facturasabonadas },
                { "Productos en Stock", productosenStock },
                { "Pymes Registradas", personaspymesreg },
                { "Individuos Registrados", personasindividuosreg }
            });

            
        }

        private void CargarDatosPiramide(Dictionary<string, int> datos)
        {
            Series serie = new Series("Resumen");
            serie.ChartType = SeriesChartType.Pyramid;

            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.Key, dato.Value);
            }

            serie.IsValueShownAsLabel = true;
            chartPiramide.Series.Add(serie);
        }

        private void InicializarGraficoPiramide()
        {
            chartPiramide.Titles.Clear();
            chartPiramide.ChartAreas.Clear();
            chartPiramide.Series.Clear();

            Title titulo = new Title("Resumen Total UAI HIPERMERCADO");
            titulo.Font = new Font("Calibri", 14, FontStyle.Bold);
            chartPiramide.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chartPiramide.ChartAreas.Add(area);
        }

       

        private void btnActualizarChart_Click(object sender, EventArgs e)
        {
            ActualizarChartProducto();

        }

        private void dgvInformes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInformes.SelectedRows.Count > 0)
                {
                    oBEResumenActual = (BEResumenInformes)dgvInformes.CurrentRow.DataBoundItem;

                    if (oBEResumenActual.Codigo == Convert.ToInt32(txtCodigo.Text))
                    {
                        oBEResumenActual.Descripcion = txtDescripcion.Text;
                        oBEResumenActual.FechaReferencia = dtpFacturaR.Text.Trim();
                        oBEResumenActual.FacturasEmitidas = Convert.ToInt32(txtFacturasEmitidas.Text);
                        oBEResumenActual.FacturasAbonadas = Convert.ToInt32(txtFacturasAbonadas.Text);
                        oBEResumenActual.ProductosEnStock = Convert.ToInt32(txtProductos.Text);
                        oBEResumenActual.PymesRegistradas = Convert.ToInt32(txtPymes.Text);
                        oBEResumenActual.IndividuosRegistrados = Convert.ToInt32(txtIndividios.Text);
                        oBEResumenActual.TotalRecaudado = Convert.ToInt32(txtTotal.Text);

                        oBLLResumen.ModificarXML(oBEResumenActual);
                        ActualizarDgvXML();

                        MessageBox.Show("Resumen modificado exitosamente.");
                    }
                    else
                    {
                        throw new ArgumentException("Debe ingresar el codigo correcto para el resumen seleccionado");
                    }
                }
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message);}
            catch (Exception ex) { throw ex; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInformes.SelectedRows.Count > 0)
                {
                    oBEResumenActual = (BEResumenInformes)dgvInformes.CurrentRow.DataBoundItem;

                    if (oBEResumenActual.Codigo == Convert.ToInt32(txtCodigo.Text) && txtCodigo.Text!=string.Empty)
                    {
                        

                        oBLLResumen.BajaXML(oBEResumenActual);
                        ActualizarDgvXML();

                        MessageBox.Show("Resumen ELIMINADO exitosamente.");
                    }
                    else
                    {
                        throw new ArgumentException("Debe ingresar el codigo correcto para el resumen seleccionado");
                    }
                }
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { throw ex; }
        }

        private void chartProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
