using System;
using System.Collections.Generic;
using System.IO;

namespace Chap1
{
    class Employe
    {
        private int code;
        private string nom;
        private string prenom;
        private double Salairebase;

        public Employe()
        {
            code = 0;
            nom = "";
            prenom = "";
            Salairebase = 0;
        }

        public Employe(int c, string n, string p, double sb)
        {
            code = c;
            nom = n;
            prenom = p;
            Salairebase = sb;
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public double SalaireBase
        {
            get { return Salairebase; }
            set { Salairebase = value; }
        }

        public virtual string Presentation()
        {
            return "[Code:" + Code + " nom:" + Nom + " prénom:" + Prenom + " Salaire:" + SalaireBase + " DH]";
        }

        public virtual double GetSalaire()
        {
            return SalaireBase * 1.3;
        }
    }

}