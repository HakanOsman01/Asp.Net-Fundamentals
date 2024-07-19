using Struvtural_Patterns.Decorator.Contracts;

namespace Struvtural_Patterns.Decorator.Models
{
    public class VanilaCoffe : ICoffe
    {
        private readonly ICoffe coffe;
        public VanilaCoffe(ICoffe _coffe)
        {

            this.coffe = _coffe ??
                throw new ArgumentNullException(nameof(coffe), "Cannot be null!");
        }

        public int GetCost
        {
            get
            {
                return this.coffe.GetCost+10;
            }
        }

        public string GetDescription()
        {
            return string.Concat(coffe.GetDescription(), " ,vanilia");
        }
    }
}
