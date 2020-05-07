using ByteBank.Employee;
using ByteBank.Systems;
using System;

namespace ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UseSystem();
            Console.WriteLine("\n----------------------------------");
            CalculateBonus();
            Console.ReadLine();
        }

        public static void UseSystem()
        {
            InternalSystem system = new InternalSystem();

            Console.WriteLine("Employees to test login\n");

            Director Account1 = new Director("159.753.398-04");
            Account1.Name = "Roberta Fierro";
            Account1.Password = "123";

            AccountManager Account2 = new AccountManager("326.985.628-89");
            Account2.Name = "Camila Caballo";
            Account2.Password = "abc";

            CommercialPartner Account3 = new CommercialPartner();
            Account3.Password = "456";

            Console.WriteLine("\nLogin status\n");

            system.Login(Account1, "123");
            system.Login(Account2, "abcd");
            system.Login(Account3, "456");
        }

        public static void CalculateBonus()
        {
            BonusManager bonusManager = new BonusManager();

            Console.WriteLine("\nEmployees to calculate bonuses\n");

            Designer Banban = new Designer("833.222.048-39");
            Banban.Name = "Banban Flinston";

            Director Roberta = new Director("159.753.398-04");
            Roberta.Name = "Roberta Santos";

            AdministrativeAssistant Ana = new AdministrativeAssistant("981.198.778-53");
            Ana.Name = "Ana Maria";

            AccountManager Camila = new AccountManager("326.985.628-89");
            Camila.Name = "Camila Castro";

            Developer Barbara = new Developer("465.132.465-78");
            Barbara.Name = "Barbara Moura";

            bonusManager.Register(Barbara);
            bonusManager.Register(Banban);
            bonusManager.Register(Roberta);
            bonusManager.Register(Ana);
            bonusManager.Register(Camila);

            Console.WriteLine("\nTotal bonuses of the month: R$ " + bonusManager.GetTotalBonus());
        }
    }
}
