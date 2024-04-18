using ABS;

using BEL;

using BLL;

using SVC;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    public partial class RentaVCL
    {
        // TODO => Llevar los métodos comunes a una clase estática.
        // MÉTODO COMÚN
        private Renta ArmarObjetoRenta()
        {
            Renta renta = new Renta();

            // Código: si es un alta, el código es 0
            if (string.IsNullOrEmpty(CodigoRentaTextbox.Text)) renta.Codigo = 0;
            else renta.Codigo = int.Parse(CodigoRentaTextbox.Text);

            // Ahora, la propiedad Cliente
            List<Cliente> clientes = new ClienteBLL().Consultar();
            renta.Cliente =
                clientes
                .Find(x => CodigoClienteTextbox.Text == x.Codigo.ToString());

            // Ahora, la propiedad Vehículo
            List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();
            renta.Vehiculo =
                vehiculos
                .Find(x => CodigoVehiculoTextbox.Text == x.Codigo.ToString());

            // Los días rentados (que no puede ser 0:solucionado con el control Numeric)
            renta.DiasRentados = (int)DiasRentadosNumeric.Value;

            // El importe (que no puede ser 0: solucionado con la validación)
            renta.Importe = decimal.Parse(ImporteControl.Importe);

            // Listo
            return renta;
        }


        // MÉTODOS DEL ABMC
        private void Agregar(object sender, EventArgs e)
        {
            bool agregado = false;

            try
            {
                Renta renta = ArmarObjetoRenta();
                DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea guardar esta renta?");
                if (resultado == DialogResult.Yes) agregado = new RentaBLL().Agregar(renta);
                else Mensajeria.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (agregado)
            {
                Mensajeria.MostrarInformacion("Renta guardada");
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }


        private void Borrar(object sender, DataGridViewCellEventArgs e)
        {
            bool borrado = false;

            try
            {
                if (e.ColumnIndex == ListadoDgv.Columns["Baja"].Index && e.RowIndex >= 0)
                {
                    Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                    DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea borrar esta renta?");
                    if (resultado == DialogResult.Yes) borrado = new RentaBLL().Borrar(renta);
                    else Mensajeria.MostrarInformacion("Borrado cancelado por el usuario");
                }
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (borrado)
            {
                Mensajeria.MostrarInformacion("Renta borrada");
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }


        private void Modificar(object sender, EventArgs e)
        {
            bool modificado = false;

            try
            {
                Renta renta = ArmarObjetoRenta();
                DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea modificar esta renta?");
                if (resultado == DialogResult.Yes) modificado = new RentaBLL().Modificar(renta);
                else Mensajeria.MostrarInformacion("Modificación cancelada por el usuario");
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (modificado)
            {
                Mensajeria.MostrarInformacion("Renta modificada");
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        /// <summary>
        /// Mi pobre método principal es el único que no obedece a un evento. Nadie
        /// lo llama, él solo está ahí, siempre presente, siendo la base para todo.
        /// </summary>
        private void Consultar()
        {
            try
            {
                ListadoDgv.DataSource = null;

                // Crear (si no existe) una nueva columna para el botón de baja
                if (!ListadoDgv.Columns.Contains("Baja"))
                {
                    DataGridViewButtonColumn BajaColumn = new DataGridViewButtonColumn
                    {
                        Name = "Baja",
                        Text = "X",
                        UseColumnTextForButtonValue = true
                    };
                    ListadoDgv.Columns.Add(BajaColumn);
                }

                List<Renta> rentas = new RentaBLL().Consultar();
                ListadoDgv.DataSource = rentas;
                ListadoDgv.Columns["Codigo"].DisplayIndex = 1; // Mover al segundo lugar
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
