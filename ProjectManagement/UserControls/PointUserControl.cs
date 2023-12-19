using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Entities;
using ProjectManagement.Interfaces;
using ProjectManagement.Repositories;

namespace ProjectManagement.UserControls
{
    public partial class PointUserControl : UserControl, IUserControl
    {
        TaskUserControl parent;
        int projectId;
        Entities.Point selectedPoint = null;
        public PointUserControl(TaskUserControl Parent, int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            UpdatePointGrid();
            parent = Parent;
            
        }

        void UpdatePointGrid()
        {
            BindingSource source = PointRepository.getPointByProjectId(projectId);
            grdPoints.DataSource = source;
        }

        private void grdPoints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            if (columnIndex != -1)
            {
                int selectedId = Convert.ToInt32(grdPoints.Rows[e.RowIndex].Cells["Id"].Value);

                Entities.Point point = PointRepository.GetById(selectedId);
                if (point != null)
                {
                    fillFields(point);
                    selectedPoint = point;
                }
                    
            }
        }

        private void fillFields(Entities.Point point)
        {
            dateBaslangicTarihi.Value = point.BaslangicTarihi;
            dateBitisTarihi.Value = point.BitisTarihi;
            txtPointName.Text = point.PointName;
        }

        private void AfterCrudOperations() {
            parent.LoadProjectsIntoTreeView();
            UpdatePointGrid();
            ClearOperation();
        }

        private void FillSelectedPointsFiels()
        {
            selectedPoint.BitisTarihi = dateBitisTarihi.Value;
            selectedPoint.BaslangicTarihi = dateBaslangicTarihi.Value;
            selectedPoint.PointName = txtPointName.Text;
        }
        private bool isInputsValid()
        {
            return !(string.IsNullOrEmpty(txtPointName.Text) || dateBitisTarihi.Value < dateBaslangicTarihi.Value);
        }

        public void SaveOperation()
        {
            if (!isInputsValid())
            {
                MessageBox.Show("Hatalı veya eksik veri girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PointRepository.SavePoint(txtPointName.Text, dateBaslangicTarihi.Value, dateBitisTarihi.Value, projectId);
            AfterCrudOperations();
        }

        public void UpdateOperation()
        {
            if (selectedPoint == null)
            {
                MessageBox.Show("Bir Kilometre Taşı Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isInputsValid())
            {
                MessageBox.Show("Hatalı veya eksik veri girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FillSelectedPointsFiels();
            PointRepository.UpdatePoint(selectedPoint);
            AfterCrudOperations();
        }

        public void DeleteOperation()
        {
            if (selectedPoint == null)
            {
                MessageBox.Show("Bir Kilometre Taşı Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PointRepository.DeletePoint(selectedPoint.Id);
            AfterCrudOperations();
        }

        public void ClearOperation()
        {
            selectedPoint = null;
            dateBaslangicTarihi.Value = DateTime.Today;
            dateBitisTarihi.Value = DateTime.Today;
            txtPointName.Text = null;
        }
    }
}
