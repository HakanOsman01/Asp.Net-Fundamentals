using Creational_Patterns.Abstract_Factory.Contracts;

namespace Creational_Patterns.Abstract_Factory.ModelsForDoors
{
    public class IronDoor : IDoor
    {
        public IronDoor(int height,int widht,string color)
        {
            Height = height;
            Widht = widht;
            Color = color;
            
        }
        public int Widht { get;private set; }

        public int Height { get; private set; }

        public string Color { get; private set; }

        public void GetDescription()
        {
            Console.WriteLine($"I am Iron door width: {this.Widht} " +
                $"and height: {this.Height} and color: {this.Color}");
        }
    }
}
