using System.Drawing;
using System.Windows.Forms;

namespace ProjectManagement
{
    partial class Form1
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

        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectUserControl1 = new ProjectManagement.UserControls.ProjectUserControl();
            this.SuspendLayout();
            // 
            // projectUserControl1
            // 
            this.projectUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectUserControl1.Location = new System.Drawing.Point(0, 0);
            this.projectUserControl1.Name = "projectUserControl1";
            this.projectUserControl1.Size = new System.Drawing.Size(800, 450);
            this.projectUserControl1.TabIndex = 0;
            this.projectUserControl1.Load += new System.EventHandler(this.projectUserControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private UserControls.ProjectUserControl projectUserControl1;
    }
}

