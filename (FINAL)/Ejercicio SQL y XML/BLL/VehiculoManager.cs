using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VehiculoManager
    {
        private static VehiculoManager _instance;
        private static readonly object _lock = new object();

        private VehiculoManager()
        {
            // Carga los vehículos desde los archivos XML
        }

        public static VehiculoManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new VehiculoManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public IVehiculo ObtenerVehiculoPorPatente(string patente)
        {
            // Busca y devuelve el vehículo correspondiente a la patente especificada
            return null;
        }

        // Otros métodos para gestionar los vehículos
    }

}
