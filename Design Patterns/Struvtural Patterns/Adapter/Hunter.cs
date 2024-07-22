using Struvtural_Patterns.Adapter.Contracts;

namespace Struvtural_Patterns.Adapter
{
    public class Hunter
    {
        public void Hunt(ILion lion)
        {
            lion.IsDead = true;
            Console.WriteLine("The lion is dead!!!"); 
        }
    }
}
