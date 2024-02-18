using BEL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIALIZACIÓN

        private EstadoFormulario estado = EstadoFormulario.Normal;

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            InicializarEventHandlers();
            Consultar();
            ConfigurarFormulario();
        }

        private void InicializarEventHandlers()
        {
            GuardarButton.Click += ConfigurarGuardar;
            CancelarButton.Click += Cancelar;

            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;

            NombreControl.TextChanged += ValidaModificacion;
            ApellidoControl.TextChanged += ValidaModificacion;
            DniControl.TextChanged += ValidaModificacion;
            FechaNacimientoDtp.ValueChanged += ValidaModificacion;
            EmailControl.TextChanged += ValidaModificacion;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE FORMULARIO

        #region SINCRONIZACIÓN ENTRE CONTROLES

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            MostrarDetalles(sender, e);
            MostrarVehiculos(sender, e);
        }

        private void MostrarDetalles(object sender, DataGridViewCellEventArgs e)
        {
            // La siguiente línea nunca falla: sin "delay" alguno
            Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;

            CodigoTextbox.Text = cliente.Codigo.ToString();
            NombreControl.Nombre = cliente.Nombre;
            ApellidoControl.Apellido = cliente.Apellido;
            DniControl.Dni = cliente.DNI.ToString();
            FechaNacimientoDtp.Text = cliente.FechaNacimiento.ToString();
            EmailControl.Email = cliente.Email;
        }

        private void MostrarVehiculos(object sender, DataGridViewCellEventArgs e)
        {
            VehiculosDgv.DataSource = null;

            if (ListadoDgv.CurrentRow != null)
            {
                // La siguiente línea nunca falla: sin "delay" alguno
                Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;

                List<Vehiculo> vehiculos = cliente.VehiculosRentados;
                if (vehiculos == null) return; // Si no tiene vehículos rentados
                VehiculosDgv.DataSource = cliente.VehiculosRentados;
            }
        }

        #endregion

        #region MODOS DE FORMULARIO 

        private void ConfigurarGuardar(object sender, EventArgs e)
        {
            if (estado == EstadoFormulario.Normal)
            {
                Tool.LimpiarFormularioCliente(Controls);
                estado = EstadoFormulario.Alta;
                ConfigurarFormulario();
                Tool.MostrarInformacion("Complete los campos y luego pulse Guardar");
            }
            else
            {
                if (estado == EstadoFormulario.Alta) Agregar(this, e);
                else if (estado == EstadoFormulario.Modificacion) Modificar(this, e);
            }
        }


        private void Cancelar(object sender, EventArgs e)
        {
            DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea cancelar?");
            if (resultado == DialogResult.Yes)
            {
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }


        private void ValidaModificacion(object sender, EventArgs e)
        {
            if (ListadoDgv.CurrentRow != null)
            {
                Cliente cliente = (Cliente)ListadoDgv.SelectedRows[0].DataBoundItem;

                bool modificado = (NombreControl.Nombre != cliente.Nombre) ||
                             (ApellidoControl.Apellido != cliente.Apellido) ||
                             (DniControl.Dni != cliente.DNI.ToString()) ||
                             (FechaNacimientoDtp.Text != cliente.FechaNacimiento.ToShortDateString()) ||
                             (EmailControl.Email != cliente.Email);
                if (modificado) estado = EstadoFormulario.Modificacion;
                else estado = EstadoFormulario.Normal;
            }
            ConfigurarFormulario();
        }

        #endregion

        //|||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS DE FORMULARIO

        private void ConfigurarFormulario()
        {
            bool nombre = NombreControl.Validar();
            bool apellido = ApellidoControl.Validar();
            bool dni = DniControl.Validar();
            bool email = EmailControl.Validar();

            bool validado = nombre && apellido && dni && email;

            switch (estado)
            {
                case EstadoFormulario.Normal:
                    GuardarButton.Text = "Alta";
                    CancelarButton.Visible = false;
                    break;
                case EstadoFormulario.Alta:
                    GuardarButton.Text = "Guardar";
                    CancelarButton.Visible = true;
                    break;
                case EstadoFormulario.Modificacion:
                    GuardarButton.Text = "Guardar";
                    CancelarButton.Visible = true;
                    break;
            }

            GuardarButton.Visible = validado;
        }


        private Cliente ArmarCliente()
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

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}