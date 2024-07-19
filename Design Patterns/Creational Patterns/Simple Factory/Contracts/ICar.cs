namespace Creational_Patterns.Simple_Factory
{
    public interface ICar
    {

         string Model { get;}
         int InitialSpeed { get;}
         void InCreaseSpeed();
         void DecreaseSpeed(int speed);
    }
}
