using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BugTracker
{
    public partial class AddUserForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;
        private Project _currentProject;
        public AddUserForm(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            CB_Roles.DataSource = Enum.GetValues(typeof(User.Role));
            _projectRepository = projectRepository;
        }

        private void BT_Create_Click(object sender, EventArgs e)
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
            var project = _projectRepository.GetById(_currentProject.Id);
            if (user.AssignedProjects == null)
            {
                user.AssignedProjects = new List<Project>();
            }
            user.AssignedProjects.Add(project);
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
        public void AssignProject(Project project)
        {
            _currentProject = project;
        }
    }
}
