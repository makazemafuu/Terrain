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

            // tableau (array) du constructeur
            // le constructeur créer l'objet
            // une classe peut pas être appelé, lorsqu'un constructeur n'est pas créer
            // il y en a un par défaut, en créer un supprime celui par défaut

            Maison[] CatalogueMaisons = new Maison[] { uneMaison, uneAutreMaison, uneDerniereMaison };

            // boucle qui permet de passer tour par tour dans chaque élément du tableau ici

            foreach (Maison M in CatalogueMaisons)
            {
                Console.WriteLine(M);
                Console.Write("\n");
            }
        }
    }
}