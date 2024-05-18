using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Serialization
{
    public partial class Form2 : Form
    {

        private String selectedClasse;
        public String SelectedClasse
        {
            get => selectedClasse;
            set => selectedClasse = value;
        }

        public Form2()
        {
            InitializeComponent();
            loadListeClasseComboBox();
        }

        private void loadListeClasseComboBox()
        {
            foreach(Classe c in Classe.lesClasses)
            {
                ListeClasseCmboBox.Items.Add(c.ToString());
            }
        }

        private void ListeClasseCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListeClasseCmboBox.SelectedItem != null)
            {
                this.SelectedClasse = ListeClasseCmboBox.SelectedItem.ToString();
            }
            this.Close();
        }
    }
}
