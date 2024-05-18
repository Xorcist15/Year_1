namespace TD1_C__PoidsIdeal
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
            this.taille_label = new System.Windows.Forms.Label();
            this.sexe_label = new System.Windows.Forms.Label();
            this.poid_label = new System.Windows.Forms.Label();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.txtSexe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // taille_label
            // 
            this.taille_label.AutoSize = true;
            this.taille_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taille_label.Location = new System.Drawing.Point(12, 14);
            this.taille_label.Name = "taille_label";
            this.taille_label.Size = new System.Drawing.Size(102, 20);
            this.taille_label.TabIndex = 0;
            this.taille_label.Text = "Taille (en cm)";
            this.taille_label.Click += new System.EventHandler(this.taille_label_Click);
            // 
            // sexe_label
            // 
            this.sexe_label.AutoSize = true;
            this.sexe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sexe_label.Location = new System.Drawing.Point(12, 45);
            this.sexe_label.Name = "sexe_label";
            this.sexe_label.Size = new System.Drawing.Size(81, 20);
            this.sexe_label.TabIndex = 1;
            this.sexe_label.Text = "Sexe (f/m)";
            // 
            // poid_label
            // 
            this.poid_label.AutoSize = true;
            this.poid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.poid_label.Location = new System.Drawing.Point(12, 77);
            this.poid_label.Name = "poid_label";
            this.poid_label.Size = new System.Drawing.Size(116, 20);
            this.poid_label.TabIndex = 2;
            this.poid_label.Text = "Poids idéal (kg)";
            // 
            // btnCalculer
            // 
            this.btnCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculer.Location = new System.Drawing.Point(263, 10);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 28);
            this.btnCalculer.TabIndex = 3;
            this.btnCalculer.Text = "&Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEffacer.Location = new System.Drawing.Point(263, 41);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 28);
            this.btnEffacer.TabIndex = 4;
            this.btnEffacer.Text = "&Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuitter.Location = new System.Drawing.Point(263, 73);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 28);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPoids.ForeColor = System.Drawing.Color.Black;
            this.lblPoids.Location = new System.Drawing.Point(163, 77);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(0, 20);
            this.lblPoids.TabIndex = 7;
            this.lblPoids.Click += new System.EventHandler(this.lblPoids_Click);
            // 
            // txtTaille
            // 
            this.txtTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTaille.ForeColor = System.Drawing.Color.Black;
            this.txtTaille.Location = new System.Drawing.Point(163, 11);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(66, 26);
            this.txtTaille.TabIndex = 8;
            this.txtTaille.TextChanged += new System.EventHandler(this.txtTaille_TextChanged);
            // 
            // txtSexe
            // 
            this.txtSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSexe.ForeColor = System.Drawing.Color.Black;
            this.txtSexe.Location = new System.Drawing.Point(163, 42);
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.Size = new System.Drawing.Size(66, 26);
            this.txtSexe.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 113);
            this.Controls.Add(this.txtSexe);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.poid_label);
            this.Controls.Add(this.sexe_label);
            this.Controls.Add(this.taille_label);
            this.Name = "Form1";
            this.Text = "Le poids idéal (formule de Lorentz)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taille_label;
        private System.Windows.Forms.Label sexe_label;
        private System.Windows.Forms.Label poid_label;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.TextBox txtSexe;
    }
}

