using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six
{
    class Program
    {
        static void Filling(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
                Console.WriteLine(arr[i]);
            }
        }

        static int FindEven(int[] arr)
        {
            return Array.FindAll(arr, element => element % 2 == 0).Length;
        }

        static double Arithm(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum / arr.Length;
        }

        static double Geom(int[] arr)
        {
            int mul = 1;
            foreach (int i in Array.FindAll(arr, element=>element>0))
            {
                mul *= i;
            }
            return Math.Pow(mul, 1 / arr.Length);
        }


        static void Main(string[] args)
        {
            int[] arr = new int[25];
            Filling(arr);
            int evenNum = FindEven(arr);
            int oddNum = arr.Length - evenNum;
            Console.WriteLine($"Четных - {evenNum}, нечетных - {oddNum}");


            if (evenNum > oddNum)
                Console.WriteLine($"Среднее арифметическое: {Arithm(arr)}");
            else
                Console.WriteLine($"Среднее геометрическое: {Geom(arr)}");
        }
    }
}
