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
                NombreTextbox.Text = cliente.Nombre;
                ApellidoTextbox.Text = cliente.Apellido;
                DniTextbox.Text = cliente.DNI.ToString();
                FechaNacimientoDTP.Text = cliente.FechaNacimiento.ToString();
                EmailTextbox.Text = cliente.Email;
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

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
