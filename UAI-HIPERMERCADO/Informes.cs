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
             
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarDatos()
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
    }
}
