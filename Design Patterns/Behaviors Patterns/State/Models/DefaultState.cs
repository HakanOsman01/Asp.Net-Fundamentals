using Behaviors_Patterns.State.Contracts;

namespace Behaviors_Patterns.State.Models
{
    public class DefaultState : IWriteState
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
