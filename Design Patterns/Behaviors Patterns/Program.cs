using Behaviors_Patterns.Chains_of_responsibility;
using Behaviors_Patterns.Command;
using Behaviors_Patterns.Command.Commands;
using Behaviors_Patterns.Mediator;
using Behaviors_Patterns.Memento;
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

            var mediator = new ChatRoom();

            var john = new User("John", mediator);
            var jane = new User("Jane", mediator);

            john.Send("Hi there!");
            jane.Send("Hey!");


        }
    }
}