using Behaviors_Patterns.Template.Contracts;

namespace Behaviors_Patterns.Template
{
    public class Sourdough : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Bake for sourDough");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mix ingredients for sourdough bread.");
        }
    }
}
