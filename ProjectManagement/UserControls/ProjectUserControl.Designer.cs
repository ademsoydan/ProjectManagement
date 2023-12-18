namespace ProjectManagement.UserControls
{
    partial class ProjectUserControl
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
            this.projeTabControl = new System.Windows.Forms.TabControl();
            this.Tanim = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProblemTanimi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKapsam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStratejikEtki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tarih = new System.Windows.Forms.TabPage();
            this.dateTahminiBitis = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTahminiBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Ekip = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboManager = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Maddi = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.comboGelirTipi = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericGetiri = new System.Windows.Forms.NumericUpDown();
            this.Durum = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.comboProjeDurumu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboProjeTipi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proje_ismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjeYoneticisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parasalGetiri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeTabControl.SuspendLayout();
            this.Tanim.SuspendLayout();
            this.Tarih.SuspendLayout();
            this.Ekip.SuspendLayout();
            this.Maddi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGetiri)).BeginInit();
            this.Durum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projeTabControl
            // 
            this.projeTabControl.Controls.Add(this.Tanim);
            this.projeTabControl.Controls.Add(this.Tarih);
            this.projeTabControl.Controls.Add(this.Ekip);
            this.projeTabControl.Controls.Add(this.Maddi);
            this.projeTabControl.Controls.Add(this.Durum);
            this.projeTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.projeTabControl.Location = new System.Drawing.Point(0, 0);
            this.projeTabControl.Name = "projeTabControl";
            this.projeTabControl.SelectedIndex = 0;
            this.projeTabControl.Size = new System.Drawing.Size(742, 250);
            this.projeTabControl.TabIndex = 0;
            // 
            // Tanim
            // 
            this.Tanim.Controls.Add(this.deleteButton);
            this.Tanim.Controls.Add(this.UpdateButton);
            this.Tanim.Controls.Add(this.button1);
            this.Tanim.Controls.Add(this.txtProblemTanimi);
            this.Tanim.Controls.Add(this.label5);
            this.Tanim.Controls.Add(this.txtAmac);
            this.Tanim.Controls.Add(this.label4);
            this.Tanim.Controls.Add(this.txtKapsam);
            this.Tanim.Controls.Add(this.label3);
            this.Tanim.Controls.Add(this.txtStratejikEtki);
            this.Tanim.Controls.Add(this.label2);
            this.Tanim.Controls.Add(this.txtProjeAdi);
            this.Tanim.Controls.Add(this.label1);
            this.Tanim.Location = new System.Drawing.Point(4, 22);
            this.Tanim.Name = "Tanim";
            this.Tanim.Padding = new System.Windows.Forms.Padding(3);
            this.Tanim.Size = new System.Drawing.Size(734, 224);
            this.Tanim.TabIndex = 0;
            this.Tanim.Text = "Tanim";
            this.Tanim.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(374, 191);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(285, 191);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Güncelle";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Devam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.passNextTabPage);
            // 
            // txtProblemTanimi
            // 
            this.txtProblemTanimi.Location = new System.Drawing.Point(110, 155);
            this.txtProblemTanimi.Multiline = true;
            this.txtProblemTanimi.Name = "txtProblemTanimi";
            this.txtProblemTanimi.Size = new System.Drawing.Size(151, 59);
            this.txtProblemTanimi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Problem Tanımı :";
            // 
            // txtAmac
            // 
            this.txtAmac.Location = new System.Drawing.Point(392, 85);
            this.txtAmac.Multiline = true;
            this.txtAmac.Name = "txtAmac";
            this.txtAmac.Size = new System.Drawing.Size(138, 54);
            this.txtAmac.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amaç :";
            // 
            // txtKapsam
            // 
            this.txtKapsam.Location = new System.Drawing.Point(392, 23);
            this.txtKapsam.Multiline = true;
            this.txtKapsam.Name = "txtKapsam";
            this.txtKapsam.Size = new System.Drawing.Size(138, 56);
            this.txtKapsam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kapsam :";
            // 
            // txtStratejikEtki
            // 
            this.txtStratejikEtki.Location = new System.Drawing.Point(110, 80);
            this.txtStratejikEtki.Multiline = true;
            this.txtStratejikEtki.Name = "txtStratejikEtki";
            this.txtStratejikEtki.Size = new System.Drawing.Size(151, 59);
            this.txtStratejikEtki.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stratejik Etki:";
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(110, 24);
            this.txtProjeAdi.Multiline = true;
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(151, 50);
            this.txtProjeAdi.TabIndex = 2;
            this.txtProjeAdi.TextChanged += new System.EventHandler(this.txtProjeAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Adı :";
            // 
            // Tarih
            // 
            this.Tarih.Controls.Add(this.dateTahminiBitis);
            this.Tarih.Controls.Add(this.label10);
            this.Tarih.Controls.Add(this.button2);
            this.Tarih.Controls.Add(this.dateTahminiBaslangic);
            this.Tarih.Controls.Add(this.label9);
            this.Tarih.Controls.Add(this.dateBaslangic);
            this.Tarih.Controls.Add(this.label8);
            this.Tarih.Controls.Add(this.dateBitis);
            this.Tarih.Controls.Add(this.label7);
            this.Tarih.Location = new System.Drawing.Point(4, 22);
            this.Tarih.Name = "Tarih";
            this.Tarih.Padding = new System.Windows.Forms.Padding(3);
            this.Tarih.Size = new System.Drawing.Size(734, 224);
            this.Tarih.TabIndex = 1;
            this.Tarih.Text = "Tarih";
            this.Tarih.UseVisualStyleBackColor = true;
            // 
            // dateTahminiBitis
            // 
            this.dateTahminiBitis.Location = new System.Drawing.Point(407, 68);
            this.dateTahminiBitis.Name = "dateTahminiBitis";
            this.dateTahminiBitis.Size = new System.Drawing.Size(200, 20);
            this.dateTahminiBitis.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tahmini Bitis";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Devam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.passNextTabPage);
            // 
            // dateTahminiBaslangic
            // 
            this.dateTahminiBaslangic.Location = new System.Drawing.Point(407, 35);
            this.dateTahminiBaslangic.Name = "dateTahminiBaslangic";
            this.dateTahminiBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTahminiBaslangic.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tahmini Baş";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(111, 33);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateBaslangic.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Proje Başlangıç :";
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(111, 68);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 20);
            this.dateBitis.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Proje Bitiş :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ekip
            // 
            this.Ekip.Controls.Add(this.button3);
            this.Ekip.Controls.Add(this.teamListBox);
            this.Ekip.Controls.Add(this.label11);
            this.Ekip.Controls.Add(this.comboManager);
            this.Ekip.Controls.Add(this.label12);
            this.Ekip.Location = new System.Drawing.Point(4, 22);
            this.Ekip.Name = "Ekip";
            this.Ekip.Padding = new System.Windows.Forms.Padding(3);
            this.Ekip.Size = new System.Drawing.Size(734, 224);
            this.Ekip.TabIndex = 2;
            this.Ekip.Text = "Ekip";
            this.Ekip.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Devam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.passNextTabPage);
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(338, 31);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(170, 124);
            this.teamListBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ekip";
            // 
            // comboManager
            // 
            this.comboManager.FormattingEnabled = true;
            this.comboManager.Location = new System.Drawing.Point(109, 31);
            this.comboManager.Name = "comboManager";
            this.comboManager.Size = new System.Drawing.Size(121, 21);
            this.comboManager.TabIndex = 2;
            this.comboManager.SelectedIndexChanged += new System.EventHandler(this.comboManager_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Proje Yöneticisi";
            // 
            // Maddi
            // 
            this.Maddi.Controls.Add(this.button5);
            this.Maddi.Controls.Add(this.comboGelirTipi);
            this.Maddi.Controls.Add(this.label16);
            this.Maddi.Controls.Add(this.label15);
            this.Maddi.Controls.Add(this.numericGetiri);
            this.Maddi.Location = new System.Drawing.Point(4, 22);
            this.Maddi.Name = "Maddi";
            this.Maddi.Size = new System.Drawing.Size(734, 224);
            this.Maddi.TabIndex = 4;
            this.Maddi.Text = "Maddi";
            this.Maddi.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Devam";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.passNextTabPage);
            // 
            // comboGelirTipi
            // 
            this.comboGelirTipi.FormattingEnabled = true;
            this.comboGelirTipi.Location = new System.Drawing.Point(319, 33);
            this.comboGelirTipi.Name = "comboGelirTipi";
            this.comboGelirTipi.Size = new System.Drawing.Size(121, 21);
            this.comboGelirTipi.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Maddi Getiri :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Getiri Tipi";
            // 
            // numericGetiri
            // 
            this.numericGetiri.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericGetiri.Location = new System.Drawing.Point(94, 31);
            this.numericGetiri.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericGetiri.Name = "numericGetiri";
            this.numericGetiri.Size = new System.Drawing.Size(120, 20);
            this.numericGetiri.TabIndex = 0;
            // 
            // Durum
            // 
            this.Durum.Controls.Add(this.button4);
            this.Durum.Controls.Add(this.comboProjeDurumu);
            this.Durum.Controls.Add(this.label13);
            this.Durum.Controls.Add(this.comboProjeTipi);
            this.Durum.Controls.Add(this.label14);
            this.Durum.Location = new System.Drawing.Point(4, 22);
            this.Durum.Name = "Durum";
            this.Durum.Padding = new System.Windows.Forms.Padding(3);
            this.Durum.Size = new System.Drawing.Size(734, 224);
            this.Durum.TabIndex = 3;
            this.Durum.Text = "Durum";
            this.Durum.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Projeyi Oluştur";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboProjeDurumu
            // 
            this.comboProjeDurumu.FormattingEnabled = true;
            this.comboProjeDurumu.Location = new System.Drawing.Point(344, 29);
            this.comboProjeDurumu.Name = "comboProjeDurumu";
            this.comboProjeDurumu.Size = new System.Drawing.Size(121, 21);
            this.comboProjeDurumu.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Proje Durumu :";
            // 
            // comboProjeTipi
            // 
            this.comboProjeTipi.FormattingEnabled = true;
            this.comboProjeTipi.Location = new System.Drawing.Point(78, 29);
            this.comboProjeTipi.Name = "comboProjeTipi";
            this.comboProjeTipi.Size = new System.Drawing.Size(121, 21);
            this.comboProjeTipi.TabIndex = 2;
            this.comboProjeTipi.SelectedIndexChanged += new System.EventHandler(this.comboProjeTipi_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Proje Tipi :";
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectNo,
            this.proje_ismi,
            this.ProjeYoneticisi,
            this.baslangic,
            this.Bitis,
            this.parasalGetiri,
            this.id});
            this.projectDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDataGridView.Location = new System.Drawing.Point(0, 256);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.Size = new System.Drawing.Size(742, 235);
            this.projectDataGridView.TabIndex = 1;
            this.projectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataGridView_CellContentClick);
            // 
            // ProjectNo
            // 
            this.ProjectNo.DataPropertyName = "proje_no";
            this.ProjectNo.HeaderText = "Proje Numarası";
            this.ProjectNo.Name = "ProjectNo";
            // 
            // proje_ismi
            // 
            this.proje_ismi.DataPropertyName = "proje_ismi";
            this.proje_ismi.HeaderText = "Proje Adı";
            this.proje_ismi.Name = "proje_ismi";
            // 
            // ProjeYoneticisi
            // 
            this.ProjeYoneticisi.DataPropertyName = "ad";
            this.ProjeYoneticisi.HeaderText = "Proje Yöneticisi";
            this.ProjeYoneticisi.Name = "ProjeYoneticisi";
            // 
            // baslangic
            // 
            this.baslangic.DataPropertyName = "baslangic_tarihi";
            this.baslangic.HeaderText = "Başlangıç Tarihi";
            this.baslangic.Name = "baslangic";
            // 
            // Bitis
            // 
            this.Bitis.DataPropertyName = "bitis_tarihi";
            this.Bitis.HeaderText = "Bitiş Tarihi";
            this.Bitis.Name = "Bitis";
            // 
            // parasalGetiri
            // 
            this.parasalGetiri.DataPropertyName = "parasal_getiri";
            this.parasalGetiri.HeaderText = "Parasal Getiri";
            this.parasalGetiri.Name = "parasalGetiri";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "projeId";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ProjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.projectDataGridView);
            this.Controls.Add(this.projeTabControl);
            this.Name = "ProjectUserControl";
            this.Size = new System.Drawing.Size(742, 491);
            this.projeTabControl.ResumeLayout(false);
            this.Tanim.ResumeLayout(false);
            this.Tanim.PerformLayout();
            this.Tarih.ResumeLayout(false);
            this.Tarih.PerformLayout();
            this.Ekip.ResumeLayout(false);
            this.Ekip.PerformLayout();
            this.Maddi.ResumeLayout(false);
            this.Maddi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGetiri)).EndInit();
            this.Durum.ResumeLayout(false);
            this.Durum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl projeTabControl;
        private System.Windows.Forms.TabPage Tanim;
        private System.Windows.Forms.TabPage Tarih;
        private System.Windows.Forms.TabPage Ekip;
        private System.Windows.Forms.TabPage Durum;
        private System.Windows.Forms.TextBox txtAmac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKapsam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStratejikEtki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProblemTanimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTahminiBaslangic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTahminiBitis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboManager;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox teamListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboProjeDurumu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboProjeTipi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage Maddi;
        private System.Windows.Forms.ComboBox comboGelirTipi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericGetiri;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje_ismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjeYoneticisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn parasalGetiri;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}
