namespace BugTracker
{
    partial class ShowUsers
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label2 = new Label();
            BT_UserAdd = new Button();
            BT_UserEdit = new Button();
            BT_UserRemove = new Button();
            DGV_Users = new DataGridView();
            TB_SearchUsers = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Users).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(244, 40, 89);
            label2.Location = new Point(46, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 14;
            label2.Text = "Users";
            // 
            // BT_UserAdd
            // 
            BT_UserAdd.BackColor = Color.FromArgb(244, 40, 89);
            BT_UserAdd.FlatStyle = FlatStyle.Popup;
            BT_UserAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_UserAdd.ForeColor = SystemColors.Control;
            BT_UserAdd.Location = new Point(1082, 116);
            BT_UserAdd.Margin = new Padding(4);
            BT_UserAdd.Name = "BT_UserAdd";
            BT_UserAdd.Size = new Size(150, 36);
            BT_UserAdd.TabIndex = 8;
            BT_UserAdd.Text = "ADD";
            BT_UserAdd.UseVisualStyleBackColor = false;
            BT_UserAdd.Click += BT_UserAdd_Click;
            // 
            // BT_UserEdit
            // 
            BT_UserEdit.BackColor = Color.FromArgb(244, 40, 89);
            BT_UserEdit.FlatStyle = FlatStyle.Popup;
            BT_UserEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_UserEdit.ForeColor = SystemColors.Control;
            BT_UserEdit.Location = new Point(1082, 160);
            BT_UserEdit.Margin = new Padding(4);
            BT_UserEdit.Name = "BT_UserEdit";
            BT_UserEdit.Size = new Size(150, 36);
            BT_UserEdit.TabIndex = 13;
            BT_UserEdit.Text = "EDIT";
            BT_UserEdit.UseVisualStyleBackColor = false;
            BT_UserEdit.Click += BT_UserEdit_Click;
            // 
            // BT_UserRemove
            // 
            BT_UserRemove.BackColor = Color.FromArgb(244, 40, 89);
            BT_UserRemove.FlatStyle = FlatStyle.Popup;
            BT_UserRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_UserRemove.ForeColor = SystemColors.Control;
            BT_UserRemove.Location = new Point(1082, 204);
            BT_UserRemove.Margin = new Padding(4);
            BT_UserRemove.Name = "BT_UserRemove";
            BT_UserRemove.Size = new Size(150, 36);
            BT_UserRemove.TabIndex = 9;
            BT_UserRemove.Text = "REMOVE";
            BT_UserRemove.UseVisualStyleBackColor = false;
            BT_UserRemove.Click += BT_UserRemove_Click;
            // 
            // DGV_Users
            // 
            DGV_Users.AllowUserToAddRows = false;
            DGV_Users.AllowUserToDeleteRows = false;
            DGV_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Users.BackgroundColor = Color.FromArgb(23, 22, 36);
            DGV_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGV_Users.DefaultCellStyle = dataGridViewCellStyle5;
            DGV_Users.Location = new Point(46, 116);
            DGV_Users.Margin = new Padding(4);
            DGV_Users.Name = "DGV_Users";
            DGV_Users.ReadOnly = true;
            DGV_Users.RowHeadersVisible = false;
            DGV_Users.RowHeadersWidth = 51;
            DGV_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Users.Size = new Size(997, 464);
            DGV_Users.TabIndex = 5;
            DGV_Users.MouseDown += DGV_Users_MouseDown;
            // 
            // TB_SearchUsers
            // 
            TB_SearchUsers.Location = new Point(46, 61);
            TB_SearchUsers.Name = "TB_SearchUsers";
            TB_SearchUsers.PlaceholderText = "Search";
            TB_SearchUsers.Size = new Size(997, 31);
            TB_SearchUsers.TabIndex = 15;
            TB_SearchUsers.TextChanged += TB_SearchUsers_TextChanged;
            // 
            // ShowUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(TB_SearchUsers);
            Controls.Add(DGV_Users);
            Controls.Add(BT_UserRemove);
            Controls.Add(BT_UserEdit);
            Controls.Add(BT_UserAdd);
            Controls.Add(label2);
            Name = "ShowUsers";
            Text = "ShowUsers";
            Load += ShowUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BT_UserAdd;
        private Button BT_UserEdit;
        private Button BT_UserRemove;
        private DataGridView DGV_Users;
        private TextBox TB_SearchUsers;
    }
}