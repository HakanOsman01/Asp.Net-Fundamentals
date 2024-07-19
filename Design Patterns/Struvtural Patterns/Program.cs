using Struvtural_Patterns.Composite;
using Struvtural_Patterns.Composite.Shapes;
using Struvtural_Patterns.Decorator.Models;
using Struvtural_Patterns.Facade;

namespace Struvtural_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCoffee = new SimpleCoffe();
            Console.WriteLine($"{myCoffee.GetCost:c}"); // $ 5.00
            Console.WriteLine(myCoffee.GetDescription()); // Simple Coffee

            var milkCoffee = new MilkCoffe(myCoffee);
            Console.WriteLine($"{milkCoffee.GetCost:c}"); // $ 6.00
            Console.WriteLine(milkCoffee.GetDescription()); // Simple Coffee, milk

            var whipCoffee = new WhipCoffe(milkCoffee);
            Console.WriteLine($"{whipCoffee.GetCost:c}"); // $ 7.00
            Console.WriteLine(whipCoffee.GetDescription()); // Simple Coffee, milk, whip

            var vanillaCoffee = new VanilaCoffe(whipCoffee);
            Console.WriteLine($"{vanillaCoffee.GetCost:c}"); // $ 8.00
            Console.WriteLine(vanillaCoffee.GetDescription()); // Simple Coffee, milk, whip, vanilla

        }
    }
}