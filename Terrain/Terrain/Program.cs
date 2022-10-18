using System;

namespace Terrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maison uneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Maison uneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true);
            Maison uneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false);

            Maison[] CatalogueMaisons = new Maison[] { uneMaison, uneAutreMaison, uneDerniereMaison };

            foreach (Maison M in CatalogueMaisons)
            {
                Console.WriteLine("Adresse = {0}", M.adresse );
                Console.WriteLine("Superficie = {0}", M.superficie);
                Console.WriteLine("Nombre de pièces = {0}", M.nbPieces);
                Console.WriteLine("Présence d'un jardin = {0}", M.jardin ? "Oui" : "Non");
                Console.Write("\n");
            }
        }
    }
}