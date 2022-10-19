using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Terrain
{
    public class Pieces
    {

        float superficie;
        string nom;

        public Pieces(float Superficie, string Nom)
        {
            this.superficie = Superficie;
            this.nom = Nom;
        }

        public override string ToString()
        {
            // Get the € sign to work
            Console.OutputEncoding = Encoding.UTF8;

            string toString = base.ToString();
            toString += String.Format("Superficie des pièces = {0}m²\n", this.superficie);
            //toString += String.Format("> Nom = {0}€", this.nom());
            return toString;
        }
    }
}
