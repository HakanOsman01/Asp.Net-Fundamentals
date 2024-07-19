namespace Behaviors_Patterns.Command.Commands
{
    public abstract class Command : ICommand
    {
        public Command(int value,char operant)
        {
            
            this.Value = value;
            this.Operant = operant;
        }
        public int Value { get; set; }
        public char Operant { get; set; }
        public abstract decimal Execute(decimal currentValue);
        public abstract decimal UnExecute(decimal currentValue);
        public override string ToString()
        {
            return $"{Operant} {Value}";
        }
    }
}
