using ABS;

using BEL;

using MPP;

using System;
using System.Collections.Generic;
using System.Linq;

/* ************************************************************************** *\
La "Persistence Management Layer" (Capa de Gestión de Persistencia) cumple una
única responsabilidad al preparar consultas específicas y gestionar la
información necesaria para realizar las operaciones de persistencia. Actúa como
un puente entre la lógica de aplicación y la capa de acceso a datos (DAL),
siguiendo los principios SOLID al enfocarse en una tarea específica y facilitar
la extensibilidad y mantenibilidad del sistema.
\* ************************************************************************** */

namespace PML
{
    public class VehiculoPML : IABMC<Vehiculo>
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
