using ABS;

using BEL;

using BLL;

using SVC;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    public partial class VehiculoVCL
    {
        // TODO => Llevar los métodos comunes a una clase estática.
        // MÉTODO COMÚN
        private Vehiculo ArmarObjetoVehiculo()
        {
            Vehiculo vehiculo;
            string tipo = TipoCombobox.SelectedValue.ToString();

            switch (tipo)
            {
                case "Automovil":
                    vehiculo = new Automovil();
                    break;
                case "Camion":
                    vehiculo = new Camion();
                    break;
                case "Camioneta":
                    vehiculo = new Camioneta();
                    break;
                case "Suv":
                    vehiculo = new Suv();
                    break;
                default:
                    throw new InvalidOperationException($"Tipo de vehículo desconocido: {tipo}");
            }

            if (string.IsNullOrEmpty(CodigoTextbox.Text)) vehiculo.Codigo = 0;
            else vehiculo.Codigo = int.Parse(CodigoTextbox.Text);
            vehiculo.Tipo = (VehiculoTipo)TipoCombobox.SelectedValue;
            vehiculo.Marca = MarcaControl.Marca;
            vehiculo.Modelo = ModeloControl.Modelo;
            vehiculo.Patente = PatenteControl.Patente;

            return vehiculo;
        }

        // MÉTODOS DEL ABMC
        private void Agregar(object sender, EventArgs e)
        {
            bool agregado = false;

            try
            {
                Vehiculo vehiculo = ArmarObjetoVehiculo();
                DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea guardar el vehículo?");
                if (resultado == DialogResult.Yes) agregado = new VehiculoBLL().Agregar(vehiculo);
                else Mensajeria.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (agregado)
            {
                Mensajeria.MostrarInformacion("Vehículo guardado");
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
                    Vehiculo vehiculo = (Vehiculo)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                    DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea borrar este vehículo?");
                    if (resultado == DialogResult.Yes) borrado = new VehiculoBLL().Borrar(vehiculo);
                    else Mensajeria.MostrarInformacion("Borrado cancelado por el usuario");
                }
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (borrado)
            {
                Mensajeria.MostrarInformacion("Vehiculo borrado");
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
                Vehiculo vehiculo = ArmarObjetoVehiculo();
                DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea modificar este vehículo?");
                if (resultado == DialogResult.Yes) modificado = new VehiculoBLL().Modificar(vehiculo);
                else Mensajeria.MostrarInformacion("Modificación cancelada por el usuario");
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (modificado)
            {
                Mensajeria.MostrarInformacion("Vehículo modificado");
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

                List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();
                ListadoDgv.DataSource = vehiculos;
                ListadoDgv.Columns["Codigo"].DisplayIndex = 1; // Mover al segundo lugar
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }
        }

    }
}
