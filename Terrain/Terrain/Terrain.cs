using System;
using System.Text.RegularExpressions;
using Terrain;

namespace Terrain
{
    public class Terrain : Bien
    {
        public int nbCotesClotures;
        public bool riviere;

        public Terrain(string Adresse, float Superficie, int NbCotesClotures, bool Riviere) : base(Adresse, Superficie)
        {
            nbCotesClotures = NbCotesClotures;
            riviere = Riviere;
        }

        public override string ToString()
        {
            string toString = base.ToString();
            toString += String.Format("Nombre de cotés clorutés = {0}\n", this.nbCotesClotures);
            toString += String.Format("Présence d'une rivière = {0}\n", this.riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());
            return toString;
        }

        public new float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.riviere) { facteur += 600; }

            facteur += 100 * this.nbCotesClotures;

            if (Regex.IsMatch(this.adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.superficie * facteur;
        }
    }
}