using System;

namespace ConsoleApp5
{
    class Program
    {
        static double x;
        static double e;
        static double arctgx;
        static void Tailor()
        {
            arctgx = x;
            double elem = x;
            double y = x;
            for (int i = 2; Math.Abs(elem) > e; i += 2)
            {
                elem = (-elem * x * x) / (i + 1);
                y += elem;
            }         
            if (x > 1)
            {
                elem = x - 5;
                for (int i = 2; Math.Abs(elem) > e; i += 2)
                {
                    elem = (-elem * (x-5) * (x-5)) / (i + 1);
                    arctgx += elem;
                }
                y = y / arctgx;
                Console.WriteLine(y);
            }
            if (x >= 0 && x <= 1)
            {
                elem = 2*x;
                for (int i = 2; Math.Abs(elem) > e; i += 2)
                {
                    elem = (-elem * 4 * x * x) / (i + 1);
                    arctgx += elem;
                }
                y = y / arctgx;
                Console.WriteLine(y);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x (>=0): ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter e (>0 and <1):");
            e = Convert.ToDouble(Console.ReadLine());
            Tailor();
        }
    }
}
