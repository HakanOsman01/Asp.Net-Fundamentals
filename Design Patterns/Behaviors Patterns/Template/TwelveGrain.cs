using Behaviors_Patterns.Template.Contracts;

namespace Behaviors_Patterns.Template
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Gathing Ingrediants for 12-Grain Bread");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Baking the 12-Golden bread");
        }
    }
}
