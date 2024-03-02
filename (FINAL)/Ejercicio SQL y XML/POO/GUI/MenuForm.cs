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
        }

        private void FormularioLoad(object sender, EventArgs e)
        {
            CerrarSesionMenu.Click += CerrarSesion;
            SalirMenuItem.Click += MenuSalir;
            ClienteMenuItem.Click += MenuCliente;
            RentaMenuItem.Click += MenuRenta;
            VehiculoMenuItem.Click += MenuVehiculo;
            DashboardMenuItem.Click += MenuDashboard;
            AcercaMenuItem.Click += MenuAcerca;
            ClienteReportMenu.Click += MenuReporte;
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            Application.Restart();
            //Close();
        }

        private void FormularioClosing(object sender, FormClosingEventArgs e)
        {
            // Se puede verificar la propiedad CloseReason para determinar
            // cómo se está cerrando el formulario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS ||

        private void MenuSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
        private void MenuDashboard(object sender, EventArgs e)
        {
            DashboardForm formulario = new DashboardForm();
            formulario.ShowDialog();
        }
        private void MenuAcerca(object sender, EventArgs e)
        {
            AcercaForm formulario = new AcercaForm();
            formulario.ShowDialog();
        }

        //*<==------------------------------------------------------------==>*\\

        private void MenuReporte(object sender, EventArgs e)
        {
            ClienteReportForm formulario = new ClienteReportForm();
            formulario.ShowDialog();
        }
    }
}
