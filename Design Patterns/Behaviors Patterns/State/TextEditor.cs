using Behaviors_Patterns.State.Contracts;
using Behaviors_Patterns.State.Models;

namespace Behaviors_Patterns.State
{
    public class TextEditor
    {
        private  IWriteState state;
        public TextEditor()
        {
            this.state = new DefaultState();
        }
        public TextEditor(IWriteState state)
        {
            this.state = state;
            
        }
        public void SetState(IWriteState newState)
        {
           this.state = newState;
        }
        public void GetType()
        {
            Console.WriteLine(this.state.GetType().Name);
        }
        public void GetState(string word)
        {
            state.Write(word);
        }




    }
}
