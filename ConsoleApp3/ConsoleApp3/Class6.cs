using System;


namespace Chap1
{
    class PiloteLigne : Employe
    {
        private string grade;
        private int NbHeures;

        public PiloteLigne()
        {
            grade = "";
            NbHeures = 0;
        }

        public PiloteLigne(int c, string n, string p, double sb, string g, int nh) : base(c, n, p, sb)
        {
            grade = g;
            NbHeures = nh;
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int NombreHeuresVols
        {
            get { return NbHeures; }
            set { NbHeures = value; }
        }

        public override string Presentation()
        {
            return "[Code:" + Code + " nom:" + Nom + " prénom:" + Prenom + " Salaire:" + GetSalaire() + " DH Grade:" + grade + " Nombre heures vols:" + NbHeures + "]";
        }

        public override double GetSalaire()
        {
            return base.GetSalaire() * 3 + SalaireBase * NbHeures / 1000;
        }
    }


}