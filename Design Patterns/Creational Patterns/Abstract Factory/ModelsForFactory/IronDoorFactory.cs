using Creational_Patterns.Abstract_Factory.Contracts;
using Creational_Patterns.Abstract_Factory.ModelsForDoors;
using Creational_Patterns.Abstract_Factory.ModelsForFittingExperts;

namespace Creational_Patterns.Abstract_Factory.ModelsForFactory
{
    public class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor(int height,int widht,string color)
        {
            return new IronDoor(height,widht,color);
        }

     
        public IDoorFittingExpert MakeFittingExpert()
        {
            return new IronDoorFittingExpert();
        }
    }
}
