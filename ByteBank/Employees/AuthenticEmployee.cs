
using ByteBank.Systems;

namespace ByteBank.Employee
{
    public abstract class AuthenticEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }
        public AuthenticEmployee(double salary, string cpf) : base(salary, cpf)
        {

        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
