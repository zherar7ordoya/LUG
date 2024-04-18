using ABS;

using BEL;

using MPP;

using System;
using System.Collections.Generic;
using System.Linq;


namespace PML
{
    public class VehiculoPML : IABMC<Vehiculo>
    {
        private readonly string archivo;
        private readonly VehiculoMPP mapeador;

        public VehiculoPML()
        {
            archivo = "Vehiculo.xml";
            mapeador = new VehiculoMPP(archivo);
        }

        //*--------------------------------------------------------------------*

        public bool Agregar(Vehiculo objeto)
        {
            try
            {
                List<Vehiculo> vehiculos = Consultar();
                int codigo = vehiculos.Max(c => c.Codigo) + 1;
                objeto.Codigo = codigo;
                vehiculos.Add(objeto);
                return mapeador.MapearHaciaXml(vehiculos);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Borrar(Vehiculo objeto)
        {
            // Si el vehículo no está asignado a una renta, se puede borrar
            if (Tool.VehiculoSinAsignar(objeto))
            {
                try
                {
                    List<Vehiculo> vehiculos = Consultar();
                    vehiculos.RemoveAll(x => x.Codigo == objeto.Codigo);
                    return mapeador.MapearHaciaXml(vehiculos);
                }
                catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
                catch (Exception ex) { throw new Exception(ex.Message); }
            } else throw new Exception("El vehículo ya está asignado a una renta.");
        }

        public bool Modificar(Vehiculo objeto)
        {
            try
            {
                List<Vehiculo> vehiculos = Consultar();
                Vehiculo vehiculo = vehiculos.Find(x => x.Codigo == objeto.Codigo);

                vehiculo.Codigo = objeto.Codigo;
                vehiculo.Tipo = objeto.Tipo;
                vehiculo.Marca = objeto.Marca;
                vehiculo.Modelo = objeto.Modelo;
                vehiculo.Patente = objeto.Patente;

                return mapeador.MapearHaciaXml(vehiculos);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Vehiculo> Consultar()
        {
            try
            {
                return mapeador.MapearDesdeXml();
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
