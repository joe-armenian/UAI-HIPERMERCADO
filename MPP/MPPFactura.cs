using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BE;
using System.Data.Odbc;
using System.Runtime.Remoting.Messaging;
using Abstraccion;
using System.Collections;

namespace MPP
{
    public class MPPFactura : IGestor<BEFactura>
    {
        Datos oDatos;
        Datos oDatos2;
        List<BEFactura> ListaBEFactura;
        DataTable oTabla;
        DataTable oTabla2;
        BEFactura oBEFactura;
        List<BEProducto> ListaBEProductos;
        BEProducto oBEProducto;
        Hashtable Hdatos;
        public MPPFactura() 
        { 
            oDatos = new Datos(); 
        }

        public List<BEFactura> ListarTodo()
        { 
            ListaBEFactura = new List<BEFactura>();

            string consulta = "Listar_Facturas";
            
            oTabla=new DataTable();
            
            oTabla = oDatos.Leer(consulta,null);

            if (oTabla.Rows.Count > 0)
            {
                foreach (DataRow fila in oTabla.Rows)
                {
                    oBEFactura = new BEFactura();
                    oBEFactura.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEFactura.Estado = (fila["Estado"]).ToString();
                    oBEFactura.FechaFactura = Convert.ToDateTime(fila["FechaFactura"]);

                    if (fila["RazonSocial"] is DBNull)
                    {
                        BEPersonaIndividuo oBEPIndividuo = new BEPersonaIndividuo();
                        oBEPIndividuo.CUIT = Convert.ToInt64(fila["CUIT"]);
                        oBEPIndividuo.Nombre = fila["Nombre"].ToString();
                        oBEPIndividuo.Apellido = fila["Apellido"].ToString();
                        oBEFactura.Persona = oBEPIndividuo;
                    }
                    else
                    {
                        BEPersonaPyme oBEPyme = new BEPersonaPyme();
                        oBEPyme.CUIT = Convert.ToInt64(fila["CUIT"]);
                        oBEPyme.RazonSocial = fila["RazonSocial"].ToString();
                        oBEFactura.Persona = oBEPyme;
                    }
                    //comienza pruebas

                    

                    oDatos2 = new Datos();
                    Hdatos=new Hashtable();
                    Hdatos.Add("@CodFactura", oBEFactura.Codigo);

                    string consulta2 = "Listar_FacturaProductosC";

                    oTabla2 = new DataTable();
                    oTabla2 = oDatos2.Leer(consulta2,Hdatos);
                    ListaBEProductos = new List<BEProducto>();

                    if (oTabla2.Rows.Count > 0)
                    {
                        foreach (DataRow fila2 in oTabla2.Rows)
                        {
                            oBEProducto = new BEProducto();
                            oBEProducto.Codigo = Convert.ToInt32(fila2["Codigo"]);
                            oBEProducto.Nombre = fila2["Nombre"].ToString();
                            oBEProducto.Precio = Convert.ToInt32(fila2["Precio"]);
                            oBEProducto.Cantidad = Convert.ToInt32(fila2["CantidadEspecifica"]);
                            ListaBEProductos.Add(oBEProducto);
                        }

                        oBEFactura.ListaProductos = ListaBEProductos;
                    }

                    ListaBEFactura.Add(oBEFactura);

                }
            }

            return ListaBEFactura;


        }

        public bool AsociarProducto(BEFactura oBeFactura, BEProducto oBEProducto)
        {
            string consulta;

            if (oBeFactura.Codigo != 0 && oBEProducto.Codigo != 0)
            {
                consulta = "Asociar_Producto";
                Hdatos=new Hashtable();
                Hdatos.Add("@CodFactura", oBeFactura.Codigo);
                Hdatos.Add("@CodProducto", oBEProducto.Codigo);
                Hdatos.Add("@CantidadEspecifica",oBEProducto.Cantidad);
                return oDatos.Escribir(consulta, Hdatos);
            }
            else
            {
                return false;
            }
        }


        public bool Guardar(BEFactura OBEFactura)
        {
            string consulta;

            if (OBEFactura.Codigo == 0)
            {
                consulta = "Guardar_Factura";
                Hdatos = new Hashtable();
                Hdatos.Add("@Estado",OBEFactura.Estado);
                Hdatos.Add("@FechaFactura", OBEFactura.FechaFactura.ToString("yyyy/MM/dd"));
                Hdatos.Add("@CodPersona",OBEFactura.Persona.Codigo);
                return oDatos.Escribir(consulta,Hdatos);


            }
            else
            {
                return false;
            }
        }

        public bool FacturaAbonada(BEFactura oBEFactura)
        {
            string consulta = "Factura_Abonado";

            Hdatos=new Hashtable();

            Hdatos.Add("@Codigo",oBEFactura.Codigo);
            Hdatos.Add("@Estado","Abonado");
            
            return oDatos.Escribir(consulta, Hdatos);



        }


        public bool Baja(BEFactura OBEFactura)
        {
            throw new NotImplementedException();
        }

        public BEFactura ListarObjeto(BEFactura oBEFacutra)
        { throw new NotImplementedException(); }



    }
}
