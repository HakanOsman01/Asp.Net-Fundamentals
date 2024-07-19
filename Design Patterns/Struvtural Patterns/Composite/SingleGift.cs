using Struvtural_Patterns.Composite.Contracts;

namespace Struvtural_Patterns.Composite
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, decimal price) 
            : base(name, price)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} with the {Price}");
            return Price;
        }
    }
}
