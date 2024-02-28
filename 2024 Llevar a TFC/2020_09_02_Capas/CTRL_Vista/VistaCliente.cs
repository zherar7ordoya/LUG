using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using ServiciosI;


namespace CTRL_Vista
{
    public class VistaCliente : Iambc<Alumno>
    {

        System.Windows.Forms.Form _f;
        Alumno _alumno;
        AlumnoBLL _alumnoBLL;
        List<MyControl> MyControls;
        int _id; string _nombre; string _apellido;  DateTime _fechaDeAlta; bool _activo;
        List<Alumno> _cacheListaAlumno;
        public VistaCliente(Form pForm)
        {
         MyControls = new List<MyControl>();
            // Se guarda en una variable privadala referencia al formulario que llega al parámetro del constructor
            _f = pForm;
            foreach (Control _c in _f.Controls)
            { MyControls.Add(new MyControl(_c.Name, _c)); }      
            ((DataGridView)MyControls.Find(x => x.Nombre=="DataGridView1").Puntero).Enter += EnterGrilla1;
            ((DataGridView)MyControls.Find(x => x.Nombre == "DataGridView1").Puntero).RowEnter += RowEnterGrilla1;
            ((Button)MyControls.Find(x => x.Nombre == "Button2").Puntero).Click += ClickButton2Alta;
            _f.Load += CargaDelFormulario;


            _alumno = new Alumno();
            _alumnoBLL= new AlumnoBLL();
           _cacheListaAlumno= new List<Alumno>();
        }
        #region "Funciones delegadas de eventos UI"
        private void RowEnterGrilla1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void EnterGrilla1(object sender, EventArgs e)
        {
            MessageBox.Show("Oprimieron Enter");
        }
        private void ClickButton2Alta(object sender, EventArgs e)
        {
            try 
            {
                _id = int.Parse(((TextBox)MyControls.Find(x => x.Nombre == "Id").Puntero).Text);
                //todo: validar id por no repetido.
                _nombre = ((TextBox)MyControls.Find(x => x.Nombre == "Nombre").Puntero).Text;
                _apellido = ((TextBox)MyControls.Find(x => x.Nombre == "Apellido").Puntero).Text;
                _fechaDeAlta = DateTime.Parse(((TextBox)MyControls.Find(x => x.Nombre == "FechaAlta").Puntero).Text);
                _activo = ((CheckBox)MyControls.Find(x => x.Nombre == "Activo").Puntero).Checked;
                Alta(_alumno);
            }
            catch (Exception ex) { MessageBox.Show($"Error en el Alta del cliente\n\n{ex.Message}"); }

           
        }
        public List<Alumno> VerLista() { return _cacheListaAlumno; }
        private void CargaDelFormulario(object sender, EventArgs e) 
        {
            DataGridView _dgv =(DataGridView)MyControls.Find(x => x.Nombre == "DataGridView1").Puntero;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.MultiSelect = false;
            _cacheListaAlumno = _alumnoBLL.CosultaTodo();
            Mostrar(_dgv, ListadoTemporalConsultaTotal());
        }

        #endregion
        private List<Alumno> ListadoTemporalConsultaTotal()
        {
            List<Alumno> _auxAlumno = new List<Alumno>();
            try 
            { 
            foreach (Alumno _a in _cacheListaAlumno) { _auxAlumno.Add(new Alumno(_a.Id, _a.Nombre, _a.Apellido, _a.Fecha_Alta, _a.Activo)); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return _auxAlumno;

        }
        private void Mostrar(DataGridView pDGV, object pO) { pDGV.DataSource = null;pDGV.DataSource = pO; }

        public void Alta(Alumno pAlumno)
        {
            _alumno.Id = _id;
            _alumno.Nombre = _nombre;
            _alumno.Apellido = _apellido;
             _alumno.Fecha_Alta = _fechaDeAlta;
             _alumno.Activo = _activo;
            _alumnoBLL.Alta(pAlumno);
            DataGridView _dgv = (DataGridView)MyControls.Find(x => x.Nombre == "DataGridView1").Puntero;
            _cacheListaAlumno = _alumnoBLL.CosultaTodo();
            Mostrar(_dgv, ListadoTemporalConsultaTotal());

        }

        public void Baja(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }

        public void ConsultaIndividual(Alumno pAlumno)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> ConsultaDesdeHasta(Alumno pAlumnoDesde, Alumno pAlumnoHasta)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> CosultaTodo()
        {
            throw new NotImplementedException();
        }
    }
    
}
