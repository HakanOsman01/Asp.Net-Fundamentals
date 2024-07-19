namespace Struvtural_Patterns.Composite.Shapes
{
    public class Text : Shape
    {
        public Text(Position position,string value) : base(position)
        {
            this.Value = value;
        }
        public string Value { get; set; }

        public override void Draw()
        {
            Console.SetCursorPosition(this.Position.Col, this.Position.Row);
            Console.Write(Value);
            base.Draw();
        }
    }
}
