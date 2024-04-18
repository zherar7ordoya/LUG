using VCL;

namespace GUI
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            _ = new LoginVCL(this);
        }
    }
}
