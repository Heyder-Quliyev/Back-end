using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Car : IVehiculo
    {
        public int Fuel { get; set; }
        public Car(int benzin)
        {
            Fuel = benzin;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("car is driving");
            }
            else
            {
                Console.WriteLine("no fuel");
            }
        }

        public bool Rafuel(int benzin)
        {
            Fuel += benzin;
            return true;

        }
    }
}