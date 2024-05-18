namespace TP_Fichiers_Sequentiels
{
    partial class GestionEleves
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxAjoutEleve = new System.Windows.Forms.GroupBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.ComboBoxEtudiants = new System.Windows.Forms.ComboBox();
            this.GroupBoxAjoutEleve.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxAjoutEleve
            // 
            this.GroupBoxAjoutEleve.Controls.Add(this.BtnAnnuler);
            this.GroupBoxAjoutEleve.Controls.Add(this.BtnValider);
            this.GroupBoxAjoutEleve.Controls.Add(this.TextBoxPrenom);
            this.GroupBoxAjoutEleve.Controls.Add(this.TextBoxNom);
            this.GroupBoxAjoutEleve.Controls.Add(this.TextBoxNum);
            this.GroupBoxAjoutEleve.Controls.Add(this.label3);
            this.GroupBoxAjoutEleve.Controls.Add(this.label2);
            this.GroupBoxAjoutEleve.Controls.Add(this.label1);
            this.GroupBoxAjoutEleve.Location = new System.Drawing.Point(12, 84);
            this.GroupBoxAjoutEleve.Name = "GroupBoxAjoutEleve";
            this.GroupBoxAjoutEleve.Size = new System.Drawing.Size(333, 152);
            this.GroupBoxAjoutEleve.TabIndex = 1;
            this.GroupBoxAjoutEleve.TabStop = false;
            this.GroupBoxAjoutEleve.Text = "Ajout d\'un élève";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(209, 82);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(65, 30);
            this.BtnAnnuler.TabIndex = 7;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(209, 46);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(65, 30);
            this.BtnValider.TabIndex = 6;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Location = new System.Drawing.Point(80, 112);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(85, 20);
            this.TextBoxPrenom.TabIndex = 5;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Location = new System.Drawing.Point(80, 68);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(85, 20);
            this.TextBoxNom.TabIndex = 4;
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.Location = new System.Drawing.Point(80, 28);
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.Size = new System.Drawing.Size(85, 20);
            this.TextBoxNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(198, 26);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(111, 21);
            this.BtnAjouter.TabIndex = 2;
            this.BtnAjouter.Text = "Ajouter un élève";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // ComboBoxEtudiants
            // 
            this.ComboBoxEtudiants.FormattingEnabled = true;
            this.ComboBoxEtudiants.Location = new System.Drawing.Point(31, 26);
            this.ComboBoxEtudiants.Name = "ComboBoxEtudiants";
            this.ComboBoxEtudiants.Size = new System.Drawing.Size(123, 21);
            this.ComboBoxEtudiants.TabIndex = 3;
            this.ComboBoxEtudiants.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEtudiants_SelectedIndexChanged);
            // 
            // GestionEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 249);
            this.Controls.Add(this.ComboBoxEtudiants);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.GroupBoxAjoutEleve);
            this.Name = "GestionEleves";
            this.Text = "Gestion des élèves";
            this.GroupBoxAjoutEleve.ResumeLayout(false);
            this.GroupBoxAjoutEleve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBoxAjoutEleve;
        private System.Windows.Forms.TextBox TextBoxPrenom;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.TextBox TextBoxNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.ComboBox ComboBoxEtudiants;
    }
}

