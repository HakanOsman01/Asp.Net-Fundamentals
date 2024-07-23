using Behaviors_Patterns.Mediator.Contracts;
using System.Xml.Linq;

namespace Behaviors_Patterns.Mediator
{
    public class User
    {
        private string name;
        private IChatRoomMediator chatRoom;
        public User(string name, IChatRoomMediator chatroom)
        {
            this.name = name;
            this.chatRoom = chatroom;
        }
        public string GetName()
        {
            return this.name;
        }

        public void Send(string message)
        {
            this.chatRoom.ShowMessage(this, message);
        }
    }
}