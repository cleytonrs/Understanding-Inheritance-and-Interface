namespace ByteBank.Employee
{
    internal class BonusManager
    {
        private double _totalBonus;
        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}
