using Creational_Patterns.Abstract_Factory.ModelsForFactory;
using Creational_Patterns.Builder;
using Creational_Patterns.Factory_Method;
using Creational_Patterns.Prototype;
using Creational_Patterns.Simple_Factory;
using Creational_Patterns.Singleton_Pattern;
using System.Security.Cryptography;

namespace Creational_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var woodenDoorFactory = new WoodenDoorFactory();

            var woodenDoor = woodenDoorFactory.MakeDoor(10,5,"Red");
            var woodenDoorFittingExpert = woodenDoorFactory.MakeFittingExpert();

            woodenDoor.GetDescription(); //Output : I am a wooden door
            woodenDoorFittingExpert.GetDescription();//Output : I can only fit woooden doors

            var ironDoorFactory = new IronDoorFactory();

            var ironDoor = ironDoorFactory.MakeDoor(12,18,"Blue");
            var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

            ironDoor.GetDescription();//Output : I am a iron door
            ironDoorFittingExpert.GetDescription();//Output : I can only fit iron doors


        }
    }
}