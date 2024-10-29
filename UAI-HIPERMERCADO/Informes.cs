using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using BE;
using BLL;


namespace UAI_HIPERMERCADO
{
    public partial class Informes : Form
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

        #endregion


        public Informes()
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
           
             
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public List<BEResumenInformes> LeerXML()
        {
            var consulta = from informe in XElement.Load("ResumenInformes.XML")
                           .Elements("informe")
                           select new BEResumenInformes
                           {
                               Descripcion=Convert.ToString(informe.Element("descripcion").Value).Trim(),
                               FechaReferencia=Convert.ToString(informe.Element("fechaReferencia").Value).Trim(),
                               FacturasEmitidas = Convert.ToInt32(informe.Element("facturasEmitidas").Value),
                               FacturasAbonadas = Convert.ToInt32(informe.Element("facturasAbonadas").Value),
                               ProductosEnStock = Convert.ToInt32(informe.Element("productosEnStock").Value),
                               PymesRegistradas = Convert.ToInt32(informe.Element("pymesRegistradas").Value),
                               IndividuosRegistrados = Convert.ToInt32(informe.Element("individuosRegistrados").Value),
                               TotalRecaudado = Convert.ToDouble(informe.Element("totalRecaudado").Value)
                           };

            // Convertimos la consulta a una lista de objetos tipo Informe
            List<BEResumenInformes> LstResumen = consulta.ToList<BEResumenInformes>();
            return LstResumen;
        }


        public void AgregarOActualizarXML(BEResumenInformes resumen)
        {
            XDocument xmlDoc = XDocument.Load("ResumenInformes.XML");


            // Acceder al nodo "informes" dentro de "resumen"
             xmlDoc.Element("informes").Add(new XElement("informe",
                new XElement("descripcion", resumen.Descripcion),
                new XElement("fechaReferencia", resumen.FechaReferencia),
                new XElement("facturasEmitidas", resumen.FacturasEmitidas),
                new XElement("facturasAbonadas", resumen.FacturasAbonadas),
                new XElement("productosEnStock", resumen.ProductosEnStock),
                new XElement("pymesRegistradas", resumen.PymesRegistradas),
                new XElement("individuosRegistrados", resumen.IndividuosRegistrados),
                new XElement("totalRecaudado", resumen.TotalRecaudado)));

            // Guardar el XML actualizado
            xmlDoc.Save("ResumenInformes.XML");
            CargarListBox();
        }

        private BEResumenInformes ActualizarDatos()
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

            personaspymesreg=oBEPersonaPyme.Count;
            personasindividuosreg=oBEPersonaIndividuo.Count;


            CargarDatosPiramide(new Dictionary<string, int>
            {
                { "Facturas Emitidas", facturasemitidas },
                { "Facturas Abonadas", facturasabonadas },
                { "Productos en Stock", productosenStock },
                { "Pymes Registradas", personaspymesreg },
                { "Individuos Registrados", personasindividuosreg }
            });


            return new BEResumenInformes
            {
                FacturasEmitidas = facturasemitidas,
                FacturasAbonadas = facturasabonadas,
                ProductosEnStock = productosenStock,
                PymesRegistradas = personaspymesreg,
                IndividuosRegistrados = personasindividuosreg,
                TotalRecaudado = totalRecaudado
            };







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
            CargarListBox();


        }


        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            try
            {
                BEResumenInformes oBEResumenActual = new BEResumenInformes();
                oBEResumenActual = ActualizarDatos(); //me traigo todo con los ultimso datos

                if (txtDescripcion.Text == string.Empty || dtpFacturaR.Text == string.Empty)
                {
                    throw new ArgumentException("Error en el ingreso de datos");
                }

                //para agregarle mass sentido al XML le agrego estas 2 propiedades adicionales.. 

                oBEResumenActual.Descripcion = txtDescripcion.Text;
                oBEResumenActual.FechaReferencia=dtpFacturaR.Text.Trim();
                
                AgregarOActualizarXML(oBEResumenActual);
                CargarListBox();// 
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

        void CargarListBox()
        {
            List<BEResumenInformes> lstResumenes = new List<BEResumenInformes>();
            lstResumenes = LeerXML();
            lstFacturasE.DataSource = null;
            lstFacturasE.DataSource=lstResumenes;
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

        private void InicializarGraficoPiramide()
        {
            chartPiramide.Titles.Clear();
            chartPiramide.ChartAreas.Clear();
            chartPiramide.Series.Clear();

            Title titulo = new Title("Resumen Total UAI HIPERMERCADO");
            titulo.Font = new Font("Calibri", 14, FontStyle.Bold);
            chartPiramide.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            chartPiramide.ChartAreas.Add(area);
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

        private void btnActualizarChart_Click(object sender, EventArgs e)
        {
            ActualizarChartProducto();

        }
    }
}
