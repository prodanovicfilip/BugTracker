using BugTracker.DataAccess;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;
namespace BugTracker
{
    public partial class MainForm : Form
    {
        public enum Modes
        {
            Normal, Admin
        }
        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IIssueRepository _issueRepository;
        private List<User> _users;
        private User _user;
        private List<Project> _projects;
        private Project _project;
        private List<Issue> _issues;
        private Issue _issue;
        public MainForm(IUserRepository userRepository, IProjectRepository projectRepository, IIssueRepository issueRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _projectRepository = projectRepository;
            _issueRepository = issueRepository;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            _users = _userRepository.GetAll().ToList();
            if (_users == null || _users.Count() == 0)
            {
                return;
            }
            DGV_Users.DataSource = _users;
            if (_users.Count > 0)
            {
                DGV_Users.Rows[0].Selected = true;
                _user = _users[0];
            }

            _projects = _projectRepository.GetAll().ToList();
            if (_projects == null || _projects.Count() == 0)
            {
                return;
            }
            DGV_Projects.DataSource = _projects;
            if (_projects.Count > 0)
            {
                DGV_Projects.Rows[0].Selected = true;
                _project = _projects[0];
            }
            

            _issues = _issueRepository.GetAll().ToList();
            if (_issues == null || _issues.Count() == 0)
            {
                return;
            }
            DGV_Issues.DataSource = _issues;
            if (_issues.Count > 0)
            {
                DGV_Issues.Rows[0].Selected = true;
                _issue = _issues[0];
            }
            
        }

        //Assigned projects? assigned issues?
        private void BT_UserRemove_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                if (_user.Id == UserController.CurrentUser.Id)
                {
                    MessageBox.Show("Can't delete current user.");
                    return;
                }
                if (_user.UserRole == User.Role.Admin)
                {
                    MessageBox.Show("Can't delete this user.");
                    return;
                }
                try
                {
                    _userRepository.DeleteById(_user.Id);
                }
                catch (Exception)
                {
                    return;
                }   
            }
            DGV_Users.DataSource = null;
            DGV_Users.DataSource = _users;
        }
        private void BT_ProjectRemove_Click(object sender, EventArgs e)
        {
            if (_project != null)
            {
                try
                {
                    _projectRepository.DeleteById(_project.Id);
                }
                catch (Exception)
                {
                    return;
                }
            }
            DGV_Projects.DataSource = null;
            DGV_Projects.DataSource = _projects;
        }
        private void BT_IssueRemove_Click(object sender, EventArgs e)
        {
            if (_issue != null)
            {
                if (_issue.Status == Issue.IssueStatus.Open || _issue.Status == Issue.IssueStatus.Resolved)
                {
                    MessageBox.Show("Issue not closed.");
                    return;
                }
                try
                {
                    _issueRepository.DeleteById(_issue.Id);
                }
                catch (Exception)
                {
                    return;
                }
            }
            DGV_Issues.DataSource = null;
            DGV_Issues.DataSource = _issues;
        }
        private void DGV_Projects_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Projects.HitTest(e.X, e.Y);
            DGV_Projects.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Projects.Rows[hit.RowIndex].Selected = true;
                _project = _projects[hit.RowIndex];
            }
        }

        private void DGV_Users_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Users.HitTest(e.X, e.Y);
            DGV_Users.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Users.Rows[hit.RowIndex].Selected = true;
                _user = _users[hit.RowIndex];
            }
        }

        private void DGV_Issues_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Issues.HitTest(e.X, e.Y);
            DGV_Issues.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Issues.Rows[hit.RowIndex].Selected = true;
                _issue = _issues[hit.RowIndex];
            }
        }

        
    }
}
