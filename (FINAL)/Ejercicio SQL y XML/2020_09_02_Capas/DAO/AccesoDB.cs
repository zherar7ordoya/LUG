using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class AccesoDB
    {
        // Conectar/Desconectar a BD
        // Escribir-Actualizar DB (Alta,Baja, Modificación)
        // Leer DB
        // Entregar a MAppers DataTables con estructura de una tabla
       
        SqlConnection _sqlConectar;
        SqlDataAdapter _sqlAdaptador;
        SqlCommandBuilder _sqlConstructorComandos;
        public AccesoDB()
        {
            _sqlConectar = new SqlConnection("Data Source=.;Initial Catalog=Gestion;Integrated Security=True");
            _sqlAdaptador = new SqlDataAdapter("", "Data Source=.;Initial Catalog=Gestion;Integrated Security=True");
            _sqlConstructorComandos = new SqlCommandBuilder();       
        }
        public DataTable RetornaDT(string pNombreTabla)
        {
            _sqlAdaptador.SelectCommand = new SqlCommand($"Select * from {pNombreTabla}");
            _sqlAdaptador.SelectCommand.Connection = _sqlConectar;
            DataTable _dt=new DataTable(pNombreTabla);
            _sqlAdaptador.FillSchema(_dt, SchemaType.Mapped);
            return _dt;
        }
        public void ActualizaDB(string pNombreTabla, DataTable pDatos)
        {
            try 
            { 
                _sqlAdaptador.SelectCommand = new SqlCommand($"Select * from {pNombreTabla}");
                _sqlAdaptador.SelectCommand.Connection = _sqlConectar;
                _sqlConstructorComandos.DataAdapter = _sqlAdaptador;
                _sqlAdaptador.DeleteCommand = _sqlConstructorComandos.GetDeleteCommand();
                _sqlAdaptador.InsertCommand = _sqlConstructorComandos.GetInsertCommand();
                _sqlAdaptador.UpdateCommand = _sqlConstructorComandos.GetUpdateCommand();
                _sqlAdaptador.Update(pDatos);   
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

        }
        public DataTable ConsultaDB(string pSQL)
        {
             DataTable _dt = new DataTable();
            try 
            { 
                _sqlAdaptador.SelectCommand = new SqlCommand(pSQL);
                _sqlAdaptador.SelectCommand.Connection = _sqlConectar;
                _sqlConstructorComandos.DataAdapter = _sqlAdaptador;
                _sqlAdaptador.Fill(_dt);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return _dt;

        }

    }
}
