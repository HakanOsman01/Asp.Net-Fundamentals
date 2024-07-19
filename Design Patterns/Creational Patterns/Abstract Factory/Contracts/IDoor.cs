namespace Creational_Patterns.Abstract_Factory.Contracts
{
    public interface IDoor
    {
        void GetDescription();
        int Widht { get; }
        int Height { get; }
        string Color { get; }
        
    }
}
