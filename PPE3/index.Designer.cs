namespace PPE3
{
    partial class index
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
            label1 = new Label();
            newDrugButton = new Button();
            editDrugButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 47);
            label1.Name = "label1";
            label1.Size = new Size(180, 40);
            label1.TabIndex = 0;
            label1.Text = "Quoi faire ?";
            // 
            // newDrugButton
            // 
            newDrugButton.Location = new Point(206, 129);
            newDrugButton.Name = "newDrugButton";
            newDrugButton.Size = new Size(189, 48);
            newDrugButton.TabIndex = 1;
            newDrugButton.Text = "Ajouter un médicament";
            newDrugButton.UseVisualStyleBackColor = true;
            newDrugButton.Click += newDrugButton_Click;
            // 
            // editDrugButton
            // 
            editDrugButton.Location = new Point(206, 206);
            editDrugButton.Name = "editDrugButton";
            editDrugButton.Size = new Size(189, 48);
            editDrugButton.TabIndex = 2;
            editDrugButton.Text = "Modfier/Supprimer un médicament";
            editDrugButton.UseVisualStyleBackColor = true;
            editDrugButton.Click += editDrugButton_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 322);
            Controls.Add(editDrugButton);
            Controls.Add(newDrugButton);
            Controls.Add(label1);
            Name = "index";
            Text = "index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button newDrugButton;
        private Button editDrugButton;
    }
}