using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;


namespace DAL
{
    public class Datos
    {
        private SqlConnection oCnn = new SqlConnection(@"Data Source=.\;Initial Catalog=UAI-HIPERMERCADO;Integrated Security=True");

       
        DataTable oTabla;
        SqlCommand Cmd;
        SqlDataAdapter oDa;
        SqlTransaction MyTrans;

        public DataSet LeerDesconectado(string consulta)
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(consulta,oCnn);
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return Ds;
        }
        public DataTable Leer(string consulta, Hashtable Hdatos)
        {
            oTabla = new DataTable();
            Cmd=new SqlCommand(consulta,oCnn);
            Cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                oDa = new SqlDataAdapter(Cmd);
                if (Hdatos != null)
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }

                oDa.Fill(oTabla);

            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { 
                oCnn.Close();
            }
            return oTabla;
        }

        public bool LeerScalar(string consulta,Hashtable Hdatos)
        {
            oCnn.Open();
            Cmd = new SqlCommand(consulta, oCnn);
            Cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if ((Hdatos != null))
                {
                     
                    foreach (string dato in Hdatos.Keys)
                    {
                      
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
                int Respuesta = Convert.ToInt32(Cmd.ExecuteScalar());
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


        public bool Escribir(string Consulta_SQL,Hashtable Hdatos)
        {

            oCnn.Open(); 

            try
            {
                MyTrans = oCnn.BeginTransaction(); //creo objeto trans para la consulta
                Cmd = new SqlCommand(Consulta_SQL, oCnn, MyTrans); //instancio el cmd para ejecutar los comandos

                Cmd.CommandType = CommandType.StoredProcedure; //al command le digo que es tipo tSPP.
                if ((Hdatos != null))
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }

                int respuesta = Cmd.ExecuteNonQuery();
                MyTrans.Commit();
                return true;
            }

           

           
            catch (SqlException ex)
            {
                MyTrans.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                MyTrans.Rollback();
                return false;
                throw ex;
            }

            finally
            { oCnn.Close(); }



        }


        }
    }
