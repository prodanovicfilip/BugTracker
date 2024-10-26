namespace BugTracker
{
    partial class AddIssueForm
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
            TB_Summary = new TextBox();
            RTB_Desc = new RichTextBox();
            CB_Priority = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BT_Create = new Button();
            CB_Status = new ComboBox();
            LB_Status = new Label();
            panel1 = new Panel();
            label4 = new Label();
            CB_Projects = new ComboBox();
            BT_Close = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_Summary
            // 
            TB_Summary.Location = new Point(131, 87);
            TB_Summary.Name = "TB_Summary";
            TB_Summary.Size = new Size(292, 31);
            TB_Summary.TabIndex = 0;
            // 
            // RTB_Desc
            // 
            RTB_Desc.Location = new Point(131, 133);
            RTB_Desc.Name = "RTB_Desc";
            RTB_Desc.Size = new Size(747, 250);
            RTB_Desc.TabIndex = 1;
            RTB_Desc.Text = "";
            // 
            // CB_Priority
            // 
            CB_Priority.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Priority.FormattingEnabled = true;
            CB_Priority.Location = new Point(696, 392);
            CB_Priority.Name = "CB_Priority";
            CB_Priority.Size = new Size(182, 33);
            CB_Priority.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 90);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 4;
            label1.Text = "Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 136);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 395);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 6;
            label3.Text = "Priority";
            // 
            // BT_Create
            // 
            BT_Create.BackColor = Color.FromArgb(244, 40, 89);
            BT_Create.FlatAppearance.BorderSize = 0;
            BT_Create.FlatStyle = FlatStyle.Popup;
            BT_Create.Location = new Point(1104, 530);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(112, 34);
            BT_Create.TabIndex = 7;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = false;
            BT_Create.Click += BT_Create_Click;
            // 
            // CB_Status
            // 
            CB_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Status.FormattingEnabled = true;
            CB_Status.Location = new Point(434, 392);
            CB_Status.Name = "CB_Status";
            CB_Status.Size = new Size(182, 33);
            CB_Status.TabIndex = 8;
            // 
            // LB_Status
            // 
            LB_Status.AutoSize = true;
            LB_Status.Location = new Point(363, 395);
            LB_Status.Name = "LB_Status";
            LB_Status.Size = new Size(60, 25);
            LB_Status.TabIndex = 9;
            LB_Status.Text = "Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 31, 45);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CB_Projects);
            panel1.Controls.Add(BT_Close);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BT_Create);
            panel1.Controls.Add(LB_Status);
            panel1.Controls.Add(TB_Summary);
            panel1.Controls.Add(CB_Status);
            panel1.Controls.Add(RTB_Desc);
            panel1.Controls.Add(CB_Priority);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 578);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(915, 25);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 16;
            label4.Text = "Project";
            // 
            // CB_Projects
            // 
            CB_Projects.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Projects.FormattingEnabled = true;
            CB_Projects.Location = new Point(1003, 25);
            CB_Projects.Name = "CB_Projects";
            CB_Projects.Size = new Size(197, 33);
            CB_Projects.TabIndex = 11;
            // 
            // BT_Close
            // 
            BT_Close.FlatAppearance.BorderSize = 0;
            BT_Close.FlatStyle = FlatStyle.Flat;
            BT_Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Close.ForeColor = Color.FromArgb(244, 40, 89);
            BT_Close.Location = new Point(13, 16);
            BT_Close.Name = "BT_Close";
            BT_Close.Size = new Size(112, 39);
            BT_Close.TabIndex = 10;
            BT_Close.Text = "< BACK";
            BT_Close.UseVisualStyleBackColor = true;
            BT_Close.Click += BT_Close_Click;
            // 
            // AddIssueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 22, 36);
            ClientSize = new Size(1256, 602);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddIssueForm";
            Text = "IssueForm";
            Load += AddIssueForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TB_Summary;
        private RichTextBox RTB_Desc;
        private ComboBox CB_Priority;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BT_Create;
        private ComboBox CB_Status;
        private Label LB_Status;
        private Panel panel1;
        private Button BT_Close;
        private ComboBox CB_Projects;
        private Label label4;
    }
}