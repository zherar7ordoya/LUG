using ABS;

using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    public partial class VehiculoVCL
    {
        private void Agregar(object sender, EventArgs e)
        {
            bool agregado = false;

            try
            {
                Vehiculo vehiculo = Tool.ArmarObjetoVehiculo((IVehiculoForm)this);
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea guardar el vehículo?");
                if (resultado == DialogResult.Yes) agregado = new VehiculoBLL().Agregar(vehiculo);
                else Tool.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (agregado)
            {
                Tool.MostrarInformacion("Vehículo guardado");
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
                    DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea borrar este vehículo?");
                    if (resultado == DialogResult.Yes) borrado = new VehiculoBLL().Borrar(vehiculo);
                    else Tool.MostrarInformacion("Borrado cancelado por el usuario");
                }
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (borrado)
            {
                Tool.MostrarInformacion("Vehiculo borrado");
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
                Vehiculo vehiculo = Tool.ArmarObjetoVehiculo((IVehiculoForm)this);
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea modificar este vehículo?");
                if (resultado == DialogResult.Yes) modificado = new VehiculoBLL().Modificar(vehiculo);
                else Tool.MostrarInformacion("Modificación cancelada por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (modificado)
            {
                Tool.MostrarInformacion("Vehículo modificado");
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
            catch (Exception ex) { Tool.MostrarError(ex.Message); }
        }

    }
}
