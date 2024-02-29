using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Student
    {
        List<Student> students = new List<Student>();

        public string FullName { get; set; }
        public int Age { get; set; }
        public string GroupNo { get; set; }



        public Student(string name, string number, int age)

        {

            FullName = name;
            Age = age;
            GroupNo = number;

        }


        public int GetBrithYear()

        {
            return Age;

        }
    }






    internal class Account
    {
        public int No;

        public string userName;
        public string password;


        int no = 1;

        public Account(string userName, string password)
        {
            userName = userName;
            password = password;


            No = no;
            no++;
        }























    }
}