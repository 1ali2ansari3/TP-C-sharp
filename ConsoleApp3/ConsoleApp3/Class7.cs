using System;


namespace Chap1
{
    class Steward : Employe
    {
        private string civilite;

        public Steward()
        {
            civilite = "";
        }

        public Steward(int c, string n, string p, double sb, string civ) : base(c, n, p, sb)
        {
            civilite = civ;
        }

        public string Civilite
        {
            get { return civilite; }
            set { civilite = value; }
        }

        public override string Presentation()
        {
            return "[Code:" + Code + " nom:" + Nom + " civilite:" + civilite + " Salaire:" + GetSalaire() + " DH]";
        }

        public override double GetSalaire()
        {
            return base.GetSalaire() * 2;
        }
    }

}