using Behaviors_Patterns.Strategy.Contracts;

namespace Behaviors_Patterns.Strategy.Models
{
    public class BubbleSortStrategy : ISorting
    {
        public IEnumerable<T> Sort<T>(T[] elements) where T : IComparable<T> 
        {
            bool swapRequired = false;
            for (int i = 0; i < elements.Length-1; i++)
            {
                swapRequired = false;
                for (int j = 0; j < elements.Length - i - 1; j++)
                {
                    if (elements[j].CompareTo(elements[j+1])<0)
                    {
                        var tempVar = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = tempVar;
                        swapRequired = true;
                    }

                }
                   
                if (swapRequired == false)
                {
                    break;
                }
                    
            }
            return elements;

        }
    }
}
