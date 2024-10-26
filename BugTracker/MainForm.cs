using BugTracker.DataAccess;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;
namespace BugTracker
{
    public partial class MainForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;
        private User _user;
        private Project _project;
        public MainForm(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _projectRepository = projectRepository;
            BT_ShowUsers.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //proveri jel user admin i onda switch mode
            if (UserController.CurrentUser.UserRole == User.Role.Admin)
            {
                BT_ShowUsers.Visible = true;
            }
        }

        // Child form
        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BT_ShowProjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.GetService<ShowProjects>());
        }

        private void BT_ShowIssues_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.GetService<ShowIssues>());
        }

        private void BT_ShowUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.GetService<ShowUsers>());
        }
    }
}
