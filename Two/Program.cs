using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two
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

        static double Arithm(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum / arr.Length;
        }


        static int MaxDeltaEl(int[] arr, double arithm)
        {
            double delta = 0;
            int element = arr[0];
            double deltaCurrent;
            foreach (int i in arr)
            {
                deltaCurrent = Math.Abs(i - arithm);
                if (deltaCurrent > delta)
                {
                    delta = deltaCurrent;
                    element = i;
                }
                    
            }
            return element;
        }

        

        static void Main(string[] args)
        {
            int[] arr = new int[25];
            Filling(arr);
            double arithm = Arithm(arr);
            Console.WriteLine($"Среднее арифметическое - {arithm}, Наиболее удаленное от среднего арифметического - {MaxDeltaEl(arr, arithm)}");
        }
    }
}
