namespace PPE3
{
    partial class PatientProfile
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
            name_label = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            antecedant_button = new Button();
            allergie_button = new Button();
            newOrdonnance_button = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(12, 20);
            name_label.Name = "name_label";
            name_label.Size = new Size(46, 20);
            name_label.TabIndex = 0;
            name_label.Text = "name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(599, 90);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 2;
            // 
            // antecedant_button
            // 
            antecedant_button.Location = new Point(219, 320);
            antecedant_button.Name = "antecedant_button";
            antecedant_button.Size = new Size(94, 29);
            antecedant_button.TabIndex = 3;
            antecedant_button.Text = "Ajouter";
            antecedant_button.UseVisualStyleBackColor = true;
            // 
            // allergie_button
            // 
            allergie_button.Location = new Point(707, 320);
            allergie_button.Name = "allergie_button";
            allergie_button.Size = new Size(94, 29);
            allergie_button.TabIndex = 4;
            allergie_button.Text = "Ajouter";
            allergie_button.UseVisualStyleBackColor = true;
            // 
            // newOrdonnance_button
            // 
            newOrdonnance_button.Location = new Point(414, 421);
            newOrdonnance_button.Name = "newOrdonnance_button";
            newOrdonnance_button.Size = new Size(194, 60);
            newOrdonnance_button.TabIndex = 5;
            newOrdonnance_button.Text = "Nouvelle ordonnance";
            newOrdonnance_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 46);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 6;
            label1.Text = "Antecedant";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(719, 46);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Allergie";
            // 
            // PatientProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 505);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newOrdonnance_button);
            Controls.Add(allergie_button);
            Controls.Add(antecedant_button);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(name_label);
            Name = "PatientProfile";
            Text = "PatientProfile";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button antecedant_button;
        private Button allergie_button;
        private Button newOrdonnance_button;
        private Label label1;
        private Label label2;
    }
}