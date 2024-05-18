namespace TD3_C__LesPays
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
            this.radioOceanie = new System.Windows.Forms.RadioButton();
            this.radioEurope = new System.Windows.Forms.RadioButton();
            this.radioAsie = new System.Windows.Forms.RadioButton();
            this.radioAntartique = new System.Windows.Forms.RadioButton();
            this.radioAmSud = new System.Windows.Forms.RadioButton();
            this.radioAmNord = new System.Windows.Forms.RadioButton();
            this.radioAfrique = new System.Windows.Forms.RadioButton();
            this.radioTous = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgDrapeau = new System.Windows.Forms.PictureBox();
            this.lblMonnaie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCapitale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.comboBoxLesPays = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrapeau)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOceanie);
            this.groupBox1.Controls.Add(this.radioEurope);
            this.groupBox1.Controls.Add(this.radioAsie);
            this.groupBox1.Controls.Add(this.radioAntartique);
            this.groupBox1.Controls.Add(this.radioAmSud);
            this.groupBox1.Controls.Add(this.radioAmNord);
            this.groupBox1.Controls.Add(this.radioAfrique);
            this.groupBox1.Controls.Add(this.radioTous);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix du continent";
            // 
            // radioOceanie
            // 
            this.radioOceanie.AutoSize = true;
            this.radioOceanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioOceanie.Location = new System.Drawing.Point(22, 187);
            this.radioOceanie.Name = "radioOceanie";
            this.radioOceanie.Size = new System.Drawing.Size(86, 24);
            this.radioOceanie.TabIndex = 13;
            this.radioOceanie.TabStop = true;
            this.radioOceanie.Text = "Océanie";
            this.radioOceanie.UseVisualStyleBackColor = true;
            this.radioOceanie.CheckedChanged += new System.EventHandler(this.radioOceanie_CheckedChanged);
            // 
            // radioEurope
            // 
            this.radioEurope.AutoSize = true;
            this.radioEurope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioEurope.Location = new System.Drawing.Point(22, 163);
            this.radioEurope.Name = "radioEurope";
            this.radioEurope.Size = new System.Drawing.Size(79, 24);
            this.radioEurope.TabIndex = 12;
            this.radioEurope.TabStop = true;
            this.radioEurope.Text = "Europe";
            this.radioEurope.UseVisualStyleBackColor = true;
            this.radioEurope.CheckedChanged += new System.EventHandler(this.radioEurope_CheckedChanged);
            // 
            // radioAsie
            // 
            this.radioAsie.AutoSize = true;
            this.radioAsie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioAsie.Location = new System.Drawing.Point(22, 140);
            this.radioAsie.Name = "radioAsie";
            this.radioAsie.Size = new System.Drawing.Size(58, 24);
            this.radioAsie.TabIndex = 11;
            this.radioAsie.TabStop = true;
            this.radioAsie.Text = "Asie";
            this.radioAsie.UseVisualStyleBackColor = true;
            this.radioAsie.CheckedChanged += new System.EventHandler(this.radioAsie_CheckedChanged);
            // 
            // radioAntartique
            // 
            this.radioAntartique.AutoSize = true;
            this.radioAntartique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioAntartique.Location = new System.Drawing.Point(22, 116);
            this.radioAntartique.Name = "radioAntartique";
            this.radioAntartique.Size = new System.Drawing.Size(101, 24);
            this.radioAntartique.TabIndex = 10;
            this.radioAntartique.TabStop = true;
            this.radioAntartique.Text = "Antartique";
            this.radioAntartique.UseVisualStyleBackColor = true;
            this.radioAntartique.CheckedChanged += new System.EventHandler(this.radioAntartique_CheckedChanged);
            // 
            // radioAmSud
            // 
            this.radioAmSud.AutoSize = true;
            this.radioAmSud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioAmSud.Location = new System.Drawing.Point(22, 93);
            this.radioAmSud.Name = "radioAmSud";
            this.radioAmSud.Size = new System.Drawing.Size(147, 24);
            this.radioAmSud.TabIndex = 9;
            this.radioAmSud.TabStop = true;
            this.radioAmSud.Text = "Amérique du sud";
            this.radioAmSud.UseVisualStyleBackColor = true;
            this.radioAmSud.CheckedChanged += new System.EventHandler(this.radioAmSud_CheckedChanged);
            // 
            // radioAmNord
            // 
            this.radioAmNord.AutoSize = true;
            this.radioAmNord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioAmNord.Location = new System.Drawing.Point(22, 70);
            this.radioAmNord.Name = "radioAmNord";
            this.radioAmNord.Size = new System.Drawing.Size(153, 24);
            this.radioAmNord.TabIndex = 8;
            this.radioAmNord.TabStop = true;
            this.radioAmNord.Tag = "AN";
            this.radioAmNord.Text = "Amérique du nord";
            this.radioAmNord.UseVisualStyleBackColor = true;
            this.radioAmNord.CheckedChanged += new System.EventHandler(this.radioAmNord_CheckedChanged);
            // 
            // radioAfrique
            // 
            this.radioAfrique.AutoSize = true;
            this.radioAfrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioAfrique.Location = new System.Drawing.Point(22, 46);
            this.radioAfrique.Name = "radioAfrique";
            this.radioAfrique.Size = new System.Drawing.Size(78, 24);
            this.radioAfrique.TabIndex = 7;
            this.radioAfrique.TabStop = true;
            this.radioAfrique.Tag = "AF";
            this.radioAfrique.Text = "Afrique";
            this.radioAfrique.UseVisualStyleBackColor = true;
            this.radioAfrique.CheckedChanged += new System.EventHandler(this.radioAfrique_CheckedChanged);
            // 
            // radioTous
            // 
            this.radioTous.AutoSize = true;
            this.radioTous.Location = new System.Drawing.Point(22, 23);
            this.radioTous.Name = "radioTous";
            this.radioTous.Size = new System.Drawing.Size(62, 24);
            this.radioTous.TabIndex = 6;
            this.radioTous.TabStop = true;
            this.radioTous.Text = "Tous";
            this.radioTous.UseVisualStyleBackColor = true;
            this.radioTous.CheckedChanged += new System.EventHandler(this.radioTous_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgDrapeau);
            this.groupBox2.Controls.Add(this.lblMonnaie);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCapitale);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTitre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renseignements du pays";
            // 
            // imgDrapeau
            // 
            this.imgDrapeau.Location = new System.Drawing.Point(15, 61);
            this.imgDrapeau.Name = "imgDrapeau";
            this.imgDrapeau.Size = new System.Drawing.Size(179, 117);
            this.imgDrapeau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDrapeau.TabIndex = 5;
            this.imgDrapeau.TabStop = false;
            // 
            // lblMonnaie
            // 
            this.lblMonnaie.AutoSize = true;
            this.lblMonnaie.Location = new System.Drawing.Point(280, 123);
            this.lblMonnaie.Name = "lblMonnaie";
            this.lblMonnaie.Size = new System.Drawing.Size(0, 20);
            this.lblMonnaie.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monnaie";
            // 
            // lblCapitale
            // 
            this.lblCapitale.AutoSize = true;
            this.lblCapitale.Location = new System.Drawing.Point(280, 91);
            this.lblCapitale.Name = "lblCapitale";
            this.lblCapitale.Size = new System.Drawing.Size(0, 20);
            this.lblCapitale.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Capitale";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(18, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(0, 22);
            this.lblTitre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(214, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des pays";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(508, 455);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(80, 34);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // comboBoxLesPays
            // 
            this.comboBoxLesPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxLesPays.FormattingEnabled = true;
            this.comboBoxLesPays.Location = new System.Drawing.Point(220, 47);
            this.comboBoxLesPays.Name = "comboBoxLesPays";
            this.comboBoxLesPays.Size = new System.Drawing.Size(368, 202);
            this.comboBoxLesPays.TabIndex = 6;
            this.comboBoxLesPays.SelectedIndexChanged += new System.EventHandler(this.comboBoxLesPays_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.comboBoxLesPays);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "les Pays";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrapeau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTous;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioOceanie;
        private System.Windows.Forms.RadioButton radioEurope;
        private System.Windows.Forms.RadioButton radioAsie;
        private System.Windows.Forms.RadioButton radioAntartique;
        private System.Windows.Forms.RadioButton radioAmSud;
        private System.Windows.Forms.RadioButton radioAmNord;
        private System.Windows.Forms.RadioButton radioAfrique;
        private System.Windows.Forms.PictureBox imgDrapeau;
        private System.Windows.Forms.Label lblMonnaie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCapitale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox comboBoxLesPays;
    }
}

