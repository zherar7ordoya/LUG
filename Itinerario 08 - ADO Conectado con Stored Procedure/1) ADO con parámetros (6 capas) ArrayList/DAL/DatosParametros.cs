﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections; //para el arraylist
using System.Configuration; 

namespace DAL
{
   public class DatosParametros
    {
        //string CadenaC = @"Data Source=.\SQLEXPRESS02;Initial Catalog=ADO_en_Capas;Integrated Security=True";
        readonly string CadenaC = ConfigurationManager.ConnectionStrings["AdoEnCapas"].ToString();
        //private SqlConnection oCnn = new SqlConnection(@"Data Source=.\SQLEXPRESS02;Initial Catalog=ADO_en_Capas;Integrated Security=True");
        private readonly SqlConnection oCnn;
        private SqlTransaction Tranx;
      private SqlCommand Cmd;

        public DatosParametros()
        {
            oCnn = new SqlConnection(CadenaC);
        }
   
        // con arraylist
       public DataTable Leer(string Consulta, ArrayList Parametros)
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da;
            //paso la consulta y el objeto conection en el constructor
            Cmd = new SqlCommand(Consulta,oCnn);
            Cmd.CommandType = CommandType.StoredProcedure;

            try {
                  Da = new SqlDataAdapter(Cmd);

	        if ((Parametros != null)) {
		        //si la el arraylist esta vacia
		        foreach (SqlParameter dato in Parametros)
                 {
			        //cargo los parametros que le estoy pasando con la Hash
			        Cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
		         }
                }
	           }
    
               catch (SqlException ex)
                     {  throw  ex;}
	         catch (Exception ex) 
                    { throw ex;}
                Da.Fill(Dt);
		        return Dt;
                
        }


        public bool LeerScalar(string Consulta, ArrayList AL)
        {
            oCnn.Open();
            //uso el constructor del objeto Command al instanciar el objeto
            Cmd = new SqlCommand(Consulta, oCnn);
            Cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if ((AL != null))
                {
                    foreach (SqlParameter dato in AL)
                    {
                        //cargo los parametros que le estoy pasando con el arraylist
                        Cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
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
        }
        public bool Escribir(string consulta, ArrayList AL)
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
                    
                if ((AL != null))
                {
                    foreach (SqlParameter dato in AL)
                    {
                        //cargo los parametros que le estoy pasando con el arraylist
                        Cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
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
            { oCnn.Close(); }


       }

    }
}
