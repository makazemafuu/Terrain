using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Terrain
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Should get other unicode languages to work but doesn't here
            // I had to go to my control panel > region > administrator and switch my region to Japan (then restart Windows)
            // the @ & other codes below also didn't work except for the € sign

            // Console.InputEncoding = Encoding.UTF8;
            // Get the € sign to work
            Console.OutputEncoding = Encoding.UTF8;

            Maison UneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 6, 2, false, true);
            Maison UneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 8, 3, true, true);
            Maison UneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, 1, false, false);

            Terrain UnTerrain = new Terrain("55 route cabossée, 29130 Locmaria-Plouzané", 5000f, 2, true);
            Terrain UnAutreTerrain = new Terrain("102 route des volcans, 63000 Clermont-Ferrand", 1500f, 4, false);
            Terrain UnDernierTerrain = new Terrain(@"東京都杉並区清水1丁目18番7号", 800f, 2, true);

            Bien[] CatalogueBiens = new Bien[] { UneMaison, UneAutreMaison, UneDerniereMaison, UnTerrain, UnAutreTerrain, UnDernierTerrain };

            foreach (Bien B in CatalogueBiens)
            {
                Console.WriteLine(B);
                Console.Write("\n");
            }

            Proprietaire Mafuu = new Proprietaire("Eden", "Walker", new Bien[] { UneMaison, UnTerrain });
            Console.WriteLine(Mafuu);

            Proprietaire Makaze = new Proprietaire("Noël", "Reklaw", new Bien[] { UneAutreMaison, UnAutreTerrain });
            Console.WriteLine(Makaze);

            Proprietaire Neo = new Proprietaire("Makaze", "Mafuu", new Bien[] { UneDerniereMaison, UnDernierTerrain });
            Console.WriteLine(Neo);

            Proprietaire Lukas = new Proprietaire("Salem", "Melas", new Bien[0]);
            Console.WriteLine(Lukas);

        }
    }
}