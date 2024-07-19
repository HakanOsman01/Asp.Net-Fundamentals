using Creational_Patterns.Prototype.Contracts;
using Newtonsoft.Json;

namespace Creational_Patterns.Prototype
{
    public class Square : Shape
    {
        public int Lenght { get; set; }
        public Page Page { get; set; }

        public override object Clone()
        {
            return JsonConvert.DeserializeObject<Square>
                (JsonConvert.SerializeObject(this));
        }
    }
}
