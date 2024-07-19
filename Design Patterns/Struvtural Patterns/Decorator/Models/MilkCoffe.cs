using Struvtural_Patterns.Decorator.Contracts;

namespace Struvtural_Patterns.Decorator.Models
{
    public class MilkCoffe : ICoffe
    {
        private readonly ICoffe coffe;
        public MilkCoffe(ICoffe _coffe)
        {
            this.coffe=_coffe  ?? 
                throw new ArgumentNullException(nameof(coffe),"Cannot be null!");
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
            return string.Concat(coffe.GetDescription()," ,milk");
        }
    }
}
