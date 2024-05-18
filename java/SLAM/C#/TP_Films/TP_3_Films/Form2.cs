using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3_Films
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Init_cboSupport();
            TxtBoxNum.Text = (Film.lesFilms.Count + 1).ToString(); // sets id
        }

        private void Init_cboSupport()
        {
            cboSupport.Items.Add("DivX");
            cboSupport.Items.Add("DVD");
            cboSupport.Items.Add("Blue Ray");
            cboSupport.Items.Add("MP4");
            cboSupport.Items.Add("TS");
            cboSupport.Items.Add("AVI");
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtBoxNum.Text);
            string titre = TxtBoxTitre.Text;
            string genre = TxtBoxGenre.Text;
            string support = cboSupport.Text;
            string ligne =
                num.ToString() +
                "," +
                titre +
                "," +
                genre +
                "," +
                support;
            AjouterLigneFichier(ligne);
            TxtBoxNum.Text = (num + 1).ToString();
            this.DialogResult = DialogResult.OK;
        }
        private void AjouterLigneFichier(string ligne)
        {
            FileStream fs = new FileStream("ficFilms.txt", FileMode.Append, FileAccess.Write);
            StreamWriter leFichier = new StreamWriter(fs);
            leFichier.WriteLine(ligne);
            leFichier.Close();
        }
    }
}
