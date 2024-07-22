using Struvtural_Patterns.Adapter.Contracts;

namespace Struvtural_Patterns.Adapter
{
    public class AfricanLion : ILion
    {
        public bool IsDead { get;  set; }

        public void Roar()
        {
            Console.WriteLine($"Roar!!! I am {this.GetType().Name}");
        }
    }
}
