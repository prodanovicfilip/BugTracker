namespace BugTracker
{
    partial class AddUserForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TB_Username = new TextBox();
            TB_Password = new TextBox();
            TB_Email = new TextBox();
            CB_Roles = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BT_Create = new Button();
            DGV_Projects = new DataGridView();
            LB_Projects = new ListBox();
            projectBindingSource = new BindingSource(components);
            label5 = new Label();
            label6 = new Label();
            BT_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(286, 20);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(150, 31);
            TB_Username.TabIndex = 0;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(553, 20);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(150, 31);
            TB_Password.TabIndex = 1;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(799, 20);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(157, 31);
            TB_Email.TabIndex = 2;
            // 
            // CB_Roles
            // 
            CB_Roles.FormattingEnabled = true;
            CB_Roles.Location = new Point(1039, 20);
            CB_Roles.Name = "CB_Roles";
            CB_Roles.Size = new Size(192, 33);
            CB_Roles.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 23);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(735, 23);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(978, 23);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // BT_Create
            // 
            BT_Create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_Create.BackColor = Color.FromArgb(244, 40, 89);
            BT_Create.FlatStyle = FlatStyle.Popup;
            BT_Create.Location = new Point(1119, 542);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(112, 34);
            BT_Create.TabIndex = 9;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = false;
            BT_Create.Click += BT_Create_Click;
            // 
            // DGV_Projects
            // 
            DGV_Projects.AllowUserToAddRows = false;
            DGV_Projects.AllowUserToDeleteRows = false;
            DGV_Projects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Projects.BackgroundColor = Color.FromArgb(23, 22, 36);
            DGV_Projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 31, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 40, 89);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_Projects.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_Projects.Location = new Point(23, 112);
            DGV_Projects.Margin = new Padding(4);
            DGV_Projects.Name = "DGV_Projects";
            DGV_Projects.ReadOnly = true;
            DGV_Projects.RowHeadersVisible = false;
            DGV_Projects.RowHeadersWidth = 51;
            DGV_Projects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Projects.Size = new Size(988, 464);
            DGV_Projects.TabIndex = 10;
            DGV_Projects.MouseDown += DGV_Projects_MouseDown;
            // 
            // LB_Projects
            // 
            LB_Projects.AllowDrop = true;
            LB_Projects.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LB_Projects.FormattingEnabled = true;
            LB_Projects.ItemHeight = 25;
            LB_Projects.Location = new Point(1039, 112);
            LB_Projects.Name = "LB_Projects";
            LB_Projects.Size = new Size(192, 354);
            LB_Projects.TabIndex = 12;
            LB_Projects.DragDrop += LB_Projects_DragDrop;
            LB_Projects.DragOver += LB_Projects_DragOver;
            // 
            // projectBindingSource
            // 
            projectBindingSource.DataSource = typeof(DataAccess.Entities.Project);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(244, 40, 89);
            label5.Location = new Point(1027, 77);
            label5.Name = "label5";
            label5.Size = new Size(217, 32);
            label5.TabIndex = 15;
            label5.Text = "Assigned Projects";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(244, 40, 89);
            label6.Location = new Point(23, 77);
            label6.Name = "label6";
            label6.Size = new Size(144, 32);
            label6.TabIndex = 16;
            label6.Text = "All Projects";
            // 
            // BT_Close
            // 
            BT_Close.FlatAppearance.BorderSize = 0;
            BT_Close.FlatStyle = FlatStyle.Flat;
            BT_Close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BT_Close.ForeColor = Color.FromArgb(244, 40, 89);
            BT_Close.Location = new Point(12, 14);
            BT_Close.Name = "BT_Close";
            BT_Close.Size = new Size(112, 39);
            BT_Close.TabIndex = 17;
            BT_Close.Text = "< BACK";
            BT_Close.UseVisualStyleBackColor = true;
            BT_Close.Click += BT_Close_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(1256, 602);
            Controls.Add(BT_Close);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LB_Projects);
            Controls.Add(DGV_Projects);
            Controls.Add(BT_Create);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CB_Roles);
            Controls.Add(TB_Email);
            Controls.Add(TB_Password);
            Controls.Add(TB_Username);
            ForeColor = SystemColors.Control;
            Name = "AddUserForm";
            Text = "AddUserForm";
            Load += AddUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Projects).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Username;
        private TextBox TB_Password;
        private TextBox TB_Email;
        private ComboBox CB_Roles;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BT_Create;
        private DataGridView DGV_Projects;
        private ListBox LB_Projects;
        private BindingSource projectBindingSource;
        private Label label5;
        private Label label6;
        private Button BT_Close;
    }
}