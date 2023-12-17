using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjectManagement.Repositories;
using ProjectManagement.Entities;

namespace ProjectManagement.UserControls
{
    public partial class EmployeeUserControl : UserControl
    {
        Employee selectedEmployee = null;
        public EmployeeUserControl()
        {
            InitializeComponent();
            UpdateEmployeeGrid();
        }

        public void SaveEmployee()
        {
            if (ControlInputs())
            {
                MessageBox.Show("Tüm alanları doldurunuz", "Eksik veri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            DateTime dogumTarihi = datedogumTarihi.Value;
            string passwordd = txtPassword.Text;
            PersonRepository.SavePerson(ad, soyad, email, telefon, adres, dogumTarihi, employeePicturebox.ImageLocation,passwordd);
            UpdateEmployeeGrid();
            ClearAll();
        }

        private void UpdateEmployeeGrid()
        {
            employeeGridView.DataSource = PersonRepository.GetEmployeeList();
        }

        private bool ControlInputs()
        {
            return string.IsNullOrEmpty(txtAd.Text) ||
                string.IsNullOrEmpty(txtAdres.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtTelefon.Text) ||
                datedogumTarihi.Value == null ||
                string.IsNullOrEmpty(employeePicturebox.ImageLocation) ||
                 string.IsNullOrEmpty(txtPassword.Text);

        }

        public void ClearAll()
        {
            txtAd.Text = null;
            txtAdres.Text = null;
            txtEmail.Text = null;
            txtSoyad.Text = null;
            txtTelefon.Text = null;
            employeePicturebox.ImageLocation = null;
            employeePicturebox.Image = null;
            selectedEmployee = null;
            txtPassword.Text = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";
                openFileDialog.Title = "Fotoğraf Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    employeePicturebox.ImageLocation = openFileDialog.FileName;
                    LoadImageFromFile(openFileDialog.FileName);
                }
            }
        }

        private void employeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;


            if (columnIndex != -1)
            {
                int selectedId = Convert.ToInt32(employeeGridView.Rows[e.RowIndex].Cells["Id"].Value);

                Employee employee = PersonRepository.FindById(selectedId);
                if(employee != null)
                    fillFields(employee);
            }
        }

        private void LoadImageFromFile(string imagePath)
        {
            try
            {
                // Resmi dosya yolundan al ve PictureBox'a yükle
                employeePicturebox.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim yükleme hatası: " + ex.Message);
            }
        }

        private void fillFields(Employee employe)
        {
            selectedEmployee = employe;
            txtAd.Text = employe.Ad;
            txtSoyad.Text = employe.Soyad;
            txtEmail.Text = employe.Email;
            txtTelefon.Text = employe.TelefonNumarasi;
            txtAdres.Text = employe.Adres;
            employeePicturebox.ImageLocation = employe.Fotograf;
            txtPassword.Text = employe.Password;
            datedogumTarihi.Value = employe.DogumTarihi;
            LoadImageFromFile(employe.Fotograf);

        }
        private void updateSelectedEmployee()
        {
            selectedEmployee.Ad = txtAd.Text;
            selectedEmployee.Soyad = txtSoyad.Text;
            selectedEmployee.Email = txtEmail.Text;
            selectedEmployee.Adres = txtAdres.Text;
            selectedEmployee.TelefonNumarasi = txtTelefon.Text;
            selectedEmployee.DogumTarihi = datedogumTarihi.Value;
            selectedEmployee.Fotograf = employeePicturebox.ImageLocation;
            selectedEmployee.Password = txtPassword.Text;
        }

        public void DeleteEmployee()
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("Bir Kişi Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProjectEmployeeReposityory.DeleteEmployee(selectedEmployee.Id);
            ClearAll();
            UpdateEmployeeGrid();
        }
        public void UpdateEmployee()
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("Bir Kişi Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateSelectedEmployee();
            PersonRepository.UpdateEmployee(selectedEmployee);
            ClearAll();
            UpdateEmployeeGrid();
        }

    }
}
