using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitJours();
            InitTraversees();
        }
        public void InitJours()
        {
            List<Traversee> lesTraversees = init_lesTraversees();
            List<string> JoursUniques = new List<string>();

            foreach (Traversee T in lesTraversees)
            {
                string date = T.GetDate();
                if (!JoursUniques.Contains(date))
                {
                    JoursUniques.Add(date);
                    comboBoxJours.Items.Add(T.GetDate());
                }
            }
        }
        public void InitTraversees()
        {
            List<Traversee> lesTraversees = init_lesTraversees();

            foreach (Traversee T in lesTraversees)
            {
                comboBoxTraversee.Items.Add(T.GetID() +
                        " : " +
                        T.GetPortDepart().GetNom() +
                        " ==> " +
                        T.GetPortArrivee().GetNom() +
                        " Départ ==> " +
                        T.GetHeureDepart());
            }
        }
        private void comboBoxJours_SelectedIndexChanged(object sender, EventArgs e)
        {
            // choix du jour de la traversée
            string dateChoisi = comboBoxJours.SelectedItem.ToString();
            Filtrer_lesTraversees(dateChoisi);
        }
        private void comboBoxTraversee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // les traversées s'affichent en fonction du jour
            string dateChoisi = comboBoxTraversee.SelectedItem.ToString();
            ShowInformation(dateChoisi);
            Console.WriteLine(dateChoisi);
        }
        private List<Traversee> init_lesTraversees()
        {
            Random random = new Random();

            Bateau b1 = new Bateau("L'ILE DE GROIX", 46, 12, 12, 450, 32);
            Port p1 = new Port(1, "Lorient");
            Port p2 = new Port(2, "Groix");

            List<Traversee> lesTraversees = new List<Traversee>();
            lesTraversees.Add(new Traversee(1, "01/04/2024", "13:45", 45, 18, 73, 20, p1, p2, b1));
            lesTraversees.Add(new Traversee(2, "01/04/2024", "16:15", 45, 18, 73, 20, p2, p1, b1));
            lesTraversees.Add(new Traversee(2, "01/04/2024", "16:15", 45, 18, 73, 20, p2, p1, b1));
            lesTraversees.Add(new Traversee(2, "01/04/2024", "16:15", 45, 18, 73, 20, p2, p1, b1));
            lesTraversees.Add(new Traversee(2, "01/04/2024", "16:15", 45, 18, 73, 20, p2, p1, b1));

            return lesTraversees;
        }
        private void Filtrer_lesTraversees(string filter)
        {
            comboBoxTraversee.Items.Clear();
            List<Traversee> lesTraversees = init_lesTraversees();

            // Parcourir chaque pays dans la liste
            foreach (Traversee T in lesTraversees)
            {
                // Vérifier si le code de continent correspond au filtre spécifié
                if (T.GetDate() == filter)
                {
                    comboBoxTraversee.Items.Add(T.GetID() + 
                        " : " + 
                        T.GetPortDepart().GetNom() + 
                        " ==> " + 
                        T.GetPortArrivee().GetNom() +
                        " Départ ==> " +
                        T.GetHeureDepart());
                }
            }
        }
        private void ShowInformation(string TraverseeSelect)
        {
            List<Traversee> lesTraversees = init_lesTraversees();
            foreach (Traversee T in lesTraversees)
            {
                String[] temp = TraverseeSelect.Split(':');
                int temp_id = int.Parse(temp[0]);
                if (T.GetID() == temp_id)
                {
                    MessageBox.Show(T.ToString());
                    break;
                }
            }
        }
    }
}
