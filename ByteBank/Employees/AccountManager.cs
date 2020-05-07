
using System;

namespace ByteBank.Employee
{
    internal class AccountManager : AuthenticEmployee
    {
        public AccountManager(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Creating ACCOUNT MANAGER");
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }

        public override double GetBonus()
        {
            return Salary * 0.25;
        }
    }
}
