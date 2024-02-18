using BEL;

using System;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        private bool normal = true, modificado = false, validado = false;
        public ClienteForm()
        {
            InitializeComponent();
        }


        private void ClienteForm_Load(object sender, EventArgs e)
        {
            InicializarEventHandlers();
            Consultar();
        }


        private void InicializarEventHandlers()
        {
            AltaButton.Click += ModoAlta;
            ModificacionButton.Click += Modificar;
            CancelarButton.Click += Cancelar;

            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;

            NombreControl.TextChanged += ValidaModificacion;
            ApellidoControl.TextChanged += ValidaModificacion;
            DniControl.TextChanged += ValidaModificacion;
            EmailControl.TextChanged += ValidaModificacion;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        #region MÉTODOS INTERNOS
        private void LimpiarControlesPersonalizados()
        {
            NombreControl.Nombre = "";
            ApellidoControl.Apellido = "";
            DniControl.Dni = "";
            EmailControl.Email = "";
        }

        private Cliente ArmarCliente()
        {
            Cliente cliente = new Cliente();

            if (string.IsNullOrEmpty(CodigoTextbox.Text)) cliente.Codigo = 0;
            else cliente.Codigo = int.Parse(CodigoTextbox.Text);

            cliente.Nombre = NombreControl.Nombre;
            cliente.Apellido = ApellidoControl.Apellido;
            cliente.DNI = int.Parse(DniControl.Dni);
            cliente.FechaNacimiento = DateTime.Parse(FechaNacimientoDTP.Text);
            cliente.Email = EmailControl.Email;

            return cliente;
        }

        #endregion

        #region MODOS DE FORMULARIO 

        private void Cancelar(object sender, EventArgs e)
        {
            DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea cancelar?");
            if (resultado == DialogResult.Yes) ModoNormal();
        }
        
        private void ModoNormal()
        {
            normal = true;

            AltaButton.Visible = true;
            ModificacionButton.Visible = false;
            CancelarButton.Visible = false;
            
            Consultar();
        }

        private void ModoAlta(object sender, EventArgs e)
        {
            if (normal)
            {
                normal = false;
                AltaButton.Text = "Guardar";

                ListadoDgv.Columns.Remove("Baja");

                AltaButton.Visible = false;
                ModificacionButton.Visible = false;
                CancelarButton.Visible = true;

                LimpiarControlesPersonalizados();
                Tool.LimpiarControlesEstandar(Controls);
                Tool.MostrarInformacion("Complete los campos y luego pulse Aceptar");
            }
            else
            {
                normal = true;
                AltaButton.Text = "Alta";
                Agregar(this, e);
            }
        }

        #endregion

        #region SINCRONIZACIÓN ENTRE CONTROLES

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            MostrarDetalles(sender, e);
            MostrarVehiculos(sender, e);
        }

        private void MostrarDetalles(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                CodigoTextbox.Text = cliente.Codigo.ToString();
                NombreControl.Nombre = cliente.Nombre;
                ApellidoControl.Apellido = cliente.Apellido;
                DniControl.Dni = cliente.DNI.ToString();
                FechaNacimientoDTP.Text = cliente.FechaNacimiento.ToString();
                EmailControl.Email = cliente.Email;
            }
        }

        private void MostrarVehiculos(object sender, DataGridViewCellEventArgs e)
        {
            VehiculosDgv.DataSource = null;

            if (ListadoDgv.CurrentRow != null)
            {
                // La siguiente línea nunca falla: sin "delay" alguno
                Cliente cliente = (Cliente)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                List<Vehiculo> vehiculos = cliente.VehiculosRentados;
                if (vehiculos == null) { return; }
                VehiculosDgv.DataSource = cliente.VehiculosRentados;
            }
        }

        #endregion

        #region VALIDACIONES MORFOLÓGICAS

        private void ValidaModificacion(object sender, EventArgs e)
        {
            if (ListadoDgv.CurrentRow == null) return;
            Cliente cliente = (Cliente)ListadoDgv.CurrentRow.DataBoundItem;
            if (NombreControl.Nombre != cliente.Nombre) modificado = true;
            if (ApellidoControl.Apellido != cliente.Apellido) modificado = true;
            if (DniControl.Dni != cliente.DNI.ToString()) modificado = true;
            if (EmailControl.Email != cliente.Email) modificado = true;
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            bool nombre = NombreControl.Validar();
            bool apellido = ApellidoControl.Validar();
            bool dni = DniControl.Validar();
            bool email = EmailControl.Validar();

            bool validado = nombre && apellido && dni && email;

            if (normal && !modificado && !validado)
            {
                CancelarButton.Visible = false;
                AltaButton.Visible = true;
                ModificacionButton.Visible = false;
            }

            if (!normal && !modificado && !validado)
            {
                CancelarButton.Visible = true;
                AltaButton.Visible = false;
                ModificacionButton.Visible = false;
            }

            if (!normal && !modificado && validado)
            {
                CancelarButton.Visible = true;
                AltaButton.Visible = true;
                ModificacionButton.Visible = false;
            }

            if (normal && modificado && !validado)
            {
                CancelarButton.Visible = true;
                AltaButton.Visible = false;
                ModificacionButton.Visible = false;
            }

            if (normal && modificado && validado)
            {
                CancelarButton.Visible = true;
                AltaButton.Visible = false;
                ModificacionButton.Visible = true;
            }
        }

        #endregion

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
