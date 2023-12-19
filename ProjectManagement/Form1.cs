using ProjectManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class Form1 : Form
    {
        UserControl activeUserControl;
        EmployeeUserControl employeeUserControl;
        ProjectUserControl projectUserControl;
        TaskUserControl taskUserControl;
        public Form1()
        {
            InitializeComponent();
            CreateUserControls();
        }

        private void CreateUserControls()
        {
            employeeUserControl = new EmployeeUserControl();
            projectUserControl = new ProjectUserControl();
            taskUserControl = new TaskUserControl();
        }

        public void ChangeActiveUserControl(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.TabIndex)
            {
                case 1:
                    activeUserControl = projectUserControl;
                    break;
                case 2:
                    activeUserControl = taskUserControl;
                    break;
                case 3:
                    activeUserControl = employeeUserControl;
                    break;
            }
            ShowUserControl(activeUserControl);
        }
        private void ShowUserControl(UserControl activeUserControl)
        {
            userControlContainerPanel.Controls.Clear();
            userControlContainerPanel.Controls.Add(activeUserControl);
            activeUserControl.Dock = DockStyle.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            if (activeUserControl is EmployeeUserControl)
                employeeUserControl.SaveEmployee();
            else if (activeUserControl is ProjectUserControl)
                projectUserControl.SaveProject();
            else if (activeUserControl is TaskUserControl)
                taskUserControl.Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (activeUserControl is EmployeeUserControl)
                employeeUserControl.UpdateEmployee();
            else if (activeUserControl is ProjectUserControl)
                projectUserControl.UpdateProject();
            else if (activeUserControl is TaskUserControl)
                taskUserControl.UpdateTaskUserControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (activeUserControl is EmployeeUserControl)
                employeeUserControl.DeleteEmployee();
            else if (activeUserControl is ProjectUserControl) 
                projectUserControl.DeleteProject();
            else if (activeUserControl is TaskUserControl) 
                taskUserControl.DeleteTaskUserControl();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (activeUserControl is EmployeeUserControl)
                employeeUserControl.ClearAll();
            else if (activeUserControl is ProjectUserControl) 
                projectUserControl.ClearAll();
            else if (activeUserControl is TaskUserControl) 
                taskUserControl.ClearAllUserControl();
        }
    }
}
