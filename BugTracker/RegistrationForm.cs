using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.DataAccess;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DataAccess.Repositories;
using BugTracker.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BugTracker
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository _userRepository;
        public RegistrationForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void BT_Register_Click(object sender, EventArgs e)
        {
            var username = TB_Username.Text;
            var password = TB_Password.Text;
            var email = TB_Email.Text;
            if (!Utils.IsValidString(username, password, email))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            var user = new User();
            user.UserName = username;
            user.Password = password;
            user.Email = email;
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
    }
}
