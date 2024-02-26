using System.Windows.Forms;

namespace ABS
{
    /// <summary>
    /// VCL no conoce a GUI ni a sus formularios ni controles. Por eso se creó
    /// esta interfaz: para que el formulario pueda ser manipulado por la
    /// clase controladora.
    /// El código funciona en los distintos métodos porque ellos solo necesitan 
    /// acceder a propiedades específicas (en este caso, controles) que están
    /// definidas en esta interfaz. La interfaz sirve como una especie de
    /// contrato que especifica qué propiedades (o métodos) deberían estar
    /// disponibles en los objetos que se comportan como IVehiculoForm, y en
    /// este caso, el formulario cumple con ese contrato.
    /// </summary>
    public interface IVehiculoForm
    {
        DataGridView ListadoDgv { get; set; }
        TextBox CodigoTextbox { get; set; }
        ComboBox TipoCombobox { get; set; }
        IMarcaControl MarcaControl { get; set; }
        IModeloControl ModeloControl { get; set; }
        IPatenteControl PatenteControl { get; set; }
        Button CancelarButton { get; set; }
        Button GuardarButton { get; set; }
    }
}
