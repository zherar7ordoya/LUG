using BEL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        private ModoFormulario modo;

        public ClienteForm()
        {
            InitializeComponent();
            modo = ModoFormulario.Alta;
            InicializarEventHandlers();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            Consultar(); // En Load para asegurarse de que se llame después de la inicialización
        }


        private void InicializarEventHandlers()
        {
            AltaButton.Click += Agregar;
            ModificacionButton.Click += Modificar;
            ListadoDGV.RowEnter += ActualizarInformacion;
            ListadoDGV.CellClick += Borrar;

            // Suscripción de los manejadores de eventos a los eventos
            // validadores de los controles de usuario
            NombreControl.ValidacionCompleta += ValidarNombre;
            ApellidoControl.ValidacionCompleta += ValidarApellido;
            DniControl.ValidacionCompleta += ValidarDni;
            EmailControl.ValidacionCompleta += ValidarEmail;
        }


        private void ActualizarInformacion(object sender, DataGridViewCellEventArgs e)
        {
            SincronizarControles(sender, e);
            MostrarVehiculos(sender, e);
        }


        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente cliente = (Cliente)ListadoDGV.Rows[e.RowIndex].DataBoundItem;
                CodigoTextbox.Text = cliente.Codigo.ToString();
                NombreControl.Nombre = cliente.Nombre;
                ApellidoControl.Apellido = cliente.Apellido;
                DniControl.Dni = cliente.DNI.ToString();
                FechaNacimientoDTP.Text = cliente.FechaNacimiento.ToString();
                EmailControl.Email = cliente.Email;
            }
        }


        private void LimpiarControlesPersonalizados()
        {
            NombreControl.Nombre = "";
            ApellidoControl.Apellido = "";
            DniControl.Dni = "";
            EmailControl.Email = "";
        }


        private void MostrarVehiculos(object sender, DataGridViewCellEventArgs e)
        {
            VehiculosDGV.DataSource = null;

            if (ListadoDGV.CurrentRow != null)
            {
                // La siguiente línea nunca falla: sin "delay" alguno
                Cliente cliente = (Cliente)ListadoDGV.Rows[e.RowIndex].DataBoundItem;
                List<Vehiculo> vehiculos = cliente.VehiculosRentados;
                if (vehiculos == null) { return; }
                VehiculosDGV.DataSource = cliente.VehiculosRentados;
            }
        }


        #region VALIDACIONES MORFOLÓGICAS

        private void ValidarNombre(object sender, bool esValido)
        {
            ValidarCampos(sender, EventArgs.Empty);
        }

        private void ValidarApellido(object sender, bool esValido)
        {
            ValidarCampos(sender, EventArgs.Empty);
        }

        private void ValidarDni(object sender, bool esValido)
        {
            ValidarCampos(sender, EventArgs.Empty);
        }

        private void ValidarEmail(object sender, bool esValido)
        {
            ValidarCampos(sender, EventArgs.Empty);
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            bool nombre = NombreControl.ValidarNombre();
            bool apellido = ApellidoControl.ValidarApellido();
            bool dni = DniControl.ValidarDni();
            bool email = EmailControl.ValidarEmail();

            bool validado = nombre && apellido && dni && email;

            AltaButton.Enabled = validado;
            ModificacionButton.Enabled = validado;
        }

        #endregion

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
