using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ecopsulation
{
    internal class Teacher : SchoolPerson
    {
        private string _subject;
        public string Subject { get; set; }
        public void Greek()
        {
            Console.WriteLine("Hello " + Name + Surname);
        }

        public void Explain()
        {
            Console.WriteLine($"Explanation begin on subject {Subject}");
        }

        public override void GoToClasses()
        {
            Console.WriteLine($"I’m {Name + Surname}, I am a teacher.");

        }





    }
}
