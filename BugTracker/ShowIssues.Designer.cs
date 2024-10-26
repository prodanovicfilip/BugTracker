namespace BugTracker
{
    partial class ShowIssues
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            BT_IssueAdd = new Button();
            BT_IssueEdit = new Button();
            BT_IssueRemove = new Button();
            DGV_Issues = new DataGridView();
            BT_SearchIssue = new TextBox();
            CT_Context = new ContextMenuStrip(components);
            TS_Assign = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DGV_Issues).BeginInit();
            CT_Context.SuspendLayout();
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
            label3.Size = new Size(83, 32);
            label3.TabIndex = 15;
            label3.Text = "Issues";
            // 
            // BT_IssueAdd
            // 
            BT_IssueAdd.BackColor = Color.FromArgb(244, 40, 89);
            BT_IssueAdd.FlatStyle = FlatStyle.Popup;
            BT_IssueAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_IssueAdd.ForeColor = SystemColors.Control;
            BT_IssueAdd.Location = new Point(1082, 116);
            BT_IssueAdd.Margin = new Padding(4);
            BT_IssueAdd.Name = "BT_IssueAdd";
            BT_IssueAdd.Size = new Size(150, 36);
            BT_IssueAdd.TabIndex = 11;
            BT_IssueAdd.Text = "ADD";
            BT_IssueAdd.UseVisualStyleBackColor = false;
            BT_IssueAdd.Click += BT_IssueAdd_Click;
            // 
            // BT_IssueEdit
            // 
            BT_IssueEdit.BackColor = Color.FromArgb(244, 40, 89);
            BT_IssueEdit.FlatStyle = FlatStyle.Popup;
            BT_IssueEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_IssueEdit.ForeColor = SystemColors.Control;
            BT_IssueEdit.Location = new Point(1082, 160);
            BT_IssueEdit.Margin = new Padding(4);
            BT_IssueEdit.Name = "BT_IssueEdit";
            BT_IssueEdit.Size = new Size(150, 36);
            BT_IssueEdit.TabIndex = 14;
            BT_IssueEdit.Text = "EDIT";
            BT_IssueEdit.UseVisualStyleBackColor = false;
            BT_IssueEdit.Click += BT_IssueEdit_Click;
            // 
            // BT_IssueRemove
            // 
            BT_IssueRemove.BackColor = Color.FromArgb(244, 40, 89);
            BT_IssueRemove.FlatStyle = FlatStyle.Popup;
            BT_IssueRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BT_IssueRemove.ForeColor = SystemColors.Control;
            BT_IssueRemove.Location = new Point(1082, 204);
            BT_IssueRemove.Margin = new Padding(4);
            BT_IssueRemove.Name = "BT_IssueRemove";
            BT_IssueRemove.Size = new Size(150, 36);
            BT_IssueRemove.TabIndex = 10;
            BT_IssueRemove.Text = "REMOVE";
            BT_IssueRemove.UseVisualStyleBackColor = false;
            BT_IssueRemove.Click += BT_IssueRemove_Click;
            // 
            // DGV_Issues
            // 
            DGV_Issues.AllowUserToAddRows = false;
            DGV_Issues.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            DGV_Issues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Issues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Issues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Issues.BackgroundColor = Color.FromArgb(23, 22, 36);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_Issues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_Issues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Issues.ContextMenuStrip = CT_Context;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_Issues.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_Issues.Location = new Point(46, 116);
            DGV_Issues.Margin = new Padding(4);
            DGV_Issues.Name = "DGV_Issues";
            DGV_Issues.ReadOnly = true;
            DGV_Issues.RowHeadersVisible = false;
            DGV_Issues.RowHeadersWidth = 51;
            DGV_Issues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Issues.Size = new Size(997, 464);
            DGV_Issues.TabIndex = 4;
            DGV_Issues.MouseDown += DGV_Issues_MouseDown;
            // 
            // BT_SearchIssue
            // 
            BT_SearchIssue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_SearchIssue.Location = new Point(46, 61);
            BT_SearchIssue.Name = "BT_SearchIssue";
            BT_SearchIssue.PlaceholderText = "Search";
            BT_SearchIssue.Size = new Size(997, 31);
            BT_SearchIssue.TabIndex = 16;
            BT_SearchIssue.TextChanged += BT_SearchIssue_TextChanged;
            // 
            // CT_Context
            // 
            CT_Context.ImageScalingSize = new Size(24, 24);
            CT_Context.Items.AddRange(new ToolStripItem[] { TS_Assign });
            CT_Context.Name = "CT_Context";
            CT_Context.Size = new Size(241, 69);
            // 
            // TS_Assign
            // 
            TS_Assign.Name = "TS_Assign";
            TS_Assign.Size = new Size(240, 32);
            TS_Assign.Text = "Assign Users";
            TS_Assign.Click += TS_Assign_Click;
            // 
            // ShowIssues
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(BT_SearchIssue);
            Controls.Add(DGV_Issues);
            Controls.Add(BT_IssueRemove);
            Controls.Add(BT_IssueEdit);
            Controls.Add(BT_IssueAdd);
            Controls.Add(label3);
            Name = "ShowIssues";
            Text = "ShowIssues";
            Load += ShowIssues_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Issues).EndInit();
            CT_Context.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BT_IssueAdd;
        private Button BT_IssueEdit;
        private Button BT_IssueRemove;
        private DataGridView DGV_Issues;
        private TextBox BT_SearchIssue;
        private ContextMenuStrip CT_Context;
        private ToolStripMenuItem TS_Assign;
    }
}