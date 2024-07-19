namespace Behaviors_Patterns.Command.Commands
{
    public class PlusCommand : Command
    {
        public PlusCommand(int value) 
            : base(value,'+')
        {
        }

        public override decimal Execute(decimal currentValue)
        {
            return currentValue + Value;
        }

        public override decimal UnExecute(decimal currentValue)
        {
            return currentValue - Value;
        }
    }
}
