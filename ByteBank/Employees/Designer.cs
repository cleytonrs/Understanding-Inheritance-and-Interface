using System;

namespace ByteBank.Employee
{
    internal class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Creating DESIGNER");
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }

        public override double GetBonus()
        {
            return Salary * 0.17;
        }
    }
}
