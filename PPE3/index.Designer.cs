namespace PPE3
{
    partial class Index
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
            menuStrip1 = new MenuStrip();
            patientToolStripMenuItem = new ToolStripMenuItem();
            listePatientToolStripMenuItem = new ToolStripMenuItem();
            addPatientToolStripMenuItem = new ToolStripMenuItem();
            medicamentToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            ordonnanceToolStripMenuItem = new ToolStripMenuItem();
            créerToolStripMenuItem = new ToolStripMenuItem();
            historiqueToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(458, 126);
            label1.Name = "label1";
            label1.Size = new Size(226, 51);
            label1.TabIndex = 0;
            label1.Text = "Quoi faire ?";
            // 
            // newDrugButton
            // 
            newDrugButton.Location = new Point(458, 199);
            newDrugButton.Margin = new Padding(3, 4, 3, 4);
            newDrugButton.Name = "newDrugButton";
            newDrugButton.Size = new Size(216, 64);
            newDrugButton.TabIndex = 1;
            newDrugButton.Text = "Ajouter un médicament";
            newDrugButton.UseVisualStyleBackColor = true;
            newDrugButton.Click += NewDrugButton_Click;
            // 
            // editDrugButton
            // 
            editDrugButton.Location = new Point(458, 310);
            editDrugButton.Margin = new Padding(3, 4, 3, 4);
            editDrugButton.Name = "editDrugButton";
            editDrugButton.Size = new Size(216, 64);
            editDrugButton.TabIndex = 2;
            editDrugButton.Text = "Modfier/Supprimer un médicament";
            editDrugButton.UseVisualStyleBackColor = true;
            editDrugButton.Click += EditDrugButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { patientToolStripMenuItem, medicamentToolStripMenuItem, ordonnanceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1120, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listePatientToolStripMenuItem, addPatientToolStripMenuItem });
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(68, 24);
            patientToolStripMenuItem.Text = "Patient";
            // 
            // listePatientToolStripMenuItem
            // 
            listePatientToolStripMenuItem.Name = "listePatientToolStripMenuItem";
            listePatientToolStripMenuItem.Size = new Size(224, 26);
            listePatientToolStripMenuItem.Text = "Liste patient";
            listePatientToolStripMenuItem.Click += listePatientToolStripMenuItem_Click;
            // 
            // addPatientToolStripMenuItem
            // 
            addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            addPatientToolStripMenuItem.Size = new Size(224, 26);
            addPatientToolStripMenuItem.Text = "Ajouter";
            addPatientToolStripMenuItem.Click += addPatientToolStripMenuItem_Click;
            // 
            // medicamentToolStripMenuItem
            // 
            medicamentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem });
            medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            medicamentToolStripMenuItem.Size = new Size(106, 24);
            medicamentToolStripMenuItem.Text = "Medicament";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(224, 26);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // ordonnanceToolStripMenuItem
            // 
            ordonnanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { créerToolStripMenuItem, historiqueToolStripMenuItem });
            ordonnanceToolStripMenuItem.Name = "ordonnanceToolStripMenuItem";
            ordonnanceToolStripMenuItem.Size = new Size(104, 24);
            ordonnanceToolStripMenuItem.Text = "Ordonnance";
            // 
            // créerToolStripMenuItem
            // 
            créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            créerToolStripMenuItem.Size = new Size(224, 26);
            créerToolStripMenuItem.Text = "Créer";
            // 
            // historiqueToolStripMenuItem
            // 
            historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            historiqueToolStripMenuItem.Size = new Size(224, 26);
            historiqueToolStripMenuItem.Text = "Historique";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 533);
            Controls.Add(menuStrip1);
            Controls.Add(editDrugButton);
            Controls.Add(newDrugButton);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Index";
            Text = "index";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button newDrugButton;
        private Button editDrugButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem listePatientToolStripMenuItem;
        private ToolStripMenuItem addPatientToolStripMenuItem;
        private ToolStripMenuItem medicamentToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem ordonnanceToolStripMenuItem;
        private ToolStripMenuItem créerToolStripMenuItem;
        private ToolStripMenuItem historiqueToolStripMenuItem;
    }
}