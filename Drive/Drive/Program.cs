using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(10);
            Car car2 = new Car(0);
            car1.Drive();
            car2.Drive();
            Console.WriteLine("Car2:" + car2.Fuel);
            //car2
            car2.Rafuel(20);
            Console.WriteLine("Car2:" + car2.Fuel);
            car2.Drive();
            Console.WriteLine("Car1:" + car1.Fuel);

            //car1
            car1.Rafuel(30);
            Console.WriteLine("Car1:" + car1.Fuel);



        }
    }
}