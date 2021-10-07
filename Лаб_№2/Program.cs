using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string count;
            Console.WriteLine("Enter a1 and a2");
            Int32 a1 = Convert.ToInt32(Console.ReadLine());
            Int32 a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1 and b2");
            Int32 b1 = Convert.ToInt32(Console.ReadLine());
            Int32 b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c1 and c2");
            Int32 c1 = Convert.ToInt32(Console.ReadLine());
            Int32 c2 = Convert.ToInt32(Console.ReadLine());
            Int32 det = a1 * b2 - b1 * a2;
            Int32 det1 = c1 * b2 - b1 * c2;
            Int32 det2 = a1 * c2 - c1 * a2;
            if (det != 0)
            {
              count = "1";
            }
            else
            {
                if ((det1 == 0) && (det2 == 0))
                {
                    count = "Infinity";

                }
                else
                {
                    count = "0";
                }
            }
            Console.WriteLine(count);
        }
    }
}
