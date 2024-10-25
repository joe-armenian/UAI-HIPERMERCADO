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
    public class MPPIndividuo : IGestor<BEPersonaIndividuo>
    {
        Datos oDatos;
        List<BEPersonaIndividuo> BEListIndividuo;
        DataTable oTabla;
        BEPersonaIndividuo oBEIndividuo;
        Hashtable Hdatos;
        
        public MPPIndividuo() 
        {
            oDatos = new Datos();
        }

        public List<BEPersonaIndividuo> ListarTodo()
        {
            BEListIndividuo = new List<BEPersonaIndividuo>();

            string consulta = "Listar_Personas";
            oTabla = new DataTable();
            oTabla = oDatos.Leer(consulta,null);

            if (oTabla.Rows.Count > 0)
            {
                foreach (DataRow fila in oTabla.Rows)
                {
                    if (fila["RazonSocial"] is DBNull)
                    {
                        oBEIndividuo = new BEPersonaIndividuo();
                        oBEIndividuo.Codigo = Convert.ToInt32(fila["Codigo"]);
                        oBEIndividuo.CUIT = Convert.ToInt32(fila["CUIT"]);
                        oBEIndividuo.Nombre = fila["Nombre"].ToString();
                        oBEIndividuo.Apellido = fila["Apellido"].ToString();
                        BEListIndividuo.Add(oBEIndividuo);
                    }
                }
            }
            return BEListIndividuo;
        }


        public bool Guardar(BEPersonaIndividuo oBEIndividuo)
        {
            oDatos = new Datos();
            string consulta;

            if (oBEIndividuo.Codigo == 0)
            {
                consulta = "Guardar_PersonaIndividuo";
                Hdatos=new Hashtable();

                Hdatos.Add("@CUIT", oBEIndividuo.CUIT);
                Hdatos.Add("@Nombre",oBEIndividuo.Nombre);
                Hdatos.Add("@Apellido", oBEIndividuo.Apellido);
                return oDatos.Escribir(consulta, Hdatos);
                
               
            }
            else
            {
                consulta = "Modificar_PersonaIndividuo";
                Hdatos= new Hashtable();
                Hdatos.Add("@CUIT",oBEIndividuo.CUIT);
                Hdatos.Add("@Nombre",oBEIndividuo.Nombre);
                Hdatos.Add("@Apellido",oBEIndividuo.Apellido);
                Hdatos.Add("@Codigo", oBEIndividuo.Codigo);
                return oDatos.Escribir(consulta,Hdatos);
            }

         
        }
        public bool Baja(BEPersonaIndividuo oBEIndividuo)
        {
            oDatos=new Datos();
            string consulta;

            if (oBEIndividuo.Codigo != 0)
            {
                consulta = "Baja_PersonaIndividuo";
                Hdatos= new Hashtable();
                Hdatos.Add("@Codigo", oBEIndividuo.Codigo);
                return oDatos.Escribir(consulta, Hdatos);
            }
            else
            {
                return false;
            }

        }

        public BEPersonaIndividuo ListarObjeto(BEPersonaIndividuo oBEIndivduo)
        {
            throw new NotImplementedException();
        }




    }
}
