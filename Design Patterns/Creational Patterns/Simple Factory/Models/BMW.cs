namespace Creational_Patterns.Simple_Factory
{
    public class BMW : ICar
    {
        private const int SpeedLimit = 5;
        public BMW(string model,int initialSpeed)
        {
            this.Model = model;
            this.InitialSpeed = initialSpeed;
        }
        public string Model { get;private set; }

        public int InitialSpeed { get; private set; }

        public void DecreaseSpeed(int speed)
        {
            if (InitialSpeed - speed < 0)
            {
                return;
            }
            this.InitialSpeed -= speed;
        }


        public void InCreaseSpeed()
        {
           this.InitialSpeed+= SpeedLimit;  
        }
    }
}
