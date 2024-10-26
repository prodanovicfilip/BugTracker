namespace BugTracker
{
    partial class ShowProjects
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
            label1 = new Label();
            BT_ProjectAdd = new Button();
            BT_ProjectEdit = new Button();
            BT_ProjectRemove = new Button();
            DGV_Projects = new DataGridView();
            TB_SearchProject = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(244, 40, 89);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 13;
            label1.Text = "Projects";
            // 
            // BT_ProjectAdd
            // 
            BT_ProjectAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_ProjectAdd.BackColor = Color.FromArgb(244, 40, 89);
            BT_ProjectAdd.FlatStyle = FlatStyle.Popup;
            BT_ProjectAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_ProjectAdd.ForeColor = Color.White;
            BT_ProjectAdd.Location = new Point(1082, 116);
            BT_ProjectAdd.Margin = new Padding(4);
            BT_ProjectAdd.Name = "BT_ProjectAdd";
            BT_ProjectAdd.Size = new Size(150, 36);
            BT_ProjectAdd.TabIndex = 6;
            BT_ProjectAdd.Text = "ADD";
            BT_ProjectAdd.UseVisualStyleBackColor = false;
            BT_ProjectAdd.Click += BT_ProjectAdd_Click;
            // 
            // BT_ProjectEdit
            // 
            BT_ProjectEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_ProjectEdit.BackColor = Color.FromArgb(244, 40, 89);
            BT_ProjectEdit.FlatStyle = FlatStyle.Popup;
            BT_ProjectEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_ProjectEdit.ForeColor = SystemColors.Control;
            BT_ProjectEdit.Location = new Point(1082, 160);
            BT_ProjectEdit.Margin = new Padding(4);
            BT_ProjectEdit.Name = "BT_ProjectEdit";
            BT_ProjectEdit.Size = new Size(150, 36);
            BT_ProjectEdit.TabIndex = 12;
            BT_ProjectEdit.Text = "EDIT";
            BT_ProjectEdit.UseVisualStyleBackColor = false;
            BT_ProjectEdit.Click += BT_ProjectEdit_Click;
            // 
            // BT_ProjectRemove
            // 
            BT_ProjectRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_ProjectRemove.BackColor = Color.FromArgb(244, 40, 89);
            BT_ProjectRemove.FlatStyle = FlatStyle.Popup;
            BT_ProjectRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_ProjectRemove.ForeColor = SystemColors.Control;
            BT_ProjectRemove.Location = new Point(1082, 204);
            BT_ProjectRemove.Margin = new Padding(4);
            BT_ProjectRemove.Name = "BT_ProjectRemove";
            BT_ProjectRemove.Size = new Size(150, 36);
            BT_ProjectRemove.TabIndex = 7;
            BT_ProjectRemove.Text = "REMOVE";
            BT_ProjectRemove.UseVisualStyleBackColor = false;
            BT_ProjectRemove.Click += BT_ProjectRemove_Click;
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
            DGV_Projects.Location = new Point(46, 116);
            DGV_Projects.Margin = new Padding(4);
            DGV_Projects.Name = "DGV_Projects";
            DGV_Projects.ReadOnly = true;
            DGV_Projects.RowHeadersVisible = false;
            DGV_Projects.RowHeadersWidth = 51;
            DGV_Projects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Projects.Size = new Size(997, 464);
            DGV_Projects.TabIndex = 3;
            DGV_Projects.MouseDown += DGV_Projects_MouseDown;
            // 
            // TB_SearchProject
            // 
            TB_SearchProject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_SearchProject.Location = new Point(46, 61);
            TB_SearchProject.Name = "TB_SearchProject";
            TB_SearchProject.PlaceholderText = "Search";
            TB_SearchProject.Size = new Size(997, 31);
            TB_SearchProject.TabIndex = 14;
            TB_SearchProject.TextChanged += TB_SearchProject_TextChanged;
            // 
            // ShowProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(TB_SearchProject);
            Controls.Add(DGV_Projects);
            Controls.Add(BT_ProjectRemove);
            Controls.Add(BT_ProjectEdit);
            Controls.Add(BT_ProjectAdd);
            Controls.Add(label1);
            Name = "ShowProjects";
            Text = "ShowProjects";
            Load += ShowProjects_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BT_ProjectAdd;
        private Button BT_ProjectEdit;
        private Button BT_ProjectRemove;
        private DataGridView DGV_Projects;
        private TextBox TB_SearchProject;
    }
}