using ABS;

using BEL;

using BLL;

using SVC;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    // La GUI, y luego, esta capa controladora, interactúan el ABMC.
    // Entonces, ¿por qué no implementar la interfaz IABMC en la GUI o acá?
    public partial class ClienteVCL
    {
        // TODO => Llevar los métodos comunes a una clase estática.
        // MÉTODO COMÚN
        private Cliente ArmarObjetoCliente()
        {
            Cliente cliente = new Cliente();

            if (string.IsNullOrEmpty(CodigoTextbox.Text)) cliente.Codigo = 0; // Es un alta
            else cliente.Codigo = int.Parse(CodigoTextbox.Text);

            cliente.Nombre = NombreControl.Nombre;
            cliente.Apellido = ApellidoControl.Apellido;
            cliente.DNI = int.Parse(DniControl.Dni);
            cliente.FechaNacimiento = DateTime.Parse(FechaNacimientoDtp.Text);
            cliente.Email = EmailControl.Email;

            return cliente;
        }

        // MÉTODOS DEL ABMC
        private void Agregar(object sender, EventArgs e)
        {
            bool agregado = false;

            try
            {
                Cliente cliente = ArmarObjetoCliente();
                DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea guardar el cliente?");
                if (resultado == DialogResult.Yes) agregado = new ClienteBLL().Agregar(cliente);
                else Mensajeria.MostrarInformacion("Guardado cancelado por el usuario");
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (agregado)
            {
                Mensajeria.MostrarInformacion("Cliente guardado");
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private void Borrar(object sender, DataGridViewCellEventArgs e)
        {
            bool borrado = false;

            try
            {
                if (e.ColumnIndex == ListadoDgv.Columns["Baja"].Index && e.RowIndex >= 0)
                {
                    Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                    DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea borrar este cliente?");
                    if (resultado == DialogResult.Yes) borrado = new ClienteBLL().Borrar(cliente);
                    else Mensajeria.MostrarInformacion("Borrado cancelado por el usuario");
                }
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (borrado)
            {
                Mensajeria.MostrarInformacion("Cliente borrado");
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private void Modificar(object sender, EventArgs e)
        {
            bool modificado = false;

            try
            {
                Cliente cliente = ArmarObjetoCliente();
                DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea modificar este cliente?");
                if (resultado == DialogResult.Yes) modificado = new ClienteBLL().Modificar(cliente);
                else Mensajeria.MostrarInformacion("Modificación cancelada por el usuario");
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }

            if (modificado)
            {
                Mensajeria.MostrarInformacion("Cliente modificado");
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

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

                List<Cliente> clientes = new ClienteBLL().Consultar();
                ListadoDgv.DataSource = clientes;
                ListadoDgv.Columns["Codigo"].DisplayIndex = 1; // Mover al segundo lugar
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
