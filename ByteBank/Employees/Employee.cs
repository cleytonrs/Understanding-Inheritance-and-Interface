using System;

namespace ByteBank.Employee
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }
        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Salary { get; protected set; }

        public Employee(double salary, string cpf)
        {
            CPF = cpf;
            Salary = salary;
            TotalEmployees++;
            //Console.WriteLine("Creating EMPLOYEE");
        }

        public abstract void IncreaseSalary();

        public abstract double GetBonus();

    }
}
