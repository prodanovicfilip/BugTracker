namespace BugTracker
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            BT_Login = new Button();
            BT_Signup = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(146, 48);
            TB_Username.Margin = new Padding(4, 4, 4, 4);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(208, 31);
            TB_Username.TabIndex = 0;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(146, 95);
            TB_Password.Margin = new Padding(4, 4, 4, 4);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(208, 31);
            TB_Password.TabIndex = 1;
            TB_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // BT_Login
            // 
            BT_Login.Location = new Point(112, 158);
            BT_Login.Margin = new Padding(4, 4, 4, 4);
            BT_Login.Name = "BT_Login";
            BT_Login.Size = new Size(118, 36);
            BT_Login.TabIndex = 4;
            BT_Login.Text = "Login";
            BT_Login.UseVisualStyleBackColor = true;
            BT_Login.Click += BT_Login_Click;
            // 
            // BT_Signup
            // 
            BT_Signup.Location = new Point(237, 158);
            BT_Signup.Margin = new Padding(4, 4, 4, 4);
            BT_Signup.Name = "BT_Signup";
            BT_Signup.Size = new Size(118, 36);
            BT_Signup.TabIndex = 5;
            BT_Signup.Text = "Sign Up";
            BT_Signup.UseVisualStyleBackColor = true;
            BT_Signup.Click += BT_Signup_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TB_Username);
            panel1.Controls.Add(BT_Signup);
            panel1.Controls.Add(TB_Password);
            panel1.Controls.Add(BT_Login);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(54, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 229);
            panel1.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istock_1061323160_scaled_1200x800;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(704, 419);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TB_Username;
        private TextBox TB_Password;
        private Label label1;
        private Label label2;
        private Button BT_Login;
        private Button BT_Signup;
        private Panel panel1;
    }
}