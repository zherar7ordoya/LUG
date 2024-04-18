using System;
using System.Windows.Forms;
using BEL;
using ABS;
using SVC;

namespace VCL
{
    public partial class VehiculoVCL
    {
        readonly Form formulario;
        private EstadoFormulario estado = EstadoFormulario.Normal;

        // Los controles del formulario
        ComboBox TipoCombobox;
        Button GuardarButton;
        Button CancelarButton;
        DataGridView ListadoDgv;
        IMarcaControl MarcaControl;
        IModeloControl ModeloControl;
        IPatenteControl PatenteControl;
        TextBox CodigoTextbox;

        public VehiculoVCL(Form formulario)
        {
            this.formulario = formulario;
            IncializarControles();
            formulario.Load += FormularioLoad;
        }

        private void IncializarControles()
        {
            TipoCombobox = (ComboBox)formulario.Controls["TipoCombobox"];
            GuardarButton = (Button)formulario.Controls["GuardarButton"];
            CancelarButton = (Button)formulario.Controls["CancelarButton"];
            ListadoDgv = (DataGridView)formulario.Controls["ListadoDgv"];
            MarcaControl = (IMarcaControl)formulario.Controls["MarcaControl"];
            ModeloControl = (IModeloControl)formulario.Controls["ModeloControl"];
            PatenteControl = (IPatenteControl)formulario.Controls["PatenteControl"];
            CodigoTextbox = (TextBox)formulario.Controls["CodigoTextbox"];
        }


        private void FormularioLoad(object sender, EventArgs e)
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
            Tool.ConfigurarBotones(formulario, estado, validado);
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
                Tool.LimpiarFormularioVehiculo(formulario.Controls);
                estado = EstadoFormulario.Alta;
                ConfigurarFormulario();
                Mensajeria.MostrarInformacion("Complete los campos y luego pulse Guardar");
            }
            else
            {
                if (estado == EstadoFormulario.Alta) Agregar(this, e);
                else if (estado == EstadoFormulario.Modificacion) Modificar(this, e);
            }
        }


        private void BotonCancelar(object sender, EventArgs e)
        {
            DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea cancelar?");
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
