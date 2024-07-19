using Creational_Patterns.Prototype.Contracts;
using Newtonsoft.Json;

namespace Creational_Patterns.Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private readonly string  bread;
        private readonly string meat;
        private readonly string cheese;
        private readonly string veggies;
        public Sandwich(string bread,string meat,string cheese,string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
            
        }
        public override SandwichPrototype Clone()
        {
            string ingredientsList = GetIngredients();
            Console.WriteLine("Cloning creating sadwich with ingredients {0}",ingredientsList);
            return MemberwiseClone() as SandwichPrototype;


        }

        public override SandwichPrototype DeepCopy()
        {
            return JsonConvert.DeserializeObject<SandwichPrototype>
                (JsonConvert.SerializeObject(this));
        }

        private string GetIngredients()
        {
            return $"{bread},{cheese},{meat},{veggies}";
        }
    }
}
