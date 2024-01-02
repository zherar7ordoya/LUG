using LUG.BE;
using LUG.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace LUG.SegundoParcial
{
    public partial class ContratacionForm : Form
    {

        private BLLCliente _bLLCliente;
        private BLLStreamingLive _bLLStreamingLive;
        private BLLStreamingVod _bLLStreamingVod;
        public ContratacionForm()
        {
            InitializeComponent();
            _bLLCliente = new BLLCliente();
            _bLLStreamingLive = new BLLStreamingLive();
            _bLLStreamingVod = new BLLStreamingVod();
        }

        private void ContratacionForm_Load(object sender, EventArgs e)
        {
            try {
                ConfigurarDataGrid();
                CargarClientes();
                CargarStreaming();                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarStreaming()
        {
            try {
                var streamings = new List<BEStreaming>();
                streamings.AddRange(_bLLStreamingLive.Obtener());
                streamings.AddRange(_bLLStreamingVod.Obtener());
                comboBoxStreaming.DataSource = null;
                comboBoxStreaming.DisplayMember = "Nombre";
                comboBoxStreaming.ValueMember = "Codigo";
                comboBoxStreaming.DataSource = streamings;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarClientes()
        {
            try {                
                comboBoxClientes.DataSource = null;
                comboBoxClientes.DisplayMember = "DNI";
                comboBoxClientes.ValueMember = "Codigo";
                comboBoxClientes.DataSource = _bLLCliente.Obtener();
                comboBoxClientesConsultados.DataSource = null;
                comboBoxClientesConsultados.DisplayMember = "DNI";
                comboBoxClientesConsultados.ValueMember = "Codigo";
                comboBoxClientesConsultados.DataSource = _bLLCliente.Obtener();
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
                    Text = "Cancelar",
                    Name = "btnCancelar",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEditar });
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Accionar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) {
                    var contratacion = (BEClienteAsociadoStreaming)dataGridView1.CurrentRow.DataBoundItem;
                    var button = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;                                        
                    _bLLCliente.CancelarContratacion(contratacion.Cliente, contratacion.Streaming);                    
                    comboBoxClientesConsultados_SelectedIndexChanged(null, null);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxClientesConsultados_SelectedIndexChanged(object sender, EventArgs e)
        {           
            try {
                if (comboBoxClientesConsultados.SelectedItem != null) {
                    BECliente cliente = _bLLCliente.Obtener((BECliente)comboBoxClientesConsultados.SelectedItem);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _bLLCliente.ObtenerContrataciones(cliente);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }            
        }

        private void BtnContratar_Click(object sender, EventArgs e)
        {
            try {
                if (comboBoxStreaming.SelectedItem != null && comboBoxClientes.SelectedItem != null) {
                    _bLLCliente.Contratar((BECliente)comboBoxClientes.SelectedItem, (BEStreaming)comboBoxStreaming.SelectedItem);
                    
                    comboBoxClientesConsultados_SelectedIndexChanged(null, null);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
