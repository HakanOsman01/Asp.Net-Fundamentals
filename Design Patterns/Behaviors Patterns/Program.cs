using Behaviors_Patterns.Chains_of_responsibility;
using Behaviors_Patterns.Command;
using Behaviors_Patterns.Command.Commands;
using Behaviors_Patterns.State;
using Behaviors_Patterns.State.Contracts;
using Behaviors_Patterns.State.Models;
using Behaviors_Patterns.Strategy;
using Behaviors_Patterns.Strategy.Models;
using System.Linq.Expressions;

namespace Behaviors_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //      If paypal can't pay then bit coin
            var bank = new Bank(100);          // Bank with balance 100
            var paypal = new Paypal(200);      // Paypal with balance 200
            var bitcoin = new Bitcoin(300);    // Bitcoin with balance 300

            bank.SetNext(paypal);
            paypal.SetNext(bitcoin);

            // Let's try to pay using the first priority i.e. bank
            bank.Pay(259);

        }
    }
}