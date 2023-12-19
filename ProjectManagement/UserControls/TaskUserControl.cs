using ProjectManagement.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagement.UserControls
{
    public partial class TaskUserControl : UserControl, IUserControl
    {
        PointUserControl pointUserControl = null;
        TaskDetailUserControl taskDetailUserControl = null;
        
        public TaskUserControl()
        {
            InitializeComponent();
            LoadProjectsIntoTreeView();
           
        }

        public void LoadProjectsIntoTreeView()
        {
            treeProje.Nodes.Clear();
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
                    currentPointnode.Tag = tree[i].Point;
                    currentProjectNode.Nodes.Add(currentPointnode);
                }
                if (tree[i].Task.Id != -1)
                {
                    TreeNode node = new TreeNode(tree[i].Task.TaskName);
                    currentPointnode.Nodes.Add(node);
                }
            }
        }
        

        private void treeProje_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                // Tag özelliği Proje sınıfına ait mi diye kontrol et
                if (e.Node.Tag is Project)
                {
                    taskDetailUserControl = null;
                    Project proje = (Project)e.Node.Tag;
                    pnlTree.Controls.Clear();
                    pointUserControl = new PointUserControl(this, proje.Id);
                    pointUserControl.Dock = DockStyle.Fill;
                    pnlTree.Controls.Add(pointUserControl);
                }
                else if (e.Node.Tag is Entities.Point)
                {
                    pointUserControl = null;
                    pnlTree.Controls.Clear();
                    Entities.Point point = (Entities.Point)e.Node.Tag;
                    taskDetailUserControl = new TaskDetailUserControl(this, point.Id);
                    taskDetailUserControl.Dock = DockStyle.Fill;
                    pnlTree.Controls.Add(taskDetailUserControl);
                }
            }
        }

        private void treeProje_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void Save()
        {
            
        }
        public void UpdateTaskUserControl()
        {
            
        }

        public void DeleteTaskUserControl()
        {
           
        }

        public void ClearAllUserControl()
        {
            
        }

        public void SaveOperation()
        {
            if (pointUserControl != null)
            {
                pointUserControl.SaveOperation();
            }
            else if (taskDetailUserControl != null) { taskDetailUserControl.SaveOperation(); }
        }

        public void UpdateOperation()
        {
            if (pointUserControl != null)
            {
                pointUserControl.UpdateOperation();
            }
            else if (taskDetailUserControl != null) { taskDetailUserControl.UpdateOperation(); }
        }

        public void DeleteOperation()
        {
            if (pointUserControl != null)
            {
                pointUserControl.DeleteOperation();
            }
            else if (taskDetailUserControl != null) { taskDetailUserControl.DeleteOperation(); ; }
        }

        public void ClearOperation()
        {
            if (pointUserControl != null)
            {
                pointUserControl.ClearOperation();
            }
            else if (taskDetailUserControl != null) { taskDetailUserControl.ClearOperation(); }
        }
    }
}
