using System;
using System.Drawing;

namespace Chap1
{
    public class XC
    {
        // classe de test
        static void Main(string[] args)
        {
            Point point = new Point(2, 3);
            Rectangle rectangle = new Rectangle(2, 3 , 1,1);
            Parallelepipede parallelepipede = new Parallelepipede(2, 3, 1, 1, 2);

            
            Console.WriteLine("Point : {0}", point);
            Console.WriteLine("Rectangle : {0}", rectangle);
            Console.WriteLine("Rectangle : {0}", parallelepipede);


        }
    }
}

