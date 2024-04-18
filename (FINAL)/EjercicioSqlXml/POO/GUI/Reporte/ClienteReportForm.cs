using VCL;

namespace GUI
{
    // Ver nota en App.config
    public partial class ClienteReportForm : BaseForm
    {
        public ClienteReportForm()
        {
            InitializeComponent();
            _ = new ClienteReportVCL(this);
        }
    }
}
