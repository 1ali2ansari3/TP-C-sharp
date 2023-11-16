using System;

namespace Chap1
{

    public class TestForme
    {
        public static void Main()
        {
            Carre carre1 = new Carre(5);
            Console.WriteLine("Carre1 : " + carre1);
            Console.WriteLine("Perimetre de carre1 : " + carre1.perimetre());
            Console.WriteLine("Aire de carre1 : " + carre1.aire());

            carre1.Cote = 10;
            Console.WriteLine("Carre1 (apres modification) : " + carre1);
            Console.WriteLine("Perimetre de carre1 (apres modification) : " + carre1.perimetre());
            Console.WriteLine("Aire de carre1 (apres modification) : " + carre1.aire());

            Carre carre2 = new Carre(8);
            Console.WriteLine("Carre2 : " + carre2);
            Console.WriteLine("Perimetre de carre2 : " + carre2.perimetre());
            Console.WriteLine("Aire de carre2 : " + carre2.aire());
        }
    }
}
