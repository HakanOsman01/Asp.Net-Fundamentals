using Struvtural_Patterns.Decorator.Contracts;

namespace Struvtural_Patterns.Decorator.Models
{
    public class SimpleCoffe : ICoffe
    {
        private const int CoffeiPrice = 5;

        public int GetCost
        {
            get
            {
                return CoffeiPrice;
            }
        }

        public string GetDescription()
        {
           return "Simple coffe with:";
        }
    }
}
