namespace Creational_Patterns.Simple_Factory
{
    public class CarFactory
    {
        private static ICar car;
        public static ICar CreateCar(string type)
        {
           

            if (type == "BMW")
            {
                Console.WriteLine("Create BMW enter the model:");

                string model = Console.ReadLine();
                Console.WriteLine("Enter The InitialSpeed: ");
                int speed  = int.Parse(Console.ReadLine());
                car = new BMW(model, speed);
            }
            else if (type == "Audi")
            {
                Console.WriteLine("Create Audi enter the model:");

                string model = Console.ReadLine();
                Console.WriteLine("Enter The InitialSpeed: ");
                int speed = int.Parse(Console.ReadLine());
                car = new Audi(model, speed);
            }
          return car;
        }

        
    }
}
