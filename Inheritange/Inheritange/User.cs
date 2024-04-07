using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritange
{
    internal class User: Account
    {
        public User(string email, string password) : base(email, password)
        {
            
            

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool GmailChecker(string email)
        {
            throw new NotImplementedException();
        }

        public override bool PasswordChecker(string password)
        {
            //throw new NotImplementedException();

            bool isUpper = false;
            bool isLower = false;

            if(password.Length >= 8)
            {

                for(int i = 0; i < password.Length; i++)
                {

                    if (password[i] > 'A' && password[i] < 'Z')
                    {
                        isUpper = true;

                    }

                    else if (password[i] > 'a' && password[i] < 'z')
                    {
                        isLower = true;

                    }

                }


            }

            if(isUpper = true && isLower ==true)
            {
                return true;
            }

            return false;










        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
