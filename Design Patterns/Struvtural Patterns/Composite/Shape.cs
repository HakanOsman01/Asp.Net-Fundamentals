namespace Struvtural_Patterns.Composite
{
    public class Shape
    {
        protected List<Shape> childrens;
        protected ConsoleColor color = ConsoleColor.Black;

     
        public Shape(Position position)
        {
            this.Position = position;
            this.childrens = new List<Shape>();
            
        }
        public Position Position { get; set; }
        public void AddChild(Shape shape)
        {
            this.childrens.Add(shape);
        }
        public virtual void Draw()
        {
            Console.ForegroundColor = color;
            foreach (var child in childrens)
            {
                child.Draw();
            }
        }
        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Up: 
                    this.Position.Row--;
                    break;
                case Direction.Down: 
                    this.Position.Row++;
                    break;
                case Direction.Left:
                    this.Position.Col--;
                    break;
                case Direction.Right:
                    this.Position.Col++;
                    break;


            }
            foreach (var child in childrens)
            {
                child.Move(direction);

            }
        }
        public void ChangeColor(ConsoleColor color)
        {
            this.color = color;
            foreach (var child in childrens)
            {
                child.ChangeColor(color);
            }
        }


    }
}
