using DevExpress.Xpo;
using ProjectManagement.Entities;
using ProjectManagement.Enums;
using ProjectManagement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.UserControls
{
    public partial class ProjectUserControl : UserControl
    {
        Project selectedProject = null;
        public ProjectUserControl()
        {
            InitializeComponent();
            populateManagerAndTeamBoxes();
            Setcomboboxes();
            UpdateProjectGridView();
        }

        private void UpdateProjectGridView()
        {
            projectDataGridView.DataSource = ProjectRepository.getProjectWithManagerName();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtProjeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        public void passNextTabPage(object sender, EventArgs e)
        {
            // Tıklandığında hangi tabpage'de olduğumuzu kontrol etmek için
            int currentTabIndex = projeTabControl.SelectedIndex;

            // Eğer son tabpage değilse, bir sonraki tabpage'e geçiş yap
            if (currentTabIndex < projeTabControl.TabCount - 1)
            {
                projeTabControl.SelectedIndex = currentTabIndex + 1;
            }
        }

        private void populateManagerAndTeamBoxes()
        {
            if (selectedProject == null)
            {
                Dictionary<int, string> employeeData = PersonRepository.GetEmployeeData();
                foreach (var kvp in employeeData)
                {
                    comboManager.DisplayMember = "Value";  // Burada "Value", göstermek istediğiniz değerin özelliğini temsil eder.
                    comboManager.ValueMember = "Key";
                    comboManager.Items.Add(new KeyValuePair<int, string>(kvp.Key, kvp.Value));
                    teamListBox.Items.Add(new KeyValuePair<int, string>(kvp.Key, kvp.Value));
                }
            }
        }

        private void Setcomboboxes()
        {


            Dictionary<int, string> enumDictionary = new Dictionary<int, string>
                {
                    { (int)ProjectStatus.OnayBekliyor, "Onay Bekliyor" },
                    { (int)ProjectStatus.DevamEdiyor, "Devam Ediyor" },
                    { (int)ProjectStatus.Tamamlandı, "Tamamlandı" }
                };
            comboProjeDurumu.DataSource = new BindingSource(enumDictionary, null);
            comboProjeDurumu.DisplayMember = "Value";
            comboProjeDurumu.ValueMember = "Key";

            Dictionary<int, string> typeenumDic = new Dictionary<int, string>
                {
                    { (int)ProjectType.Tübitak, "Tübitak" },
                    { (int)ProjectType.Yurtdışı, "Yurtdışı" },
                    { (int)ProjectType.Kobi, "Kobi" }
                };
            comboProjeTipi.DataSource = new BindingSource(typeenumDic, null);
            comboProjeTipi.DisplayMember = "Value";
            comboProjeTipi.ValueMember = "Key";

            Dictionary<int, string> incomeDic = new Dictionary<int, string>
                {
                    { (int)IncomeType.Günlük, "Günlük" },
                    { (int)IncomeType.Aylık, "Aylık" },
                    { (int)IncomeType.Yıllık, "Yıllık" }
                };
            comboGelirTipi.DataSource = new BindingSource(incomeDic, null);
            comboGelirTipi.DisplayMember = "Value";
            comboGelirTipi.ValueMember = "Key";

        }

        public void SaveProject()
        {
            if (!AllInputsAreFilled())
            {
                MessageBox.Show("Eksik veri girişi yaptınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int insertedProjecId = ProjectRepository.SaveProject(txtProjeAdi.Text, txtStratejikEtki.Text,
                getComboboxKey(comboManager), txtAmac.Text, txtProblemTanimi.Text, txtKapsam.Text, DateTime.Today,
                dateBaslangic.Value, dateBitis.Value, dateTahminiBitis.Value, dateTahminiBaslangic.Value,
                getComboboxKey(comboProjeDurumu), numericGetiri.Value, getComboboxKey(comboGelirTipi),
                getComboboxKey(comboProjeTipi));

            if (insertedProjecId != -1)
            {
                ProjectEmployeeReposityory.SaveEmployeesInProject(insertedProjecId, getSelectedEmployeeIds());
            }
        }
        public void UpdateProject()
        {
            ProjectRepository.UpdateProject(selectedProject.Id,txtProjeAdi.Text, txtStratejikEtki.Text,
            getComboboxKey(comboManager), txtAmac.Text, txtProblemTanimi.Text, txtKapsam.Text, DateTime.Today,
            dateBaslangic.Value, dateBitis.Value, dateTahminiBitis.Value, dateTahminiBaslangic.Value,
            getComboboxKey(comboProjeDurumu), numericGetiri.Value, getComboboxKey(comboGelirTipi),
             getComboboxKey(comboProjeTipi));
            ProjectEmployeeReposityory.UpdateEmployeeProject(selectedProject.Id, getSelectedEmployeeIds());
            UpdateProjectGridView();
        }
        public bool AllInputsAreFilled()
        {
            return string.IsNullOrEmpty(txtProjeAdi.Text) ||
                 string.IsNullOrEmpty(txtStratejikEtki.Text) ||
                 string.IsNullOrEmpty(txtAmac.Text) ||
                 string.IsNullOrEmpty(txtProblemTanimi.Text) ||
                 string.IsNullOrEmpty(txtKapsam.Text) ||
                 string.IsNullOrEmpty(txtProjeAdi.Text) ||
                 string.IsNullOrEmpty(txtProjeAdi.Text) ||
                 string.IsNullOrEmpty(txtProjeAdi.Text) ||
                 string.IsNullOrEmpty(txtProjeAdi.Text) || comboManager.SelectedItem == null ||
                 comboProjeDurumu.SelectedItem == null || comboGelirTipi == null
                 || comboProjeTipi == null || teamListBox.CheckedItems.Count > 0;
        }
        private int getComboboxKey(ComboBox comboBox)
        {
            KeyValuePair<int, string> selectedKeyValue = (KeyValuePair<int, string>)comboBox.SelectedItem;

            // selectedKeyValue.Key'i kullanabilirsiniz
            int selectedKey = selectedKeyValue.Key;
            return selectedKey;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveProject();
        }
        private List<int> getSelectedEmployeeIds()
        {
            List<int> selectedKeys = new List<int>();

            // Seçilen öğeleri alın
            foreach (var selectedItem in teamListBox.CheckedItems)
            {
                // Öğenin değerine veya Text özelliğine erişerek key'leri listeye ekleyin
                int key = GetKeyFromItem(selectedItem); // GetKeyFromItem metodunu öğenizin türüne ve veri yapısına göre uyarlayın
                selectedKeys.Add(key);
            }
            return selectedKeys;
        }
        private int GetKeyFromItem(object item)
        {
            if (item is KeyValuePair<int, string> keyValuePair)
            {
                return keyValuePair.Key;
            }
            throw new InvalidOperationException("Invalid item type or format");

        }

        private void comboProjeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void projectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
            int columnIndex = e.ColumnIndex;

            if (columnIndex != -1)
            {
                int selectedId = Convert.ToInt32(projectDataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                selectedProject = ProjectRepository.GetProjectById(selectedId);
                if (selectedProject != null)
                    fillFields(selectedProject);
            }

        }

        private void fillFields(Project project)
        {
            txtProjeAdi.Text = project.ProjeIsmi;
            txtStratejikEtki.Text = project.StratejikEtki;
            txtAmac.Text = project.Amac;

            txtProblemTanimi.Text = project.ProblemTanimi;
            txtKapsam.Text = project.Kapsam;
            dateBaslangic.Value = project.BaslangicTarihi;
            dateBitis.Value = project.BitisTarihi;
            dateTahminiBitis.Value = project.BitisTahmini;
            dateTahminiBaslangic.Value = project.BaslangicTahmini;
            numericGetiri.Value = project.ParasalGetiri;

            fillCombboxAccordingToKey(comboManager, project.ProjeYurutucu);
            fillCombboxAccordingToKey(comboProjeDurumu, project.ProjeDurumu);
            fillCombboxAccordingToKey(comboProjeTipi, project.ProjeTipi);
            fillCombboxAccordingToKey(comboGelirTipi, project.ParasalGetiriTipi);
            CheckItemsByKeyOnCheckedListBox(teamListBox,ProjectEmployeeReposityory.GetEmployeeIdsByProjectId(project.Id)); ;
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
        private void CheckItemsByKeyOnCheckedListBox(CheckedListBox checkedListBox, List<int> targetKeys)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.Items[i] is KeyValuePair<int, string> item)
                {
                    if (targetKeys.Contains(item.Key))
                    {
                        checkedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        public void ClearAll()
        {
            txtProjeAdi.Text = null;
            txtStratejikEtki.Text = null;
            txtAmac.Text = null;
            txtProblemTanimi.Text = null;
            txtKapsam.Text = null;
            dateBaslangic.Value = DateTime.Today;
            dateBitis.Value = DateTime.Today;
            dateTahminiBitis.Value = DateTime.Today;
            dateTahminiBaslangic.Value = DateTime.Today;
            numericGetiri.Value = decimal.Zero;
            for (int i = 0; i < teamListBox.Items.Count; i++)
            {
                teamListBox.SetItemChecked(i, false);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateProject();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ProjectEmployeeReposityory.DeleteEmployeeProject(selectedProject.Id);
            ClearAll();
            UpdateProjectGridView();
        }
    }
}
