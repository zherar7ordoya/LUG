using ABS;

using BEL;

using MPP;

using System;
using System.Collections.Generic;
using System.Linq;

namespace ASL
{
    public class VehiculoASL : IABMC<Vehiculo>
    {
        private readonly string archivo = "Vehiculo.xml";

        public bool Agregar(Vehiculo objeto)
        {
            try
            {
                List<Vehiculo> vehiculos = Consultar();
                int codigo = vehiculos.Max(c => c.Codigo) + 1;
                objeto.Codigo = codigo;
                vehiculos.Add(objeto);
                return new VehiculoMPP().MapearHaciaXml(archivo, vehiculos);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Borrar(Vehiculo objeto)
        {
            try
            {
                List<Vehiculo> vehiculos = Consultar();
                vehiculos.RemoveAll(x => x.Codigo == objeto.Codigo);
                return new VehiculoMPP().MapearHaciaXml(archivo, vehiculos);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Modificar(Vehiculo objeto)
        {
            try
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
                return new VehiculoMPP().MapearHaciaXml(archivo, vehiculos);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Vehiculo> Consultar()
        {
            try
            {
                return new VehiculoMPP().MapearDesdeXml(archivo);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
