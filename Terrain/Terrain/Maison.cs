using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maison uneMaison = new Maison();

            Console.WriteLine("Adresse = {0}", uneMaison.adresse);
            Console.WriteLine("Superficie = {0}", uneMaison.superficie);
            Console.WriteLine("Nombre de pièces = {0}", uneMaison.nbPieces);
            Console.WriteLine("Présence d'un jardin = {0}", uneMaison.jardin);
        }
    }
}
