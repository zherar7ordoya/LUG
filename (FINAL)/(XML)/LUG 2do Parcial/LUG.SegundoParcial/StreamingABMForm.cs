using LUG.BE;
using LUG.BLL;
using LUG.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LUG.SegundoParcial
{
    public partial class StreamingABMForm : Form
    {
        private BLLStreamingLive _bLLStreamingLive;
        private BLLStreamingVod _bLLStreamingVod;
        public StreamingABMForm()
        {
            InitializeComponent();            
            _bLLStreamingLive = new BLLStreamingLive();
            _bLLStreamingVod = new BLLStreamingVod();
        }

        private void CargarComboBoxCategoria()
        {
            try {
                comboBoxCategoria.DataSource = null;
                comboBoxCategoria.DataSource = Enum.GetValues(typeof(ECategoria));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarComboBoxTipoReproduccion()
        {
            try {
                comboBoxTipoReproduccion.DataSource = null;
                comboBoxTipoReproduccion.DataSource = Enum.GetValues(typeof(ETipoReproduccion));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
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
                if (string.IsNullOrEmpty(textBoxNombre.Text)) {
                    throw new Exception("El nombre es mandatorio");
                }
                if (!Regex.IsMatch(textBoxDuracion.Text, @"^[0-9]*$")) {
                    throw new Exception("La duracion debe ser solo numerica");
                }
                if (comboBoxCategoria.SelectedItem == null) {
                    throw new Exception("La cateegoria es mandatoria");
                }
                if (radioButtonLive.Checked) {
                    if (fechaTransmicion.Value.ToString() == "") {
                        throw new Exception("La fecha de transmicion mandatoria");
                    }
                    _bLLStreamingLive.Guardar(new BEStreamingLive
                    {
                        Categoria = (ECategoria)comboBoxCategoria.SelectedItem,
                        Nombre = textBoxNombre.Text,
                        Codigo = string.IsNullOrEmpty(textBoxCodigo.Text) ? 0 : Convert.ToInt64(textBoxCodigo.Text),
                        Duracion = Convert.ToDouble(textBoxDuracion.Text),
                        FechaTransmicion = Convert.ToDateTime(fechaTransmicion.Text),
                    });
                } else {
                    if (comboBoxTipoReproduccion.SelectedItem == null) {
                        throw new Exception("El tipo de reproduccion es obligatorio");
                    }
                    _bLLStreamingVod.Guardar(new BEStreamingVod
                    {
                        Nombre = textBoxNombre.Text,
                        Categoria = (ECategoria)comboBoxCategoria.SelectedItem,
                        Codigo = string.IsNullOrEmpty(textBoxCodigo.Text) ? 0 : Convert.ToInt64(textBoxCodigo.Text),
                        Duracion = Convert.ToDouble(textBoxDuracion.Text),
                        TipoReproduccion = (ETipoReproduccion)comboBoxTipoReproduccion.SelectedItem
                    });
                }                
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
                CargarComboBoxCategoria();
                CargarDataGrid();
                CargarComboBoxTipoReproduccion();
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
                    var streaming = (BEStreaming)dataGridView1.CurrentRow.DataBoundItem;
                    var button = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
                    if (button.Text == "Remover") {
                        if (streaming is BEStreamingLive)
                            _bLLStreamingLive.Eliminar(streaming as BEStreamingLive);
                        else
                            _bLLStreamingVod.Eliminar(streaming as BEStreamingVod);
                        CargarDataGrid();
                    } else {
                        CargarStreaming(streaming);
                        MostrarOcultarBotones(true);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarStreaming(BEStreaming bEStreaming)
        {
            try {
                if (bEStreaming is BEStreamingLive) {
                    var streaming = _bLLStreamingLive.Obtener(bEStreaming as BEStreamingLive);
                    textBoxDuracion.Text = streaming.Duracion.ToString();
                    textBoxCodigo.Text = streaming.Codigo.ToString();
                    textBoxNombre.Text = streaming.Nombre.ToString();
                    comboBoxCategoria.SelectedItem = streaming.Categoria;
                    comboBoxCategoria.Text = streaming.Categoria.ToString();
                    radioButtonLive.Checked = true;
                    fechaTransmicion.Value = streaming.FechaTransmicion;
                    RadioButtonTipo_Checked(null, null);
                } else {
                    var streaming = _bLLStreamingVod.Obtener(bEStreaming as BEStreamingVod);
                    textBoxDuracion.Text = streaming.Duracion.ToString();
                    textBoxNombre.Text = streaming.Nombre.ToString();
                    textBoxCodigo.Text = streaming.Codigo.ToString();
                    comboBoxCategoria.SelectedItem = streaming.Categoria;
                    comboBoxCategoria.Text = streaming.Categoria.ToString();
                    radioButtonVod.Checked = true;
                    comboBoxTipoReproduccion.SelectedItem = (ETipoReproduccion)streaming.TipoReproduccion;
                    comboBoxTipoReproduccion.Text = streaming.TipoReproduccion.ToString();
                    RadioButtonTipo_Checked(null, null);
                }                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDataGrid()
        {
            try {
                List<BEStreaming> streamings = new List<BEStreaming>();
                streamings.AddRange(_bLLStreamingLive.Obtener());
                streamings.AddRange(_bLLStreamingVod.Obtener());

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = streamings.OrderBy(a => a.Codigo).ToList();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try {
                textBoxDuracion.Text = string.Empty;
                textBoxCodigo.Text = string.Empty;
                textBoxNombre.Text = string.Empty;
                comboBoxCategoria.SelectedItem = null;
                comboBoxTipoReproduccion.SelectedItem = null;
                fechaTransmicion.Text = string.Empty;
                radioButtonLive.Checked = false;
                radioButtonVod.Checked = false;
                RadioButtonTipo_Checked(null, null);
            } catch (Exception ex) {
                throw ex;
            }
        }

        private void RadioButtonTipo_Checked(object sender, EventArgs e)
        {
            try {
                if (radioButtonLive.Checked) {
                    radioButtonVod.Checked = false;
                    labelTipoReproduccion.Visible = false;
                    comboBoxTipoReproduccion.Visible = false;
                    labelFechaTransmicion.Visible = true;
                    fechaTransmicion.Visible = true;
                } else if (radioButtonVod.Checked)  {
                    radioButtonLive.Checked = false;
                    labelTipoReproduccion.Visible = true;
                    comboBoxTipoReproduccion.Visible = true;
                    labelFechaTransmicion.Visible = false;
                    fechaTransmicion.Visible = false;                    
                } else {
                    labelTipoReproduccion.Visible = false;
                    comboBoxTipoReproduccion.Visible = false;
                    labelFechaTransmicion.Visible = false;
                    fechaTransmicion.Visible = false;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
