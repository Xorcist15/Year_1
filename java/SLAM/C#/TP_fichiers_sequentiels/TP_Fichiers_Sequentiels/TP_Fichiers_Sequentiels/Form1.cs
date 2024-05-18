using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace TP_Fichiers_Sequentiels
{
    public partial class GestionEleves : Form
    {
        public GestionEleves()
        {
            InitializeComponent();
            GroupBoxAjoutEleve.Visible = false;
            Init_List_Etudiants();
            LoadEtudiants();
        }
        private void LoadEtudiants()
        {
            ComboBoxEtudiants.Items.Clear();
            foreach (Etudiant E in Etudiant.Etudiants)
            {
                ComboBoxEtudiants.Items.Add(E.Nom);
            }
        }
        private void Init_List_Etudiants()
        {
            //ouvrir le fichier en mode lecture
            FileStream fs = new FileStream("lesEleves.txt", FileMode.Open, FileAccess.Read);
            //ouvrir un flux en mode lecture
            StreamReader leFichier = new StreamReader(fs);
            //Amorce
            string ligne = leFichier.ReadLine();
            while (ligne != null)
            {
                string[] temp = ligne.Split(';');
                Etudiant.AddEtudiant(temp[0], temp[1], temp[2]);
                ligne = leFichier.ReadLine();
            }
            leFichier.Close();
        }
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            GroupBoxAjoutEleve.Visible = true;
        }
        private void BtnValider_Click(object sender, EventArgs e)
        {
            string regex = ";";
            FileStream fs = new FileStream("lesEleves.txt", FileMode.Append, FileAccess.Write);
            StreamWriter leFichier = new StreamWriter(fs);
            string num = TextBoxNum.Text.Trim();
            string nom = TextBoxNom.Text.Trim();
            string prenom = TextBoxPrenom.Text.Trim();
            string ligne = num + regex + nom + regex + prenom;
            Etudiant.AddEtudiant(num, nom, prenom);
            leFichier.WriteLine(ligne);
            Console.WriteLine(ligne);
            leFichier.Close();
        }
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            TextBoxNum.Text = string.Empty;
            TextBoxNom.Text = string.Empty;
            TextBoxPrenom.Text = string.Empty;
        }
        private void ComboBoxEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ComboBoxEtudiants.SelectedItem.ToString();
            foreach (Etudiant E in Etudiant.Etudiants)
            {
                if (E.Nom == value)
                {
                    MessageBox.Show(E.ToString());
                }
            }
        }
    }
}
