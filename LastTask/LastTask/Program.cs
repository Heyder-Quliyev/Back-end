using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LastTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList car = new ArrayList();
            car.Add(new { Name = "Heydar", Surname = "Hasanov", age = "24", graduate = "Bachelor"});

            //Console.WriteLine($"I’m {Name + Surname}, I am a teacher.");


            Console.WriteLine($"Hello {Name + Surname}, I am a developer");




        }
        class student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }
            public Program(string Name, string Surname)
            {
            Name = Name;
            Surname = Surname;
            }
        

    }
}