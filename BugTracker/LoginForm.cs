using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BugTracker
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;
        public LoginForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void BT_Signup_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<RegistrationForm>();
            form.ShowDialog();
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text;

            if (!Utils.IsValidString(username, password))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            try
            {
                var currentUser = _userRepository.Login(username, password);
                if (currentUser == null)
                {
                    MessageBox.Show("Cannot login!");
                    return;
                }
                UserController.CurrentUser = currentUser;
                var form = Program.GetService<MainForm>();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
