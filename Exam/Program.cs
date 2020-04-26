using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void NonRecFunc(int m, int n)
        {
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine(i);
            }
        }


        static void RecFunc(int m, int n)
        {
            //int i = m;
            if (m == n+1) return;
            if (m % 2 == 0 && m % 3 == 0)
                Console.WriteLine(m);
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
