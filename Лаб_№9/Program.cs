using System;

namespace OP9
{
    class Program
    {
        static void Count(string str)
        {
            int count1 = 0;
            int count2 = 0;         
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i].Equals('('))
                {
                    count1++;

                    bool flag = true;
                    int j;
                    for (j = i; flag && j < str.Length; j++)
                    {
                        if (str[j].Equals(')'))
                        {
                            count2++;
                            flag = false;
                        }                     
                    }
                    str = str.Remove(j-1, 1).Insert(j-1, "0");
                }              
            }


            if (count2 == count1)
            {
                Console.WriteLine("The number of brackets is equal");
            }
            else
            {
                Console.WriteLine("The number of brackets is not equal");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string str = Console.ReadLine();
            Count(str);         
        }
    }
}
