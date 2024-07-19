﻿namespace Creational_Patterns.Simple_Factory
{
    public class Audi : ICar
    {
        private const int SpeedLimit  =  10;
        public Audi(string model,int initalSpeed)
        {
            this.Model = model;
            this.InitialSpeed = initalSpeed;
            
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
            this.InitialSpeed += SpeedLimit;
        }
    }
}