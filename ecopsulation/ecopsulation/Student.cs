using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecopsulation
{
    internal class Student : SchoolPerson
    {
        public override void GoToClasses() 
        {
            Console.WriteLine($"I'm {Name + Surname}, I am student and I'm going to class.");

        }
    }
}
