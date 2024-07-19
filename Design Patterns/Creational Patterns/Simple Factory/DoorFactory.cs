using Creational_Patterns.Simple_Factory.Contracts;
using Creational_Patterns.Simple_Factory.Models;

namespace Creational_Patterns.Simple_Factory
{
    public static class IDoorFactory
    {
        public static IDoor CreateDoors(string type,int height, int width)
        {
            if (type == "wood")
            {
                return new WoodenDoor(height, width);
            }
            return null;

        }
    }
}
