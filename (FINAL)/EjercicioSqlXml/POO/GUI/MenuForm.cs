using SVC;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuForm : BaseForm
    {
        public MenuForm(bool validado)
        {
            InitializeComponent();
            if (!validado)
            {
                Mensajeria.MostrarError("La clave ingresada es incorrecta");
            }
            this.GestorMenu.Enabled = validado;
            this.VerMenu.Enabled = validado;
            this.Load += FormularioLoad;
            this.FormClosing += FormularioClosing;
            // TODO => Implementar la salida mediante la tecla ESC
        }

        private void FormularioLoad(object sender, EventArgs e)
        {
            // Menú Archivo
            CerrarSesionMenu.Click += CerrarSesion;
            SalirMenuItem.Click += MenuSalir;

            // Menú Gestor
            ClienteMenuItem.Click += MenuCliente;
            RentaMenuItem.Click += MenuRenta;
            VehiculoMenuItem.Click += MenuVehiculo;

            // Menú Ver
            DashboardMenuItem.Click += MenuDashboard;
            ClienteReportMenu.Click += MenuReporte;

            // Menú Ayuda
            AcercaMenuItem.Click += MenuAcerca;
        }

        #region MENÚ ARCHIVO
        private void CerrarSesion(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MenuSalir(object sender, EventArgs e)
        {
            DialogResult result = Mensajeria.MostrarPregunta("¿Está seguro de que quiere salir?");
            if (result == DialogResult.Yes) Application.Exit();
        }

        // ¿Por qué? Porque el usuario puede cerrar el formulario con el botón
        // de cerrar (X).
        private void FormularioClosing(object sender, FormClosingEventArgs e)
        {
            // Se puede verificar la propiedad CloseReason para determinar
            // cómo se está cerrando el formulario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = Mensajeria.MostrarPregunta("¿Está seguro de que quiere salir?");
                if (result == DialogResult.Yes) Application.Exit();
                else e.Cancel = true;
            }
        }
        #endregion

        #region MENÚ GESTOR
        private void MenuCliente(object sender, EventArgs e)
        {
            ClienteForm formulario = new ClienteForm();
            formulario.ShowDialog(); // Singleton, ¡chupáte esta mandarina!
        }

        private void MenuRenta(object sender, EventArgs e)
        {
            RentaForm formulario = new RentaForm();
            formulario.ShowDialog();
        }

        private void MenuVehiculo(object sender, EventArgs e)
        {
            VehiculoForm formulario = new VehiculoForm();
            formulario.ShowDialog();
        }
        #endregion

        #region MENÚ VER
        private void MenuDashboard(object sender, EventArgs e)
        {
            DashboardForm formulario = new DashboardForm();
            formulario.ShowDialog();
        }

        private void MenuReporte(object sender, EventArgs e)
        {
            ClienteReportForm formulario = new ClienteReportForm();
            formulario.ShowDialog();
        }
        #endregion

        #region MENÚ AYUDA
        private void MenuAcerca(object sender, EventArgs e)
        {
            AcercaForm formulario = new AcercaForm();
            formulario.ShowDialog();
        }
        #endregion
    }
}
