using System;

namespace ConsoleApp1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number ");
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Int32 i;
            Int32 j;
            Int32 a_minus = a;
            Int32 a_plus = a;    
            bool ne_proste1 = true;
            bool ne_proste2 = true;
            while ((ne_proste1) && (ne_proste2))
            {
                a_minus --;
                a_plus ++;
                i = 2;
                j = 2;
                ne_proste1 = false;
                ne_proste2 = false;
                while ((i < a_minus) && !(ne_proste1))
                {
                    if (a_minus % i == 0)
                    {
                        ne_proste1 = true;
                    }
                    else
                    {
                        ne_proste1 = false;
                    }
                    i++;            
                }
                while ((j < a_plus) && !(ne_proste2))
                {
                    if (a_plus % j == 0)
                    {
                        ne_proste2 = true;
                    }
                    else
                    {
                        ne_proste2 = false;
                    }
                    j++;
                }
            }
            if (ne_proste1 == false)
            {
                Console.WriteLine(a_minus + " is the nearest prime number");
            }
            else
            {
                Console.WriteLine(a_plus + " is the nearest prime number");
            }
        }
    }
}
