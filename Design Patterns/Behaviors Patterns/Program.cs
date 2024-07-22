using Behaviors_Patterns.Chains_of_responsibility;
using Behaviors_Patterns.Command;
using Behaviors_Patterns.Command.Commands;
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


            var editor = new Editor();

            //Type some stuff
            editor.Type("This is the first sentence.");
            editor.Type("This is second.");

            // Save the state to restore to : This is the first sentence. This is second.
            editor.Save();

            //Type some more
            editor.Type("This is third.");

            //Output the content
            Console.WriteLine(editor.Content); // This is the first sentence. This is second. This is third.

            //Restoring to last saved state
            editor.Restore();

            Console.Write(editor.Content); // Th
        }
    }
}