using VCL;


namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        public ClienteForm()
        {
            InitializeComponent();
            _ = new ClienteVCL(this);
        }
    }
}