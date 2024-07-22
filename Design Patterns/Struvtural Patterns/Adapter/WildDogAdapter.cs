using Struvtural_Patterns.Adapter.Contracts;

namespace Struvtural_Patterns.Adapter
{
    public class WildDogAdapter : ILion
    {
        private WildDog wildDog;
        public WildDogAdapter(WildDog wildDog)
        {
            this.wildDog = wildDog;
        }
        public bool IsDead { get ; set; }

        public void Roar()
        {
            wildDog.Bark();
        }
    }
}
