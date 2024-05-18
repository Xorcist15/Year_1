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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChargerFilms();
            RemplirComboBoxFilms();
        }
        public void RemplirComboBoxFilms()
        {
            ComboBoxFilms.Items.Clear();
            foreach (Film F in Film.lesFilms)
            {
                ComboBoxFilms.Items.Add(F.toLine());
            }
        }
        private void ChargerFilms()
        {
            FileStream fs = new FileStream("ficFilms.txt", FileMode.Open, FileAccess.Read);
            StreamReader leFichier = new StreamReader(fs);

            string ligne = leFichier.ReadLine();
            Film.lesFilms.Clear();
            while (ligne != null)
            {
                if (ligne.Length > 0)
                {
                    Film.AddFilm(ligne);
                }
                ligne = leFichier.ReadLine();
            }
            leFichier.Close();
        }
        private void ComboBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ComboBoxFilms.SelectedItem.ToString();
            string[] temp = selectedItem.Split('.');
            foreach (Film F in Film.lesFilms)
            {
                if (temp[0] == F.Numero.ToString())
                {
                    TxtBoxNum.Text = F.Numero.ToString();
                    TxtBoxSupport.Text = F.Support;
                    TxtBoxGenre.Text = F.Genre;
                    LblTitre.Text = F.Titre;
                    try
                    {
                        PictureBoxFilm.Image = Image.FromFile("Affiches\\" + F.Numero.ToString() + ".jpg");
                    }
                    catch(Exception)
                    {
                        PictureBoxFilm.Image = Image.FromFile("Affiches\\sans.png");
                    }
                    break;
                }
            }
        }
        private void BtnNouveauFilm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                ChargerFilms();
                RemplirComboBoxFilms();
            }
        }
    }
}
