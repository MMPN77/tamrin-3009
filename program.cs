using System;

namespace calc
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Type:");
            int type = Convert.ToInt32(Console.ReadLine());
            calaculator calc = new calaculator(type);
            Console.WriteLine("circle: " + calc.circle());
            Console.WriteLine("square: " + calc.square());
            Console.WriteLine("triangle: " + calc.triangle());
            Console.WriteLine("trapezoid: " + calc.trapezoid());
        }
    }
    class calaculator
    {
        private int r;
        private int x;
        private int h;
        private int a;
        private int b;
        private Double p = 3.14;

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int H
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public calaculator() { }
        public calaculator(int type)
        {
            if(type == 1) // Circle
            {
                r = Convert.ToInt32(Console.ReadLine());
            }
            else if(type == 2) //Square
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            else if (type == 3) //triangle
            {
                x = Convert.ToInt32(Console.ReadLine());
                h = Convert.ToInt32(Console.ReadLine());
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            else if(type == 4) //trapezoid
            {
                h = Convert.ToInt32(Console.ReadLine());
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
        }

        public (Double, Double) circle()
        {
            Double c = 2 * p * r;
            Double s = p * Math.Pow(r, 2) ;
            return (c, s);
        }
        public (Double, Double) square()
        {
            Double c = x * 4;
            Double s = x * x;
            return (c, s);
        }
        public (Double, Double) triangle()
        {
            Double c = x + a + b;
            Double s = (x * h) / 2;
            return (c, s);
        }
        public (Double, Double) trapezoid()
        {
            Double c = b + a + ( 2 * Math.Sqrt( Math.Pow((b - a) / 2, 2) + Math.Pow(h, 2) ) );
            Double s = ((a + b) / 2 ) * h;
            return (c, s);
        }

    }
}
