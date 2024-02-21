using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuForm : BaseForm
    {
        public MenuForm() => InitializeComponent();
        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Asignar Eventos
            SalirMenuItem.Click += MenuSalir;
            ClienteMenuItem.Click += MenuCliente;
            RentaMenuItem.Click += MenuRenta;
            VehiculoMenuItem.Click += MenuVehiculo;
            DashboardMenuItem.Click += MenuDashboard;
            AcercaMenuItem.Click += MenuAcerca;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS ||

        private void MenuSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuCliente(object sender, EventArgs e)
        {
            ClienteForm formulario = new ClienteForm();
            formulario.ShowDialog();
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
    }
}
