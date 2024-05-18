namespace TP_3_Films
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
            this.ComboBoxFilms = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnNouveauFilm = new System.Windows.Forms.Button();
            this.TxtBoxGenre = new System.Windows.Forms.TextBox();
            this.TxtBoxSupport = new System.Windows.Forms.TextBox();
            this.TxtBoxNum = new System.Windows.Forms.TextBox();
            this.PictureBoxFilm = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTitre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxFilms);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des films";
            // 
            // ComboBoxFilms
            // 
            this.ComboBoxFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ComboBoxFilms.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxFilms.Name = "ComboBoxFilms";
            this.ComboBoxFilms.Size = new System.Drawing.Size(364, 112);
            this.ComboBoxFilms.TabIndex = 0;
            this.ComboBoxFilms.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilms_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNouveauFilm);
            this.groupBox2.Controls.Add(this.TxtBoxGenre);
            this.groupBox2.Controls.Add(this.TxtBoxSupport);
            this.groupBox2.Controls.Add(this.TxtBoxNum);
            this.groupBox2.Controls.Add(this.PictureBoxFilm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblTitre);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations du film";
            // 
            // BtnNouveauFilm
            // 
            this.BtnNouveauFilm.Location = new System.Drawing.Point(260, 160);
            this.BtnNouveauFilm.Name = "BtnNouveauFilm";
            this.BtnNouveauFilm.Size = new System.Drawing.Size(84, 20);
            this.BtnNouveauFilm.TabIndex = 8;
            this.BtnNouveauFilm.Text = "Nouveau film";
            this.BtnNouveauFilm.UseVisualStyleBackColor = true;
            this.BtnNouveauFilm.Click += new System.EventHandler(this.BtnNouveauFilm_Click);
            // 
            // TxtBoxGenre
            // 
            this.TxtBoxGenre.Location = new System.Drawing.Point(182, 126);
            this.TxtBoxGenre.Name = "TxtBoxGenre";
            this.TxtBoxGenre.ReadOnly = true;
            this.TxtBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxGenre.TabIndex = 7;
            // 
            // TxtBoxSupport
            // 
            this.TxtBoxSupport.Location = new System.Drawing.Point(182, 100);
            this.TxtBoxSupport.Name = "TxtBoxSupport";
            this.TxtBoxSupport.ReadOnly = true;
            this.TxtBoxSupport.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxSupport.TabIndex = 6;
            // 
            // TxtBoxNum
            // 
            this.TxtBoxNum.Location = new System.Drawing.Point(182, 78);
            this.TxtBoxNum.Name = "TxtBoxNum";
            this.TxtBoxNum.ReadOnly = true;
            this.TxtBoxNum.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxNum.TabIndex = 5;
            // 
            // PictureBoxFilm
            // 
            this.PictureBoxFilm.Location = new System.Drawing.Point(19, 27);
            this.PictureBoxFilm.Name = "PictureBoxFilm";
            this.PictureBoxFilm.Size = new System.Drawing.Size(104, 131);
            this.PictureBoxFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFilm.TabIndex = 4;
            this.PictureBoxFilm.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Support";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film n\'";
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(133, 38);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(117, 22);
            this.LblTitre.TabIndex = 0;
            this.LblTitre.Text = "Titre du film";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion des films";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Button BtnNouveauFilm;
        private System.Windows.Forms.TextBox TxtBoxGenre;
        private System.Windows.Forms.TextBox TxtBoxSupport;
        private System.Windows.Forms.TextBox TxtBoxNum;
        private System.Windows.Forms.PictureBox PictureBoxFilm;
        private System.Windows.Forms.ComboBox ComboBoxFilms;
    }
}

