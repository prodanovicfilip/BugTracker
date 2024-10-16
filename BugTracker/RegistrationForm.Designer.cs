namespace BugTracker
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BT_Register = new Button();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(211, 60);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(179, 27);
            TB_Username.TabIndex = 0;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(211, 93);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(179, 27);
            TB_Password.TabIndex = 1;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(211, 126);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(179, 27);
            TB_Email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 129);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // BT_Register
            // 
            BT_Register.Location = new Point(296, 172);
            BT_Register.Name = "BT_Register";
            BT_Register.Size = new Size(94, 29);
            BT_Register.TabIndex = 6;
            BT_Register.Text = "Register";
            BT_Register.UseVisualStyleBackColor = true;
            BT_Register.Click += BT_Register_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 262);
            Controls.Add(BT_Register);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_Email);
            Controls.Add(TB_Password);
            Controls.Add(TB_Username);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Username;
        private TextBox TB_Password;
        private TextBox TB_Email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BT_Register;
    }
}