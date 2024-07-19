namespace Behaviors_Patterns.Template.Contracts
{
    public abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine($"Slice the {this.GetType().Name} bread");
        }
        public void Make()
        {
            this.MixIngredients();
            this.Bake();
            this.Slice();
        }

    }
}
