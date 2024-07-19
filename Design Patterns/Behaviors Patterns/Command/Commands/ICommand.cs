namespace Behaviors_Patterns.Command.Commands
{
    public interface ICommand
    {
        decimal Execute(decimal currentValue);
        decimal UnExecute(decimal currentValue);
    }
}
