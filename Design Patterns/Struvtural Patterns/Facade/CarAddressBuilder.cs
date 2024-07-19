namespace Struvtural_Patterns.Facade
{
    public class CarAddressBuilder : CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            this.Car = car;
        }
        public CarAddressBuilder WihtAddress(string address)
        {
            this.Car.Address = address;
            return this;
        }
        public CarAddressBuilder WithCity(string city)
        {
            this.Car.City = city;
            return this;
        }
    }
}
