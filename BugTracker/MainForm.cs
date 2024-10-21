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
        private User _user;
        private Project _project;
        private Issue _issue;
        public MainForm(IUserRepository userRepository, IProjectRepository projectRepository, IIssueRepository issueRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _projectRepository = projectRepository;
            _issueRepository = issueRepository;
            PL_Users.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            if (UserController.CurrentUser.UserRole == User.Role.Admin)
            {
                PL_Users.Visible = true;
            }
        }
        private void LoadData()
        {
            if (_userRepository.GetAll() != null)
            {
                DGV_Users.DataSource = _userRepository.GetAll();
                if (_userRepository.GetAll().Count() > 0)
                {
                    DGV_Users.Rows[0].Selected = true;
                    _user = _userRepository.GetAll().FirstOrDefault();
                }
            }

            if (_projectRepository.GetAll() != null)
            {
                DGV_Projects.DataSource = _projectRepository.GetAll();
                if (_projectRepository.GetAll().Count() > 0)
                {
                    DGV_Projects.Rows[0].Selected = true;
                    _project = _projectRepository.GetAll().FirstOrDefault();
                }
            }

            if (_issueRepository.GetAll() != null)
            {
                DGV_Issues.DataSource = _issueRepository.GetAll();
                if (_issueRepository.GetAll().Count() > 0)
                {
                    DGV_Issues.Rows[0].Selected = true;
                    _issue = _issueRepository.GetAll().FirstOrDefault();
                }
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
            DGV_Users.DataSource = _userRepository.GetAll();
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
            DGV_Projects.DataSource = _projectRepository.GetAll();
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
            DGV_Issues.DataSource = _issueRepository.GetAll();
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
        private void DGV_Users_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Users.HitTest(e.X, e.Y);
            DGV_Users.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Users.Rows[hit.RowIndex].Selected = true;
                _user = _userRepository.GetAll().ToList()[hit.RowIndex];
            }
        }
        private void DGV_Issues_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Issues.HitTest(e.X, e.Y);
            DGV_Issues.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Issues.Rows[hit.RowIndex].Selected = true;
                _issue = _issueRepository.GetAll().ToList()[hit.RowIndex];
            }
        }

        private void BT_ProjectAdd_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddProjectForm>();
            form.ShowDialog();
            DGV_Projects.DataSource = null;
            DGV_Projects.DataSource = _projectRepository.GetAll();
        }

        private void BT_UserAdd_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddUserForm>();
            form.AssignProject(_project);
            form.ShowDialog();
            DGV_Users.DataSource = null;
            DGV_Users.DataSource = _userRepository.GetAll();
        }

        private void BT_IssueAdd_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<AddIssueForm>();
            form.ShowDialog();
            DGV_Issues.DataSource = null;
            DGV_Issues.DataSource = _issueRepository.GetAll();
        }
    }
}
