using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiciosI;
using Entidades;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace Mapeadores
{
    public class MapAlumno : Iambc<Alumno>
    {
        AccesoDB _aDB;
        public MapAlumno()
        {

            _aDB = new AccesoDB();
        }
        public void Alta(Alumno pAlumno)
        {
            try 
            {
                DataTable _dt = _aDB.RetornaDT("Alumno");
                DataRow _dr = _dt.NewRow();         
                _dr.ItemArray = new object[] { pAlumno.Id,pAlumno.Nombre,pAlumno.Apellido,pAlumno.Fecha_Alta,pAlumno.Activo };
                _dt.Rows.Add(_dr);
                _aDB.ActualizaDB("Alumno", _dt);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Baja(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }
        public List<Alumno> ConsultaDesdeHasta(Alumno pAlumnoDesde, Alumno pAlumnoHasta)
        {
            throw new NotImplementedException();
        }
        public void ConsultaIndividual(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }
        public List<Alumno> CosultaTodo()
        {
            List<Alumno> _la = new List<Alumno>();
            try 
            {
                DataTable _dt = _aDB.ConsultaDB("Select * from Alumno");
                foreach(DataRow _r in _dt.Rows) {_la.Add(new Alumno(_r.ItemArray)); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return _la;
        }

        public void Modificacion(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }
    }
}
