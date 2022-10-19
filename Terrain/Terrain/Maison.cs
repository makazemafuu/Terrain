﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Terrain
{
    public class Maison : Bien
    {
        public int nbPieces;
        public int nbEtages;
        public bool baignoire;
        public bool jardin;

        public List<Pieces> pieces = new List<Pieces>();

        // constructeur Maison (de la class Maison)
        // initialisation
        public Maison(string Adresse, float Superficie, int NbPieces, int NbEtages, bool Baignoire, bool jardin) : base(Adresse, Superficie)
        {
            this.nbPieces = NbPieces;
            this.nbEtages = NbEtages;
            this.baignoire = Baignoire;
            this.jardin = jardin;
        }

        public override string ToString()
        {
            // Get the € sign to work
            Console.InputEncoding = Encoding.UTF8;

            // redéfinir la string ToString puisqu'on l'override (donc ajoute)
            string toString = base.ToString();

            // NE PAS OUBLIER LE + SINON TU ECRASE ! :'))
            // .Format est une méthode de formatage
            toString += String.Format("Nombre de pièces = {0}\n", this.nbPieces);
            toString += String.Format("Nombre d'étages = {0}\n", this.nbEtages);
            toString += String.Format("Présence d'une baignoire = {0}\n", this.baignoire ? "Oui" : "Non");
            toString += String.Format("Présence d'un jardin = {0}\n", this.baignoire ? "Oui" : "Non");

            // substitution par la méthode ToString : chaque classe hérite implicitement de la classe Object
            // ainsi ToString retourne une représentation sous forme de chaîne de caractère de cet objet
            // ex : toutes les variables de type int ont une méthode ToString

            // méthode = fonction mais fonction =/= méthode
            // méthode car c'est dans une classe

            if (baignoire)
            {
                // Get the € sign to work
                Console.OutputEncoding = Encoding.UTF8;

                toString += String.Format("Coûts totaux de la construction de la baignoire (si applicable) = {0}€\n", this.CoutFinirSalleDeBain());
            }
            else
            {
                // empty, on ne veut rien afficher
            }

            toString += String.Format("> VALEUR = {0}€", this.EvaluationValeur());

            return toString;
        }

        // méthode = fonction mais fonction =/= méthode
        // méthode car c'est dans une classe
        public new float EvaluationValeur()
        {
            int facteur = 3000;

            // this = permet de lever des ambiguïtés de nommage entre attributs et paramètres
            // utilisé lorsqu'on ne nomme pas différent

            if (this.baignoire) { facteur += 10; }
            if (this.nbPieces > 3) { facteur += 200; }

            // Regex.IsMatch : permet de renvoyer une occurence qui est délimité par les \b dans la string qui suit
            // Si Regex.IsMatch = true par exemple ici pour Paris ça va renvoyer le facteur 7000

            if (Regex.IsMatch(this.adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.superficie * facteur;
        }

        public int CoutFinirSalleDeBain()
        {
            int facteur = 50;

            if (this.baignoire) { facteur += 50; }
            if (this.nbEtages > 4) { facteur += 50; }

            return this.nbEtages * facteur;

        }

    }
}
