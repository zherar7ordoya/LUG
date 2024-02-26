using VCL;


namespace GUI
{
    public partial class DashboardForm : BaseForm
    {
        public DashboardForm()
        {
            InitializeComponent();
            _ = new DashboardVCL(this);
        }
    }
}
