using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        private ClienteBLL clienteBLL = new ClienteBLL();
        private ModoFormulario modo;
        public ClienteForm()
        {
            InitializeComponent();
            Listar();
            AltaButton.Click += Agregar;
            ListadoDGV.CellClick += Borrar;
            ListadoDGV.RowEnter += MostrarVehiculos;
            modo = ModoFormulario.Alta;

        }


        private void Listar()
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

            List<Cliente> clientes = clienteBLL.Consultar();
            ListadoDGV.DataSource = clientes;
            ListadoDGV.Columns["Codigo"].DisplayIndex = 1; // Mover al segundo lugar
        }




        

        private void Agregar(object sender, EventArgs e)
        {
            if (modo == ModoFormulario.Alta)
            {
                Tool.Limpiar(Controls);
                ListadoDGV.Columns.Remove("Baja");

                AltaButton.Text = "Guardar";
                ModificacionButton.Visible = false;
                Tool.MostrarInformacion("Complete los campos y luego pulse Aceptar");

                modo = ModoFormulario.Guardado;
            }
            else if (modo == ModoFormulario.Guardado)
            {
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea guardar el cliente?");
                if (resultado == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente
                    {
                        Codigo = 0,
                        Nombre = NombreTextbox.Text,
                        Apellido = ApellidoTextbox.Text,
                        DNI = Int32.Parse(DniTextbox.Text),
                        FechaNacimiento = DateTime.Parse(FechaNacimientoDTP.Text),
                        Email = EmailTextbox.Text
                    };
                    clienteBLL.Agregar(cliente);
                }
                else { Tool.MostrarInformacion("Guardado cancelado por el usuario"); }

                AltaButton.Text = "Alta";
                ModificacionButton.Visible = true;
                Listar();
                modo = ModoFormulario.Alta;
            }



        }

        private void Borrar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListadoDGV.Columns["Baja"].Index && e.RowIndex >= 0)
            {
                Cliente cliente = (Cliente)ListadoDGV.Rows[e.RowIndex].DataBoundItem;
                DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea borrar este cliente?");

                if (resultado == DialogResult.Yes)
                {
                    bool borrado = clienteBLL.Borrar(cliente);
                    if (borrado)
                    {
                        Tool.MostrarInformacion("Cliente borrado");
                        Listar();
                    }
                    else { Tool.MostrarError("No se pudo borrar el cliente"); }
                }
                else { Tool.MostrarInformacion("Borrado cancelado por el usuario"); }
            }
        }


        private void Modificar(object sender, EventArgs e)
        {
        }

        private void MostrarVehiculos(object sender, EventArgs e)
        {
            if (ListadoDGV.CurrentRow == null) { return; }
            VehiculosDGV.DataSource = null;
            Cliente cliente = (Cliente)ListadoDGV.CurrentRow.DataBoundItem;
            List<Vehiculo> vehiculos = cliente.VehiculosRentados;
            if (vehiculos == null) { return; }
            VehiculosDGV.DataSource = cliente.VehiculosRentados;
        }


    }
}
