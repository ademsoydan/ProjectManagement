using ProjectManagement.Entities;
using ProjectManagement.Interfaces;
using ProjectManagement.Repositories;
using ProjectManagement.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectManagement.UserControls
{
    public partial class LogInUserControl : UserControl
    {
        Form loginForm;
        IMainForm mainForm;
        public LogInUserControl(Form loginForm, Form1 mainForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.mainForm = mainForm;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidationUtil.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Geçerli Bir Email adresi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = PersonRepository.GetEmployeebyEmailAndPassword(txtEmail.Text,txtPassword.Text);
            if (employee != null)
            {
                mainForm.ControlLoginAcitons(employee);
                MessageBox.Show("Hoşgeldin " + employee.Ad, "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginForm.Close();
            }

        }


    }
}
