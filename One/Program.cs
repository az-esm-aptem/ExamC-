using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    class Program
    {

        static void Main(string[] args)
        {
            List<double> Y = new List<double>();
            for (double x = -5; x <= 15; x += 0.01)
            {
                Y.Add(3 * x * x * x - 15 * x * x - 12 * x + 8);
            }
            Console.WriteLine($"Минимальное значение - {Y.Min()}");
            Console.WriteLine($"Максимальное значение - {Y.Max()}");
        }
    }
}
