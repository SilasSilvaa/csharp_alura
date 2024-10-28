
namespace ByteBankIO
{
    public class CurrentAccount
    {
        public int Number { get; }
        public int Agency { get; }
        public double Balance { get; private set; }
        public Client Owner { get; set; }

        public CurrentAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor de deposito deve ser maior que zero.", nameof(value));
            }

            Balance += value;
        }

        public void Withdrawn(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que zero.", nameof(value));
            }

            if (value > Balance)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Balance += value;
        }


    }
}
