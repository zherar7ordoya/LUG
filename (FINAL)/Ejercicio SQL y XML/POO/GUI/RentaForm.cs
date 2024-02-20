using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RentaForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIALIZACIÓN

        private EstadoFormulario estado = EstadoFormulario.Normal;
        public RentaForm() => InitializeComponent();

        private void RentaForm_Load(object sender, EventArgs e)
        {
            InicializarEventHandlers();
            ClientesDgv.DataSource = new ClienteBLL().Consultar();
            VehiculosDgv.DataSource = new VehiculoBLL().Consultar();
            Consultar();
        }

        private void InicializarEventHandlers()
        {
            // Botones
            GuardarButton.Click += BotonGuardar;
            CancelarButton.Click += BotonCancelar;
            CalcularButton.Click += BotonCalcular;

            // DataGridViews
            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;
            ClientesDgv.RowEnter += MostarCliente;
            VehiculosDgv.RowEnter += MostarVehiculo;

            // Controles
            CodigoClienteTextbox.TextChanged += CompararDatos;
            CodigoVehiculoTextbox.TextChanged += CompararDatos;
            DiasRentadosNumeric.ValueChanged += CompararDatos;
            ImporteControl.TextChanged += CompararDatos;
        }

        private void ConfigurarFormulario()
        {
            bool validado = ImporteControl.Validar();
            Tool.ConfigurarBotones(this, estado, validado);
        }


        #region ||*----------------------------------------------------> EVENTOS

        //|||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE DATAGRIDVIEW

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                CodigoRentaTextbox.Text = renta.Codigo.ToString();
                DiasRentadosNumeric.Value = renta.DiasRentados;
                ImporteControl.Importe = renta.Importe.ToString();
                MostarCliente(sender, e);
                MostarVehiculo(sender, e);
            }
        }

        private void MostarCliente(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = null;

            if (sender == ListadoDgv)
            {
                Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                List<Cliente> clientes = new ClienteBLL().Consultar();
                cliente = clientes.Find(c => c.Codigo == renta.Cliente.Codigo);
            }
            else if (sender == ClientesDgv)
            {
                cliente = (Cliente)ClientesDgv.Rows[e.RowIndex].DataBoundItem;
            }
            if (cliente == null) return;

            CodigoClienteTextbox.Text = cliente.Codigo.ToString();
            NombreControl.Nombre = cliente.Nombre;
            ApellidoControl.Apellido = cliente.Apellido;
            DniControl.Dni = cliente.DNI.ToString();
            FechaNacimientoDtp.Value = cliente.FechaNacimiento;
            EmailControl.Email = cliente.Email;
        }

        private void MostarVehiculo(object sender, DataGridViewCellEventArgs e)
        {
            Vehiculo vehiculo = null;

            if (sender == ListadoDgv)
            {
                Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();
                vehiculo = vehiculos.Find(v => v.Codigo == renta.Vehiculo.Codigo);
            }
            else if (sender == VehiculosDgv)
            {
                vehiculo = (Vehiculo)VehiculosDgv.Rows[e.RowIndex].DataBoundItem;
            }
            if (vehiculo == null) return;

            CodigoVehiculoTextbox.Text = vehiculo.Codigo.ToString();
            TipoCombobox.Text = vehiculo.Tipo.ToString();
            MarcaControl.Marca = vehiculo.Marca;
            ModeloControl.Modelo = vehiculo.Modelo;
            PatenteControl.Patente = vehiculo.Patente;
        }

        //|||||||||||||||||||||||||||||||||||||| EVENTOS DE CONTROLES DE USUARIO

        private void CompararDatos(object sender, EventArgs e)
        {
            if (ListadoDgv.CurrentRow != null) // Dato: es null durante el alta
            {
                Renta renta = (Renta)ListadoDgv.SelectedRows[0].DataBoundItem;

                bool modificado = (CodigoClienteTextbox.Text != renta.Cliente.Codigo.ToString()) ||
                                  (CodigoVehiculoTextbox.Text != renta.Vehiculo.Codigo.ToString()) ||
                                  (DiasRentadosNumeric.Value != renta.DiasRentados) ||
                                  (ImporteControl.Importe != renta.Importe.ToString());

                if (modificado) estado = EstadoFormulario.Modificacion;
                else estado = EstadoFormulario.Normal;
            }
            ConfigurarFormulario(); // Actualiza el estado de los botones
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE BOTONES

        private void BotonGuardar(object sender, EventArgs e)
        {
            if (estado == EstadoFormulario.Normal)
            {
                Tool.LimpiarFormularioVehiculo(Controls);
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

        private void BotonCancelar(object sender, EventArgs e)
        {
            DialogResult resultado = Tool.MostrarPregunta("¿Seguro que desea cancelar?");
            if (resultado == DialogResult.Yes)
            {
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        private void BotonCalcular(object sender, EventArgs e)
        {
            // Obtengo el objeto renta
            Renta renta = (Renta)ListadoDgv.SelectedRows[0].DataBoundItem;

            // Obtengo el objeto vehiculo de esa renta
            Vehiculo vehiculo = renta.Vehiculo;
            
            // Calculo el importe de la renta según el tipo de vehículo
            switch (vehiculo.Tipo)
            {
                case VehiculoTipo.Automovil:
                    AutomovilBLL automovilBLL = new AutomovilBLL();
                    ImporteControl.Importe = automovilBLL.CalcularRenta((Automovil)renta.Vehiculo, renta.DiasRentados).ToString("0.00");
                    break;
                case VehiculoTipo.Camion:
                    CamionBLL camionBLL = new CamionBLL();
                    ImporteControl.Importe = camionBLL.CalcularRenta((Camion)renta.Vehiculo, renta.DiasRentados).ToString("0.00");
                    break;
                case VehiculoTipo.Camioneta:
                    CamionetaBLL camionetaBLL = new CamionetaBLL();
                    ImporteControl.Importe = camionetaBLL.CalcularRenta((Camioneta)renta.Vehiculo, renta.DiasRentados).ToString("0.00");
                    break;
                case VehiculoTipo.Suv:
                    SuvBLL suvBLL = new SuvBLL();
                    ImporteControl.Importe = suvBLL.CalcularRenta((Suv)renta.Vehiculo, renta.DiasRentados).ToString("0.00");
                    break;
                default:
                    break;
            }

            ImporteControl.Update();  // Forzar la actualización inmediata del control
            CompararDatos(this, e);
        }

        #endregion


    }
}
