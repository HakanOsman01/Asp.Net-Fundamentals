
using Creational_Patterns.Abstract_Factory.Contracts;

namespace Creational_Patterns.Abstract_Factory
{
    public interface IDoorFactory
    {
        IDoor MakeDoor(int height, int widht, string color);
        IDoorFittingExpert MakeFittingExpert();
    }
}
