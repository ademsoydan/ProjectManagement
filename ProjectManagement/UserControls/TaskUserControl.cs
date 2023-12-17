using ProjectManagement.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagement.UserControls
{
    public partial class TaskUserControl : UserControl
    {
        public TaskUserControl()
        {
            InitializeComponent();
            LoadProjectsIntoTreeView();
        }

        private void LoadProjectsIntoTreeView()
        {
            List<TreeResponse> tree = ProjectRepository.GetTreeInfo();
            if (tree.Count == 0)
                return;

            int lastProjectId = -2;
            int lastPointId = -2;
            TreeNode currentProjectNode = null;
            TreeNode currentPointnode = null;
            for (int i = 0; i < tree.Count; i++) {
                 
                if (lastProjectId != tree[i].Proje.Id)
                {
                    lastProjectId = tree[i].Proje.Id;
                    currentProjectNode = new TreeNode(tree[i].Proje.ProjeIsmi);
                    currentProjectNode.Tag = tree[i].Proje;
                    treeProje.Nodes.Add(currentProjectNode);
                }
                if(lastPointId != tree[i].Point.Id && tree[i].Point.Id != -1)
                {
                    lastPointId = tree[i].Point.Id;
                    currentPointnode = new TreeNode(tree[i].Point.PointName);
                    currentProjectNode.Nodes.Add(currentPointnode);
                }
                if (tree[i].Task.Id != -1)
                {
                    TreeNode node = new TreeNode(tree[i].Task.TaskName);
                    currentPointnode.Nodes.Add(node);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
