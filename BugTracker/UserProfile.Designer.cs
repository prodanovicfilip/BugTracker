namespace BugTracker
{
    partial class UserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label3 = new Label();
            DGV_Projects = new DataGridView();
            DGV_Issues = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            LB_Username = new Label();
            LB_Role = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Issues).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(244, 40, 89);
            label3.Location = new Point(46, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 16;
            label3.Text = "User:";
            // 
            // DGV_Projects
            // 
            DGV_Projects.AllowUserToAddRows = false;
            DGV_Projects.AllowUserToDeleteRows = false;
            DGV_Projects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Projects.BackgroundColor = Color.FromArgb(23, 22, 36);
            DGV_Projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Projects.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_Projects.Location = new Point(46, 112);
            DGV_Projects.Margin = new Padding(4);
            DGV_Projects.Name = "DGV_Projects";
            DGV_Projects.ReadOnly = true;
            DGV_Projects.RowHeadersVisible = false;
            DGV_Projects.RowHeadersWidth = 51;
            DGV_Projects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Projects.Size = new Size(533, 449);
            DGV_Projects.TabIndex = 17;
            // 
            // DGV_Issues
            // 
            DGV_Issues.AllowUserToAddRows = false;
            DGV_Issues.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            DGV_Issues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            DGV_Issues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Issues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Issues.BackgroundColor = Color.FromArgb(23, 22, 36);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_Issues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGV_Issues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGV_Issues.DefaultCellStyle = dataGridViewCellStyle4;
            DGV_Issues.Location = new Point(665, 112);
            DGV_Issues.Margin = new Padding(4);
            DGV_Issues.Name = "DGV_Issues";
            DGV_Issues.ReadOnly = true;
            DGV_Issues.RowHeadersVisible = false;
            DGV_Issues.RowHeadersWidth = 51;
            DGV_Issues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Issues.Size = new Size(547, 449);
            DGV_Issues.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(244, 40, 89);
            label1.Location = new Point(46, 67);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 19;
            label1.Text = "Assigned Projects:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(244, 40, 89);
            label2.Location = new Point(665, 67);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 20;
            label2.Text = "Assigned Issues:";
            // 
            // LB_Username
            // 
            LB_Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Username.AutoSize = true;
            LB_Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LB_Username.ForeColor = SystemColors.Control;
            LB_Username.Location = new Point(125, 9);
            LB_Username.Name = "LB_Username";
            LB_Username.Size = new Size(65, 32);
            LB_Username.TabIndex = 21;
            LB_Username.Text = "User";
            // 
            // LB_Role
            // 
            LB_Role.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Role.AutoSize = true;
            LB_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LB_Role.ForeColor = SystemColors.Control;
            LB_Role.Location = new Point(389, 9);
            LB_Role.Name = "LB_Role";
            LB_Role.Size = new Size(64, 32);
            LB_Role.TabIndex = 23;
            LB_Role.Text = "Role";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(244, 40, 89);
            label5.Location = new Point(310, 9);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 22;
            label5.Text = "Role:";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(LB_Role);
            Controls.Add(label5);
            Controls.Add(LB_Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGV_Issues);
            Controls.Add(DGV_Projects);
            Controls.Add(label3);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Issues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView DGV_Projects;
        private DataGridView DGV_Issues;
        private Label label1;
        private Label label2;
        private Label LB_Username;
        private Label LB_Role;
        private Label label5;
    }
}