using System;

namespace Terrain
{
    public class Maison
    {
        public string adresse;
        public float superficie;
        public int nbPieces;
        public bool jardin;

        public Maison(string Adresse, float Superficie, int NbPiece, bool Jardin)
        {
            adresse = Adresse;
            superficie = Superficie;
            nbPieces = NbPiece;
            jardin = Jardin;

        }
    }
}