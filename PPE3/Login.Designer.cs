﻿namespace PPE3
{
    partial class Login
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
            loginButton = new Button();
            passwordTextBox = new MaskedTextBox();
            usernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(315, 295);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(144, 41);
            loginButton.TabIndex = 0;
            loginButton.Text = "Confirmer";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(279, 241);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(225, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(279, 168);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(225, 27);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 56);
            label1.Name = "label1";
            label1.Size = new Size(130, 49);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(342, 143);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(342, 216);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private MaskedTextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}