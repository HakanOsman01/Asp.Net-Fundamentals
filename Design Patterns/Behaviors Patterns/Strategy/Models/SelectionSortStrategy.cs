using Behaviors_Patterns.Strategy.Contracts;

namespace Behaviors_Patterns.Strategy.Models
{
    public class SelectionSortStrategy : ISorting
    {
        public IEnumerable<T> Sort<T>(T[] elements) where T : IComparable<T>
        {
             
            for (int i = 1; i < elements.Length; i++)
            {
                int maxIndexElement = i;
                for (int j = i+1; j < elements.Length; j++)
                {
                    if (elements[i].CompareTo(elements[j]) < 0)
                    {
                        maxIndexElement = j;
                    }

                }
                var temp = elements[i];
                elements[i] = elements[maxIndexElement];
                elements[maxIndexElement] = temp;
              

            }
            return elements;
            
        }
      
    }

}
