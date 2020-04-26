using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven
{
    class Program
    {
        static void Input(out double cash, out double percent, out int period)
        {
            bool success = false;
            do
            {
                Console.Write($"Введите сумму: ");
                success = double.TryParse(Console.ReadLine(), out cash);
            }
            while (!success);

            success = false;
            do
            {
                Console.Write($"Введите годовую прцентную ставку: ");
                success = double.TryParse(Console.ReadLine(), out percent);
            }
            while (!success);

            success = false;
            do
            {
                Console.Write($"Введите срок вложения в годах: ");
                success = int.TryParse(Console.ReadLine(), out period);
            }
            while (!success);
        }

        static double Calculation(double cash, double percent, double period)
        {
            double profit = cash;
            for (int i = 1; i <= period; i++)
            {
                profit = profit * (1 + percent / 100);
            }
            return profit;
        }


        static void Main(string[] args)
        {
            Input(out double cash, out double percent, out int period);
            Console.WriteLine($"Будущая стоимость - {Calculation(cash, percent, period)}");
        }
    }
}
