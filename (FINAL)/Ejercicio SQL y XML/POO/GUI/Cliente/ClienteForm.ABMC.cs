using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// 
    /// ABMC = Alta, Baja, Modificación y Consulta.
    /// Aquí se encuentran los métodos que manejan el ABMC de clientes.
    /// 
    /// Básicamente, esta clase es la controladora de la vista ClienteForm,
    /// excepto que por ser una clase parcial, no necesito instanciarla.
    /// </summary>
    public partial class ClienteForm
    {
        private void Agregar(object sender, EventArgs e)
        {
            bool agregado = false;

            try
            {
                Cliente cliente = ArmarCliente();
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea guardar el cliente?");
                if (resultado == DialogResult.Yes) agregado = new ClienteBLL().Agregar(cliente);
                else Tool.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (agregado)
            {
                Tool.MostrarInformacion("Cliente guardado");
                ModoNormal();
            }
        }


        private void Borrar(object sender, DataGridViewCellEventArgs e)
        {
            bool borrado = false;

            try
            {
                if (e.ColumnIndex == ListadoDGV.Columns["Baja"].Index && e.RowIndex >= 0)
                {
                    Cliente cliente = (Cliente)ListadoDGV.Rows[e.RowIndex].DataBoundItem;
                    DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea borrar este cliente?");
                    if (resultado == DialogResult.Yes) borrado = new ClienteBLL().Borrar(cliente);
                    else Tool.MostrarInformacion("Borrado cancelado por el usuario");
                }
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (borrado)
            {
                Tool.MostrarInformacion("Cliente borrado");
                ModoNormal();
            }
        }


        private void Modificar(object sender, EventArgs e)
        {
            bool modificado = false;

            try
            {
                Cliente cliente = ArmarCliente();
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea modificar este cliente?");
                if (resultado == DialogResult.Yes) modificado = new ClienteBLL().Modificar(cliente);
                else Tool.MostrarInformacion("Modificación cancelada por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }

            if (modificado)
            {
                Tool.MostrarInformacion("Cliente modificado");
                ModoNormal();
            }
        }


        private void Consultar()
        {
            try
            {
                ListadoDGV.DataSource = null;

                // Crear (si no existe) una nueva columna para el botón de baja
                if (!ListadoDGV.Columns.Contains("Baja"))
                {
                    DataGridViewButtonColumn BajaColumn = new DataGridViewButtonColumn
                    {
                        Name = "Baja",
                        Text = "X",
                        UseColumnTextForButtonValue = true
                    };
                    ListadoDGV.Columns.Add(BajaColumn);
                }

                List<Cliente> clientes = new ClienteBLL().Consultar();
                ListadoDGV.DataSource = clientes;
                ListadoDGV.Columns["Codigo"].DisplayIndex = 1; // Mover al segundo lugar
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
