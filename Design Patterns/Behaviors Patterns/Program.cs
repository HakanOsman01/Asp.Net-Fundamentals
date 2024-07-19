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

           int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var soringStrategy = new SortClass<int>(new BubbleSortStrategy());
            var sorted = soringStrategy.SortCollection(array);
            Console.WriteLine(string.Join(' ',sorted));
            
            
            
        }
    }
}