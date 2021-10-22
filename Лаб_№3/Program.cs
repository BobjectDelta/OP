using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 1;
            double sum = 0;
            double a;
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());
            a = Math.Pow(x, 2 * n) * Math.Sin(Math.Pow(x, n) / (n * n));        
            while ((n <= 10) || (Math.Abs(a) >= 0.0001))
            {
                Console.WriteLine(n);
                sum += a;
                n++;
                Console.WriteLine(a + " " + sum);           
                a = Math.Pow(x, 2 * n) * Math.Sin(Math.Pow(x, n) / (n * n));         
            }     
            Console.WriteLine(sum);
        }
    }
}
