using System.Windows.Forms;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BugTracker
{
    public partial class ShowProjects : Form
    {
        private readonly IProjectRepository _projectRepository;
        private Project _project;
        public ShowProjects(IProjectRepository projectRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository;
        }

        private void DGV_Projects_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Projects.HitTest(e.X, e.Y);
            DGV_Projects.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Projects.Rows[hit.RowIndex].Selected = true;
                _project = _projectRepository.GetAll().ToList()[hit.RowIndex];
            }
        }

        private void ShowProjects_Load(object sender, EventArgs e)
        {
            if (_projectRepository.GetAll() != null)
            {
                DGV_Projects.DataSource = _projectRepository.GetAll();
                if (_projectRepository.GetAll().Count() > 0)
                {
                    DGV_Projects.Rows[0].Selected = true;
                    _project = _projectRepository.GetAll().FirstOrDefault();
                }
            }
        }

        private void BT_ProjectAdd_Click(object sender, EventArgs e)
        {
            if (!Utils.IsAllowed())
            {
                MessageBox.Show("User is not allowed to do that action");
                return;
            }
            var mainForm = Program.GetService<MainForm>();
            var addProjectForm = Program.GetService<AddProjectForm>();

            addProjectForm.SetMode(AddProjectForm.Modes.Add);
            mainForm.OpenChildForm(addProjectForm);
        }

        private void BT_ProjectEdit_Click(object sender, EventArgs e)
        {
            if (!Utils.IsAllowed(_project))
            {
                MessageBox.Show("User is not allowed to do that action");
                return;
            }
            var mainForm = Program.GetService<MainForm>();
            var addProjectForm = Program.GetService<AddProjectForm>();

            addProjectForm.SetProject(_project);
            addProjectForm.SetMode(AddProjectForm.Modes.Edit);
            mainForm.OpenChildForm(addProjectForm);
        }

        private void BT_ProjectRemove_Click(object sender, EventArgs e)
        {
            if (!Utils.IsAllowed(_project))
            {
                MessageBox.Show("User is not allowed to do that action");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_project != null)
                {
                    try
                    {
                        _projectRepository.DeleteById(_project.Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                DGV_Projects.DataSource = null;
                DGV_Projects.DataSource = _projectRepository.GetAll();
            }
            
        }

        private void TB_SearchProject_TextChanged(object sender, EventArgs e)
        {
            if (!Utils.IsValidString(TB_SearchProject.Text))
            {
                DGV_Projects.DataSource = _projectRepository.GetAll();
                return;
            }
            DGV_Projects.DataSource = _projectRepository.GetAll()
                                              .Where(p => p.ProjectName.Contains(TB_SearchProject.Text, StringComparison.OrdinalIgnoreCase))
                                              .ToList();
        }
    }
}
