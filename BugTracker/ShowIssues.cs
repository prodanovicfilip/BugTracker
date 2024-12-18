﻿using System.Data;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.DTO;
using BugTracker.Utilities;
using Mapster;

namespace BugTracker
{
    public partial class ShowIssues : Form
    {
        private readonly IIssueRepository _issueRepository;
        private Issue _issue;
        private bool validClick = false;

        public ShowIssues(IIssueRepository issueRepository)
        {
            InitializeComponent();
            _issueRepository = issueRepository;
        }

        private void ShowIssues_Load(object sender, EventArgs e)
        {
            if (_issueRepository.GetAll() != null)
            {
                DGV_Issues.DataSource = _issueRepository.GetAll().Adapt<List<IssueDTO>>();
                if (_issueRepository.GetAll().Count() > 0)
                {
                    DGV_Issues.Rows[0].Selected = true;
                    _issue = _issueRepository.GetAll().FirstOrDefault();
                }
            }
        }

        private void BT_SearchIssue_TextChanged(object sender, EventArgs e)
        {
            if (!Utils.IsValidString(BT_SearchIssue.Text))
            {
                DGV_Issues.DataSource = _issueRepository.GetAll();
                return;
            }
            DGV_Issues.DataSource = _issueRepository.GetAll()
                                              .Where(p => p.Summary.Contains(BT_SearchIssue.Text, StringComparison.OrdinalIgnoreCase))
                                              .ToList();
        }

        private void BT_IssueAdd_Click(object sender, EventArgs e)
        {
            if (Utils.IsAllowed())
            {
                var mainForm = Program.GetService<MainForm>();
                var addIssueForm = Program.GetService<AddIssueForm>();
                addIssueForm.SetMode(AddIssueForm.Modes.Add);

                mainForm.OpenChildForm(addIssueForm);
            }
            else
            {
                MessageBox.Show("User is not allowed to do that action");
            }
        }

        private void BT_IssueEdit_Click(object sender, EventArgs e)
        {
            if (Utils.IsAllowed(_issue))
            {
                var mainForm = Program.GetService<MainForm>();
                var addIssueForm = Program.GetService<AddIssueForm>();
                addIssueForm.SetMode(AddIssueForm.Modes.Edit);
                addIssueForm.SetIssue(_issue);

                mainForm.OpenChildForm(addIssueForm);
            }
            else
            {
                MessageBox.Show("User is not allowed to do that action");
            }
        }

        private void BT_IssueRemove_Click(object sender, EventArgs e)
        {
            if (!Utils.IsAllowed(_issue))
            {
                MessageBox.Show("User is not allowed to do that action");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
                        _issue = _issueRepository.GetAll().FirstOrDefault();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                DGV_Issues.DataSource = null;
                DGV_Issues.DataSource = _issueRepository.GetAll();
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
                validClick = true;
            }
            else validClick = false;
        }

        private void TS_Assign_Click(object sender, EventArgs e)
        {
            if (!Utils.IsAllowed())
            {
                MessageBox.Show("User is not allowed to do that action");
                return;
            }
            if (validClick)
            {
                var mainForm = Program.GetService<MainForm>();
                var selectionForm = Program.GetService<UserSelectionForm>();

                selectionForm.SetIssue(_issue);
                mainForm.OpenChildForm(selectionForm);
            }
        }
    }
}