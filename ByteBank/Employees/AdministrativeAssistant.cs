using System;

namespace ByteBank.Employee
{
    internal class AdministrativeAssistant : Employee
    {
        public AdministrativeAssistant(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Creating ADMINISTRATIVE ASSISTANT");
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        public override double GetBonus()
        {
            return Salary * 0.2;
        }
    }
}
