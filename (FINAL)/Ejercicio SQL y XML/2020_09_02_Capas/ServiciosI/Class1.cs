using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ServiciosI
{
    public class Class1
    {
    }
    public interface Iambc<T>
    {
        void Alta(T pAlumno);
        void Baja(T pAlumno);
        void Modificacion(T pAlumno);
        void ConsultaIndividual(T pAlumno);
        List<T> ConsultaDesdeHasta(T pAlumnoDesde, T pAlumnoHasta);
        List<T> CosultaTodo();
    }
}
