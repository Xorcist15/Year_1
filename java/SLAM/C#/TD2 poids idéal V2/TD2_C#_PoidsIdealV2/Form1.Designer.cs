namespace TD2_C__PoidsIdealV2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioHomme = new System.Windows.Forms.RadioButton();
            this.radioFemme = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstResultats = new System.Windows.Forms.ListBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.checkEnListe = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEnListe);
            this.groupBox1.Controls.Add(this.btnEffacer);
            this.groupBox1.Controls.Add(this.btnCalculer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTaille);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioFemme);
            this.groupBox1.Controls.Add(this.radioHomme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renseignements de la personne";
            // 
            // radioHomme
            // 
            this.radioHomme.AutoSize = true;
            this.radioHomme.Location = new System.Drawing.Point(12, 24);
            this.radioHomme.Name = "radioHomme";
            this.radioHomme.Size = new System.Drawing.Size(61, 17);
            this.radioHomme.TabIndex = 0;
            this.radioHomme.TabStop = true;
            this.radioHomme.Text = "Homme";
            this.radioHomme.UseVisualStyleBackColor = true;
            // 
            // radioFemme
            // 
            this.radioFemme.AutoSize = true;
            this.radioFemme.Location = new System.Drawing.Point(90, 24);
            this.radioFemme.Name = "radioFemme";
            this.radioFemme.Size = new System.Drawing.Size(59, 17);
            this.radioFemme.TabIndex = 1;
            this.radioFemme.TabStop = true;
            this.radioFemme.Text = "Femme";
            this.radioFemme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taille";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(57, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(57, 88);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(37, 20);
            this.txtTaille.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "cm";
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(238, 87);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 7;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(238, 113);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 8;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVider);
            this.groupBox3.Controls.Add(this.lstResultats);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblPoids);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox3.Location = new System.Drawing.Point(12, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Résultats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Poids idéal";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPoids.Location = new System.Drawing.Point(38, 67);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(23, 13);
            this.lblPoids.TabIndex = 1;
            this.lblPoids.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Liste des personnes";
            // 
            // lstResultats
            // 
            this.lstResultats.FormattingEnabled = true;
            this.lstResultats.Location = new System.Drawing.Point(121, 33);
            this.lstResultats.Name = "lstResultats";
            this.lstResultats.Size = new System.Drawing.Size(192, 82);
            this.lstResultats.TabIndex = 3;
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(238, 121);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 23);
            this.btnVider.TabIndex = 4;
            this.btnVider.Text = "Vider la liste";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnQuitter.Location = new System.Drawing.Point(250, 319);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // checkEnListe
            // 
            this.checkEnListe.AutoSize = true;
            this.checkEnListe.Location = new System.Drawing.Point(144, 90);
            this.checkEnListe.Name = "checkEnListe";
            this.checkEnListe.Size = new System.Drawing.Size(92, 17);
            this.checkEnListe.TabIndex = 9;
            this.checkEnListe.Text = "Mettre en liste";
            this.checkEnListe.UseVisualStyleBackColor = true;
            this.checkEnListe.CheckedChanged += new System.EventHandler(this.checkEnListe_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 349);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Le poids idéal v2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFemme;
        private System.Windows.Forms.RadioButton radioHomme;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkEnListe;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.ListBox lstResultats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuitter;
    }
}

