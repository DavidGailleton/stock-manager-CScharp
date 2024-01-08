namespace PPE3
{
    partial class NewOrdonnance
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
            patient_comboBox = new ComboBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            medicament_comboBox = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // patient_comboBox
            // 
            patient_comboBox.FormattingEnabled = true;
            patient_comboBox.Location = new Point(70, 69);
            patient_comboBox.Name = "patient_comboBox";
            patient_comboBox.Size = new Size(256, 28);
            patient_comboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(70, 228);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(337, 146);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(564, 228);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(363, 146);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 181);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Posologie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 181);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 5;
            label3.Text = "Instruction supplementaire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 35);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Medicament";
            // 
            // medicament_comboBox
            // 
            medicament_comboBox.FormattingEnabled = true;
            medicament_comboBox.Location = new Point(398, 67);
            medicament_comboBox.Name = "medicament_comboBox";
            medicament_comboBox.Size = new Size(256, 28);
            medicament_comboBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(401, 411);
            button1.Name = "button1";
            button1.Size = new Size(171, 53);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(814, 35);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Durée";
            label5.Click += label5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(759, 67);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // NewOrdonnance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 499);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(medicament_comboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(patient_comboBox);
            Name = "NewOrdonnance";
            Text = "NewOrdonnance";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox patient_comboBox;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox medicament_comboBox;
        private Button button1;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}