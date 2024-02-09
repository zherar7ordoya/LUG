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
        public ClienteForm()
        {
            InitializeComponent();
           NuevoFormButton.Click += CrearForm;
        }



        private void CrearForm(object sender, EventArgs e)
        {
            // Crear un nuevo formulario en el aire
            Form formularioNuevoCliente = new Form();

            // Configurar propiedades del formulario
            formularioNuevoCliente.Text = "Nuevo Cliente";
            formularioNuevoCliente.Size = new System.Drawing.Size(300, 200);

            // Crear TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formularioNuevoCliente.Controls.Add(tableLayoutPanel);

            // Añadir controles al formulario (por ejemplo, TextBox y Label)
            Label lblNombre = new Label();
            lblNombre.Text = "Nombre:";
            tableLayoutPanel.Controls.Add(lblNombre, 0, 0);

            TextBox txtNombre = new TextBox();
            tableLayoutPanel.Controls.Add(txtNombre, 1, 0);

            // Añadir un botón para guardar
            Button btnGuardar = new Button();
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += (s, ev) =>
            {
                // Aquí puedes manejar la lógica para guardar el nuevo cliente
                // Puedes acceder a los valores de los controles, como el texto del TextBox (txtNombre.Text)

                // Cerrar el formulario
                formularioNuevoCliente.Close();
            };

            // Añadir el botón al TableLayoutPanel en la fila 1
            tableLayoutPanel.Controls.Add(btnGuardar, 0, 1);
            tableLayoutPanel.SetColumnSpan(btnGuardar, 2);

            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Mostrar el formulario
            formularioNuevoCliente.ShowDialog();
        }


    }
}
