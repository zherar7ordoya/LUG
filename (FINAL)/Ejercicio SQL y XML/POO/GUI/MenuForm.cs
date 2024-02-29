using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuForm : BaseForm
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Load += MenuLoad;
            this.FormClosing += MenuClosing;
        }

        private void MenuLoad(object sender, EventArgs e)
        {
            SalirMenuItem.Click += MenuSalir;
            ClienteMenuItem.Click += MenuCliente;
            RentaMenuItem.Click += MenuRenta;
            VehiculoMenuItem.Click += MenuVehiculo;
            DashboardMenuItem.Click += MenuDashboard;
            AcercaMenuItem.Click += MenuAcerca;
            ClienteReportMenu.Click += MenuReporte;
        }

        private void MenuClosing(object sender, FormClosingEventArgs e)
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
