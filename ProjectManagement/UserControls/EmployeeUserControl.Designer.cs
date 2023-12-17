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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datedogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.pROJECTMANAGEMENTDataSet = new ProjectManagement.PROJECTMANAGEMENTDataSet();
            this.pROJECTMANAGEMENTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTMANAGEMENTDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            this.employeePicturebox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(92, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(92, 48);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon : ";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(79, 160);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(172, 47);
            this.txtAdres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(92, 103);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(159, 20);
            this.txtTelefon.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "D. Tarihi : ";
            // 
            // datedogumTarihi
            // 
            this.datedogumTarihi.Location = new System.Drawing.Point(359, 187);
            this.datedogumTarihi.Name = "datedogumTarihi";
            this.datedogumTarihi.Size = new System.Drawing.Size(172, 20);
            this.datedogumTarihi.TabIndex = 12;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // employeeGridView
            // 
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
            this.employeeGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeGridView.Location = new System.Drawing.Point(0, 264);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.Size = new System.Drawing.Size(820, 255);
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
            // employeePicturebox
            // 
            this.employeePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.employeePicturebox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.employeePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("employeePicturebox.Image")));
            this.employeePicturebox.InitialImage = ((System.Drawing.Image)(resources.GetObject("employeePicturebox.InitialImage")));
            this.employeePicturebox.Location = new System.Drawing.Point(330, 22);
            this.employeePicturebox.Name = "employeePicturebox";
            this.employeePicturebox.Size = new System.Drawing.Size(201, 124);
            this.employeePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePicturebox.TabIndex = 16;
            this.employeePicturebox.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(399, 149);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Fotograf Sec";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(363, 235);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Guncelle";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(282, 235);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(189, 235);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Temizle";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.employeePicturebox);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datedogumTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(820, 519);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTMANAGEMENTDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datedogumTarihi;
        private PROJECTMANAGEMENTDataSet pROJECTMANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource pROJECTMANAGEMENTDataSetBindingSource;
        private System.Windows.Forms.BindingSource pROJECTMANAGEMENTDataSetBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.PictureBox employeePicturebox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotograf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihi;
    }
}
