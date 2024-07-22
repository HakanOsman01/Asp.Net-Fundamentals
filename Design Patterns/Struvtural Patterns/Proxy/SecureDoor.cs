using Struvtural_Patterns.Proxy.Contracts;

namespace Struvtural_Patterns.Proxy
{
    public class SecureDoor
    {
        private IDoor door;
        private static int count = 0;
        public SecureDoor(IDoor door)
        {
            this.door = door;
        }
        public void Close()
        {
           door.Close();
        }

        public void Open(string password)
        {
            if(count >= 3)
            {
                Console.WriteLine("Securety alert!!!");
                Environment.Exit(1);
            }

            if(Authenticate(password))
            {
                door.Open();
                count = 0;
            }
            else
            {
                Console.WriteLine("Wrong password!!!");
                count++;
            }

            
        }
        private bool Authenticate(string password)
        {
            return password == "hho123321";
        }
    }
}
