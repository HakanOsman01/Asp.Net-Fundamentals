
using Behaviors_Patterns.Strategy.Contracts;
using System.ComponentModel;

namespace Behaviors_Patterns.Strategy
{
    public class SortClass<T> where T : IComparable<T>
    {
        private readonly ISorting sorting;
        public SortClass(ISorting sorting)
        {
            this.sorting = sorting;
        }
       public  T[] SortCollection(IEnumerable<T>elements) 
       {
            T[] sorted = new T[elements.Count()];
            sorted = (T[])sorting.Sort((T[])elements);
            return sorted;
       }

    }
}
