using VCL;


namespace GUI
{
    public partial class VehiculoForm : BaseForm
    {
        public VehiculoForm()
        {
            InitializeComponent();
            _ = new VehiculoVCL(this);
        }
    }
}
