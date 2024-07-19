namespace Struvtural_Patterns.Facade
{
    public class Car
    {
        public string Color { get; set; }
        public string Type { get; set; }
        public int NumberOfDoors { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"CarType: {this.Type}, Color:{this.Color}, Number of Doors:{this.NumberOfDoors}, " +
                $"Manifactured in city:{this.City}, at address:{this.Address}";
        }
    }
}
