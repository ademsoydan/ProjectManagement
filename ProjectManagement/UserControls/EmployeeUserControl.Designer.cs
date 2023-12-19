namespace ProjectManagement.UserControls
{
    partial class EmployeeUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUserControl));
            this.pROJECTMANAGEMENTDataSet = new ProjectManagement.PROJECTMANAGEMENTDataSet();
            this.pROJECTMANAGEMENTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTMANAGEMENTDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotograf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.employeePicturebox = new System.Windows.Forms.PictureBox();
            this.datedogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pROJECTMANAGEMENTDataSet
            // 
            this.pROJECTMANAGEMENTDataSet.DataSetName = "PROJECTMANAGEMENTDataSet";
            this.pROJECTMANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTMANAGEMENTDataSetBindingSource
            // 
            this.pROJECTMANAGEMENTDataSetBindingSource.DataSource = this.pROJECTMANAGEMENTDataSet;
            this.pROJECTMANAGEMENTDataSetBindingSource.Position = 0;
            // 
            // pROJECTMANAGEMENTDataSetBindingSource1
            // 
            this.pROJECTMANAGEMENTDataSetBindingSource1.DataSource = this.pROJECTMANAGEMENTDataSet;
            this.pROJECTMANAGEMENTDataSetBindingSource1.Position = 0;
            // 
            // employeeGridView
            // 
            this.employeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.password,
            this.telefonNumarasi,
            this.Fotograf,
            this.Soyad,
            this.Id,
            this.Email,
            this.Adres,
            this.dogumTarihi});
            this.employeeGridView.Location = new System.Drawing.Point(3, 340);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.Size = new System.Drawing.Size(814, 176);
            this.employeeGridView.TabIndex = 15;
            this.employeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGridView_CellContentClick);
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // telefonNumarasi
            // 
            this.telefonNumarasi.DataPropertyName = "telefon_numarasi";
            this.telefonNumarasi.HeaderText = "Tel No";
            this.telefonNumarasi.Name = "telefonNumarasi";
            // 
            // Fotograf
            // 
            this.Fotograf.DataPropertyName = "fotograf";
            this.Fotograf.HeaderText = "Fotograf";
            this.Fotograf.Name = "Fotograf";
            this.Fotograf.Visible = false;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.DataPropertyName = "dogum_tarihi";
            this.dogumTarihi.HeaderText = "D Tarihi";
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeeGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 519);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.employeePicturebox);
            this.panel1.Controls.Add(this.datedogumTarihi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 331);
            this.panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 54;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Şifre :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(406, 150);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 52;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Fotograf Sec";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // employeePicturebox
            // 
            this.employeePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.employeePicturebox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.employeePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("employeePicturebox.Image")));
            this.employeePicturebox.InitialImage = ((System.Drawing.Image)(resources.GetObject("employeePicturebox.InitialImage")));
            this.employeePicturebox.Location = new System.Drawing.Point(337, 23);
            this.employeePicturebox.Name = "employeePicturebox";
            this.employeePicturebox.Size = new System.Drawing.Size(201, 124);
            this.employeePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePicturebox.TabIndex = 51;
            this.employeePicturebox.TabStop = false;
            // 
            // datedogumTarihi
            // 
            this.datedogumTarihi.Location = new System.Drawing.Point(366, 188);
            this.datedogumTarihi.Name = "datedogumTarihi";
            this.datedogumTarihi.Size = new System.Drawing.Size(172, 20);
            this.datedogumTarihi.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "D. Tarihi : ";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(99, 104);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(159, 20);
            this.txtTelefon.TabIndex = 48;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(86, 161);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(172, 47);
            this.txtAdres.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Telefon : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Email :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtSoyad.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 20);
            this.txtAd.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ad : ";
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(820, 519);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PROJECTMANAGEMENTDataSet pROJECTMANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource pROJECTMANAGEMENTDataSetBindingSource;
        private System.Windows.Forms.BindingSource pROJECTMANAGEMENTDataSetBindingSource1;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotograf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox employeePicturebox;
        private System.Windows.Forms.DateTimePicker datedogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
    }
}
