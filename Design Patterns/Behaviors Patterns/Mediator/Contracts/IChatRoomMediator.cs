using System.Reflection.Metadata;

namespace Behaviors_Patterns.Mediator.Contracts
{
    public interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }
}
