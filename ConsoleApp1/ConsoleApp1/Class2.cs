using System;

namespace Chap1
{

    public class Rectangle : Point
    {
        private int longueur;
        private int largeur;

        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public Rectangle(): base()
        {
            Longueur = 0;
            Largeur = 0;
        }

        public Rectangle(int x, int y, int longueur, int largeur): base(x, y)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public int Aire()
        {
            return Longueur * Largeur;
        }

        public override string ToString()
        {
            return string.Format("Rectangle de longueur {0} et de largeur {1} avec le coin supérieur gauche à {2}", Longueur, Largeur, base.ToString());
        }

    }




}






