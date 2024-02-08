using ABS;

using BEL;

using MPP;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRL
{
    public class VehiculoDRL : IABMC<Vehiculo>
    {
        private readonly string archivo = "Vehiculo.xml";
        readonly VehiculoMPP vehiculoMPP = new VehiculoMPP();

        public bool Modificar(Vehiculo objeto)
        {
            List<Vehiculo> vehiculos = Consultar();
            Vehiculo vehiculo = vehiculos.Find(x => x.Codigo == objeto.Codigo);
            if (vehiculo != null)
            {
                vehiculo.Codigo = objeto.Codigo;
                vehiculo.Tipo = objeto.Tipo;
                vehiculo.Marca = objeto.Marca;
                vehiculo.Modelo = objeto.Modelo;
                vehiculo.Patente = objeto.Patente;
            }
            return vehiculoMPP.MapearHaciaXmlArchivo(archivo, vehiculos);
        }

        public bool Borrar(Vehiculo objeto)
        {
            List<Vehiculo> vehiculos = Consultar();
            vehiculos.RemoveAll(x => x.Codigo == objeto.Codigo);
            return vehiculoMPP.MapearHaciaXmlArchivo(archivo, vehiculos);
        }

        public bool Agregar(Vehiculo objeto)
        {
            List<Vehiculo> vehiculos = Consultar();
            vehiculos.Add(objeto);
            return vehiculoMPP.MapearHaciaXmlArchivo(archivo, vehiculos);
        }

        public List<Vehiculo> Consultar()
        {
            return vehiculoMPP.MapearDesdeXmlArchivo(archivo);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
