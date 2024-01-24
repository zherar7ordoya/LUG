using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace Presentacion
{
    // Verde comentario
    public partial class ABMDesconectaado : Form
    {
        /* VERDE COMENTARIO */
        public ABMDesconectaado() => InitializeComponent();
        readonly SqlConnection conexion = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=LUG;
                Integrated Security=True");

        //CREO EL OBJETO PERSONA SOLO PARA USAR EL LISTAR.
        readonly ClsPersona persona = new ClsPersona();

        //DECLARAMOS EL DATASET.
        DataSet dataset = new DataSet();

        //DECLARAMOS EL DATAROW PARA APROVECHAR LOS EVENTOS DEL FORMULARIO.
        DataRow datarow;

        //DECLARAMOS EL DATAADAPTER PARA APROVECHAR LOS EVENTOS DEL FORMULARIO.
        SqlDataAdapter adaptador;

        //UTILIZAREMOS ESTE ENUMERADO Y ESTA VARIABLE COMO FLAG PARA SABER SI
        //VAMOS A MODIFICAR O AGREGAR UNA PERSONA.
        enum Accion
        {
            Modificar = 1,
            Nuevo = 2
        }

        Accion accion;


        //||||||||||||||||||||||||||||||||||||||||| PROCESO DE CARGA Y DESCARGA


        private void LoadForm(object sender, EventArgs e)
        {
            SetearGrilla();
            CargarGrilla();

            //SE SETEAN LOS BOTONES
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnDeshacer.Enabled = false;

            RegistrosDGV.ClearSelection();
        }

        public void SetearGrilla()
        {
            DataGridView grilla = RegistrosDGV;
            DataGridViewColumnCollection columna = grilla.Columns;

            columna.Add("cEstado", "Estado");
            columna.Add("cId", "Id");
            columna.Add("cNombre", "Nombre");
            columna.Add("cApellido", "Apellido");
            columna.Add("cDireccion", "Dirección");

            columna["cId"].Width = 32;
            columna["cId"].DataPropertyName = "Persona_id";
            columna["cId"].ReadOnly = true;
            columna["cNombre"].Width = 110;
            columna["cNombre"].DataPropertyName = "Persona_nombre";
            columna["cNombre"].ReadOnly = true;
            columna["cApellido"].Width = 110;
            columna["cApellido"].DataPropertyName = "Persona_apellido";
            columna["cApellido"].ReadOnly = true;
            columna["cDireccion"].Width = 120;
            columna["cDireccion"].ReadOnly = true;
            columna["cDireccion"].DataPropertyName = "Persona_direccion";

            grilla.AllowDrop = false;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeColumns = false;
            grilla.AllowUserToResizeRows = false;
            grilla.RowHeadersVisible = true;
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.MultiSelect = false;
        }

        public void CargarGrilla()
        {
            dataset = persona.ListarSinSaldo();
            //ENLAZAMOS LA GRILLA 
            RegistrosDGV.DataSource = null;
            RegistrosDGV.DataSource = dataset.Tables[0];
        }


        private void UnloadForm(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_ABMDesconectaado = false;
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BOTONES


        private void Guardar_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case Accion.Modificar:
                    // MODIFICAMOS LOS CAMPOS EN EL DATAROW QUE HABIAMOS
                    // OBTENIDO EN EL METODO "".
                    datarow["persona_nombre"] = txtNombre.Text;
                    datarow["persona_apellido"] = txtApellido.Text;
                    datarow["persona_direccion"] = txtDireccion.Text;
                    RegistrosDGV.SelectedRows[0].Cells[0].Value = datarow.RowState.ToString();
                    break;

                case Accion.Nuevo:
                    // ACTUALIZAMOS EL ULTIMO ID DE PERSONA EN LA SEGUNDA TABLA
                    // DE NUESTRO DATASET.
                    dataset.Tables[1].Rows[0][0] = (int.Parse(dataset.Tables[1].Rows[0][0].ToString())) + 1;
                    txtId.Text = dataset.Tables[1].Rows[0][0].ToString();

                    // OBTENEMOS UNA NUEVA ROW PARA LA TABLA "PERSONA" Y LE
                    // PASAMOS LOS DATOS DE NUESTRA CAJAS DE TEXTO.
                    datarow = dataset.Tables[0].NewRow();
                    datarow["persona_id"] = Convert.ToInt32(txtId.Text);
                    datarow["persona_nombre"] = txtNombre.Text;
                    datarow["persona_apellido"] = txtApellido.Text;
                    datarow["persona_direccion"] = txtDireccion.Text;

                    // SE AGREGA LA NUEVA ROW AL DATATABLE
                    dataset.Tables[0].Rows.Add(datarow);

                    RegistrosDGV.Rows[RegistrosDGV.Rows.Count - 1].Selected = true;
                    RegistrosDGV.SelectedRows[0].Cells[0].Value = datarow.RowState.ToString();

                    break;
            }

            // SETEMOS LOS BOTONES E INTERFAZ DE USUARIO
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDireccion.Text = null;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            RegistrosDGV.Enabled = true;

            if ((RegistrosDGV.SelectedRows.Count > 0))
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnDeshacer.Enabled = true;
            }

            btnNuevo.Enabled = true;
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDireccion.Text = null;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            RegistrosDGV.Enabled = true;

            if (RegistrosDGV.SelectedRows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            btnNuevo.Enabled = true;
        }

        //---------------------------------------------------------------------


        private void Nuevo_Click(object sender, EventArgs e)
        {
            // SETEO DE LOS BOTONES E INTERFAZ
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDireccion.Text = null;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            RegistrosDGV.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;

            if (dataset.Tables[1].Rows[0] is null == false && IsNumeric(dataset.Tables[1].Rows[0][0].ToString()))
            {
                int a = (int.Parse(dataset.Tables[1].Rows[0][0].ToString())) + 1;
                txtId.Text = a.ToString();
            }
            else { txtId.Text = "1"; }

            // ESTE FLAG LO UTILIZAMOS PARA QUE AL PRESIONAR EL BOTON GUARDAR
            // SEPAMOS QUÉ ESTAMOS HACIENDO: SI ESTAMOS AGREGANDO UNA NUEVA
            // PERSONA O SI ESTAMOS MODIFICANDO UNA.
            accion = Accion.Nuevo;
        }


        private void Modificar_Click(object sender, EventArgs e)
        {
            //SI HAY UNA FILA SELECCONADA SE LLENAN LOS CAMPOS PARA MODIFICARSE
            {
                if (RegistrosDGV.SelectedRows.Count > 0)
                {
                    //RESGUARDAMOS EL DATAROW QUE ESTA ENLAZADO AL ROW
                    //SELECCIONADO EN LA VARIABLE DECLARADA CON AMBITO DE CLASE
                    //(FORMULARIO) PARA PODER ACCEDERLO DESDE EL METODO GUARDAR.
                    datarow = ((DataRowView)RegistrosDGV.SelectedRows[0].DataBoundItem).Row;

                    //LLENAMOS LOS CAMPOS CON LOS VALORES ACTUALES DEL DATAROW
                    txtId.Text = datarow[0].ToString();
                    txtNombre.Text = datarow[1].ToString();
                    txtApellido.Text = datarow[2].ToString();
                    txtDireccion.Text = datarow[3].ToString();

                    //SETEMAMOS LOS BOTONES E INTERFAZ DE USUARIO
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtDireccion.Enabled = true;

                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;

                    RegistrosDGV.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnNuevo.Enabled = false;

                    //ESTE FLAG LO UTILIZAMOS PARA QUE AL PRESIONAR EL BOTON
                    //GUARDAR SEPAMOS QUE ESTAMOS HACIENDO. SI ESTAMOS
                    //AGREGANDO UNA NUEVA PERSONA O SI ESTAMOS MODIFICANDO UNA.
                    accion = Accion.Modificar;
                }
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (RegistrosDGV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"¿Eliminar a {RegistrosDGV.SelectedRows[0].Cells[2].Value} " +
                    $"{RegistrosDGV.SelectedRows[0].Cells[3].Value}?",
                    "Eliminación",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //EL USUARIO CONFIRMO LA ELIMINACION Y SE PROCEDE A
                    //ELIMINAR EL DATAROW DEL DATASET QUE ESTA ENLAZADO A LA
                    //ROW SELECCIONADA DE LA GRILLA.
                    ((DataRowView)
                        RegistrosDGV.SelectedRows[0]
                        .DataBoundItem)
                        .Row
                        .Delete();
                }
                else { MessageBox.Show("Cancelado"); }
            }
        }


        private void Deshacer_Click(object sender, EventArgs e)
        {
            //SE DESHACE EL CAMBIO PARA LA FILA SELECCIONADA
            ((DataRowView)RegistrosDGV.SelectedRows[0].DataBoundItem).Row.RejectChanges();

            //SE DESHABILITA EL BOTON PARA DESHACER CAMBIOS EN ESE DATAROW
            btnDeshacer.Enabled = false;
        }


        //---------------------------------------------------------------------


        private void Grabar_Click(object sender, EventArgs e)
        {
            //SETEO DATAADAPTER CON COnsulta Y CONNECTIONSTRING         
            adaptador = new SqlDataAdapter(
                "SELECT Persona_id, Persona_nombre, Persona_apellido, Persona_direccion " +
                "FROM Persona; " +
                "SELECT MAX(persona_id) " +
                "FROM Persona;", conexion);

            //SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder Cb = new SqlCommandBuilder(adaptador);
            adaptador.UpdateCommand = Cb.GetUpdateCommand();
            adaptador.DeleteCommand = Cb.GetDeleteCommand();
            adaptador.InsertCommand = Cb.GetInsertCommand();
            adaptador.ContinueUpdateOnError = true;

            //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            adaptador.Update(dataset.Tables[0]);
        }


        private void Descartar_Click(object sender, EventArgs e)
        {
            //SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET. SI ALGUN DATAROW
            //HABIA SIDO AGREGADO Y SE AUMENTO EL MAXIMO ID EN NUESTRA SEGUNDA
            //TABLA, TAMBIEN SE DESCARTAN ESOS CAMBIOS. POR ESO SE DESHACEN LOS
            //CAMBIOS DE TODO EL DATASET Y NO SOLO DE LA TABLA PERSONA.
            dataset.RejectChanges();
        }


        private void Cargar_Click(object sender, EventArgs e)
        {
            dataset.Tables[0].Rows.Clear();
            CargarGrilla();
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| OTROS


        public static bool IsNumeric(string valor) => int.TryParse(valor, out _);


        private void Grilla_Click(object sender, DataGridViewCellEventArgs e)
        {
            if ((RegistrosDGV.SelectedRows.Count > 0))
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnDeshacer.Enabled = ((DataRowView)(RegistrosDGV.SelectedRows[0].DataBoundItem)).Row.RowState != DataRowState.Unchanged;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }


    }
}
