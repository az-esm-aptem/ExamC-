using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight
{
    public class Car : Vehicle
    {
        public string Model { get; private set; }
        public Car(double speed, double deterioration, double mileage, string model) : base(speed, deterioration, mileage)
        {
            Model = model;
        }

        public override void Repair()
        {
            Deterioration = Deterioration * 0.5;
            Milege = Milege * 0.5;
        }
    }
}
