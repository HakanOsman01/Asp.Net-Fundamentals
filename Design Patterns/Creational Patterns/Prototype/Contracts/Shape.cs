using Newtonsoft.Json;

namespace Creational_Patterns.Prototype.Contracts
{
    public abstract class Shape : ICloneable
    {
        public int Widht { get; set; }

        public abstract object Clone();
       
    }
}
