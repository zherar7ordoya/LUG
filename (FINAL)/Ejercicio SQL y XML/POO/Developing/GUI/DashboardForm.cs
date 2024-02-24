using ABS;
using BLL;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
