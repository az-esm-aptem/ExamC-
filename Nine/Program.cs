using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nine
{
    class Program
    {
        static void Input(int[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int cols = arr.Length / rows;
            Console.WriteLine($"Rows - {rows}, Columns - {cols}");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Строка {i}");
                for (int j = 0; j < cols; j++)
                {
                    bool success = false;
                    try
                    {
                        do
                        {
                            int tmp = int.Parse(Console.ReadLine());
                            if (tmp > 9 && tmp < 100)
                            {
                                arr[i, j] = tmp;
                                success = true;
                            }
                            else
                            {
                                Console.WriteLine("Only 2-digits non-negative values");
                            }
                        }
                        while (!success);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}    Only int values are available!");
                        arr[i, j] = -1;
                    }
                    
                }
            }
        }

        static void Prnt(int[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int cols = arr.Length / rows;
            Console.WriteLine("Matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Input(arr);
            Prnt(arr);


        }
    }
}
