using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class Datos
    {
        private SqlConnection oCnn = new SqlConnection(@"Data Source=.\;Initial Catalog=UAI-HIPERMERCADO;Integrated Security=True");

        SqlCommand cmd;

        public DataTable Leer(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(consulta, oCnn);

                Da.Fill(tabla);

            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { 
                oCnn.Close();
            }
            return tabla;
        }

        public bool LeerScalar(string consulta)
        {
            oCnn.Open();
            cmd = new SqlCommand(consulta, oCnn);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                oCnn.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            finally
            {
                oCnn.Close();
            }
        }


        public bool Escribir(string Consulta_SQL)
        {

            oCnn.Open(); //abro conexion
            SqlTransaction myTrans; //creo objeto trans para la consulta
            cmd = new SqlCommand(); //instancio el cmd para ejecutar los comandos
            myTrans = oCnn.BeginTransaction(); //le paso la ruta y hace el begin.

            cmd.CommandType = CommandType.Text; //al command le digo que es tipo texto.
            cmd.Connection = oCnn; //le paso la conexion.
            cmd.CommandText = Consulta_SQL; //le paso la consulta recibida x parametro.
            try
            {
                cmd.Transaction = myTrans; //al objeto command, le paso la trans.
                int respuesta = cmd.ExecuteNonQuery(); //si se ejecuta bien
                myTrans.Commit(); //hace el commit.
                return true;
            }
            catch (SqlException ex)
            {
                myTrans.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }

            finally
            { oCnn.Close(); }



        }


        }
    }
