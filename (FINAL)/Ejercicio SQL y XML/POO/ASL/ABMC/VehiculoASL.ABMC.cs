using ABS;

using BEL;

using MPP;

using System.Collections.Generic;

namespace ASL
{
    public partial class VehiculoASL : IABMC<Vehiculo>
    {
        private readonly string archivo = "Vehiculo.xml";

        public bool Agregar(Vehiculo objeto)
        {
            List<Vehiculo> vehiculos = Consultar();
            vehiculos.Add(objeto);
            return new VehiculoMPP().MapearHaciaXmlArchivo(archivo, vehiculos);
        }

        public bool Borrar(Vehiculo objeto)
        {
            List<Vehiculo> vehiculos = Consultar();
            vehiculos.RemoveAll(x => x.Codigo == objeto.Codigo);
            return new VehiculoMPP().MapearHaciaXmlArchivo(archivo, vehiculos);
        }

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
            return new VehiculoMPP().MapearHaciaXmlArchivo(archivo, vehiculos);
        }

        public List<Vehiculo> Consultar()
        {
            return new VehiculoMPP().MapearDesdeXmlArchivo(archivo);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
