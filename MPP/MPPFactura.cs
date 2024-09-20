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
        public MPPFactura() 
        { 
            oDatos = new Datos(); 
        }

        public List<BEFactura> ListarTodo()
        { 
            ListaBEFactura = new List<BEFactura>();

            string consulta = "select Factura.Codigo,Estado,FechaFactura,Persona.CUIT,Persona.Nombre,Persona.Apellido,Persona.RazonSocial from Factura,Persona where Factura.CodPersona=Persona.Codigo";
            
            oTabla=new DataTable();
            
            oTabla = oDatos.Leer(consulta);

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

                    string consulta2 = string.Format("Select P.Codigo,P.Nombre,P.Precio,Factura_Producto.CantidadEspecifica from Factura_Producto,Producto as P, Factura as F" +
                        " where Factura_Producto.CodProducto=P.Codigo and Factura_Producto.CodFactura=F.Codigo and F.Codigo={0}", oBEFactura.Codigo);

                    oDatos2 = new Datos();
                    ListaBEProductos = new List<BEProducto>();
                    oTabla2 = new DataTable();
                    oTabla2 = oDatos2.Leer(consulta2);

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
                consulta = string.Format("insert into Factura_Producto(CodFactura,CodProducto,CantidadEspecifica) values ({0},{1},{2})", oBeFactura.Codigo, oBEProducto.Codigo, oBEProducto.Cantidad);
                return oDatos.Escribir(consulta);
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
                consulta = string.Format("insert into Factura(Estado,FechaFactura,CodPersona) values ('{0}','{1}',{2})", OBEFactura.Estado, OBEFactura.FechaFactura.ToString("yyyy-MM-dd"),OBEFactura.Persona.Codigo);
                return oDatos.Escribir(consulta);
            }
            else
            {
                return false;
            }
        }

        public bool FacturaAbonada(BEFactura oBEFactura)
        {
            string consulta;

            consulta = string.Format("update Factura SET Estado='{0}' where Codigo={1}","Abonado",oBEFactura.Codigo);
            return oDatos.Escribir(consulta);

        }


        public bool Baja(BEFactura OBEFactura)
        {
            throw new NotImplementedException();
        }

        public BEFactura ListarObjeto(BEFactura oBEFacutra)
        { throw new NotImplementedException(); }



    }
}
