using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission6
{
    internal class Port
    {
        private int id;
        private String nom;

        public Port(int id, String nom)
        {
            this.id = id;
            this.nom = nom;
        }
        public String GetNom (){
            return nom;
        }
    }
}
