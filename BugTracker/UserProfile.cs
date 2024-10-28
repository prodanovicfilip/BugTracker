using BugTracker.DTO;
using BugTracker.Utilities;
using Mapster;

namespace BugTracker
{
    public partial class UserProfile : Form
    {
        private List<IssueDTO> _issues;
        private List<ProjectDTO> _projects;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            LB_Username.Text = UserController.CurrentUser.UserName;
            LB_Role.Text = UserController.CurrentUser.UserRole.ToString();
            _projects = UserController.CurrentUser.AssignedProjects.ToList().Adapt<List<ProjectDTO>>();
            _issues = UserController.CurrentUser.AssignedIssues.ToList().Adapt<List<IssueDTO>>();
            DGV_Projects.DataSource = _projects;
            DGV_Issues.DataSource = _issues;

        }
    }
}
