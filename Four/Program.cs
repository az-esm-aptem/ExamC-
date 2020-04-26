using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four
{

    
    class Program
    {
        static void Filling(int[] arr)
        {
            bool success = false;
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    Console.Write($"Введите элемент (int) {i,3}:  "); ;
                    success = int.TryParse(Console.ReadLine(), out arr[i]);
                }
                while (!success);
            }
        }

        static void Prnt(int[] arr)
        {
            Console.WriteLine("Array");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void PositiveElements(int[] arr, out double geom, out int min)
        {
            int mul = 1;
            foreach (int i in Array.FindAll(arr, element => element > 0))
            {
                mul *= i;
            }
            geom = Math.Pow(mul, 1 / arr.Length);

            min = Array.FindAll(arr, element => element > 0).Min();
        }


        static void NegativeElements(int[] arr, out int sum, out int max)
        {
            sum = 0;
            foreach (int i in Array.FindAll(arr, element => element < 0))
            {
                sum += i;
            }
            max = Array.FindAll(arr, element => element < 0).Max();
        }


        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Filling(arr);
            Prnt(arr);
            PositiveElements(arr, out double geom, out int min);
            NegativeElements(arr, out int sum, out int max);
            Console.WriteLine($"Положительные числа. Среднее геометрическое - {geom}, минимальное - {min}");
            Console.WriteLine($"Отрицательные числа. Сумма - {sum}, максимальное - {max}");
        }
    }
}
