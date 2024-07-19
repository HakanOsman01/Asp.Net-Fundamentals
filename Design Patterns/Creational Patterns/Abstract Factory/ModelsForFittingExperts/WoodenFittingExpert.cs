using Creational_Patterns.Abstract_Factory.Contracts;

namespace Creational_Patterns.Abstract_Factory.ModelsForFittingExperts
{
    public class WoodenFittingExpert : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit a wooden door!!!");
        }
    }
}
