namespace Behaviors_Patterns.Strategy.Contracts
{
    public interface ISorting 
    {
        IEnumerable<T> Sort<T>(T[] elements) where T : IComparable<T>;
    }
}
