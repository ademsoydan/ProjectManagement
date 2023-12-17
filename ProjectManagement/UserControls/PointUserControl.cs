using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.UserControls
{
    public partial class PointUserControl : UserControl
    {
        public PointUserControl(BindingSource gridViewSource)
        {
            InitializeComponent();
            grdPoints.DataSource = gridViewSource;
        }
    }
}
