using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCL
{
    public static class Tool
    {
        

        //public static Renta ArmarObjetoRenta(RentaForm formulario)
        //{
        //    Renta renta = new Renta();

        //    // Código: si es un alta, el código es 0
        //    if (string.IsNullOrEmpty(formulario.CodigoRentaTextbox.Text)) renta.Codigo = 0;
        //    else renta.Codigo = int.Parse(formulario.CodigoRentaTextbox.Text);

        //    // Ahora, la propiedad Cliente
        //    List<Cliente> clientes = new ClienteBLL().Consultar();
        //    renta.Cliente =
        //        clientes
        //        .Find(x => formulario.CodigoClienteTextbox.Text == x.Codigo.ToString());

        //    // Ahora, la propiedad Vehículo
        //    List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();
        //    renta.Vehiculo =
        //        vehiculos
        //        .Find(x => formulario.CodigoVehiculoTextbox.Text == x.Codigo.ToString());

        //    // Los días rentados (que no puede ser 0:solucionado con el control Numeric)
        //    renta.DiasRentados = (int)formulario.DiasRentadosNumeric.Value;

        //    // El importe (que no puede ser 0: solucionado con la validación)
        //    renta.Importe = decimal.Parse(formulario.ImporteControl.Importe);

        //    // Listo
        //    return renta;
        //}

        //public static Vehiculo ArmarObjetoVehiculo(VehiculoForm formulario)
        //{
        //    Vehiculo vehiculo;
        //    string tipo = formulario.TipoCombobox.SelectedValue.ToString();

        //    switch (tipo)
        //    {
        //        case "Automovil":
        //            vehiculo = new Automovil();
        //            break;
        //        case "Camion":
        //            vehiculo = new Camion();
        //            break;
        //        case "Camioneta":
        //            vehiculo = new Camioneta();
        //            break;
        //        case "Suv":
        //            vehiculo = new Suv();
        //            break;
        //        default:
        //            throw new InvalidOperationException($"Tipo de vehículo desconocido: {tipo}");
        //    }

        //    if (string.IsNullOrEmpty(formulario.CodigoTextbox.Text)) vehiculo.Codigo = 0;
        //    else vehiculo.Codigo = int.Parse(formulario.CodigoTextbox.Text);
        //    vehiculo.Tipo = (VehiculoTipo)formulario.TipoCombobox.SelectedValue;
        //    vehiculo.Marca = formulario.MarcaControl.Marca;
        //    vehiculo.Modelo = formulario.ModeloControl.Modelo;
        //    vehiculo.Patente = formulario.PatenteControl.Patente;

        //    return vehiculo;
        //}
    }
}
