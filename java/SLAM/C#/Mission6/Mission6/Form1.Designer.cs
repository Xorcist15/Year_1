namespace Mission6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxJours = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTraversee = new System.Windows.Forms.ComboBox();
            this.comboBoxlesTraversees = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxJours);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir parmi les jours disponibles";
            // 
            // comboBoxJours
            // 
            this.comboBoxJours.FormattingEnabled = true;
            this.comboBoxJours.Location = new System.Drawing.Point(6, 19);
            this.comboBoxJours.Name = "comboBoxJours";
            this.comboBoxJours.Size = new System.Drawing.Size(218, 21);
            this.comboBoxJours.TabIndex = 0;
            this.comboBoxJours.SelectedIndexChanged += new System.EventHandler(this.comboBoxJours_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTraversee);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 233);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisir la traversée";
            // 
            // comboBoxTraversee
            // 
            this.comboBoxTraversee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxTraversee.FormattingEnabled = true;
            this.comboBoxTraversee.Location = new System.Drawing.Point(6, 19);
            this.comboBoxTraversee.Name = "comboBoxTraversee";
            this.comboBoxTraversee.Size = new System.Drawing.Size(218, 203);
            this.comboBoxTraversee.TabIndex = 0;
            this.comboBoxTraversee.SelectedIndexChanged += new System.EventHandler(this.comboBoxTraversee_SelectedIndexChanged);
            // 
            // comboBoxlesTraversees
            // 
            this.comboBoxlesTraversees.FormattingEnabled = true;
            this.comboBoxlesTraversees.Location = new System.Drawing.Point(6, 29);
            this.comboBoxlesTraversees.Name = "comboBoxlesTraversees";
            this.comboBoxlesTraversees.Size = new System.Drawing.Size(213, 21);
            this.comboBoxlesTraversees.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AP2_Mission_6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxlesTraversees;
        private System.Windows.Forms.ComboBox comboBoxJours;
        private System.Windows.Forms.ComboBox comboBoxTraversee;
    }
}

