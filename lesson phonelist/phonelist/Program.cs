using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonelist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList phone = new ArrayList();
            phone.Add(new { name = " ", model = " ", storage = " ", version = " " });
            bool exit = true;

            while (exit)
            {

                Console.WriteLine("1- Add New Phone");
                Console.WriteLine("2- Phone List");
                Console.WriteLine("3- Delete Old Phone");
                Console.WriteLine("4- Search Phone");
                Console.WriteLine("5- Update");
                Console.WriteLine("6- Exit");

                Console.WriteLine("Please, Select Option");
                char operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '1':
                        Console.WriteLine("How many phones do you want to add?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {

                            Console.WriteLine("phone name: ");
                            string phoneName = Console.ReadLine();
                            Console.WriteLine("Phone model: ");
                            string phoneModel = Console.ReadLine();
                            Console.WriteLine("ios/android version: ");
                            string phoneVersion = Console.ReadLine();
                            Console.WriteLine("charge life: ");
                            string phoneChargeLife = Console.ReadLine();
                            Console.WriteLine("camera features: ");
                            string phoneCamera = Console.ReadLine();
                        }

                        break;

                    case '2':

                        foreach (dynamic item in phone)
                        {
                            Console.WriteLine("name" + item.name, "\n model" + item.model, "\n version" + item.version, "\n camera" + item.camera + "\n");
                        }
                        break;

                    case '3':

                        bool find = false;
                        Console.WriteLine("please, enter phone name");
                        string name = Console.ReadLine();
                        foreach (dynamic item in phone)
                        {
                            if (item.name == name)
                            {
                                phone.Remove(item);
                                find = true;
                                Console.WriteLine("Delete Phone");
                                break;
                            }
                        }
                        if (!find)
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;

                    case '4':

                        bool search = false;
                        Console.WriteLine("Search Phone");
                        string search_phone = Console.ReadLine();

                        foreach (dynamic item in phone)
                        {
                            if (item.name == search_phone)
                            {
                                find = true;
                                Console.WriteLine("name" + item.name, "\n model" + item.model, "\n version" + item.version, "\n camera" + item.camera + "\n");

                                if (!find)
                                {
                                    Console.WriteLine("Not Found!");
                                }
                            }
                        }
                        break;

                    case '5':

                        bool boolFound = false;
                        Console.WriteLine("Please, edit");
                        string editModel = Console.ReadLine();

                        foreach (dynamic item in phone)
                        {
                            if (item.name == editModel)
                            {
                                Console.WriteLine("Please, enter new name");
                                string newName = Console.ReadLine();
                                item.name = newName;
                                Console.WriteLine("new name: " + item.name);

                                Console.WriteLine("Please, add new gender");
                                string newModel = Console.ReadLine();
                                item.studentGender = newModel;
                                Console.WriteLine("new gender: " + item.phoneModel);

                                Console.WriteLine("Please new age");
                                int newVersion = Convert.ToInt32(Console.ReadLine());
                                item.version = newVersion;
                                Console.WriteLine("new age: " + item.phoneVersion);

                                Console.WriteLine("Please, add new number");
                                string newCamera = Console.ReadLine();
                                item.camera = newCamera;
                                Console.WriteLine("new nuber: " + item.phoneCamera);

                                boolFound = true;
                                break;
                            }
                        }
                        if (!boolFound)
                        {
                            Console.WriteLine("not found");
                        }
                        break;

                    case '6':

                        exit = false;
                        Console.WriteLine("Exited");

                        break;
                }

            }
        }
    }
}