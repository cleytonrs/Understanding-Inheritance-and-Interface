using System;

namespace ByteBank.Employee
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Creating DEVELOPER");
        }

        public override void IncreaseSalary()
        {
            Salary *= 0.15;
        }

        public override double GetBonus()
        {
            return Salary * 0.1;
        }
    }
}
