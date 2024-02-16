using BEL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
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
            AltaButton.Click += CambiarAlModoAlta;
            ModificacionButton.Click += Modificar;
            GuardarButton.Click += Agregar;
            CancelarButton.Click += CambiarAlModoNormal;

            ListadoDGV.RowEnter += SincronizarControles;
            ListadoDGV.CellClick += Borrar;

            NombreControl.Leave += ValidarCampos;
            ApellidoControl.Leave += ValidarCampos;
            DniControl.Leave += ValidarCampos;
            EmailControl.Leave += ValidarCampos;
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
        private void CambiarAlModoAlta(object sender, EventArgs e)
        {
            ListadoDGV.Columns.Remove("Baja");

            AltaButton.Visible = false;
            ModificacionButton.Visible = false;
            CancelarButton.Visible = true;
            GuardarButton.Visible = false;

            LimpiarControlesPersonalizados();
            Tool.LimpiarControlesEstandar(Controls);
            Tool.MostrarInformacion("Complete los campos y luego pulse Aceptar");
        }


        private void CambiarAlModoNormal(object sender, EventArgs e)
        {
            DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea cancelar?");
            if (resultado == DialogResult.Yes) CambiarAlModoNormal();
        }


        private void CambiarAlModoNormal()
        {
            AltaButton.Visible = true;
            ModificacionButton.Visible = true;
            CancelarButton.Visible = false;
            GuardarButton.Visible = false;
            Consultar();
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
                Cliente cliente = (Cliente)ListadoDGV.Rows[e.RowIndex].DataBoundItem;
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
        #endregion


        #region VALIDACIONES MORFOLÓGICAS

        private void ValidarCampos(object sender, EventArgs e)
        {
            bool validado = ValidarCampos();
            bool cancelado = CancelarButton.Visible;

            // Si cancelado está oculto, entonces no es una alta, por lo tanto,
            // el botón de guardar no debe participar de esta validación.
            GuardarButton.Visible = validado && cancelado;

            // Sigue la misma lógica que el botón de guardar, pero a la inversa
            AltaButton.Visible = validado && !cancelado;
            ModificacionButton.Visible = validado && !cancelado;
        }


        private bool ValidarCampos()
        {
            bool nombre = NombreControl.Validar();
            bool apellido = ApellidoControl.Validar();
            bool dni = DniControl.Validar();
            bool email = EmailControl.Validar();

            bool validado = nombre && apellido && dni && email;

            return validado;
        }

        #endregion

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
