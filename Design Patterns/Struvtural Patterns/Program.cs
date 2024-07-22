using Struvtural_Patterns.Adapter;
using Struvtural_Patterns.Decorator.Models;
using Struvtural_Patterns.FlyWeight;
using Struvtural_Patterns.Proxy;

namespace Struvtural_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var door = new SecureDoor(new LabDoor());
            for (int i = 0; i < 100; i++)
            {
                door.Open("fuck it!!!");


            }

        }
        
    }
}