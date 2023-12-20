using ProjectManagement.Entities;
using ProjectManagement.Enums;
using ProjectManagement.Interfaces;
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
    public partial class TaskDetailUserControl : UserControl, IUserControl
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
                string formattedValue = "";
               
                // Hücredeki int değerini al
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int intValue))
                {
                    string value = grdTask.Rows[e.RowIndex].Cells[4].Value.ToString();
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
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                // Hücredeki değeri kontrol et.
                if (e.Value != null)
                {
                    string status = grdTask.Rows[e.RowIndex].Cells[4].Value.ToString();
                    // Eğer e.Value bir DateTime ise, doğrudan kullan.
                    if (e.Value is DateTime)
                    {
                        DateTime cellValue = (DateTime)e.Value;
                        
                        // Koşulu kontrol et (örnek: bugünün tarihinden küçükse).
                        if (cellValue < DateTime.Today && !status.Equals("2"))
                        {
                            // Tüm sütunu değiştir.
                            ChangeBackRowColor(e, Color.Red, Color.White);
                        }
                        else
                        {
                            if (status.Equals("1"))
                            {
                                ChangeBackRowColor(e, Color.Yellow, Color.Black);
                            }else if (status.Equals("2"))
                            {
                                ChangeBackRowColor(e, Color.Green, Color.Black);
                            }
                        }
                    }
                    else if (DateTime.TryParse(e.Value.ToString(), out DateTime cellValue))
                    {
                        // Koşulu kontrol et (örnek: bugünün tarihinden küçükse).
                        if (cellValue < DateTime.Today && !status.Equals("2"))
                        {
                            ChangeBackRowColor(e, Color.Red, Color.White);
                        }
                        else
                        {
                            if (status.Equals("1"))
                            {
                                ChangeBackRowColor(e, Color.Yellow, Color.Black);
                            }
                            else if (status.Equals("2"))
                            {
                                ChangeBackRowColor(e, Color.Green, Color.Black);
                            }
                        }
                    }
                }
            }

        }

        private void ChangeBackRowColor(DataGridViewCellFormattingEventArgs e, Color backcolor, Color forecolor)
        {
            for (int i = 0; i < grdTask.Rows.Count; i++)
            {
                grdTask.Rows[e.RowIndex].DefaultCellStyle.BackColor = backcolor;
                grdTask.Rows[e.RowIndex].DefaultCellStyle.ForeColor = forecolor;
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
            ClearOperation();
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

        public void SaveOperation()
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

        public void UpdateOperation()
        {
            if (selectedTask == null)
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

        public void DeleteOperation()
        {
            if (selectedTask == null)
            {
                MessageBox.Show("Bir Task Seçmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaskRepository.DeleteTask(selectedTask.Id);
            AfterCrudOperations();
        }

        public void ClearOperation()
        {
            selectedTask = null;
            txtTaskName.Text = null;
            dateBaslangic.Value = DateTime.Today;
            dateBitis.Value = DateTime.Today;
            comboGorevli.SelectedItem = null;
            comboStatus.SelectedItem = null;
        }
    }
}
