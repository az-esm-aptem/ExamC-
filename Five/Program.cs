using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five
{
    class Program
    {
        static void NonRecFunc(int m, int n)
        {
            for (int i = m; i <= n; i++)
            {
                Console.WriteLine($"{i}{Math.Pow(2, i),10}{Math.Pow(3, i),10}");
            }
        }


        static void RecFunc(int m, int n)
        {
            if (m == n + 1) return;
            Console.WriteLine($"{m}{Math.Pow(2, m),10}{Math.Pow(3, m),10}");
            RecFunc(m + 1, n);
        }



        static void Main(string[] args)
        {
            int m;
            int n;

            Console.WriteLine("Input m: ");
            int.TryParse(Console.ReadLine(), out m);

            Console.WriteLine("Input m: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Answer non-rec: ");
            NonRecFunc(m, n);

            Console.WriteLine("Answer rec: ");
            RecFunc(m, n);
        }
    }
}

