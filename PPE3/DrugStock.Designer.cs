namespace PPE3
{
    partial class DrugStock
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            new_drug = new Button();
            stockAdd_button = new Button();
            numericUpDown1 = new NumericUpDown();
            edit_button = new Button();
            numericUpDown2 = new NumericUpDown();
            removeStock_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(428, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(458, 505);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Chercher";
            // 
            // new_drug
            // 
            new_drug.Location = new Point(111, 139);
            new_drug.Name = "new_drug";
            new_drug.Size = new Size(178, 37);
            new_drug.TabIndex = 6;
            new_drug.Text = "Nouveau medicament";
            new_drug.UseVisualStyleBackColor = true;
            new_drug.Click += button1_Click;
            // 
            // stockAdd_button
            // 
            stockAdd_button.Location = new Point(111, 213);
            stockAdd_button.Name = "stockAdd_button";
            stockAdd_button.Size = new Size(178, 37);
            stockAdd_button.TabIndex = 7;
            stockAdd_button.Text = "Ajouter du stock :";
            stockAdd_button.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(295, 219);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // edit_button
            // 
            edit_button.Location = new Point(111, 290);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(178, 48);
            edit_button.TabIndex = 9;
            edit_button.Text = "Modifier un médicament";
            edit_button.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(295, 379);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(73, 27);
            numericUpDown2.TabIndex = 11;
            // 
            // removeStock_button
            // 
            removeStock_button.Location = new Point(111, 373);
            removeStock_button.Name = "removeStock_button";
            removeStock_button.Size = new Size(178, 37);
            removeStock_button.TabIndex = 10;
            removeStock_button.Text = "Enlever du stock :";
            removeStock_button.UseVisualStyleBackColor = true;
            // 
            // DrugStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 505);
            Controls.Add(numericUpDown2);
            Controls.Add(removeStock_button);
            Controls.Add(edit_button);
            Controls.Add(numericUpDown1);
            Controls.Add(stockAdd_button);
            Controls.Add(new_drug);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DrugStock";
            Text = "DrugStock";
            Load += DrugStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button new_drug;
        private Button stockAdd_button;
        private NumericUpDown numericUpDown1;
        private Button edit_button;
        private NumericUpDown numericUpDown2;
        private Button removeStock_button;
    }
}