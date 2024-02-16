using BEL;

using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class VehiculoForm : BaseForm
    {
        public VehiculoForm()
        {
            InitializeComponent();
        }
        private void VehiculoForm_Load(object sender, EventArgs e)
        {
            // Obtén los valores del enumerador VehiculoTipo y asignarlos al ComboBox
            VehiculoTipo[] tipos = (VehiculoTipo[])Enum.GetValues(typeof(VehiculoTipo));
            TipoCombobox.DataSource = tipos;

            InicializarEventHandlers();
            Consultar();
        }

        private void InicializarEventHandlers()
        {
            // Botones
            AltaButton.Click += CambiarAlModoAlta;
            ModificacionButton.Click += Modificar;
            GuardarButton.Click += Agregar;
            CancelarButton.Click += CambiarAlModoNormal;

            // DataGridViews
            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;

            // Controles de usuario
            MarcaControl.Leave += ValidarCampos;
            ModeloControl.Leave += ValidarCampos;
            PatenteControl.Leave += ValidarCampos;
        }

        #region MÉTODOS INTERNOS
        private Vehiculo ArmarVehiculo()
        {
            Vehiculo vehiculo;
            string tipo = TipoCombobox.SelectedValue.ToString();

            switch (tipo)
            {
                case "Automovil":
                    vehiculo = new Automovil();
                    break;
                case "Camion":
                    vehiculo = new Camion();
                    break;
                case "Camioneta":
                    vehiculo = new Camioneta();
                    break;
                case "Suv":
                    vehiculo = new Suv();
                    break;
                default:
                    throw new InvalidOperationException($"Tipo de vehículo desconocido: {tipo}");
            }

            if (string.IsNullOrEmpty(CodigoTextbox.Text)) vehiculo.Codigo = 0;
            else vehiculo.Codigo = int.Parse(CodigoTextbox.Text);
            vehiculo.Tipo = (VehiculoTipo)TipoCombobox.SelectedValue;
            vehiculo.Marca = MarcaControl.Marca;
            vehiculo.Modelo = ModeloControl.Modelo;
            vehiculo.Patente = PatenteControl.Patente;

            return vehiculo;
        }


        private void LimpiarControlesPersonalizados()
        {
            MarcaControl.Marca = "";
            ModeloControl.Modelo = "";
            PatenteControl.Patente = "";
        }
        #endregion

        #region MODOS DE FORMULARIO
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


        private void CambiarAlModoAlta(object sender, EventArgs e)
        {
            ListadoDgv.Columns.Remove("Baja");
            AltaButton.Visible = false;
            ModificacionButton.Visible = false;
            CancelarButton.Visible = true;
            GuardarButton.Visible = false;
            LimpiarControlesPersonalizados();
            Tool.LimpiarControlesEstandar(Controls);
            Tool.MostrarInformacion("Complete los campos y luego pulse Aceptar");
        }
        #endregion

        #region MUESTRA DE DATOS
        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Vehiculo vehiculo = (Vehiculo)ListadoDgv.Rows[e.RowIndex].DataBoundItem;

                CodigoTextbox.Text = vehiculo.Codigo.ToString();
                TipoCombobox.Text = vehiculo.Tipo.ToString();
                MarcaControl.Marca = vehiculo.Marca;
                ModeloControl.Modelo = vehiculo.Modelo;
                PatenteControl.Patente = vehiculo.Patente;
            }
        }
        #endregion

        #region VALIDACIONES MORFOLÓGICAS
        private void ValidarCampos(object sender, EventArgs e)
        {
            bool validado = ValidarCampos();
            bool cancelado = CancelarButton.Visible;

            // Cancelado oculto: modo alta alta (guardar no debe participar de esta validación)
            GuardarButton.Visible = validado && cancelado;
            AltaButton.Visible = validado && !cancelado;
            ModificacionButton.Visible = validado && !cancelado;
        }


        private bool ValidarCampos()
        {
            bool marca = MarcaControl.Validar();
            bool modelo = ModeloControl.Validar();
            bool patente = PatenteControl.Validar();

            bool validado = marca && modelo && patente;

            return validado;
        }
        #endregion
    }
}
