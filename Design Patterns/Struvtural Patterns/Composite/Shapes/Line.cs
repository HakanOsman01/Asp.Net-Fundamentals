namespace Struvtural_Patterns.Composite.Shapes
{
    public class Line : Shape
    {
        public Line(Position position,int lenght) : base(position)
        {
            this.Lenght = lenght;

        }
        public int Lenght { get; set; }
        public override void Draw()
        {
            Console.SetCursorPosition(this.Position.Col, this.Position.Row);
            for (int i = 0; i < this.Lenght; i++)
            {
                Console.Write("-");
            }

            base.Draw();
        }

    }
}
