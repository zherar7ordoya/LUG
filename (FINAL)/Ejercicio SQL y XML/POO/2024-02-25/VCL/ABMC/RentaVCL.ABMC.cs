using ABS;

using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    public partial class RentaVCL
    {
        private void Agregar(object sender, EventArgs e)
        {
            bool agregado = false;

            try
            {
                Renta renta = Tool.ArmarObjetoRenta((IRentaForm)formulario);
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea guardar esta renta?");
                if (resultado == DialogResult.Yes) agregado = new RentaBLL().Agregar(renta);
                else Tool.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (agregado)
            {
                Tool.MostrarInformacion("Renta guardada");
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
                    DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea borrar esta renta?");
                    if (resultado == DialogResult.Yes) borrado = new RentaBLL().Borrar(renta);
                    else Tool.MostrarInformacion("Borrado cancelado por el usuario");
                }
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (borrado)
            {
                Tool.MostrarInformacion("Renta borrada");
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
                Renta renta = Tool.ArmarObjetoRenta((IRentaForm)formulario);
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea modificar esta renta?");
                if (resultado == DialogResult.Yes) modificado = new RentaBLL().Modificar(renta);
                else Tool.MostrarInformacion("Modificación cancelada por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (modificado)
            {
                Tool.MostrarInformacion("Renta modificada");
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
            catch (Exception ex) { Tool.MostrarError(ex.Message); }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
