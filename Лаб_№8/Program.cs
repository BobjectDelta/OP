using System;

namespace OP8
{
    class Program
    {
        static void ArrayFill(int [,] array)
        {
            Random rand = new Random();
            for (int i = 0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j<array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-20, 50);
                }
            }
        }

        static void PrintArray(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,5}", array[i, j]));
                }
                Console.WriteLine();
            }
        }

        static int Max(int[,] array)
        {
            int del_j = 1;            
            int max = array[0,del_j];
            for (int i = 0; i < array.GetLength(0)-1; i++)
            {                            
                for (int j = 0; j < array.GetLength(1); j++)
                {                  
                    if (i<j)
                    {
                        if (max <= array[i,j])
                        {
                            max = array[i, j];                         
                            del_j = j;
                        }
                    }
                }
            }
            return (del_j);
        }

        static void Del(int[,] array, int[,] array1, int del_j)
        {
            for (int i = 0; i<array.GetLength(0); i++)
            {
                for (int j = del_j; j < array.GetLength(1)-1; j++)
                {
                    array[i, j] = array[i, j + 1];
                }
            }
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = array[i, j];
                }
            }
        }
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter size of matrix n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size of matrix m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            int[,] array1 = new int[n, m - 1];

            ArrayFill(array);       
            PrintArray(array);
            Console.WriteLine();
            Del(array,array1, Max(array));
            PrintArray(array1);

        }
    }
}
