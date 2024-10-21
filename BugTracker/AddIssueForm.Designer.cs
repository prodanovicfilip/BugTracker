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
            SuspendLayout();
            // 
            // TB_Summary
            // 
            TB_Summary.Location = new Point(163, 38);
            TB_Summary.Name = "TB_Summary";
            TB_Summary.Size = new Size(150, 31);
            TB_Summary.TabIndex = 0;
            // 
            // RTB_Desc
            // 
            RTB_Desc.Location = new Point(163, 84);
            RTB_Desc.Name = "RTB_Desc";
            RTB_Desc.Size = new Size(524, 243);
            RTB_Desc.TabIndex = 1;
            RTB_Desc.Text = "";
            // 
            // CB_Priority
            // 
            CB_Priority.FormattingEnabled = true;
            CB_Priority.Location = new Point(237, 340);
            CB_Priority.Name = "CB_Priority";
            CB_Priority.Size = new Size(182, 33);
            CB_Priority.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 41);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 4;
            label1.Text = "Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 87);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 343);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 6;
            label3.Text = "Priority";
            // 
            // BT_Create
            // 
            BT_Create.Location = new Point(575, 338);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(112, 34);
            BT_Create.TabIndex = 7;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = true;
            BT_Create.Click += BT_Create_Click;
            // 
            // AddIssueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(BT_Create);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CB_Priority);
            Controls.Add(RTB_Desc);
            Controls.Add(TB_Summary);
            Name = "AddIssueForm";
            Text = "AddIssueForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Summary;
        private RichTextBox RTB_Desc;
        private ComboBox CB_Priority;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BT_Create;
    }
}