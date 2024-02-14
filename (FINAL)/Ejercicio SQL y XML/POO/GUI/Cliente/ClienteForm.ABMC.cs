using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public enum ModoFormulario { Alta, Guardado }



    /// <summary>
    /// Básicamente, esta clase es la controladora de la vista ClienteForm,
    /// excepto que por ser una clase parcial, no necesito instanciarla.
    /// Aquí se encuentran los métodos que manejan el ABMC de clientes.
    /// </summary>
    public partial class ClienteForm
    {

        private void Agregar(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea guardar el cliente?");
                if (resultado == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente
                    {
                        Codigo = 0,
                        Nombre = NombreControl.Nombre,
                        Apellido = ApellidoControl.Apellido,
                        DNI = int.Parse(DniControl.Dni),
                        FechaNacimiento = DateTime.Parse(FechaNacimientoDTP.Text),
                        Email = EmailControl.Email
                    };

                    bool agregado = new ClienteBLL().Agregar(cliente);

                    if (agregado) Tool.MostrarInformacion("Cliente guardado");
                    else Tool.MostrarError("No se pudo guardar el cliente");
                }
                else Tool.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }
            finally { CambiarAlModoNormal(); }
        }


        private void Borrar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == ListadoDGV.Columns["Baja"].Index && e.RowIndex >= 0)
                {
                    Cliente cliente = (Cliente)ListadoDGV.Rows[e.RowIndex].DataBoundItem;
                    DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea borrar este cliente?");

                    if (resultado == DialogResult.Yes)
                    {
                        bool borrado = new ClienteBLL().Borrar(cliente);
                        if (borrado)
                        {
                            Tool.MostrarInformacion("Cliente borrado");
                            Consultar();
                        }
                        else { Tool.MostrarError("No se pudo borrar el cliente"); }
                    }
                    else { Tool.MostrarInformacion("Borrado cancelado por el usuario"); }
                }
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }
        }


        private void Modificar(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Codigo = int.Parse(CodigoTextbox.Text),
                    Nombre = NombreControl.Nombre,
                    Apellido = ApellidoControl.Apellido,
                    DNI = int.Parse(DniControl.Dni),
                    FechaNacimiento = DateTime.Parse(FechaNacimientoDTP.Text),
                    Email = EmailControl.Email
                };

                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea modificar este cliente?");

                if (resultado == DialogResult.Yes)
                {
                    bool modificado = new ClienteBLL().Modificar(cliente);
                    if (modificado)
                    {
                        Tool.MostrarInformacion("Cliente modificado");
                        Consultar();
                    }
                    else { Tool.MostrarError("No se pudo modificar el cliente"); }
                }
                else { Tool.MostrarInformacion("Modificación cancelada por el usuario"); }
            }
            catch (Exception ex) { Tool.MostrarError(ex.Message); }
            finally { CambiarAlModoNormal(); }
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
