using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject
{
    internal class Car
    {


        public static List<Car> car = new List<Car>();

        public Car(string brand, string model, int horspower, int speed, int year)
        {
            carBrand = brand;
            carModel = model;
            carHorsPower = horspower;
            carSpeed = speed;
            Year = year;

        }



        public string carBrand { get; set; }
        public string carModel { get; set; }
        public int carHorsPower { get; set; }
        public int carSpeed { get; set; }
        public int Year { get; set; }











    }
}
