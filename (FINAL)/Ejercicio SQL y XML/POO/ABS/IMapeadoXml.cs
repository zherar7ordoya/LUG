using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IMapeadoXml<T> where T : IEntidad
    {
        List<T> MapearDesdeXml(string archivo);
        bool MapearHaciaXml(string archivo, List<T> objetos);
    }
}
