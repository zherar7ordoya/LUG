using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using ServiciosI;
using Mapeadores;

namespace BLL
{
    
    public class AlumnoBLL : Iambc<Alumno>
    {
        MapAlumno _mapAlumno;
        public AlumnoBLL()
        {
            _mapAlumno = new MapAlumno();
        }
        public void Alta(Alumno pAlumno)
        {
            try {_mapAlumno.Alta(pAlumno); }
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
            try 
            {
                return _mapAlumno.CosultaTodo();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }


        }

        public void Modificacion(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }
    }
}
