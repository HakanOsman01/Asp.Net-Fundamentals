namespace Behaviors_Patterns.Memento
{
    public class EditorMemento
    {
        private string content;
        public EditorMemento(string _content)
        {
            content = _content;
        }
        public string Content
        {
            get { return content; }
        }
    }
}
