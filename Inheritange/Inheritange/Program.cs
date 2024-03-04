using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please, add your name");
            string name = Console.ReadLine();

            Console.WriteLine("please, add your email");
            string gmail = Console.ReadLine();


            Console.WriteLine("please, add your password");
            string password = Console.ReadLine();


            User user = new User("Heyder Quliyev", "heyderquliyev@gmail.com");
            user.FullName = name;
            user.ShowInfo();
            Console.WriteLine(user.Password);












        }
    }
}