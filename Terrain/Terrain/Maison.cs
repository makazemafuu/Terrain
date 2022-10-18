using System;
using System.Text.RegularExpressions;

namespace Terrain
{
    public class Maison
    {
        public string adresse;
        public float superficie;
        public int nbEtages;
        public bool baignoire;

        // constructeur Maison (de la class Maison)
        // initialisation
        public Maison(string Adresse, float Superficie, int NbEtages, bool Baignoire)
        {
            adresse = Adresse;
            superficie = Superficie;
            nbEtages = NbEtages;
            baignoire = Baignoire;
        }

        // substitution par la méthode ToString : chaque classe hérite implicitement de la classe Object
        // ainsi ToString retourne une représentation sous forme de chaîne de caractère de cet objet
        // ex : toutes les variables de type int ont une méthode ToString

        // méthode = fonction mais fonction =/= méthode
        // méthode car c'est dans une classe
        public override string ToString()
        {
            // ça va retourner le namespace + le nom de la class
            //return base.ToString();

            string ToString = base.ToString();
            string toString = String.Format("Adresse = {0}\n", this.adresse);
            toString += String.Format("Superficie = {0}m²\n", this.superficie);
            toString += String.Format("Nombre d'étages = {0}\n", this.nbEtages);
            toString += String.Format("Présence d'une baignoire = {0}\n", this.baignoire ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());

            return toString;
        }

        // méthode = fonction mais fonction =/= méthode
        // méthode car c'est dans une classe
        public float EvaluationValeur()
        {
            int facteur = 3000;

            // this = permet de lever des ambiguïtés de nommage entre attributs et paramètres
            // utilisé lorsqu'on ne nomme pas différent

            if (this.baignoire) { facteur += 500; }
            if (this.nbEtages > 3) { facteur += 200; }

            // Regex.IsMatch : permet de renvoyer une occurence qui est délimité par les \b dans la string qui suit
            // Si Regex.IsMatch = true par exemple ici pour Paris ça va renvoyer le facteur 7000

            if (Regex.IsMatch(this.adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.superficie * facteur;
        }

    }
}
