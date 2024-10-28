using System.Linq;
using System.Windows.Forms;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DTO;
using Mapster;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace BugTracker
{
    public partial class UserSelectionForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IIssueRepository _issueRepository;
        private Issue _issue;
        private List<UserWithIssueDTO> _users;
        public UserSelectionForm(IUserRepository userRepository, IIssueRepository issueRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _issueRepository = issueRepository;
        }
        public void SetIssue(Issue issue)
        {
            _issue = issue;
        }

        private void UserSelectionForm_Load(object sender, EventArgs e)
        {
            if (_userRepository.GetAll() == null)
            {
                return;
            }
            _users = _userRepository.GetAll().ToList().Adapt<List<UserWithIssueDTO>>();
            if (_issueRepository.GetById(_issue.Id).Users != null)
            {
                foreach (var user in _users)
                {
                    if (_issueRepository.GetById(_issue.Id).Users.Any(u => u.UserName == user.UserName))
                    {
                        user.HasIssue = true;
                    }
                }
            }
            DGV_Users.DataSource = _users;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (_issue != null)
            {
                foreach (var user in _users)
                {
                    if (user.HasIssue)
                    {
                        if (_issue.Users == null)
                        {
                            _issue.Users = new List<User>();
                        }
                        var newUser = _userRepository.GetAll().FirstOrDefault(n => n.UserName.Equals(user.UserName));
                        try
                        {
                            _issueRepository.AddUser(_issue.Id, newUser);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            this.Close();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
