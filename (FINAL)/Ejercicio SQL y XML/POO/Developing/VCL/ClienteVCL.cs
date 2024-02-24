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
    public class ClienteVCL
    {
        readonly Form formulario;
        readonly List<Controlador> controladores;
        readonly DataGridView ListadoDgv;
        public ClienteVCL(Form formulario)
        {
            this.formulario = formulario;

            foreach (Control control in formulario.Controls)
            {
                controladores.Add(new Controlador(control.Name, control));
            }

            ListadoDgv = (DataGridView)formulario.Controls["ListadoDgv"];
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        //private void Agregar(object sender, EventArgs e)
        //{
        //    bool agregado = false;

        //    try
        //    {
        //        Cliente cliente = Tool.ArmarObjetoCliente(this);
        //        DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea guardar el cliente?");
        //        if (resultado == DialogResult.Yes) agregado = new ClienteBLL().Agregar(cliente);
        //        else Tool.MostrarInformacion("Guardado cancelado por el usuario");
        //    }
        //    catch (Exception ex) { Tool.MostrarError(ex.Message); }

        //    if (agregado)
        //    {
        //        Tool.MostrarInformacion("Cliente guardado");
        //        estado = EstadoFormulario.Normal;
        //        Consultar();
        //        ConfigurarFormulario();
        //    }
        //}


        //private void Borrar(object sender, DataGridViewCellEventArgs e)
        //{
        //    bool borrado = false;

        //    try
        //    {
        //        if (e.ColumnIndex == ListadoDgv.Columns["Baja"].Index && e.RowIndex >= 0)
        //        {
        //            Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
        //            DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea borrar este cliente?");
        //            if (resultado == DialogResult.Yes) borrado = new ClienteBLL().Borrar(cliente);
        //            else Tool.MostrarInformacion("Borrado cancelado por el usuario");
        //        }
        //    }
        //    catch (Exception ex) { Tool.MostrarError(ex.Message); }

        //    if (borrado)
        //    {
        //        Tool.MostrarInformacion("Cliente borrado");
        //        estado = EstadoFormulario.Normal;
        //        Consultar();
        //        ConfigurarFormulario();
        //    }
        //}


        //private void Modificar(object sender, EventArgs e)
        //{
        //    bool modificado = false;

        //    try
        //    {
        //        Cliente cliente = Tool.ArmarObjetoCliente(this);
        //        DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea modificar este cliente?");
        //        if (resultado == DialogResult.Yes) modificado = new ClienteBLL().Modificar(cliente);
        //        else Tool.MostrarInformacion("Modificación cancelada por el usuario");
        //    }
        //    catch (Exception ex) { Tool.MostrarError(ex.Message); }

        //    if (modificado)
        //    {
        //        Tool.MostrarInformacion("Cliente modificado");
        //        estado = EstadoFormulario.Normal;
        //        Consultar();
        //        ConfigurarFormulario();
        //    }
        //}

        ////\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        ///// <summary>
        ///// Mi pobre método principal es el único que no obedece a un evento. Nadie
        ///// lo llama, él solo está ahí, siempre presente, siendo la base para todo.
        ///// </summary>
        //private void Consultar()
        //{
        //    try
        //    {
        //        ListadoDgv.DataSource = null;

        //        // Crear (si no existe) una nueva columna para el botón de baja
        //        if (!ListadoDgv.Columns.Contains("Baja"))
        //        {
        //            DataGridViewButtonColumn BajaColumn = new DataGridViewButtonColumn
        //            {
        //                Name = "Baja",
        //                Text = "X",
        //                UseColumnTextForButtonValue = true
        //            };
        //            ListadoDgv.Columns.Add(BajaColumn);
        //        }

        //        List<Cliente> clientes = new ClienteBLL().Consultar();
        //        ListadoDgv.DataSource = clientes;
        //        ListadoDgv.Columns["Codigo"].DisplayIndex = 1; // Mover al segundo lugar
        //    }
        //    catch (Exception ex) { Tool.MostrarError(ex.Message); }
        //}

        ////\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        //private Cliente ArmarObjetoCliente(ClienteForm formulario)
        //{
        //    Cliente cliente = new Cliente();

        //    if (string.IsNullOrEmpty(formulario.CodigoTextbox.Text)) cliente.Codigo = 0; // Es un alta
        //    else cliente.Codigo = int.Parse(formulario.CodigoTextbox.Text);

        //    cliente.Nombre = formulario.NombreControl.Nombre;
        //    cliente.Apellido = formulario.ApellidoControl.Apellido;
        //    cliente.DNI = int.Parse(formulario.DniControl.Dni);
        //    cliente.FechaNacimiento = DateTime.Parse(formulario.FechaNacimientoDtp.Text);
        //    cliente.Email = formulario.EmailControl.Email;

        //    return cliente;
        //}
    }
}
