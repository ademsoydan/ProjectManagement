﻿using ProjectManagement.Interfaces;
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
        IUserControl activeUserControl;
 
        public Form1()
        {
            InitializeComponent();
            ProjectUserControl projectUserControl = new ProjectUserControl();
            ShowUserControl(projectUserControl);
            activeUserControl = projectUserControl;
        }



        public void ChangeActiveUserControl(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.TabIndex)
            {
                case 1:
                    ProjectUserControl projectUserControl = new ProjectUserControl();
                    ShowUserControl(projectUserControl);
                    activeUserControl = projectUserControl;
                    break;
                case 2:
                    TaskUserControl taskUserControl = new TaskUserControl();
                    ShowUserControl(taskUserControl);
                    activeUserControl = taskUserControl;
                    break;
                case 3:
                    EmployeeUserControl employeeUserControl = new EmployeeUserControl();
                    ShowUserControl(employeeUserControl);
                    activeUserControl = employeeUserControl;
                    break;
            }
            
        }
        private void ShowUserControl(UserControl activeUserControl)
        {
            userControlContainerPanel.Controls.Clear();
            userControlContainerPanel.Controls.Add(activeUserControl);
            activeUserControl.Dock = DockStyle.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            activeUserControl.SaveOperation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            activeUserControl.UpdateOperation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            activeUserControl.DeleteOperation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            activeUserControl.ClearOperation();
        }
    }
}
