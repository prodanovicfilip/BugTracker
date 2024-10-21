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
            TB_Username = new TextBox();
            TB_Password = new TextBox();
            TB_Email = new TextBox();
            CB_Roles = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BT_Create = new Button();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(111, 24);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(150, 31);
            TB_Username.TabIndex = 0;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(111, 74);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(150, 31);
            TB_Password.TabIndex = 1;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(111, 120);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(150, 31);
            TB_Email.TabIndex = 2;
            // 
            // CB_Roles
            // 
            CB_Roles.FormattingEnabled = true;
            CB_Roles.Location = new Point(111, 178);
            CB_Roles.Name = "CB_Roles";
            CB_Roles.Size = new Size(182, 33);
            CB_Roles.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 123);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 181);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // BT_Create
            // 
            BT_Create.Location = new Point(111, 245);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(112, 34);
            BT_Create.TabIndex = 9;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = true;
            BT_Create.Click += BT_Create_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 386);
            Controls.Add(BT_Create);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CB_Roles);
            Controls.Add(TB_Email);
            Controls.Add(TB_Password);
            Controls.Add(TB_Username);
            Name = "AddUserForm";
            Text = "AddUserForm";
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
    }
}