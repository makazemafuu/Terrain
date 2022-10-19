using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Terrain
{
    public class Proprietaire
    {
        public string nom;
        public string prenom;

        public Bien[] bien = new Bien[0];


        public Proprietaire(string Nom, string Prenom, Bien[] Bien)
        {
            this.nom = Nom;
            this.prenom = Prenom;
            this.bien = Bien;
        }

        private string ListeBien()
        {
            string listeBien = "";

            foreach (Bien B in this.bien)
            {
                listeBien += String.Format("- {0} {1} au {2}\n", B.GetType().Name == "Maison" ? "Une" : "Un", B.GetType().Name, B.adresse);
            }
            return listeBien;
        }

        public override string ToString()
        {
            string toString = String.Format("{0} {1} {2}\n", this.nom, this.prenom, this.bien?.Length != 0 ? "possède :" : "ne possède aucun bien.");
            toString += ListeBien();

            return toString;
        }
    }
}
