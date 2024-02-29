using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Heyder", "498256", 24);
            Student student1 = new Student("Bill", "789634", 29);
            Student student2 = new Student("Kate", "159753", 51);
            Student student3 = new Student("Polina", "498256", 22);

            List<Student> students = new List<Student>();

            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            GetStudent("");


        }

        public static int GetStudent(string group, List<Student> list)
        {
            int count = 0;

            foreach (Student student in list)
            {
                if (group == student.GroupNo)
                {
                    count++;

                }



            }
            return count;

























        }


    }

    }
