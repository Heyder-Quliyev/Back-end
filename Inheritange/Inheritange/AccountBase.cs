namespace Inheritange
{
    internal abstract class AccountBase
    {


        public abstract bool GmailChecker(string email)

        {
            bool result = email.Contains('@');
            bool result = false;

            return result;
        }
    }
}