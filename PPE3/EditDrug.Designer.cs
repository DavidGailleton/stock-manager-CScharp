﻿namespace PPE3
{
    partial class EditDrug
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(354, 255);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 2;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Modifier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 136);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 80);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Nom";
            // 
            // EditDrug
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditDrug";
            Text = "EditDrug";
            Load += EditDrug_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}