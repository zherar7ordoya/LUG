using VCL;


namespace GUI
{
    public partial class RentaForm : BaseForm
    {
        public RentaForm()
        {
            InitializeComponent();
            _ = new RentaVCL(this);
        }
    }
}
