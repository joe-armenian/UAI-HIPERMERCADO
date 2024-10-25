using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;
using Abstraccion;
using System.Collections;

namespace MPP
{
    public class MPPProduct : IGestor<BEProducto>
    {
        Datos oDatos;
        List<BEProducto> ListaProductos;
        DataTable oTabla;
        BEProducto oBEProducto;
        Hashtable Hdatos;
        

        public MPPProduct()
        {
            oDatos = new Datos();

        }

        public List<BEProducto> ListarTodo()
        {
            ListaProductos = new List<BEProducto>();
            string Consulta = "Listar_Productos";
            
            oTabla = oDatos.Leer(Consulta, null);

            if (oTabla.Rows.Count > 0)
            {
                foreach (DataRow fila in oTabla.Rows)
                {

                    oBEProducto = new BEProducto();
                    oBEProducto.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEProducto.Nombre = fila["Nombre"].ToString();
                    oBEProducto.Precio = Convert.ToInt32(fila["Precio"]);
                    oBEProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                    ListaProductos.Add(oBEProducto);
                }
            }
            return ListaProductos;

        }


        public bool Guardar(BEProducto oBEProducto)
        {
            string consulta_sql;
            oDatos = new Datos();


            if (oBEProducto.Codigo == 0)
            {
                consulta_sql = "Guardar_Producto";
                Hdatos=new Hashtable();
                Hdatos.Add("@Nombre", oBEProducto.Nombre);
                Hdatos.Add("@Precio", oBEProducto.Precio);
                Hdatos.Add("@Cantidad", oBEProducto.Cantidad);

                return oDatos.Escribir(consulta_sql,Hdatos);

            }
            else
            {
                consulta_sql = "Modificar_Producto";
                Hdatos = new Hashtable();
                Hdatos.Add("@Nombre", oBEProducto.Nombre);
                Hdatos.Add("@Precio", oBEProducto.Precio);
                Hdatos.Add("@Cantidad", oBEProducto.Cantidad);
                Hdatos.Add("@Codigo",oBEProducto.Codigo);
                return oDatos.Escribir(consulta_sql,Hdatos);

            }
        }

        public bool Baja(BEProducto oBEProd)
        {
            string consulta;
            oDatos = new Datos();

            if (oBEProd.Codigo != 0)
            {
                consulta = "Baja_Producto";
                Hdatos=new Hashtable();
                Hdatos.Add("@Codigo",oBEProd.Codigo);
                return oDatos.Escribir(consulta,Hdatos);
            }
            else
            {
                return false;
            }

        }

        public BEProducto ListarObjeto(BEProducto oBEProd)
        {
            throw new NotImplementedException();
        }















    }
}
