using System;
using System.Data;
using System.Windows.Forms;

using BLL;

namespace Presentacion
{
    public partial class FrmCrearDS : Form
    {
        public FrmCrearDS() => InitializeComponent();

        Metodos oBLL = new Metodos();
        public DataSet dataset = new DataSet();

        private void FrmCrearDS_Load(object sender, EventArgs e)
        {
            BtnCargarDs.Enabled = false;
            BtnMostrarDs.Enabled = false;
            groupBoxFiltros.Enabled = false;
        }

        private void BtnCrearDs_Click(object sender, EventArgs e)
        {
            dataset = oBLL.ArmarDataSet();
            BtnCargarDs.Enabled = true;
        }

        private void BtnCargarDs_Click(object sender, EventArgs e)
        {
            //LE PASO EL DATASET A CARGAR.
            oBLL.CargarDataSet(dataset);
            BtnMostrarDs.Enabled = true;
        }

        private void BtnMostrarDs_Click(object sender, EventArgs e)
        {
            //1RA FORMA DE CARGAR.
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = dataset;
            dgvPersonas.DataMember = "Persona";

            //2DA FORMA DE CARGAR.
            dgvPaises.DataSource = null;
            dgvPaises.DataSource = dataset.Tables["Pais"];

            //HABILITAR FILTROS.
            groupBoxFiltros.Enabled = true;
        }


        // *-------------------------------------------------------=> 2DA PARTE


        private void FiltrarDataTable_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInicio.Text) || string.IsNullOrEmpty(txtFin.Text))
                {
                    MessageBox.Show("Debe ingresar los años para la búsqueda");
                    return;
                }

                DataTable datatable = dataset.Tables["Persona"];

                if (!int.TryParse(txtInicio.Text, out int inicioYear) || !int.TryParse(txtFin.Text, out int finYear))
                {
                    MessageBox.Show("Formato de año incorrecto");
                    return;
                }

                DateTime inicio = new DateTime(inicioYear, 1, 1);
                DateTime fin = new DateTime(finYear, 12, 31);

                // string filtro = $"FechaNac >= #{inicio.ToString("yyyy-MM-dd")}# AND FechaNac <= #{fin.ToString("yyyy-MM-dd")}#";
                string filtro = $"FechaNac >= #{inicio:yyyy-MM-dd}# AND FechaNac <= #{fin:yyyy-MM-dd}#";

                LimpiarYConfigurarGrilla();

                foreach (DataRow fila in datatable.Select(filtro, "FechaNac"))
                {
                    dgvFiltros.Rows.Add(
                        fila["Codigo_Persona"],
                        fila["Nombre"],
                        fila["Apellido"],
                        Convert.ToDateTime(fila["FechaNac"]).ToString("yyyy-MM-dd"), // Formatear la fecha correctamente
                        fila["Persona_Pais_Id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarYConfigurarGrilla()
        {
            dgvFiltros.Columns.Clear();

            // Agregar columnas a la grilla.
            dgvFiltros.Columns.Add("Codigo_Persona", "Código");
            dgvFiltros.Columns.Add("Nombre", "Nombre");
            dgvFiltros.Columns.Add("Apellido", "Apellido");
            dgvFiltros.Columns.Add("FechaNac", "Nacimiento");
            dgvFiltros.Columns.Add("Persona_Pais_Id", "Pais(Id)");

            dgvFiltros.DataSource = null;
        }












        private void FiltrarDataView_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataTable datatable = dataset.Tables["Persona"];
                DataView dataview = new DataView(datatable);

                if ((rdbPais.Checked || rdbApe.Checked) && (TxfiltroData.Text != string.Empty))
                {
                    FiltrarYMostrar(dataview, TxfiltroData.Text.Trim(), rdbPais.Checked);
                }
                else { MessageBox.Show("Debe seleccionar una opción y llenar el campo de búsqueda."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FiltrarYMostrar(DataView dataview, string filtro, bool porPais)
        {
            string filtroQuery = porPais ? $"Persona_Pais_Id = {filtro}" : $"Apellido = '{filtro}'";

            // Aplicar filtro y ordenar.
            dataview.RowFilter = filtroQuery;
            dataview.Sort = "FechaNac";

            // Limpieza y asignación del DataSource.
            dgvFiltros.Columns.Clear();
            dgvFiltros.DataSource = null;
            dgvFiltros.DataSource = dataview;
        }



        private void LimpiarFiltro_ButtonClick(object sender, EventArgs e)
        {
            txtFin.Text = string.Empty;
            txtInicio.Text = string.Empty;
            TxfiltroData.Text = string.Empty;
            rdbApe.Checked = false;
            rdbPais.Checked = false;

            //COMO ESTOY EN MEMORIA, DEBO BORRAR LA GRILLA COMPLETA SINO QUEDAN
            //LAS COLUMNAS.
            dgvFiltros.Columns.Clear();
        }

        private void FrmCrearDS_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_FrmCrearDS = false;
        }
    }
}
