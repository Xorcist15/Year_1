using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace TP_3_Films
{
    internal class Film
    {
        private int numero;
        private string titre;
        private string genre;
        private string support;
        public static List<Film> lesFilms = new List<Film>();

        public Film(int numero, string titre, string genre, string support)
        {
            this.numero = numero;
            this.titre = titre;
            this.genre = genre;
            this.support = support;
        }
        public Film(string csv)
        {
            //1,"titre","genre","support","Dispo"
            char coma = ',';
            string[] temp = csv.Split(coma);
            this.numero = int.Parse(temp[0]);
            this.titre = temp[1].Trim('\"');
            this.genre = temp[2].Trim('\"');
            this.support = temp[3].Trim('\"');
        }
        // Accessors and mutators
        public int Numero
        {
            get { return numero; }
        }
        public string Titre
        {
            get { return titre; }
        }
        public string Genre
        {
            get { return genre; }
        }
        public string Support
        {
            get { return support; }
        }
        public static void AddFilm(string csv)
        {
            lesFilms.Add(new Film(csv));
        }
        public static void AddFilm(Film F)
        {
            lesFilms.Add(F);
        }
        public string toLine()
        {
            return 
                this.numero.ToString() + "."+ 
                "   " + 
                this.titre.Trim('\"') + 
                "   " + 
                this.genre.Trim('\"');
        }
        public string toCSV()
        {
            //1,"American Beauty","Drame","DVD","Dispo"
            string coma = ",";
            return
                this.numero.ToString() +
                coma +
                this.titre +
                coma +
                this.genre +
                coma +
                this.support +
                coma +
                "Dispo" +
                coma +
                this.numero + ".jpg";
        }
    }
}
