using BEL;

using System;
using System.Windows.Forms;

/* ************************************************************************** *\
La capa GUI se centra en la presentación de información de manera amigable y en
facilitar la interacción del usuario con la aplicación, sirviendo como un punto
de entrada visual a las funcionalidades de las capas subyacentes.
\* ************************************************************************** */

namespace GUI
{
    public partial class VehiculoForm : BaseForm
    {
        private EstadoFormulario estado = EstadoFormulario.Normal;
        public VehiculoForm() => InitializeComponent();


        private void VehiculoForm_Load(object sender, EventArgs e)
        {
            // Obtener los valores del enumerador VehiculoTipo y asignarlos al ComboBox
            VehiculoTipo[] tipos = (VehiculoTipo[])Enum.GetValues(typeof(VehiculoTipo));
            TipoCombobox.DataSource = tipos;

            InicializarEventHandlers();
            Consultar();
        }


        private void InicializarEventHandlers()
        {
            // Botones
            GuardarButton.Click += BotonGuardar;
            CancelarButton.Click += BotonCancelar;

            // DataGridViews
            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;

            // Estos eventos son críticos para el funcionamiento del formulario,
            // y se resumen en: todo aquello que el usuario pueda ingresar o modificar
            TipoCombobox.TextChanged += CompararDatos;
            MarcaControl.TextChanged += CompararDatos;
            ModeloControl.TextChanged += CompararDatos;
            PatenteControl.TextChanged += CompararDatos;
        }


        private void ConfigurarFormulario()
        {
            bool marca = MarcaControl.Validar();
            bool modelo = ModeloControl.Validar();
            bool patente = PatenteControl.Validar();

            bool validado = marca && modelo && patente;
            Tool.ConfigurarBotones(this, estado, validado);
        }

        #region ||*----------------------------------------------------> EVENTOS

        //|||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE DATAGRIDVIEW

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

        //|||||||||||||||||||||||||||||||||||||| EVENTOS DE CONTROLES DE USUARIO

        private void CompararDatos(object sender, EventArgs e)
        {
            if (ListadoDgv.CurrentRow != null) // Dato: es null durante el alta
            {
                Vehiculo vehiculo = (Vehiculo)ListadoDgv.SelectedRows[0].DataBoundItem;

                bool modificado = (MarcaControl.Marca != vehiculo.Marca) ||
                                  (TipoCombobox.Text != vehiculo.Tipo.ToString()) ||
                                  (ModeloControl.Modelo != vehiculo.Modelo) ||
                                  (PatenteControl.Patente != vehiculo.Patente);
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

        #endregion
    }
}
