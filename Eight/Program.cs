using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(150, 10, 1000);
            Car volvo = new Car(220, 5, 500, "Volvo");
            vehicle.ShowInfo();
            volvo.ShowInfo();
            vehicle.Repair();
            volvo.Repair();
            vehicle.ShowInfo();
            volvo.ShowInfo();
        }
    }
}
