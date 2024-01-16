using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DatosDictionary
    {
        //string CadenaC = @"Data Source=.\SQLEXPRESS02;Initial Catalog=ADO_en_Capas;Integrated Security=True";
        string CadenaC = ConfigurationManager.ConnectionStrings["AdoEnCapas"].ToString();
        //private SqlConnection oCnn = new SqlConnection(@"Data Source=.\SQLEXPRESS02;Initial Catalog=ADO_en_Capas;Integrated Security=True");
        private SqlConnection oCnn;
        private SqlTransaction Tranx;
        private SqlCommand Cmd;

        public DatosDictionary()
        {
            oCnn =  new SqlConnection(CadenaC);
        }

        // Con Dictionary
        public DataTable Leer(string consulta, Dictionary<string, object> parametros)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador;
            //paso la consulta y el objeto conection en el constructor
            Cmd = new SqlCommand(consulta, oCnn)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                adaptador = new SqlDataAdapter(Cmd);

                if (parametros != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (var parametro in parametros)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            adaptador.Fill(tabla);
            return tabla;
        }


        public bool LeerScalar(string consulta, Dictionary<string, object> parametros)
        {
            oCnn.Open();
            //uso el constructor del objeto Command al instanciar el objeto
            Cmd = new SqlCommand(consulta, oCnn)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                if (parametros != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (var parametro in parametros)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }
                int respuesta = Convert.ToInt32(Cmd.ExecuteScalar());
                oCnn.Close();
                if (respuesta > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public bool Escribir(string consulta, Dictionary<string, object> parametros)
        {
            if (oCnn.State == ConnectionState.Closed)
            {
                oCnn.ConnectionString = CadenaC;
                oCnn.Open();
            }
            try
            {
                Tranx = oCnn.BeginTransaction();
                //uso el constructor del objeto command
                Cmd = new SqlCommand(consulta, oCnn, Tranx);
                //Cmd.Connection = oCnn;
                //Cmd.CommandText = consulta;
                //Cmd.Transaction = Tranx;
                Cmd.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (var parametro in parametros)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                int respuesta = Cmd.ExecuteNonQuery();
                Tranx.Commit();
                return true;
            }
            catch (SqlException)
            {
                Tranx.Rollback();
                return false;
            }
            catch (Exception)
            {
                Tranx.Rollback();
                return false;
            }
            finally
            {
                oCnn.Close();
            }
        }

    }
}
