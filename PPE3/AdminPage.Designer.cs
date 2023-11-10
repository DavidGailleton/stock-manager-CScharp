namespace PPE3
{
    partial class AdminPage
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
            addButton = new Button();
            deleteButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(446, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(458, 490);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellContentClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(139, 189);
            addButton.Name = "addButton";
            addButton.Size = new Size(146, 60);
            addButton.TabIndex = 1;
            addButton.Text = "Ajouter un utilisateur";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(139, 304);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(146, 60);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Supprimer un utilisateur";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Rechercher :";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 490);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Name = "AdminPage";
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button deleteButton;
        private TextBox textBox1;
        private Label label1;
    }
}