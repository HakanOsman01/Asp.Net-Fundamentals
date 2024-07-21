using Struvtural_Patterns.Decorator.Models;
using Struvtural_Patterns.FlyWeight;

namespace Struvtural_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teaMaker = new TeaMaker();
            var teaShop = new TeaShop(teaMaker);

            teaShop.TakeOrder("less sugar", 1);
            teaShop.TakeOrder("more milk", 2);
            teaShop.TakeOrder("without sugar", 5);

            teaShop.Serve();



        }
        
    }
}