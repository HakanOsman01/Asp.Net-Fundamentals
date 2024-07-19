using Creational_Patterns.Abstract_Factory.Contracts;

namespace Creational_Patterns.Abstract_Factory.ModelsForDoors
{
    public class WoodenDoor : IDoor
    {
        public WoodenDoor(int widht,int height,string color)
        {
            this.Widht = widht;
            this.Height = height;
            this.Color = color;
        }
        public int Widht { get;private set; }

        public int Height { get;private set; }

        public string Color { get;private set; }

        public void GetDescription()
        {
            Console.WriteLine($"I am wooden door width: {this.Widht} " +
                $"and height: {this.Height} and color: {this.Color}");
        }
    }
}
