namespace BugTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sideMenuPanel = new Panel();
            BT_ShowUsers = new Button();
            BT_ShowIssues = new Button();
            BT_ShowProjects = new Button();
            panel1 = new Panel();
            childPanel = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            sideMenuPanel.SuspendLayout();
            childPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.Controls.Add(BT_ShowUsers);
            sideMenuPanel.Controls.Add(BT_ShowIssues);
            sideMenuPanel.Controls.Add(BT_ShowProjects);
            sideMenuPanel.Controls.Add(panel1);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(300, 744);
            sideMenuPanel.TabIndex = 20;
            // 
            // BT_ShowUsers
            // 
            BT_ShowUsers.BackColor = Color.FromArgb(11, 8, 20);
            BT_ShowUsers.Dock = DockStyle.Top;
            BT_ShowUsers.FlatAppearance.BorderColor = Color.FromArgb(23, 22, 36);
            BT_ShowUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 31, 45);
            BT_ShowUsers.FlatStyle = FlatStyle.Flat;
            BT_ShowUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BT_ShowUsers.ForeColor = SystemColors.Control;
            BT_ShowUsers.Location = new Point(0, 257);
            BT_ShowUsers.Name = "BT_ShowUsers";
            BT_ShowUsers.Padding = new Padding(20, 0, 0, 0);
            BT_ShowUsers.Size = new Size(300, 60);
            BT_ShowUsers.TabIndex = 3;
            BT_ShowUsers.Text = "Users";
            BT_ShowUsers.TextAlign = ContentAlignment.MiddleLeft;
            BT_ShowUsers.UseVisualStyleBackColor = false;
            BT_ShowUsers.Click += BT_ShowUsers_Click;
            // 
            // BT_ShowIssues
            // 
            BT_ShowIssues.BackColor = Color.FromArgb(11, 8, 20);
            BT_ShowIssues.Dock = DockStyle.Top;
            BT_ShowIssues.FlatAppearance.BorderColor = Color.FromArgb(23, 22, 36);
            BT_ShowIssues.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 31, 45);
            BT_ShowIssues.FlatStyle = FlatStyle.Flat;
            BT_ShowIssues.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BT_ShowIssues.ForeColor = SystemColors.Control;
            BT_ShowIssues.Location = new Point(0, 197);
            BT_ShowIssues.Name = "BT_ShowIssues";
            BT_ShowIssues.Padding = new Padding(20, 0, 0, 0);
            BT_ShowIssues.Size = new Size(300, 60);
            BT_ShowIssues.TabIndex = 2;
            BT_ShowIssues.Text = "Issues";
            BT_ShowIssues.TextAlign = ContentAlignment.MiddleLeft;
            BT_ShowIssues.UseVisualStyleBackColor = false;
            BT_ShowIssues.Click += BT_ShowIssues_Click;
            // 
            // BT_ShowProjects
            // 
            BT_ShowProjects.BackColor = Color.FromArgb(11, 8, 20);
            BT_ShowProjects.Dock = DockStyle.Top;
            BT_ShowProjects.FlatAppearance.BorderColor = Color.FromArgb(23, 22, 36);
            BT_ShowProjects.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 31, 45);
            BT_ShowProjects.FlatStyle = FlatStyle.Flat;
            BT_ShowProjects.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BT_ShowProjects.ForeColor = SystemColors.Control;
            BT_ShowProjects.Location = new Point(0, 137);
            BT_ShowProjects.Name = "BT_ShowProjects";
            BT_ShowProjects.Padding = new Padding(20, 0, 0, 0);
            BT_ShowProjects.Size = new Size(300, 60);
            BT_ShowProjects.TabIndex = 1;
            BT_ShowProjects.Text = "Projects";
            BT_ShowProjects.TextAlign = ContentAlignment.MiddleLeft;
            BT_ShowProjects.UseVisualStyleBackColor = false;
            BT_ShowProjects.Click += BT_ShowProjects_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 137);
            panel1.TabIndex = 0;
            // 
            // childPanel
            // 
            childPanel.BackColor = Color.FromArgb(33, 31, 45);
            childPanel.Controls.Add(label1);
            childPanel.Location = new Point(300, 3);
            childPanel.Name = "childPanel";
            childPanel.Size = new Size(1278, 658);
            childPanel.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(300, 667);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 77);
            panel2.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 40F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(244, 40, 89);
            label1.Location = new Point(438, 254);
            label1.Name = "label1";
            label1.Size = new Size(384, 106);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 8, 20);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1578, 744);
            Controls.Add(panel2);
            Controls.Add(sideMenuPanel);
            Controls.Add(childPanel);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1600, 800);
            MinimumSize = new Size(1600, 800);
            Name = "MainForm";
            ShowIcon = false;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            sideMenuPanel.ResumeLayout(false);
            childPanel.ResumeLayout(false);
            childPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel sideMenuPanel;
        private Button BT_ShowProjects;
        private Panel panel1;
        private Panel childPanel;
        private Button BT_ShowUsers;
        private Button BT_ShowIssues;
        private Panel panel2;
        private Label label1;
    }
}
