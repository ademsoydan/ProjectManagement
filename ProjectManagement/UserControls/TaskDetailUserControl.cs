using ProjectManagement.Entities;
using ProjectManagement.Enums;
using ProjectManagement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectManagement.UserControls
{
    public partial class TaskDetailUserControl : UserControl
    {
        TaskUserControl parentTaskUserControl;
        int PointId;
        ProjectTask selectedTask = null;
        public TaskDetailUserControl(TaskUserControl taskUserControl,int pointId)
        {
            InitializeComponent();
            parentTaskUserControl = taskUserControl; 
            this.PointId = pointId; 
            PopulateEmployeeCombobox();
            UpdateTaskGrid();
            SetStatusComboBox();
        }

        private void SetStatusComboBox()
        {
            Dictionary<int, string> incomeDic = new Dictionary<int, string>
                {
                    { (int)ProjectStatuses.Yapılacak, "Yapılacak" },
                    { (int)ProjectStatuses.DevamEdiyor, "Devam Ediyor" },
                    { (int)ProjectStatuses.Yapıldı, "Yapıldı" }
                };
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = new BindingList<KeyValuePair<int, string>>(incomeDic.ToList());
            comboStatus.DataSource = bindingSource;
            comboStatus.DisplayMember = "Value";
            comboStatus.ValueMember = "Key";
        }

        private void PopulateEmployeeCombobox()
        {
            Dictionary<int, string> employeeData = PersonRepository.GetEmployeeData();
            foreach (var kvp in employeeData)
            {
                comboGorevli.DisplayMember = "Value";  // Burada "Value", göstermek istediğiniz değerin özelliğini temsil eder.
                comboGorevli.ValueMember = "Key";
                comboGorevli.Items.Add(new KeyValuePair<int, string>(kvp.Key, kvp.Value));
            }
        }

        void UpdateTaskGrid()
        {
            BindingSource source = TaskRepository.GetTaskByPointId(PointId);
            grdTask.DataSource = source;
        }

        private void comboGorevli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void UpdateTask()
        {
            if(selectedTask == null)
            {
                MessageBox.Show("Bir Task Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!AllInputsAreFilled())
            {
                MessageBox.Show("Eksik veri girişi yaptınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProjectTask task = new ProjectTask()
            {
                Id = selectedTask.Id,
                TaskName = txtTaskName.Text,
                BaslangicTarihi = dateBaslangic.Value,
                BitisTarihi = dateBitis.Value,
                Status = GetComboboxKey(comboStatus),
                employeeId = GetComboboxKey(comboGorevli)
            };
            TaskRepository.UpdateTask(task);
            AfterCrudOperations();
        }

        public void DeleteTask()
        {
            if (selectedTask == null)
            {
                MessageBox.Show("Bir Task Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaskRepository.DeleteTask(selectedTask.Id);
            AfterCrudOperations();
        }
        public void SaveTask()
        {
            if (!AllInputsAreFilled())
            {
                MessageBox.Show("Eksik veri girişi yaptınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProjectTask task = new ProjectTask()
            {
                TaskName = txtTaskName.Text,
                BaslangicTarihi = dateBaslangic.Value,
                BitisTarihi = dateBitis.Value,
                Status = GetComboboxKey(comboStatus),
                employeeId = GetComboboxKey(comboGorevli),
                pointId = PointId
            };
            TaskRepository.SaveTask(task);
            AfterCrudOperations();
        }
        public bool AllInputsAreFilled()
        {
            return !(string.IsNullOrEmpty(txtTaskName.Text) ||
                 comboGorevli.SelectedItem == null ||
                 comboStatus.SelectedItem == null);
        }
        private int GetComboboxKey(ComboBox comboBox)
        {
            KeyValuePair<int, string> selectedKeyValue = (KeyValuePair<int, string>)comboBox.SelectedItem;

            // selectedKeyValue.Key'i kullanabilirsiniz
            int selectedKey = selectedKeyValue.Key;
            return selectedKey;
        }

        private void grdTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int targetColumnIndex = 4;

            if (e.ColumnIndex == targetColumnIndex && e.RowIndex >= 0)
            {
                // Hücredeki int değerini al
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int intValue))
                {
                   
                    string formattedValue = "";
                    switch (intValue)
                    {
                        case (int)ProjectStatuses.Yapılacak:
                            formattedValue = "Yapılacak";
                            break;
                        case (int)ProjectStatuses.DevamEdiyor:
                            formattedValue = "Devam Ediyor";
                            break;
                        case (int)ProjectStatuses.Yapıldı:
                            formattedValue = "Yapıldı";
                            break;
                    }
                    // DataGridView hücresine özel biçimli değeri yaz
                    e.Value = formattedValue;
                    e.FormattingApplied = true;
                }
            }
        }

        private void grdTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            if (columnIndex != -1)
            {
                int selectedId = Convert.ToInt32(grdTask.Rows[e.RowIndex].Cells["Id"].Value);
                ProjectTask projectTask = TaskRepository.GetById(selectedId);
                if (projectTask != null)
                    fillFields(projectTask);
            }
        }

        private void fillFields(ProjectTask task)
        {
            selectedTask = task;
            txtTaskName.Text = task.TaskName;
            dateBaslangic.Value = task.BaslangicTarihi;
            dateBitis.Value = task.BitisTarihi;
            fillCombboxAccordingToKey(comboStatus, task.Id);
            fillCombboxAccordingToKey(comboGorevli, task.employeeId);
        }
        private void AfterCrudOperations()
        {
            parentTaskUserControl.LoadProjectsIntoTreeView();
            UpdateTaskGrid();
            ClearAll();
        }

        public void ClearAll()
        {
            selectedTask = null;
            txtTaskName.Text = null;
            dateBaslangic.Value = DateTime.Today;
            dateBitis.Value = DateTime.Today;
            //comboStatus.
        }

        private void fillCombboxAccordingToKey(ComboBox combobox, int key)
        {
            for (int i = 0; i < combobox.Items.Count; i++)
            {
                var item = (KeyValuePair<int, string>)combobox.Items[i];
                if (item.Key == key)
                {
                    combobox.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
