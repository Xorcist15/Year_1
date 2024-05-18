namespace TP_Serialization
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NomClassLbl = new System.Windows.Forms.Label();
            this.NvlClasseGrpBox = new System.Windows.Forms.GroupBox();
            this.BtnCreerClasse = new System.Windows.Forms.Button();
            this.NomClassTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsrtGrpBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EtudiantsComboBox = new System.Windows.Forms.ComboBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.PrenomTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NomTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.NvlClasseGrpBox.SuspendLayout();
            this.InsrtGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleClasseToolStripMenuItem,
            this.ouvrirClasseToolStripMenuItem,
            this.enregistrerClasseToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouvelleClasseToolStripMenuItem
            // 
            this.nouvelleClasseToolStripMenuItem.Name = "nouvelleClasseToolStripMenuItem";
            this.nouvelleClasseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nouvelleClasseToolStripMenuItem.Text = "Nouvelle classe";
            this.nouvelleClasseToolStripMenuItem.Click += new System.EventHandler(this.nouvelleClasseToolStripMenuItem_Click);
            // 
            // ouvrirClasseToolStripMenuItem
            // 
            this.ouvrirClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorateurToolStripMenuItem});
            this.ouvrirClasseToolStripMenuItem.Name = "ouvrirClasseToolStripMenuItem";
            this.ouvrirClasseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ouvrirClasseToolStripMenuItem.Text = "Ouvrir classe";
            this.ouvrirClasseToolStripMenuItem.Click += new System.EventHandler(this.ouvrirClasseToolStripMenuItem_Click);
            // 
            // explorateurToolStripMenuItem
            // 
            this.explorateurToolStripMenuItem.Name = "explorateurToolStripMenuItem";
            this.explorateurToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.explorateurToolStripMenuItem.Text = "Ouvrir de";
            this.explorateurToolStripMenuItem.Click += new System.EventHandler(this.explorateurToolStripMenuItem_Click);
            // 
            // enregistrerClasseToolStripMenuItem
            // 
            this.enregistrerClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerSousToolStripMenuItem});
            this.enregistrerClasseToolStripMenuItem.Name = "enregistrerClasseToolStripMenuItem";
            this.enregistrerClasseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.enregistrerClasseToolStripMenuItem.Text = "Enregistrer classe";
            this.enregistrerClasseToolStripMenuItem.Click += new System.EventHandler(this.enregistrerClasseToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(286, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe :";
            // 
            // NomClassLbl
            // 
            this.NomClassLbl.AutoSize = true;
            this.NomClassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NomClassLbl.ForeColor = System.Drawing.Color.Black;
            this.NomClassLbl.Location = new System.Drawing.Point(400, 52);
            this.NomClassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomClassLbl.Name = "NomClassLbl";
            this.NomClassLbl.Size = new System.Drawing.Size(282, 26);
            this.NomClassLbl.TabIndex = 2;
            this.NomClassLbl.Text = "Aucune classe sélectionnée";
            // 
            // NvlClasseGrpBox
            // 
            this.NvlClasseGrpBox.Controls.Add(this.BtnCreerClasse);
            this.NvlClasseGrpBox.Controls.Add(this.NomClassTxtBox);
            this.NvlClasseGrpBox.Controls.Add(this.label3);
            this.NvlClasseGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NvlClasseGrpBox.Location = new System.Drawing.Point(24, 97);
            this.NvlClasseGrpBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NvlClasseGrpBox.Name = "NvlClasseGrpBox";
            this.NvlClasseGrpBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NvlClasseGrpBox.Size = new System.Drawing.Size(904, 105);
            this.NvlClasseGrpBox.TabIndex = 3;
            this.NvlClasseGrpBox.TabStop = false;
            this.NvlClasseGrpBox.Text = "Nouvelle classe";
            // 
            // BtnCreerClasse
            // 
            this.BtnCreerClasse.Location = new System.Drawing.Point(678, 38);
            this.BtnCreerClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCreerClasse.Name = "BtnCreerClasse";
            this.BtnCreerClasse.Size = new System.Drawing.Size(198, 43);
            this.BtnCreerClasse.TabIndex = 2;
            this.BtnCreerClasse.Text = "Créer Classe";
            this.BtnCreerClasse.UseVisualStyleBackColor = true;
            this.BtnCreerClasse.Click += new System.EventHandler(this.BtnCreerClasse_Click);
            // 
            // NomClassTxtBox
            // 
            this.NomClassTxtBox.Location = new System.Drawing.Point(208, 42);
            this.NomClassTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomClassTxtBox.Name = "NomClassTxtBox";
            this.NomClassTxtBox.Size = new System.Drawing.Size(458, 32);
            this.NomClassTxtBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom de la classe :";
            // 
            // InsrtGrpBox
            // 
            this.InsrtGrpBox.Controls.Add(this.label6);
            this.InsrtGrpBox.Controls.Add(this.EtudiantsComboBox);
            this.InsrtGrpBox.Controls.Add(this.InsertBtn);
            this.InsrtGrpBox.Controls.Add(this.PrenomTxtBox);
            this.InsrtGrpBox.Controls.Add(this.label5);
            this.InsrtGrpBox.Controls.Add(this.NomTxtBox);
            this.InsrtGrpBox.Controls.Add(this.label4);
            this.InsrtGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InsrtGrpBox.Location = new System.Drawing.Point(24, 211);
            this.InsrtGrpBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsrtGrpBox.Name = "InsrtGrpBox";
            this.InsrtGrpBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsrtGrpBox.Size = new System.Drawing.Size(904, 328);
            this.InsrtGrpBox.TabIndex = 4;
            this.InsrtGrpBox.TabStop = false;
            this.InsrtGrpBox.Text = "Insertion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Liste des étudiants";
            // 
            // EtudiantsComboBox
            // 
            this.EtudiantsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.EtudiantsComboBox.FormattingEnabled = true;
            this.EtudiantsComboBox.Location = new System.Drawing.Point(456, 58);
            this.EtudiantsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EtudiantsComboBox.Name = "EtudiantsComboBox";
            this.EtudiantsComboBox.Size = new System.Drawing.Size(418, 246);
            this.EtudiantsComboBox.TabIndex = 5;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(254, 235);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(146, 60);
            this.InsertBtn.TabIndex = 4;
            this.InsertBtn.Text = "Insérer";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // PrenomTxtBox
            // 
            this.PrenomTxtBox.Location = new System.Drawing.Point(154, 112);
            this.PrenomTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrenomTxtBox.Name = "PrenomTxtBox";
            this.PrenomTxtBox.Size = new System.Drawing.Size(242, 35);
            this.PrenomTxtBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prénom";
            // 
            // NomTxtBox
            // 
            this.NomTxtBox.Location = new System.Drawing.Point(154, 54);
            this.NomTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomTxtBox.Name = "NomTxtBox";
            this.NomTxtBox.Size = new System.Drawing.Size(242, 35);
            this.NomTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 555);
            this.Controls.Add(this.InsrtGrpBox);
            this.Controls.Add(this.NvlClasseGrpBox);
            this.Controls.Add(this.NomClassLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tests sérialisation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NvlClasseGrpBox.ResumeLayout(false);
            this.NvlClasseGrpBox.PerformLayout();
            this.InsrtGrpBox.ResumeLayout(false);
            this.InsrtGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerClasseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NomClassLbl;
        private System.Windows.Forms.GroupBox NvlClasseGrpBox;
        private System.Windows.Forms.Button BtnCreerClasse;
        private System.Windows.Forms.TextBox NomClassTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox InsrtGrpBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EtudiantsComboBox;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox PrenomTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem explorateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
    }
}

