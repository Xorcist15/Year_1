using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NvlClasseGrpBox.Visible = false;
        }
        private void nouvelleClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NvlClasseGrpBox.Visible = true;
            NomClassTxtBox.Focus();
        }
        private void ouvrirClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.ShowDialog();

            NvlClasseGrpBox.Visible = false;

            // changes current class values
            NomClassLbl.Text = f.SelectedClasse;

            // uses selected item value from previous dialog window's "Form2" combobox
            LoadEtudiants(f.SelectedClasse);
        }
        private void BtnCreerClasse_Click(object sender, EventArgs e)
        {
            NomClassLbl.Text = NomClassTxtBox.Text;
            if (!String.IsNullOrEmpty(NomClassTxtBox.Text))
            {
                new Classe(NomClassTxtBox.Text);
                NvlClasseGrpBox.Visible = false;
                NomClassTxtBox.Text = null;
            }
            NomClassTxtBox.Text = null;
            EtudiantsComboBox.Items.Clear();
            NomTxtBox.Focus();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            String currentClasse = NomClassLbl.Text;
            InsertEtudiant(currentClasse);
            LoadEtudiants(currentClasse);
            NomTxtBox.Text = null;
            PrenomTxtBox.Text = null;
            NomTxtBox.Focus();
        }
        public void InsertEtudiant(string currentClasse)
        {
            if (!String.IsNullOrEmpty(NomTxtBox.Text) & !String.IsNullOrEmpty(PrenomTxtBox.Text))
            {
                foreach (Classe c in Classe.lesClasses)
                {
                    if (c.Nom == currentClasse)
                    {
                        c.addEtudiant(new Etudiant(NomTxtBox.Text, PrenomTxtBox.Text));
                        break;
                    }
                }
            }
        }
        public void LoadEtudiants(string currentClasse)
        {
            EtudiantsComboBox.Items.Clear();
            foreach (Classe c in Classe.lesClasses)
            {
                if (c.Nom == currentClasse)
                {
                    foreach(Etudiant e in c.LesEtudiants)
                    {
                        EtudiantsComboBox.Items.Add(e.ToString());
                    }
                    break;
                }
            }
        }

        private void explorateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream flux = File.OpenRead(openFileDialog1.FileName);
                    BinaryFormatter deserialiseur = new BinaryFormatter();
                    Classe maClasse = (Classe)(deserialiseur.Deserialize(flux));
                    Classe.addClasse(maClasse);
                    NomClassLbl.Text = maClasse.Nom;
                    flux.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
            String currentClasse = NomClassLbl.Text;
            InsertEtudiant(currentClasse);
            LoadEtudiants(currentClasse);
        }
        private void enregistrerClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialiseur = new BinaryFormatter(); ;

            for (int i = 0; i < Classe.lesClasses.Count; i++)
            {
                System.IO.Stream monFichier = File.Create(Classe.lesClasses[i].Nom + ".txt");
                serialiseur.Serialize(monFichier, Classe.lesClasses[i]);
                monFichier.Close();
            }
        }
        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of SaveFileDialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set properties of the SaveFileDialog as needed
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Show the SaveFileDialog to the user
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the file path selected by the user
                    string filePath = saveFileDialog1.FileName;
                    string currentClasse = NomClassLbl.Text;

                    BinaryFormatter serialiseur = new BinaryFormatter(); ;

                    System.IO.Stream monFichier = File.Create(filePath + currentClasse + ".bin");
                    for(int i = 0; i < Classe.lesClasses.Count; i++)
                    {
                        if(currentClasse == Classe.lesClasses[i].Nom)
                        {
                            serialiseur.Serialize(monFichier, Classe.lesClasses[i]);
                            monFichier.Close();
                            break;
                        }
                    }
                    

                    

                    // Perform saving process here, for example:
                    // Write data to the selected file
                    //System.IO.File.WriteAllText(filePath, "Sample text content");

                    // Show a message to indicate successful saving
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur during saving
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
