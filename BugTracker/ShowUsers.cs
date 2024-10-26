using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DataAccess.Repositories;
using BugTracker.Utilities;

namespace BugTracker
{
    public partial class ShowUsers : Form
    {
        private readonly IUserRepository _userRepository;
        private User _user;
        public ShowUsers(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }
        private void ShowUsers_Load(object sender, EventArgs e)
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

        private void BT_UserAdd_Click(object sender, EventArgs e)
        {
            var mainForm = Program.GetService<MainForm>();
            var addUserForm = Program.GetService<AddUserForm>();
            addUserForm.SetMode(AddUserForm.Modes.Add);

            mainForm.OpenChildForm(addUserForm);
        }

        private void BT_UserEdit_Click(object sender, EventArgs e)
        {
            var mainForm = Program.GetService<MainForm>();
            var addUserForm = Program.GetService<AddUserForm>();
            addUserForm.SetMode(AddUserForm.Modes.Edit);
            addUserForm.SetUser(_user);

            mainForm.OpenChildForm(addUserForm);
        }

        private void BT_UserRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                DGV_Users.DataSource = null;
                DGV_Users.DataSource = _userRepository.GetAll();
            }
        }

        private void TB_SearchUsers_TextChanged(object sender, EventArgs e)
        {
            if (!Utils.IsValidString(TB_SearchUsers.Text))
            {
                DGV_Users.DataSource = _userRepository.GetAll();
                return;
            }
            DGV_Users.DataSource = _userRepository.GetAll()
                                              .Where(u => u.UserName.Contains(TB_SearchUsers.Text, StringComparison.OrdinalIgnoreCase))
                                              .ToList();
        }
    }
}
