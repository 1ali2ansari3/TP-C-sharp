

using System;

namespace Chap1
{
    // classe de test
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public override string ToString()
        {
            return string.Format("X : {0}, Y : {1}", x, y);
        }



    }
}







