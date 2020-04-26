using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight
{
    public class Vehicle
    {
        public double MaxSpeed { get; private protected set; }
        public double Deterioration { get; private protected set; }
        public double Milege { get; private protected set; }

        public Vehicle(double speed, double deterioration, double mileage)
        {
            MaxSpeed = speed;
            Deterioration = deterioration;
            Milege = mileage;
        }

        private Vehicle() { }

        public virtual void Repair()
        {
            Deterioration = 0.0;
            Milege = 0.0;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Максимальная скорость - {MaxSpeed}, Износ - {Deterioration}, Пробег - {Milege}");
        }
    }
}
