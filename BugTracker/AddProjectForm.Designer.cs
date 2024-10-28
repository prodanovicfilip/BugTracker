namespace BugTracker
{
    partial class AddProjectForm
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
            TB_ProjectName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DTP_Start = new DateTimePicker();
            DTP_End = new DateTimePicker();
            BT_Create = new Button();
            BT_Close = new Button();
            LB_User = new Label();
            CB_Users = new ComboBox();
            SuspendLayout();
            // 
            // TB_ProjectName
            // 
            TB_ProjectName.Location = new Point(230, 93);
            TB_ProjectName.Name = "TB_ProjectName";
            TB_ProjectName.Size = new Size(300, 31);
            TB_ProjectName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 96);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 3;
            label1.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 141);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 178);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "End Date";
            // 
            // DTP_Start
            // 
            DTP_Start.Location = new Point(230, 136);
            DTP_Start.Name = "DTP_Start";
            DTP_Start.Size = new Size(300, 31);
            DTP_Start.TabIndex = 6;
            // 
            // DTP_End
            // 
            DTP_End.Location = new Point(230, 173);
            DTP_End.Name = "DTP_End";
            DTP_End.Size = new Size(300, 31);
            DTP_End.TabIndex = 7;
            // 
            // BT_Create
            // 
            BT_Create.BackColor = Color.FromArgb(244, 40, 89);
            BT_Create.FlatStyle = FlatStyle.Popup;
            BT_Create.Location = new Point(1062, 520);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(112, 34);
            BT_Create.TabIndex = 8;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = false;
            BT_Create.Click += BT_Create_Click;
            // 
            // BT_Close
            // 
            BT_Close.FlatAppearance.BorderSize = 0;
            BT_Close.FlatStyle = FlatStyle.Flat;
            BT_Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Close.ForeColor = Color.FromArgb(244, 40, 89);
            BT_Close.Location = new Point(12, 12);
            BT_Close.Name = "BT_Close";
            BT_Close.Size = new Size(112, 39);
            BT_Close.TabIndex = 11;
            BT_Close.Text = "< BACK";
            BT_Close.UseVisualStyleBackColor = true;
            BT_Close.Click += BT_Close_Click;
            // 
            // LB_User
            // 
            LB_User.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_User.AutoSize = true;
            LB_User.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LB_User.ForeColor = SystemColors.Control;
            LB_User.Location = new Point(580, 96);
            LB_User.Name = "LB_User";
            LB_User.Size = new Size(50, 25);
            LB_User.TabIndex = 18;
            LB_User.Text = "User";
            // 
            // CB_Users
            // 
            CB_Users.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Users.FormattingEnabled = true;
            CB_Users.Location = new Point(636, 93);
            CB_Users.Name = "CB_Users";
            CB_Users.Size = new Size(197, 33);
            CB_Users.TabIndex = 17;
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(LB_User);
            Controls.Add(CB_Users);
            Controls.Add(BT_Close);
            Controls.Add(BT_Create);
            Controls.Add(DTP_End);
            Controls.Add(DTP_Start);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_ProjectName);
            ForeColor = SystemColors.Control;
            Name = "AddProjectForm";
            Text = "AddProjectForm";
            Load += AddProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_ProjectName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker DTP_Start;
        private DateTimePicker DTP_End;
        private Button BT_Create;
        private Button BT_Close;
        private Label LB_User;
        private ComboBox CB_Users;
    }
}