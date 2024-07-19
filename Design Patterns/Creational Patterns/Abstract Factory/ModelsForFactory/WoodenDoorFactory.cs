using Creational_Patterns.Abstract_Factory.Contracts;
using Creational_Patterns.Abstract_Factory.ModelsForDoors;
using Creational_Patterns.Abstract_Factory.ModelsForFittingExperts;

namespace Creational_Patterns.Abstract_Factory.ModelsForFactory
{
    public class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor(int height, int widht, string color)
        {
            return new WoodenDoor(height, widht, color);
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new WoodenFittingExpert();
        }
    }
}
