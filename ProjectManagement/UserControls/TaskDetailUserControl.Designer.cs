namespace ProjectManagement.UserControls
{
    partial class TaskDetailUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGorevli = new System.Windows.Forms.ComboBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdTask = new System.Windows.Forms.DataGridView();
            this.taskismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorevli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTask)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdTask, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.comboStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateBitis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateBaslangic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboGorevli);
            this.panel1.Controls.Add(this.txtTaskName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 240);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitiş Tarihi :";
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(324, 72);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(168, 20);
            this.dateBitis.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Başlangıç Tarihi :";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(324, 44);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(168, 20);
            this.dateBaslangic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Görevli :";
            // 
            // comboGorevli
            // 
            this.comboGorevli.FormattingEnabled = true;
            this.comboGorevli.Location = new System.Drawing.Point(90, 71);
            this.comboGorevli.Name = "comboGorevli";
            this.comboGorevli.Size = new System.Drawing.Size(129, 21);
            this.comboGorevli.TabIndex = 2;
            this.comboGorevli.SelectedIndexChanged += new System.EventHandler(this.comboGorevli_SelectedIndexChanged);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(90, 44);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(129, 20);
            this.txtTaskName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task İsmi :";
            // 
            // grdTask
            // 
            this.grdTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskismi,
            this.Gorevli,
            this.Id,
            this.BaslangicTarihi,
            this.BitisTarihi,
            this.Durum});
            this.grdTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTask.Location = new System.Drawing.Point(3, 249);
            this.grdTask.Name = "grdTask";
            this.grdTask.Size = new System.Drawing.Size(607, 158);
            this.grdTask.TabIndex = 1;
            this.grdTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTask_CellContentClick);
            this.grdTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdTask_CellFormatting);
            // 
            // taskismi
            // 
            this.taskismi.DataPropertyName = "task_ismi";
            this.taskismi.HeaderText = "Task İsmi";
            this.taskismi.Name = "taskismi";
            // 
            // Gorevli
            // 
            this.Gorevli.DataPropertyName = "ad";
            this.Gorevli.HeaderText = "Görevli";
            this.Gorevli.Name = "Gorevli";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.DataPropertyName = "baslangic_tarihi";
            this.BaslangicTarihi.HeaderText = "Başlangıç Tarihi";
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.DataPropertyName = "bitis_tarihi";
            this.BitisTarihi.HeaderText = "Bitiş Tarihi";
            this.BitisTarihi.Name = "BitisTarihi";
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(90, 98);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(129, 21);
            this.comboStatus.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(26, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Durum :";
            // 
            // TaskDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaskDetailUserControl";
            this.Size = new System.Drawing.Size(613, 410);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboGorevli;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorevli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboStatus;
    }
}
