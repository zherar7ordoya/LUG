using BEL;

using BLL;

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
    public partial class ClienteForm : BaseForm
    {
        private Cliente cliente = new Cliente();
        private ClienteBLL clienteBLL = new ClienteBLL();

        public ClienteForm()
        {
            InitializeComponent();
            Listar();
        }


        private void Listar()
        {
            List<Cliente> clientes = clienteBLL.Consultar();
            ListadoDGV.DataSource = clientes;
        }

        private void Limpiar()
        {
            foreach (Control control in Controls)
            {
                if (control is DataGridView)
                {
                    ListadoDGV.DataSource = null;
                }

                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is DateTimePicker)
                {
                    control.Text = DateTime.Now.ToString();
                }
            }
        }

        private void Alta(object sender, EventArgs e)
        {
            Limpiar();
            AltaButton.Text = "Cancelar";
            ModificacionButton.Text = "Guardar";
        }

        private void Baja(object sender, EventArgs e)
        {
        }

        private void Modificacion(object sender, EventArgs e)
        {
        }




    }
}
