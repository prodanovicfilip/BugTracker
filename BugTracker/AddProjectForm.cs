using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DataAccess.Repositories;
using BugTracker.Utilities;

namespace BugTracker
{
    public partial class AddProjectForm : Form
    {
        private readonly IProjectRepository _projectRepository;
        public AddProjectForm(IProjectRepository projectRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository;
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            string Name = TB_ProjectName.Text;
            DateTime startDate = DTP_Start.Value;
            DateTime endDate = DTP_End.Value;
            if (!Utils.IsValidString(Name))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                MessageBox.Show("Invalid start/end date");
                return;
            }
            var project = new Project();
            project.ProjectName = Name;
            project.StartDate = startDate;
            project.EndDate = endDate;
            try
            {
                _projectRepository.Add(project);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Project created successfully");
            this.Close();
        }
    }
}
