using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BE;
using Abstraccion;
using System.Collections;

namespace MPP
{
    public class MPPyme:IGestor<BEPersonaPyme>
    {
        Datos oDatos;
        List<BEPersonaPyme> BEListPyme;
        DataTable oTabla;
        BEPersonaPyme oBEPyme;
        Hashtable Hdatos;
        public MPPyme()
        {
            oDatos=new Datos();
        }


        public List<BEPersonaPyme> ListarTodo()
        {
           BEListPyme=new List<BEPersonaPyme>();
            string consulta = "Listar_Personas";
            oTabla = new DataTable();
            oTabla = oDatos.Leer(consulta, null);

            if (oTabla.Rows.Count > 0)
            {
                foreach (DataRow fila in oTabla.Rows)
                {
                    if (fila["Nombre"] is DBNull)
                    {
                        oBEPyme = new BEPersonaPyme();
                        oBEPyme.Codigo = Convert.ToInt32(fila["Codigo"]);
                        oBEPyme.CUIT = Convert.ToInt32(fila["CUIT"]);
                        oBEPyme.RazonSocial = fila["RazonSocial"].ToString();
                        BEListPyme.Add(oBEPyme);    
                    }
                }
            }
            return BEListPyme;

        }

        public bool Guardar(BEPersonaPyme oBEPyme)
        {
            oDatos = new Datos();
            string consulta;

            if (oBEPyme.Codigo == 0)
            {
                consulta = "Guardar_PersonaPyme";
                Hdatos=new Hashtable();
                Hdatos.Add("@CUIT", oBEPyme.CUIT);
                Hdatos.Add("@RazonSocial", oBEPyme.RazonSocial);

                return oDatos.Escribir(consulta, Hdatos);

            }
            else
            {
                consulta = "Modificar_PersonaPyme";
                Hdatos = new Hashtable();
                Hdatos.Add("@CUIT",oBEPyme.CUIT);
                Hdatos.Add("@RazonSocial",oBEPyme.RazonSocial);
                Hdatos.Add("@Codigo",oBEPyme.Codigo);

                return oDatos.Escribir(consulta, Hdatos);
            }

        }
        public bool Baja(BEPersonaPyme oBEPyme)
        {
            oDatos=new Datos();
            string consulta;
            Hdatos = new Hashtable();
            Hdatos.Add("@Codigo",oBEPyme.Codigo);

            if (oBEPyme.Codigo != 0)
            {
                consulta = "Baja_PersonaPyme";
                return oDatos.Escribir(consulta, Hdatos);
            }
            else
            {
                return false;
            }

        }

        public BEPersonaPyme ListarObjeto(BEPersonaPyme oBEPyme)
        {
            throw new NotImplementedException();
        }




    }
}
