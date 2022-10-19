using System;
using System.Text.RegularExpressions;

namespace Terrain
{
    public class Proprietaire
    {
        public string nom;
        public string prenom;

        public List<Bien> bien = new List<Bien>();


        public Proprietaire(string Nom, string Prenom)
        {
            this.nom = Nom;
            this.prenom = Prenom;
        }
        public override string ToString()
        {
            string toString = String.Format("Nom = {0}\n", this.nom);
            toString += String.Format("Prénom = {0}m²\n", this.prenom);

            return toString;
        }
    }
}
