using Creational_Patterns.Prototype.Contracts;

namespace Creational_Patterns.Prototype
{
    public class SandwichMenu
    {
        private IDictionary<string, SandwichPrototype> sadwiches;
        public SandwichMenu()
        {
            this.sadwiches = new Dictionary<string, SandwichPrototype>();
        }

        public SandwichPrototype this[string name]
        {
            get => this[name];
            set => this[name] = value;
        }
    }
}
