using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Terrain
{
    public class Pieces
    {

        public float superficie;
        public string nom;

        public Pieces(float Superficie, string Nom)
        {
            this.superficie = Superficie;
            this.nom = Nom;
        }

        public override string ToString()
        {
            // Get the € sign to work
            Console.OutputEncoding = Encoding.UTF8;

            string toString = String.Format("La pièce {0} fait {1}m²\n", this.nom, this.superficie);
            //toString += String.Format("> Nom = {0}€", this.nom());
            return toString;
        }
    }
}
