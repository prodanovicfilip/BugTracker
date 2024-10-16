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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DGV_Projects = new DataGridView();
            DGV_Issues = new DataGridView();
            DGV_Users = new DataGridView();
            BT_ProjectAdd = new Button();
            BT_ProjectRemove = new Button();
            BT_UserAdd = new Button();
            BT_UserRemove = new Button();
            BT_IssueRemove = new Button();
            BT_IssueAdd = new Button();
            BT_ProjectEdit = new Button();
            BT_UserEdit = new Button();
            BT_IssueEdit = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Issues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Users).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(15, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 45);
            label1.TabIndex = 0;
            label1.Text = "Projects";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(806, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 45);
            label2.TabIndex = 1;
            label2.Text = "Issues";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(38, 501);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 45);
            label3.TabIndex = 2;
            label3.Text = "Users";
            // 
            // DGV_Projects
            // 
            DGV_Projects.AllowUserToAddRows = false;
            DGV_Projects.AllowUserToDeleteRows = false;
            DGV_Projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Projects.BackgroundColor = Color.MidnightBlue;
            DGV_Projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Projects.Location = new Point(15, 122);
            DGV_Projects.Margin = new Padding(4);
            DGV_Projects.Name = "DGV_Projects";
            DGV_Projects.ReadOnly = true;
            DGV_Projects.RowHeadersWidth = 51;
            DGV_Projects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Projects.Size = new Size(716, 374);
            DGV_Projects.TabIndex = 3;
            DGV_Projects.MouseDown += DGV_Projects_MouseDown;
            // 
            // DGV_Issues
            // 
            DGV_Issues.AllowUserToAddRows = false;
            DGV_Issues.AllowUserToDeleteRows = false;
            DGV_Issues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Issues.BackgroundColor = Color.MidnightBlue;
            DGV_Issues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Issues.Location = new Point(770, 122);
            DGV_Issues.Margin = new Padding(4);
            DGV_Issues.Name = "DGV_Issues";
            DGV_Issues.ReadOnly = true;
            DGV_Issues.RowHeadersWidth = 51;
            DGV_Issues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Issues.Size = new Size(1011, 790);
            DGV_Issues.TabIndex = 4;
            DGV_Issues.MouseDown += DGV_Issues_MouseDown;
            // 
            // DGV_Users
            // 
            DGV_Users.AllowUserToAddRows = false;
            DGV_Users.AllowUserToDeleteRows = false;
            DGV_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Users.BackgroundColor = Color.MidnightBlue;
            DGV_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Users.Location = new Point(15, 549);
            DGV_Users.Margin = new Padding(4);
            DGV_Users.Name = "DGV_Users";
            DGV_Users.ReadOnly = true;
            DGV_Users.RowHeadersWidth = 51;
            DGV_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Users.Size = new Size(716, 363);
            DGV_Users.TabIndex = 5;
            DGV_Users.MouseDown += DGV_Users_MouseDown;
            // 
            // BT_ProjectAdd
            // 
            BT_ProjectAdd.BackColor = Color.Firebrick;
            BT_ProjectAdd.FlatStyle = FlatStyle.Popup;
            BT_ProjectAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_ProjectAdd.ForeColor = Color.White;
            BT_ProjectAdd.Location = new Point(185, 82);
            BT_ProjectAdd.Margin = new Padding(4);
            BT_ProjectAdd.Name = "BT_ProjectAdd";
            BT_ProjectAdd.Size = new Size(118, 36);
            BT_ProjectAdd.TabIndex = 6;
            BT_ProjectAdd.Text = "ADD";
            BT_ProjectAdd.UseVisualStyleBackColor = false;
            // 
            // BT_ProjectRemove
            // 
            BT_ProjectRemove.BackColor = Color.Firebrick;
            BT_ProjectRemove.FlatStyle = FlatStyle.Popup;
            BT_ProjectRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_ProjectRemove.ForeColor = SystemColors.Control;
            BT_ProjectRemove.Location = new Point(310, 82);
            BT_ProjectRemove.Margin = new Padding(4);
            BT_ProjectRemove.Name = "BT_ProjectRemove";
            BT_ProjectRemove.Size = new Size(118, 36);
            BT_ProjectRemove.TabIndex = 7;
            BT_ProjectRemove.Text = "REMOVE";
            BT_ProjectRemove.UseVisualStyleBackColor = false;
            BT_ProjectRemove.Click += BT_ProjectRemove_Click;
            // 
            // BT_UserAdd
            // 
            BT_UserAdd.BackColor = Color.Firebrick;
            BT_UserAdd.FlatStyle = FlatStyle.Popup;
            BT_UserAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_UserAdd.ForeColor = SystemColors.Control;
            BT_UserAdd.Location = new Point(185, 511);
            BT_UserAdd.Margin = new Padding(4);
            BT_UserAdd.Name = "BT_UserAdd";
            BT_UserAdd.Size = new Size(118, 31);
            BT_UserAdd.TabIndex = 8;
            BT_UserAdd.Text = "ADD";
            BT_UserAdd.UseVisualStyleBackColor = false;
            // 
            // BT_UserRemove
            // 
            BT_UserRemove.BackColor = Color.Firebrick;
            BT_UserRemove.FlatStyle = FlatStyle.Popup;
            BT_UserRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_UserRemove.ForeColor = SystemColors.Control;
            BT_UserRemove.Location = new Point(310, 509);
            BT_UserRemove.Margin = new Padding(4);
            BT_UserRemove.Name = "BT_UserRemove";
            BT_UserRemove.Size = new Size(118, 36);
            BT_UserRemove.TabIndex = 9;
            BT_UserRemove.Text = "REMOVE";
            BT_UserRemove.UseVisualStyleBackColor = false;
            BT_UserRemove.Click += BT_UserRemove_Click;
            // 
            // BT_IssueRemove
            // 
            BT_IssueRemove.BackColor = Color.Firebrick;
            BT_IssueRemove.FlatStyle = FlatStyle.Popup;
            BT_IssueRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_IssueRemove.ForeColor = SystemColors.Control;
            BT_IssueRemove.Location = new Point(1048, 82);
            BT_IssueRemove.Margin = new Padding(4);
            BT_IssueRemove.Name = "BT_IssueRemove";
            BT_IssueRemove.Size = new Size(118, 36);
            BT_IssueRemove.TabIndex = 10;
            BT_IssueRemove.Text = "REMOVE";
            BT_IssueRemove.UseVisualStyleBackColor = false;
            BT_IssueRemove.Click += BT_IssueRemove_Click;
            // 
            // BT_IssueAdd
            // 
            BT_IssueAdd.BackColor = Color.Firebrick;
            BT_IssueAdd.FlatStyle = FlatStyle.Popup;
            BT_IssueAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_IssueAdd.ForeColor = SystemColors.Control;
            BT_IssueAdd.Location = new Point(922, 82);
            BT_IssueAdd.Margin = new Padding(4);
            BT_IssueAdd.Name = "BT_IssueAdd";
            BT_IssueAdd.Size = new Size(118, 36);
            BT_IssueAdd.TabIndex = 11;
            BT_IssueAdd.Text = "ADD";
            BT_IssueAdd.UseVisualStyleBackColor = false;
            // 
            // BT_ProjectEdit
            // 
            BT_ProjectEdit.BackColor = Color.Firebrick;
            BT_ProjectEdit.FlatStyle = FlatStyle.Popup;
            BT_ProjectEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_ProjectEdit.ForeColor = SystemColors.Control;
            BT_ProjectEdit.Location = new Point(435, 82);
            BT_ProjectEdit.Margin = new Padding(4);
            BT_ProjectEdit.Name = "BT_ProjectEdit";
            BT_ProjectEdit.Size = new Size(118, 36);
            BT_ProjectEdit.TabIndex = 12;
            BT_ProjectEdit.Text = "EDIT";
            BT_ProjectEdit.UseVisualStyleBackColor = false;
            // 
            // BT_UserEdit
            // 
            BT_UserEdit.BackColor = Color.Firebrick;
            BT_UserEdit.FlatStyle = FlatStyle.Popup;
            BT_UserEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_UserEdit.ForeColor = SystemColors.Control;
            BT_UserEdit.Location = new Point(435, 509);
            BT_UserEdit.Margin = new Padding(4);
            BT_UserEdit.Name = "BT_UserEdit";
            BT_UserEdit.Size = new Size(118, 36);
            BT_UserEdit.TabIndex = 13;
            BT_UserEdit.Text = "EDIT";
            BT_UserEdit.UseVisualStyleBackColor = false;
            // 
            // BT_IssueEdit
            // 
            BT_IssueEdit.BackColor = Color.Firebrick;
            BT_IssueEdit.FlatStyle = FlatStyle.Popup;
            BT_IssueEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_IssueEdit.ForeColor = SystemColors.Control;
            BT_IssueEdit.Location = new Point(1172, 82);
            BT_IssueEdit.Margin = new Padding(4);
            BT_IssueEdit.Name = "BT_IssueEdit";
            BT_IssueEdit.Size = new Size(118, 36);
            BT_IssueEdit.TabIndex = 14;
            BT_IssueEdit.Text = "EDIT";
            BT_IssueEdit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(15, 11);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(369, 54);
            label4.TabIndex = 15;
            label4.Text = "Bug Tracker Board";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1798, 924);
            Controls.Add(label4);
            Controls.Add(BT_IssueEdit);
            Controls.Add(BT_UserEdit);
            Controls.Add(BT_ProjectEdit);
            Controls.Add(BT_IssueAdd);
            Controls.Add(BT_IssueRemove);
            Controls.Add(BT_UserRemove);
            Controls.Add(BT_UserAdd);
            Controls.Add(BT_ProjectRemove);
            Controls.Add(BT_ProjectAdd);
            Controls.Add(DGV_Users);
            Controls.Add(DGV_Issues);
            Controls.Add(DGV_Projects);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1820, 980);
            MinimumSize = new Size(1820, 980);
            Name = "MainForm";
            ShowIcon = false;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Issues).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView DGV_Projects;
        private DataGridView DGV_Issues;
        private DataGridView DGV_Users;
        private Button BT_ProjectAdd;
        private Button BT_ProjectRemove;
        private Button BT_UserAdd;
        private Button BT_UserRemove;
        private Button BT_IssueRemove;
        private Button BT_IssueAdd;
        private Button BT_ProjectEdit;
        private Button BT_UserEdit;
        private Button BT_IssueEdit;
        private Label label4;
    }
}
