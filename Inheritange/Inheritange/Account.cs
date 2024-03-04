using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritange
{
    internal abstract class Account
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Account(string email, string password)
        {

            Email = email;
            if(PasswordChecker(password) && GmailChecker(email))
            {
                Password = password;

            }
            else
            {
                Console.WriteLine("try again -- incorrect password");
            }

        }


        public abstract bool GmailChecker(string email)

        {
           bool result = email.Contains('@');
            bool result = false;

            return result;
        }



        public abstract bool PasswordChecker( string password);

        public virtual void ShowInfo()
        {
            Console.WriteLine( "Full Name: " + FullName);
            Console.WriteLine("Email: " + Email);

        }



















    }
}
