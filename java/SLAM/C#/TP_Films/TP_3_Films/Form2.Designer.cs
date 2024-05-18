namespace TP_3_Films
{
    partial class Form2
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
            this.cboSupport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxTitre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxNum = new System.Windows.Forms.TextBox();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSupport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtBoxGenre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxTitre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxNum);
            this.groupBox1.Controls.Add(this.BtnValider);
            this.groupBox1.Controls.Add(this.BtnAnnuler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie des informations d\'un nouveau film";
            // 
            // cboSupport
            // 
            this.cboSupport.FormattingEnabled = true;
            this.cboSupport.Location = new System.Drawing.Point(86, 103);
            this.cboSupport.Name = "cboSupport";
            this.cboSupport.Size = new System.Drawing.Size(150, 21);
            this.cboSupport.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Support";
            // 
            // TxtBoxGenre
            // 
            this.TxtBoxGenre.Location = new System.Drawing.Point(86, 77);
            this.TxtBoxGenre.Name = "TxtBoxGenre";
            this.TxtBoxGenre.Size = new System.Drawing.Size(150, 20);
            this.TxtBoxGenre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre";
            // 
            // TxtBoxTitre
            // 
            this.TxtBoxTitre.Location = new System.Drawing.Point(86, 51);
            this.TxtBoxTitre.Name = "TxtBoxTitre";
            this.TxtBoxTitre.Size = new System.Drawing.Size(150, 20);
            this.TxtBoxTitre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titre";
            // 
            // TxtBoxNum
            // 
            this.TxtBoxNum.Location = new System.Drawing.Point(86, 25);
            this.TxtBoxNum.Name = "TxtBoxNum";
            this.TxtBoxNum.Size = new System.Drawing.Size(49, 20);
            this.TxtBoxNum.TabIndex = 6;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(245, 101);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(68, 24);
            this.BtnValider.TabIndex = 5;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(245, 75);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(68, 24);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 163);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxNum;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.ComboBox cboSupport;
    }
}