namespace PPE3
{
    partial class AddUser
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
            button1 = new Button();
            label1 = new Label();
            adminCheckBox = new CheckBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(358, 309);
            button1.Name = "button1";
            button1.Size = new Size(125, 53);
            button1.TabIndex = 0;
            button1.Text = "Créer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 119);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Location = new Point(615, 163);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(75, 24);
            adminCheckBox.TabIndex = 2;
            adminCheckBox.Text = "Admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(80, 163);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(181, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(333, 163);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(180, 27);
            passwordTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 119);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(adminCheckBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "addUser";
            Text = "addUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox adminCheckBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label2;
    }
}