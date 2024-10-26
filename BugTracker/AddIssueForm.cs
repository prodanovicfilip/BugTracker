using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using BugTracker.Utilities;

namespace BugTracker
{
    public partial class AddIssueForm : Form
    {
        public enum Modes
        {
            Add, Edit
        }
        private readonly IIssueRepository _issueRepository;
        private readonly IProjectRepository _projectRepository;
        private Modes _mode;
        private Issue _issue;
        public AddIssueForm(IIssueRepository issueRepository, IProjectRepository projectRepository)
        {
            InitializeComponent();
            _issueRepository = issueRepository;
            _projectRepository = projectRepository;
            CB_Priority.DataSource = Enum.GetValues(typeof(Issue.PriorityLevel));
            CB_Status.DataSource = Enum.GetValues(typeof(Issue.IssueStatus));

            var _projectNames = new List<string>();
            foreach(Project p in _projectRepository.GetAll())
            {
                _projectNames.Add(p.ProjectName);
            }
            CB_Projects.DataSource = _projectNames;
        }
        public void SetMode(Modes mode)
        {
            _mode = mode;
        }
        public void SetIssue(Issue issue)
        {
            _issue = issue;
        }
        private void AddIssueForm_Load(object sender, EventArgs e)
        {
            if (_mode == Modes.Add)
            {
                LB_Status.Visible = false;
                CB_Status.Visible = false;
            }
            else
            {
                LB_Status.Visible = true;
                CB_Status.Visible = true;
                BT_Create.Text = "Edit";
                if (_issue != null)
                {
                    TB_Summary.Text = _issue.Summary;
                    RTB_Desc.Text = _issue.Description;
                    CB_Status.Text = _issue.Status.ToString();
                    CB_Priority.Text = _issue.Priority.ToString();
                    CB_Projects.Text = _issue.RelatedProject.ProjectName.ToString();
                }
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
            if (CB_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Select Priority");
                return;
            }
            if (CB_Projects.SelectedIndex == -1)
            {
                MessageBox.Show("Select Project");
                return;
            }
            if (_issue != null)
            {
                _issue.Summary = Summary;
                _issue.Description = Description;
                _issue.Priority = (Issue.PriorityLevel)CB_Priority.SelectedItem;
                _issue.Status = (Issue.IssueStatus)CB_Status.SelectedItem;
                //Related project
                var relatedProjectName = CB_Projects.SelectedItem;
                _issue.RelatedProject = _projectRepository.GetAll().FirstOrDefault(n => n.ProjectName.Equals(relatedProjectName));
                if (_issue.RelatedProject == null)
                {
                    MessageBox.Show("Couldn't find project with that name");
                    return;
                }
                try
                {
                    _issueRepository.Update(_issue.Id, _issue);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Issue modified successfully");
            }
            else
            {
                MessageBox.Show("Error: Missing issue");
                this.Close();
            }
        }
        private void AddMode()
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
            if (CB_Projects.SelectedIndex == -1)
            {
                MessageBox.Show("Select Project");
                return;
            }

            var issue = new Issue();
            issue.Status = Issue.IssueStatus.Open;
            issue.Summary = Summary;
            issue.Description = Description;
            issue.Priority = (Issue.PriorityLevel)CB_Priority.SelectedItem;
            //Related project
            var relatedProjectName = CB_Projects.SelectedItem;
            _issue.RelatedProject = _projectRepository.GetAll().FirstOrDefault(n => n.ProjectName.Equals(relatedProjectName));
            if (_issue.RelatedProject == null)
            {
                MessageBox.Show("Couldn't find project with that name");
                return;
            }
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

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
