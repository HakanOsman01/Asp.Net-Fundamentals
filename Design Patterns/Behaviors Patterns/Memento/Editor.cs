namespace Behaviors_Patterns.Memento
{
    public class Editor
    {
        private EditorMemento memento;
        private string content = string.Empty;
        public Editor()
        {
            memento = new EditorMemento(string.Empty); 
        }
        public void Type(string content)
        {
            this.content = String.Concat(this.content," ",content);
        }

        public string Content
        {
            get { return this.content; }
        }
        public void Save()
        {
            memento = new EditorMemento(this.content);
        }
        public void Restore()
        {
            this.content = memento.Content;
        }
    }
}
