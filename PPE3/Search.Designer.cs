namespace PPE3
{
    partial class Search
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
            editButton = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new Point(229, 274);
            editButton.Name = "editButton";
            editButton.Size = new Size(130, 33);
            editButton.TabIndex = 0;
            editButton.Text = "Modifier";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 68);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Chercher";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(276, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(438, 274);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(130, 33);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Supprimer";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(editButton);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editButton;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button deleteButton;
    }
}