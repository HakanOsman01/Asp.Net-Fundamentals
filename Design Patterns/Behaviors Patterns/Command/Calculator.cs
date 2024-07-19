using Behaviors_Patterns.Command.Commands;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Behaviors_Patterns.Command
{
    public class Calculator
    {
        private List<ICommand>commands  = new List<ICommand>();
        public decimal Result { get; set; }
        public void Execute(ICommand command) 
        {
            commands.Add(command);
            Result = command.Execute(Result);

        }
        public void Undo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (commands.Count == 0)
                {
                    break;
                }
                ICommand command = commands[commands.Count - 1];
                Result = command.UnExecute(Result);
                commands.Remove(command);
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("0 ");
            foreach (ICommand command in commands)
            {
                stringBuilder.Append(command.ToString());
            }
            stringBuilder.Append($" = {Result}");
            return stringBuilder.ToString().Trim();
            
        }

    }
}
