using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ecopsulation
{
    internal class SchoolPerson
    {
  
            public string Name { get; set; }
            public string Surname { get; set; }
        private int _age;
            public int Age
        {
            get { return _age; }  //cagirilan zaman qaytaracaq-------------

            set   //deyeri yoxlayib menimsedecek----
            {
                try
                {
                    if(20<Age && Age<50)
                    _age = value;

                    else if(20>Age && Age>50)
                    {
                        Console.WriteLine("false");
                    }

                }
                catch (Exception)
                {
                    //throw new ArgumentException("Email is not valid");
                }
            }
        } 
            public int DateofBirth { get; set; }


            public void Greek()
            {
             Console.WriteLine("Hello " + Name + Surname);
            }
        public virtual void GoToClasses() /*: base(name, surname, age, brithday)*/
        {
            Console.WriteLine("Inside Base GoToClasses method"/*$"I'm {Name + Surname}, I am student and I'm going to class."*/);
        }

        }
   







}