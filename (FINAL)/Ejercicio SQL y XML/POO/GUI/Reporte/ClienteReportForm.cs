using System;

using VCL;

namespace GUI
{
    public partial class ClienteReportForm : BaseForm
    {
        public ClienteReportForm()
        {
            InitializeComponent();
            _ = new ClienteReportVCL(this);
        }
    }
}
