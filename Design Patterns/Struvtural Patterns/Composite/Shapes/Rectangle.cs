namespace Struvtural_Patterns.Composite.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(Position position,int widht,int height) 
            : base(position)
        {
            this.Widht = widht;
            this.Height = height;
            
        }
        public int Widht { get; set; }
        public int Height { get; set; }
        public override void Draw()
        {
           
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Widht; j++)
                {
                    Console.SetCursorPosition(this.Position.Col+j, this.Position.Row+i);
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            base.Draw();
        }
    }
}
