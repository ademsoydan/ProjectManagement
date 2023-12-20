namespace ProjectManagement.UserControls
{
    partial class PointUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdPoints = new System.Windows.Forms.DataGridView();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangic_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitis_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtPointName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPoints)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdPoints, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 475);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdPoints
            // 
            this.grdPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPoints.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adi,
            this.Id,
            this.baslangic_tarihi,
            this.bitis_tarihi});
            this.grdPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPoints.Location = new System.Drawing.Point(3, 288);
            this.grdPoints.Name = "grdPoints";
            this.grdPoints.Size = new System.Drawing.Size(732, 184);
            this.grdPoints.TabIndex = 0;
            this.grdPoints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPoints_CellContentClick);
            // 
            // adi
            // 
            this.adi.DataPropertyName = "durak_ismi";
            this.adi.HeaderText = "K. Taşı Adı";
            this.adi.Name = "adi";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // baslangic_tarihi
            // 
            this.baslangic_tarihi.DataPropertyName = "baslangic_tarihi";
            this.baslangic_tarihi.HeaderText = "Başlangıç  Tarihi";
            this.baslangic_tarihi.Name = "baslangic_tarihi";
            // 
            // bitis_tarihi
            // 
            this.bitis_tarihi.DataPropertyName = "bitis_tarihi";
            this.bitis_tarihi.HeaderText = "Bitis Tarihi";
            this.bitis_tarihi.Name = "bitis_tarihi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateBaslangicTarihi);
            this.panel1.Controls.Add(this.dateBitisTarihi);
            this.panel1.Controls.Add(this.txtPointName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 279);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // dateBaslangicTarihi
            // 
            this.dateBaslangicTarihi.Location = new System.Drawing.Point(136, 55);
            this.dateBaslangicTarihi.Name = "dateBaslangicTarihi";
            this.dateBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateBaslangicTarihi.TabIndex = 3;
            // 
            // dateBitisTarihi
            // 
            this.dateBitisTarihi.Location = new System.Drawing.Point(136, 81);
            this.dateBitisTarihi.Name = "dateBitisTarihi";
            this.dateBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateBitisTarihi.TabIndex = 2;
            // 
            // txtPointName
            // 
            this.txtPointName.Location = new System.Drawing.Point(136, 29);
            this.txtPointName.Name = "txtPointName";
            this.txtPointName.Size = new System.Drawing.Size(100, 20);
            this.txtPointName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilometre Taşı Adı : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PointUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PointUserControl";
            this.Size = new System.Drawing.Size(738, 475);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPoints)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dateBitisTarihi;
        private System.Windows.Forms.TextBox txtPointName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitis_tarihi;
    }
}
