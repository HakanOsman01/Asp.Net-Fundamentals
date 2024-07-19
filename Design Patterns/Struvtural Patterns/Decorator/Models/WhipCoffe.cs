using Struvtural_Patterns.Decorator.Contracts;

namespace Struvtural_Patterns.Decorator.Models
{
    public class WhipCoffe : ICoffe
    {
        private readonly ICoffe coffe;
        public WhipCoffe(ICoffe Coffee)
        {
            this.coffe = Coffee ?? throw new ArgumentNullException(nameof(Coffee));

        }

        public int GetCost
        {
            get
            {
                return coffe.GetCost+1;
            }
        }

        public string GetDescription()
        {
            return string.Concat(coffe.GetDescription(), " ,whip");
        }
    }
}
