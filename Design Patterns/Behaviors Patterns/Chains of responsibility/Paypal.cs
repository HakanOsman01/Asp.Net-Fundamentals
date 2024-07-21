namespace Behaviors_Patterns.Chains_of_responsibility
{
    public class Paypal : Account
    {
        public Paypal(decimal balance)
        {
            this.balance = balance;
        }
    }
}
