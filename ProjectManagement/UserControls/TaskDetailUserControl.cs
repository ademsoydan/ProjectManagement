using ProjectManagement.Repositories;
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
    public partial class TaskDetailUserControl : UserControl
    {
        public TaskDetailUserControl(TaskUserControl taskUserControl,int pointId)
        {
            InitializeComponent();
            PopulateEmployeeCombobox();
        }

        private void PopulateEmployeeCombobox()
        {
            Dictionary<int, string> employeeData = PersonRepository.GetEmployeeData();
            foreach (var kvp in employeeData)
            {
                comboGorevli.DisplayMember = "Value";  // Burada "Value", göstermek istediğiniz değerin özelliğini temsil eder.
                comboGorevli.ValueMember = "Key";
                comboGorevli.Items.Add(new KeyValuePair<int, string>(kvp.Key, kvp.Value));
            }
        }

        private void comboGorevli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
