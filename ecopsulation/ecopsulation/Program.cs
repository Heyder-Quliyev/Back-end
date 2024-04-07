using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecopsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolPerson teacher = new SchoolPerson();
            teacher.Name="Heyder ";
            teacher.Surname="Quliyev";

            teacher.Age = 30;
            teacher.Greek();
            teacher.GoToClasses();


            SchoolPerson student = new SchoolPerson();
            student.Name = "Bill ";
            student.Surname = "Jackson";
            student.GoToClasses();



        }
    }
}
