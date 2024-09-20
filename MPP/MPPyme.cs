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
    public class MPPyme:IGestor<BEPersonaPyme>
    {
        Datos oDatos;
        List<BEPersonaPyme> BEListPyme;
        DataTable oTabla;
        BEPersonaPyme oBEPyme;

        public MPPyme()
        {
            oDatos=new Datos();
        }


        public List<BEPersonaPyme> ListarTodo()
        {
           BEListPyme=new List<BEPersonaPyme>();
            string consulta = "select * from Persona";
            oTabla = new DataTable();
            oTabla = oDatos.Leer(consulta);

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
                consulta = string.Format("Insert into Persona(CUIT,RazonSocial) values ({0},'{1}')",oBEPyme.CUIT,oBEPyme.RazonSocial);
            }
            else
            {
                consulta = string.Format("update Persona set CUIT={0},RazonSocial='{1}' where Codigo={2}",oBEPyme.CUIT,oBEPyme.RazonSocial,oBEPyme.Codigo);
            }

            return oDatos.Escribir(consulta);
        }
        public bool Baja(BEPersonaPyme oBEPyme)
        {
            oDatos=new Datos();
            string consulta;
            if (oBEPyme.Codigo != 0)
            {
                consulta = string.Format("delete from Persona where Codigo={0}", oBEPyme.Codigo);
                return oDatos.Escribir(consulta);
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
