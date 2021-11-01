using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = 0;
            double v1 = 1.5;
            double v2 = 0;
            double v3 = 0;
            Int32 n = Convert.ToInt32(Console.ReadLine());
            for (double i = 4; i <= n; i++)
            {
                v = (i + 1)/(i * i + 1) * v1 - v2 * v3;
                v3 = v2;
                v2 = v1;
                v1 = v;
            }
            Console.WriteLine(v);
        }   
        
        
    }
}
