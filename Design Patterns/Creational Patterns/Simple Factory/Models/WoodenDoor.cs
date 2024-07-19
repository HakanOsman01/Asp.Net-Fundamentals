using Creational_Patterns.Simple_Factory.Contracts;

namespace Creational_Patterns.Simple_Factory.Models
{
    public class WoodenDoor : IDoor
    {
        private int Height { get; set; }
        private int Width { get; set; }
        public WoodenDoor(int height,int widht)
        {
            this.Height = height;
            this.Width = widht;

        }

        public int GetHeight()
        {
            return this.Height;
        }

        public int GetWidht()
        {
            return this.Width;
        }
    }
}
