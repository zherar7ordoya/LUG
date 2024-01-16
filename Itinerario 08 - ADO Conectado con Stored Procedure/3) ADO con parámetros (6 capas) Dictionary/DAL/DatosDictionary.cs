using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DatosDictionary
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["AdoEnCapas"].ToString();
        private readonly SqlConnection conexion;
        private SqlTransaction transaccion;
        private SqlCommand comando;

        public DatosDictionary()
        {
            conexion = new SqlConnection(cadena);
        }

        public DataTable Leer(string consulta, Dictionary<string, object> parametros)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador;

            comando = new SqlCommand(consulta, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                adaptador = new SqlDataAdapter(comando);

                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }

            adaptador.Fill(tabla);
            return tabla;
        }


        public bool Existe(string consulta, Dictionary<string, object> parametros)
        {
            conexion.Open();
            comando = new SqlCommand(consulta, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }
                int respuesta = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();

                if (respuesta > 0) { return true; }
                else { return false; }
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }


        public bool Escribir(string consulta, Dictionary<string, object> parametros)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena;
                conexion.Open();
            }
            try
            {
                transaccion = conexion.BeginTransaction();
                //uso el constructor del objeto command
                comando = new SqlCommand(consulta, conexion, transaccion);
                //Cmd.Connection = oCnn;
                //Cmd.CommandText = consulta;
                //Cmd.Transaction = Tranx;
                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (var parametro in parametros)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                int respuesta = comando.ExecuteNonQuery();
                transaccion.Commit();
                return true;
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                return false;
            }
            catch (Exception)
            {
                transaccion.Rollback();
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
