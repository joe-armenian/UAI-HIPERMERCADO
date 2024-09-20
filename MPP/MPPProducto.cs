using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;


namespace MPP
{
    public class MPPProduct : IGestor<BEProducto>
    {
        Datos oDatos;
        List<BEProducto> ListaProductos;
        DataTable oTabla;
        BEProducto oBEProducto;

        public MPPProduct()
        {
            oDatos = new Datos();

        }

        public List<BEProducto> ListarTodo()
        {
            ListaProductos = new List<BEProducto>();
            string Consulta = "Select Codigo,Nombre,Precio,Cantidad From Producto";
            oTabla = oDatos.Leer(Consulta);

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
                consulta_sql = string.Format("insert into Producto(Nombre,Precio,Cantidad) values('{0}',{1},{2})",oBEProducto.Nombre,oBEProducto.Precio,oBEProducto.Cantidad);
            }
            else
            {
                consulta_sql = string.Format("update Producto set Nombre='{0}',Precio={1},Cantidad={2} where Codigo={3}",oBEProducto.Nombre, oBEProducto.Precio, oBEProducto.Cantidad,oBEProducto.Codigo);

            }

           return  oDatos.Escribir(consulta_sql);
        }

        public bool Baja(BEProducto oBEProd)
        {
            string consulta;
            oDatos = new Datos();

            if (oBEProd.Codigo != 0)
            {
                consulta = string.Format("delete from Producto where Codigo={0}", oBEProd.Codigo);
                return oDatos.Escribir(consulta);
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
