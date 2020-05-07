using System;


namespace ByteBank.Employee
{
    public class Director : AuthenticEmployee
    {
        public Director(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Creating DIRECTOR");
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }

        public override double GetBonus()
        {
            return Salary * 0.5;
        }
    }
}
