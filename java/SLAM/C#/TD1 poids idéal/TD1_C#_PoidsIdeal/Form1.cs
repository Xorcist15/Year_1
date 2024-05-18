using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD1_C__PoidsIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void taille_label_Click(object sender, EventArgs e)
        {

        }

        private void txtTaille_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPoids_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            int taille;
            char sexe;
            double resultat;

            taille = Int16.Parse(txtTaille.Text);

            if (taille >= 140 && taille <= 220)
            {
                sexe = Char.Parse(txtSexe.Text);

                switch (sexe)
                {
                    case 'm':
                        resultat = (taille - 100) - ((taille - 150) / (4));
                        lblPoids.Text = resultat.ToString() + " kg";
                        break;

                    case 'f':
                        resultat = (taille - 100) - ((taille - 150) / (2.5));
                        lblPoids.Text = resultat.ToString() + " kg";
                        break;

                    default:
                        MessageBox.Show("this is the message (f ou m)", "this is the title of the messagebox (f ou m)");
                        txtSexe.Clear();
                        txtSexe.Focus();
                        break;
                }
            }
            else
            {
                MessageBox.Show("this is the message", "this is the title of the messagebox");
                txtTaille.Clear();
                txtTaille.Focus();
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtTaille.Clear();
            txtSexe.Clear();
            lblPoids.Text = null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
