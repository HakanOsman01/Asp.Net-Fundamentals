namespace Behaviors_Patterns.Chains_of_responsibility
{
    public abstract class Account
    {
        private Account successor;
        protected decimal balance;

        public void SetNext(Account account)
        {
            successor = account;
        }

        public void Pay(decimal amountTopay)
        {
            if (CanPay(amountTopay))
            {
                Console.WriteLine($"Paid {amountTopay:c} using {this.GetType().Name}.");
            }
            else if (this.successor != null)
            {
                Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding..");
                successor.Pay(amountTopay);
            }
            else
            {
                throw new Exception("None of the accounts have enough balance");
            }
        }
        private bool CanPay(decimal amount)
        {
            return balance >= amount;
        }

    }
}
