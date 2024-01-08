namespace PPE3
{
    partial class DrugInStock
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
            deleteWithQuantityButton = new Button();
            numericQuantityDelete = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantityDelete).BeginInit();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new Point(262, 365);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(149, 44);
            editButton.TabIndex = 0;
            editButton.Text = "Modifier";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Chercher";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(234, 122);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(469, 220);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(384, 87);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(501, 365);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(162, 62);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Supprimer";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // deleteWithQuantityButton
            // 
            deleteWithQuantityButton.Location = new Point(501, 449);
            deleteWithQuantityButton.Name = "deleteWithQuantityButton";
            deleteWithQuantityButton.Size = new Size(162, 62);
            deleteWithQuantityButton.TabIndex = 7;
            deleteWithQuantityButton.Text = "Supprimer la quantité suivante :";
            deleteWithQuantityButton.UseVisualStyleBackColor = true;
            deleteWithQuantityButton.Click += DeleteWithQuantityButton_Click;
            // 
            // numericQuantityDelete
            // 
            numericQuantityDelete.Location = new Point(681, 469);
            numericQuantityDelete.Name = "numericQuantityDelete";
            numericQuantityDelete.Size = new Size(48, 27);
            numericQuantityDelete.TabIndex = 8;
            numericQuantityDelete.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DrugInStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(numericQuantityDelete);
            Controls.Add(deleteWithQuantityButton);
            Controls.Add(deleteButton);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(editButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DrugInStock";
            Text = "Search";
            Load += DrugInStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantityDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editButton;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button deleteButton;
        private Button deleteWithQuantityButton;
        private NumericUpDown numericQuantityDelete;
    }
}