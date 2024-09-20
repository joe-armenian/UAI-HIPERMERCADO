using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BE;

namespace MPP
{
    public class MPPIndividuo : IGestor<BEPersonaIndividuo>
    {
        Datos oDatos;
        List<BEPersonaIndividuo> BEListIndividuo;
        DataTable oTabla;
        BEPersonaIndividuo oBEIndividuo;
        public MPPIndividuo() 
        {
            oDatos = new Datos();
        }

        public List<BEPersonaIndividuo> ListarTodo()
        {
            BEListIndividuo = new List<BEPersonaIndividuo>();

            string consulta = "select * from Persona";
            oTabla = new DataTable();
            oTabla = oDatos.Leer(consulta);

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
                consulta = string.Format("Insert into Persona(CUIT,Nombre,Apellido) values ({0},'{1}','{2}')",oBEIndividuo.CUIT,oBEIndividuo.Nombre,oBEIndividuo.Apellido);
            }
            else
            {
                consulta = string.Format("update Persona set CUIT={0},Nombre='{1}',Apellido='{2}' where Codigo={3}",oBEIndividuo.CUIT,oBEIndividuo.Nombre,oBEIndividuo.Apellido,oBEIndividuo.Codigo);
            }

            return oDatos.Escribir(consulta);
        }
        public bool Baja(BEPersonaIndividuo oBEIndividuo)
        {
            oDatos=new Datos();
            string consulta;

            if (oBEIndividuo.Codigo != 0)
            {
                consulta = string.Format("Delete from Persona where Codigo={0}", oBEIndividuo.Codigo);
                return oDatos.Escribir(consulta);
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
