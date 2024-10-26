namespace BugTracker
{
    partial class UserSelectionForm
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
            DGV_Users = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserRole = new DataGridViewTextBoxColumn();
            HasIssue = new DataGridViewCheckBoxColumn();
            BT_Save = new Button();
            BT_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Users).BeginInit();
            SuspendLayout();
            // 
            // DGV_Users
            // 
            DGV_Users.AllowUserToAddRows = false;
            DGV_Users.AllowUserToDeleteRows = false;
            DGV_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Users.BackgroundColor = Color.FromArgb(23, 22, 36);
            DGV_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Users.Columns.AddRange(new DataGridViewColumn[] { UserName, UserRole, HasIssue });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Users.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_Users.Location = new Point(46, 116);
            DGV_Users.Margin = new Padding(4);
            DGV_Users.Name = "DGV_Users";
            DGV_Users.RowHeadersVisible = false;
            DGV_Users.RowHeadersWidth = 51;
            DGV_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Users.Size = new Size(997, 464);
            DGV_Users.TabIndex = 6;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // UserRole
            // 
            UserRole.DataPropertyName = "UserRole";
            UserRole.HeaderText = "UserRole";
            UserRole.MinimumWidth = 8;
            UserRole.Name = "UserRole";
            UserRole.ReadOnly = true;
            // 
            // HasIssue
            // 
            HasIssue.DataPropertyName = "HasIssue";
            HasIssue.HeaderText = "HasIssue";
            HasIssue.MinimumWidth = 8;
            HasIssue.Name = "HasIssue";
            // 
            // BT_Save
            // 
            BT_Save.BackColor = Color.FromArgb(244, 40, 89);
            BT_Save.FlatStyle = FlatStyle.Popup;
            BT_Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_Save.ForeColor = SystemColors.Control;
            BT_Save.Location = new Point(1093, 13);
            BT_Save.Margin = new Padding(4);
            BT_Save.Name = "BT_Save";
            BT_Save.Size = new Size(150, 36);
            BT_Save.TabIndex = 9;
            BT_Save.Text = "SAVE";
            BT_Save.UseVisualStyleBackColor = false;
            BT_Save.Click += BT_Save_Click;
            // 
            // BT_Close
            // 
            BT_Close.FlatAppearance.BorderSize = 0;
            BT_Close.FlatStyle = FlatStyle.Flat;
            BT_Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Close.ForeColor = Color.FromArgb(244, 40, 89);
            BT_Close.Location = new Point(46, 13);
            BT_Close.Name = "BT_Close";
            BT_Close.Size = new Size(112, 39);
            BT_Close.TabIndex = 12;
            BT_Close.Text = "< BACK";
            BT_Close.UseVisualStyleBackColor = true;
            BT_Close.Click += BT_Close_Click;
            // 
            // UserSelectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(BT_Close);
            Controls.Add(BT_Save);
            Controls.Add(DGV_Users);
            Name = "UserSelectionForm";
            Text = "UserSelectionForm";
            Load += UserSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Users;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserRole;
        private DataGridViewCheckBoxColumn HasIssue;
        private Button BT_Save;
        private Button BT_Close;
    }
}