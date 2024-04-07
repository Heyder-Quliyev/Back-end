using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack number = new Stack();
            number.Push(1);
            number.Push(2);
            number.Push(3);
            number.Push(4);
            number.Push(5);

            List<int> list = new List<int> { };
            list.Add(10);
            list.Add(50);

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            foreach (int i in list)
            {
                Console.WriteLine(i); 
            
            }

















            















        }
    }
}