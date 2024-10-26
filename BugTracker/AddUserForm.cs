using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;

namespace BugTracker
{
    public partial class AddUserForm : Form
    {
        public enum Modes
        {
            Add, Edit
        }

        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;
        private User _user;
        private List<Project> _projects;
        private Modes _mode;

        public AddUserForm(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            CB_Roles.DataSource = Enum.GetValues(typeof(User.Role));
            _projectRepository = projectRepository;
        }

        public void SetMode(Modes mode)
        {
            _mode = mode;
        }

        public void SetUser(User user)
        {
            _user = user;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            if (_mode == Modes.Edit)
            {
                if (_user != null)
                {
                    // Fillup fields
                    TB_Username.Text = _user.UserName;
                    TB_Password.Text = _user.Password;
                    TB_Email.Text = _user.Email;
                    CB_Roles.Text = _user.UserRole.ToString();
                    _projects = _user.AssignedProjects.ToList();
                    foreach (Project project in _projects)
                    {
                        LB_Projects.Items.Add(project.ProjectName);
                    }

                    BT_Create.Text = "Edit";
                }
                else
                {
                    MessageBox.Show("Select user");
                    this.Close();
                }
            }
            
            if (_mode == Modes.Add)
            {
                _projects = new List<Project>();
            }
            if (_projectRepository.GetAll() != null)
            {
                DGV_Projects.DataSource = _projectRepository.GetAll();
            }
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            if (_mode == Modes.Add)
                AddMode();
            else if (_mode == Modes.Edit)
                EditMode();
        }

        private void EditMode()
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text;
            string email = TB_Email.Text;
            if (!Utils.IsValidString(username, password, email))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            if (CB_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("Select Role");
                return;
            }
            User.Role role = (User.Role)CB_Roles.SelectedValue;
            if (_user != null)
            {
                _user.UserName = username;
                _user.Password = password;
                _user.Email = email;
                _user.UserRole = role;
                if (_user.AssignedProjects == null)
                {
                    _user.AssignedProjects = new List<Project>();
                }
                foreach (Project project in _projects)
                {
                    var _project = _projectRepository.GetById(project.Id);
                    _user.AssignedProjects.Add(_project);
                }
                try
                {
                    _userRepository.Update(_user.Id, _user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("User modified successfully");
                this.Close();
            }
        }

        private void AddMode()
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text;
            string email = TB_Email.Text;
            if (!Utils.IsValidString(username, password, email))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            if (CB_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("Select Role");
                return;
            }
            User.Role role = (User.Role)CB_Roles.SelectedValue;
            var user = new User();
            user.UserName = username;
            user.Password = password;
            user.Email = email;
            user.UserRole = role;
            if (user.AssignedProjects == null)
            {
                user.AssignedProjects = new List<Project>();
            }
            foreach (Project project in _projects)
            {
                var _project = _projectRepository.GetById(project.Id);
                user.AssignedProjects.Add(_project);
            }
            try
            {
                _userRepository.Add(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("User created successfully");
            this.Close();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Projects_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Projects.HitTest(e.X, e.Y);
            DGV_Projects.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_Projects.Rows[hit.RowIndex].Selected = true;
                var _selectedProject = _projectRepository.GetAll().ToList()[hit.RowIndex];
                if (_selectedProject != null)
                {
                    // Start dragging the row
                    DGV_Projects.DoDragDrop(_selectedProject, DragDropEffects.Move);
                }
            }
        }

        private void LB_Projects_DragOver(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is a DataGridViewRow
            if (e.Data.GetDataPresent(typeof(Project)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LB_Projects_DragDrop(object sender, DragEventArgs e)
        {
            // Ensure the data is of type Project
            if (e.Data.GetDataPresent(typeof(Project)))
            {
                // Retrieve the Project object from the drag data
                var project = (Project)e.Data.GetData(typeof(Project));

                // Check if project is already in _projects list to avoid duplicates
                if (!_projects.Any(p => p.Id == project.Id))
                {
                    // Add the project to the _projects list
                    _projects.Add(project);

                    // Update the ListBox with the ProjectName only
                    LB_Projects.Items.Add(project.ProjectName);
                }
                else
                {
                    MessageBox.Show("This project has already been added.");
                }
            }
        }
    }
}