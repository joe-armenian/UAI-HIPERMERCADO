using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Abstraccion;
using System.Collections;



namespace MPP
{
    public class MPPUsuario
    {
        Datos oDatos;
        Hashtable Hdatos;

        public bool Baja(BEUsuario Objeto)
        {
            if (Objeto.Usuario.Length > 2)
            {
                string Consulta_SQL = "Baja_Usuario";
                Hdatos=new Hashtable();
                Hdatos.Add("@Username",Objeto.Usuario);

                oDatos = new Datos();
                return oDatos.Escribir(Consulta_SQL,Hdatos);

            }
            else
            { return false; }
        }

        public bool Guardar(BEUsuario oUsuario)
        {
            oDatos = new Datos();
            string consulta = string.Empty;

            if (oUsuario.Usuario.Length > 0)
            {
                consulta = "Guardar_Usuario";
                Hdatos = new Hashtable();
                Hdatos.Add("@Username",oUsuario.Usuario);
                Hdatos.Add("@Password", oUsuario.Contrasenia);

                return oDatos.Escribir(consulta,Hdatos);
            }

            else
            {
                consulta = "Modificar_Usuario";
                Hdatos = new Hashtable();
                Hdatos.Add("@Password", oUsuario.Contrasenia);
                Hdatos.Add("@Username", oUsuario.Usuario);
                return oDatos.Escribir(consulta, Hdatos);
            }

           
        }

        public bool ListarObjeto(BEUsuario oUsuario)
        {
            string Consulta =string.Format("Listar_Usuario");
            Hdatos=new Hashtable();
            Hdatos.Add("@Username",oUsuario.Usuario);
            Hdatos.Add("@Password",oUsuario.Contrasenia);

            oDatos = new Datos();
            DataTable Tabla = oDatos.Leer(Consulta,Hdatos);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEUsuario oUser = new BEUsuario();
                    oUser.Usuario = (fila["Username"]).ToString();
                    oUser.Contrasenia = (fila["Password"]).ToString();
                    return true;
                }

            }
            return false;
        }

        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
