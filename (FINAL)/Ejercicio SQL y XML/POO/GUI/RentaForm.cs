using BEL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // Controles de usuario
            ImporteControl.TextChanged += ValidarDatos;
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
            }
        }

        //|||||||||||||||||||||||||||||||||||||| EVENTOS DE CONTROLES DE USUARIO

        private void ValidarDatos(object sender, EventArgs e)
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

        private void BotonCalcular(object sender, EventArgs e)
        {
            // TODO: Implementar el cálculo de la renta
        }

        #endregion


    }
}
