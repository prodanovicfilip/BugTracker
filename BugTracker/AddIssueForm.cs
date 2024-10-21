using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DataAccess.Repositories;
using BugTracker.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BugTracker
{
    public partial class AddIssueForm : Form
    {
        private readonly IIssueRepository _issueRepository;
        public AddIssueForm(IIssueRepository issueRepository)
        {
            InitializeComponent();
            _issueRepository = issueRepository;
            CB_Priority.DataSource = Enum.GetValues(typeof(Issue.PriorityLevel));
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            string Summary = TB_Summary.Text;
            string Description = RTB_Desc.Text;
            if (!Utils.IsValidString(Summary, Description))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            if (CB_Priority.SelectedIndex == -1)
            {
                MessageBox.Show("Select Priority");
                return;
            }
            var issue = new Issue();
            issue.Status = Issue.IssueStatus.Open;
            issue.Summary = Summary;
            issue.Description = Description;
            issue.Priority = (Issue.PriorityLevel)CB_Priority.SelectedItem;
            try
            {
                _issueRepository.Add(issue);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Issue created successfully");
            this.Close();
        }
    }
}
