using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>();

            Car car1 = new Car("Ferrari", "Portofino", 1200, 365, 2022);
            Car car2 = new Car("Ferrari", "Spider 458", 1090, 330, 2018);
            Car car3 = new Car("lamborghini", "Aventador", 1280, 402, 2023);
            Car car4 = new Car("lamborghini", "Huracan", 1285, 405, 2021);
            Car car5 = new Car("Bugatti", "Chiron", 1480, 440, 2020);
            Car car6 = new Car("Bugatti", "La Voiture Noire", 1600, 488, 2019);

            car.Add(car1);
            car.Add(car2);
            car.Add(car3);
            car.Add(car4);
            car.Add(car5);
            car.Add(car6);

            bool exit = true;

            while (exit)
            {
                Console.WriteLine("1. Add new car");
                Console.WriteLine("2. All car list");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Edit");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Select option");
                char operation = Convert.ToChar(Console.ReadLine());


                switch (operation)
                {
                    case '1':

                        Console.WriteLine("How many cars will be added?");
                        int count = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Brand of car");
                            string carBrand = Console.ReadLine();

                            Console.WriteLine("Model");
                            string carModel = Console.ReadLine();

                            Console.WriteLine("Horspower");
                            int carHorsPower = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Max speed (only: Km/h)");
                            int carSpeed = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Year of production");
                            int year = Convert.ToInt32(Console.ReadLine());

                            Car cr = new Car(carBrand, carModel, carHorsPower, carSpeed, year);
                            car.Add(cr);
                            Console.WriteLine((i + 1) + ".Car Add");
                        }
                        break;


                    case '2':
                        foreach( var item in car)
                        {

                            Console.WriteLine("\nBrand: "+ item.carBrand + "\nModel: " + item.carModel + "\nHorspower: " + item.carHorsPower + "\nSpeed: " + item.carSpeed + "\nYear: " + item.Year );
                        }
                        break;

                    case '3':
                        bool bo = true;
                        Console.WriteLine("Delete Now");
                        string removeCar = Console.ReadLine();
                        foreach(var item in car)
                        {
                            if(item.carModel == removeCar)
                            {
                                car.Remove(item);
                                Console.WriteLine("Deleted");
                                bo = false;
                                break;
                            }
                        }
                        break;

                    case '4':
                        bool boolFound = false;
                        Console.WriteLine("Please, edit");
                        string editName = Console.ReadLine();
                        foreach( var item in car)
                        {
                            if(item.carBrand == editName)
                            {
                                Console.WriteLine("Add new brand");
                                string newBrand = Console.ReadLine();
                                item.carBrand = newBrand;
                                Console.WriteLine("new brand "+ item.carBrand);

                                Console.WriteLine("Add new model");
                                string newModel = Console.ReadLine();
                                item.carModel = newModel;
                                Console.WriteLine("new model"+ item.carModel);

                                Console.WriteLine("Add engine power");
                                int newHorsPower =Convert.ToInt32(Console.ReadLine());
                                item.carHorsPower = newHorsPower;
                                Console.WriteLine("hors power"+  newHorsPower);

                                Console.WriteLine("Add vehicle speed");
                                int newSpeed = Convert.ToInt32(Console.ReadLine());
                                item.carSpeed = newSpeed;
                                Console.WriteLine("new speed"+ newSpeed);

                                boolFound = true;
                                break;
                            }
                        }
                        break;

                    case '5':
                        exit = false;
                        Console.WriteLine("Exited");
                        break;
                }
            }
        }
    }
}