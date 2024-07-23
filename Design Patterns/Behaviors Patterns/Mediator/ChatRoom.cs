using Behaviors_Patterns.Mediator.Contracts;

namespace Behaviors_Patterns.Mediator
{
    public class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("MMMM dd, H:mm")} " +
                $"[{user.GetType().Name}]:{message}");
        }
    }
}
