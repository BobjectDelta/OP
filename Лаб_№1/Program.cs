using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first cathetus");
            double cathetus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the hypotenuse");
            double hypotenuse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The second cathetus is " + (Math.Sqrt(Math.Pow(hypotenuse,2) - Math.Pow(cathetus,2))));
            Console.ReadKey();



        }
    }
}
