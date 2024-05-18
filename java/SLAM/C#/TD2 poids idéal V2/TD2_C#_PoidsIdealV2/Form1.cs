using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD2_C__PoidsIdealV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            int taille;
            char sexe;
            double resultat;

            string ligne;

            taille = Int16.Parse(txtTaille.Text);

            if (taille >= 140 && taille <= 220)
            {
                if (radioHomme.Checked)
                {
                    resultat = (taille - 100) - ((taille - 150) / (4));
                    lblPoids.Text = resultat.ToString() + " Kg";
                    if (checkEnListe.Checked)
                    {
                        ligne = "H - " + txtNom.Text.PadRight(15) + txtTaille.Text + " cm --> " + resultat.ToString();
                        lstResultats.Items.Add(ligne);
                    }
                }
                if (radioFemme.Checked)
                {
                    resultat = (taille - 100) - ((taille - 150) / (2.5));
                    lblPoids.Text = resultat.ToString() + " Kg";
                    if (checkEnListe.Checked)
                    {
                        ligne = "F - " + txtNom.Text.PadRight(15) + txtTaille.Text + " cm --> " + resultat.ToString();
                        lstResultats.Items.Add(ligne);
                    }
                }
            }
            else
            {
                MessageBox.Show("this is content of messag", "this is title of message");
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            radioFemme.Checked = false;
            radioHomme.Checked = false;

            txtNom.Text = null;
            txtTaille.Text = null;

            lblPoids.Text = null;
        }

        private void checkEnListe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            lstResultats.Items.Clear();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
