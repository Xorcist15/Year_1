namespace TP_Serialization
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
        void InitializeComponent()
        {
            this.ChoisirClasseGrpBox = new System.Windows.Forms.GroupBox();
            this.ListeClasseCmboBox = new System.Windows.Forms.ComboBox();
            this.ChoisirClasseGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoisirClasseGrpBox
            // 
            this.ChoisirClasseGrpBox.Controls.Add(this.ListeClasseCmboBox);
            this.ChoisirClasseGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChoisirClasseGrpBox.Location = new System.Drawing.Point(12, 12);
            this.ChoisirClasseGrpBox.Name = "ChoisirClasseGrpBox";
            this.ChoisirClasseGrpBox.Size = new System.Drawing.Size(308, 298);
            this.ChoisirClasseGrpBox.TabIndex = 0;
            this.ChoisirClasseGrpBox.TabStop = false;
            this.ChoisirClasseGrpBox.Text = "Sélectionner la classe";
            // 
            // ListeClasseCmboBox
            // 
            this.ListeClasseCmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ListeClasseCmboBox.FormattingEnabled = true;
            this.ListeClasseCmboBox.Location = new System.Drawing.Point(6, 25);
            this.ListeClasseCmboBox.Name = "ListeClasseCmboBox";
            this.ListeClasseCmboBox.Size = new System.Drawing.Size(296, 270);
            this.ListeClasseCmboBox.TabIndex = 0;
            this.ListeClasseCmboBox.SelectedIndexChanged += new System.EventHandler(this.ListeClasseCmboBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 317);
            this.Controls.Add(this.ChoisirClasseGrpBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ChoisirClasseGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChoisirClasseGrpBox;
        private System.Windows.Forms.ComboBox ListeClasseCmboBox;
    }
}