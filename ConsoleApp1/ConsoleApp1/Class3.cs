using System;

namespace Chap1
{
    public class Parallelepipede : Rectangle
    {
        private int hauteur;

        public int Hauteur
        {
            get { return hauteur; }
            set { hauteur = value; }
        }

        public Parallelepipede()
            : base()
        {
            Hauteur = 0;
        }

        public Parallelepipede(int x, int y, int longueur, int largeur, int hauteur)
            : base(x, y, longueur, largeur)
        {
            Hauteur = hauteur;
        }

        public int Aire()
        {
            return 2 * (Longueur * Largeur + Longueur * Hauteur + Largeur * Hauteur);
        }

        public int Volume()
        {
            return Longueur * Largeur * Hauteur;
        }

        public override string ToString()
        {
            return string.Format("Parallélépipède de longueur {0}, de largeur {1} et de hauteur {2} avec le coin supérieur gauche à {3}", Longueur, Largeur, Hauteur, base.ToString());
        }
    }

}











