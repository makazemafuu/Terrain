using System;

namespace Terrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maison UneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 10, 5, false);
            Maison UneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 4, 2, true);
            Maison UneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 6, 3, false);

            Terrain UnTerrain = new Terrain("55 route cabossée, 29130 Locmaria-Plouzané", 5000f, 2, true);
            Terrain UnAutreTerrain = new Terrain("102 route des volcans, 63000 Clermont-Ferrand", 1500f, 4, false);

            Bien[] CatalogueBiens = new Bien[] { UneMaison, UneAutreMaison, UneDerniereMaison, UnTerrain, UnAutreTerrain };

            foreach (Bien B in CatalogueBiens)
            {
                Console.WriteLine(B);
                Console.Write("\n");
            }
        }
    }
}