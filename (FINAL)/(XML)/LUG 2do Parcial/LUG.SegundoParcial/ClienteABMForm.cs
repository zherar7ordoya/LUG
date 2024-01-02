using LUG.BE;
using LUG.BLL;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LUG.SegundoParcial
{
    public partial class ClienteABMForm : Form
    {
        private BLLCliente _bLLCliente;
        public ClienteABMForm()
        {
            InitializeComponent();
            _bLLCliente = new BLLCliente();
        }

        private void MostrarOcultarBotones(bool ocultar = false)
        {
            try {                
                btnLimpiar.Visible = ocultar;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try {
                if (!Regex.IsMatch(textBoxApellido.Text, @"^[A-Z][a-zA-Z]*$")) {
                    throw new Exception("Para el apellido solo se admiten letras");
                }
                if (!Regex.IsMatch(textBoxNombre.Text, @"^[A-Z][a-zA-Z]*$")) {
                    throw new Exception("Para el nombre solo se admiten letras");
                }
                if (!Regex.IsMatch(textBoxDni.Text, @"^[0-9]{8}$")) {
                    throw new Exception("El DNI debe ser solo numerico y contener 8 numeros exactos");
                }
                if (!Regex.IsMatch(textBoxMail.Text, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.[a-zA-Z]{2,3})+$")) {
                    throw new Exception("Revisa el formato del mail");
                }
                var cliente = new BECliente
                {
                    Apellido = textBoxApellido.Text,
                    Codigo = string.IsNullOrEmpty(textBoxCodigo.Text) ? 0 : Convert.ToInt64(textBoxCodigo.Text),
                    DNI = long.Parse(textBoxDni.Text.ToString()),
                    Mail = textBoxMail.Text,
                    Nombre = textBoxNombre.Text,
                };
                _bLLCliente.Guardar(cliente);
                MostrarOcultarBotones();
                BtnLimpiar_Click(null, null);
                CargarDataGrid();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void ClienteABMForm_Load(object sender, EventArgs e)
        {
            try {
                ConfigurarDataGrid();
                CargarDataGrid();                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigurarDataGrid()
        {
            try {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Text = "Editar",
                    Name = "btnEditarCliente",
                    UseColumnTextForButtonValue = true
                };

                DataGridViewButtonColumn btnRemover = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Text = "Remover",
                    Name = "btnRemoverCliente",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnRemover });
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Accionar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) {
                    var cliente = (BECliente)dataGridView1.CurrentRow.DataBoundItem;
                    var button = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
                    if (button.Text == "Remover") {
                        _bLLCliente.Eliminar(new BECliente { Codigo = cliente.Codigo });
                        CargarDataGrid();
                    } else {
                        CargarCliente(cliente);
                        MostrarOcultarBotones(true);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCliente(BECliente bECliente)
        {
            try {
                var cliente = _bLLCliente.Obtener(bECliente);
                textBoxApellido.Text = cliente.Apellido;
                textBoxCodigo.Text = cliente.Codigo.ToString();
                textBoxDni.Text = cliente.DNI.ToString();
                textBoxMail.Text = cliente.Mail;
                textBoxNombre.Text = cliente.Nombre;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDataGrid()
        {
            try {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _bLLCliente.Obtener();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try {
                _bLLCliente.Eliminar(new BECliente { Codigo = long.Parse(textBoxCodigo.Text) });
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try {
                textBoxApellido.Text = string.Empty;
                textBoxCodigo.Text = string.Empty;
                textBoxDni.Text = string.Empty;
                textBoxMail.Text = string.Empty;
                textBoxNombre.Text = string.Empty;
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
