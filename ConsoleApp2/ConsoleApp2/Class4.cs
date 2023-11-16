using System;

namespace Chap1
{


    public class Carre : Forme
    {
        private double cote;

        public Carre(double cote)
        {
            this.cote = cote;
        }

        public double perimetre()
        {
            return 4 * cote;
        }

        public double aire()
        {
            return cote * cote;
        }

        public override string ToString()
        {
            return "Carre de cote " + cote;
        }

        public double Cote
        {
            get { return cote; }
            set { cote = value; }
        }
    }

}