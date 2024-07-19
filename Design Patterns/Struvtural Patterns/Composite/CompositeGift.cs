

using Struvtural_Patterns.Composite.Contracts;

namespace Struvtural_Patterns.Composite
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private ICollection<GiftBase> gifts;
        public CompositeGift(string name, decimal price) 
            : base(name, price)
        {
            gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            this.gifts.Add(gift);
        }

        public override decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            Console.WriteLine($"{Name} contanis the following prices:");
            foreach (var gift in gifts)
            {
                totalPrice += gift.CalculateTotalPrice();
            }
            return totalPrice;
        }

        public void Remove(GiftBase gift)
        {
            this.gifts.Remove(gift);
        }
    }
}
