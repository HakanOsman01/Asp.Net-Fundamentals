using Struvtural_Patterns.Proxy.Contracts;

namespace Struvtural_Patterns.Proxy
{
    public class LabDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Closing the lab door!!!");
        }

        public void Open()
        {
            Console.WriteLine("Opening the lab door!!!");
        }
    }
}
