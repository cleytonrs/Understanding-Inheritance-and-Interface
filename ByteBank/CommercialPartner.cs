
using ByteBank.Systems;
using System;

namespace ByteBank
{
    public class CommercialPartner : IAuthenticable
    {
        public CommercialPartner()
        {
            Console.WriteLine("Creating COMMERCIAL PARTNER");
        }
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
