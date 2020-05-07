using System;

namespace ByteBank.Systems
{
    internal class InternalSystem
    {
        public bool Login(IAuthenticable employee, string password)
        {
            bool authenticatedUser = employee.Authenticate(password);

            if (authenticatedUser)
            {
                Console.WriteLine("Welcome to the system!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect password!");
                return false;
            }
        }
    }
}
