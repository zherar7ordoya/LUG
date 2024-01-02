using System;

namespace ListaRepudioLib
{
    public class ListaRepudioException : Exception
    {
        public ListaRepudioException(string mensaje) : base(mensaje)
        {
        }

        public class CargarListaException : ListaRepudioException
        {
            public CargarListaException(string mensaje) : base(mensaje)
            {
            }
        }

        public class BuscarException: ListaRepudioException
        {
            public BuscarException(string mensaje) : base(mensaje)
            {
            }
        }

        public class EsAlfanumericaException : ListaRepudioException
        {
            public EsAlfanumericaException(string mensaje) : base(mensaje)
            {
            }
        }

        // Otras excepciones anidadas si es necesario
    }
}
