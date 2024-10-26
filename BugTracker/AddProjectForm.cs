using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DataAccess.Repositories;
using BugTracker.Utilities;

namespace BugTracker
{
    public partial class AddProjectForm : Form
    {
        public enum Modes
        {
            Add, Edit
        }
        private readonly IProjectRepository _projectRepository;
        private readonly IUserRepository _userRepository;
        private Modes _mode;
        private Project _project;
        public AddProjectForm(IProjectRepository projectRepository, IUserRepository userRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository;
            _userRepository = userRepository;

            var _userNames = new List<string>();
            foreach (User u in _userRepository.GetAll())
            {
                _userNames.Add(u.UserName);
            }
            CB_Users.DataSource = _userNames;
        }
        public void SetMode(Modes mode)
        {
            _mode = mode;
        }
        public void SetProject(Project project)
        {
            _project = project;
        }
        private void AddProjectForm_Load(object sender, EventArgs e)
        {
            if (_mode == Modes.Edit)
            {
                if (_project != null)
                {
                    TB_ProjectName.Text = _project.ProjectName;
                    DTP_Start.Value = _project.StartDate;
                    DTP_End.Value = _project.EndDate;
                }
                BT_Create.Text = "Edit";
                CB_Users.Visible = false;
            }
        }
        private void BT_Create_Click(object sender, EventArgs e)
        {
            if (_mode == Modes.Add)
                AddMode();
            else if (_mode == Modes.Edit)
                EditMode();
        }
        private void AddMode()
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

            //First user
            var firstUserName = CB_Users.SelectedItem;
            project.Users = new List<User>();
            var user = _userRepository.GetAll().FirstOrDefault(x => x.UserName.Equals(firstUserName));
            if (user == null)
            {
                MessageBox.Show("Couldn't find user with that name");
                return;
            }
            project.Users.Add(user);
            //Adding project
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
        private void EditMode()
        {
            string ProjectName = TB_ProjectName.Text;
            if (!Utils.IsValidString(ProjectName))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            DateTime startDate = DTP_Start.Value;
            DateTime endDate = DTP_End.Value;
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                MessageBox.Show("Invalid start/end date");
                return;
            }
            if (_project != null)
            {
                _project.ProjectName = ProjectName;
                _project.StartDate = startDate;
                _project.EndDate = endDate;
                try
                {
                    _projectRepository.Update(_project.Id, _project);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Project modified successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Missing project");
                this.Close();
            }

        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
