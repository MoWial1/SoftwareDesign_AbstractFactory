
using System.Drawing;

namespace CompositePattern.Shapes
{
    public class Circle : IShape
    {
        public Point Position { get; set; }
        public int Radius { get; set; }
        public Pen Pen { get; set; } = Pens.Black;

        public Circle(Point position, int radius)
        {
            Position = position;
            Radius = radius;
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pen, Position.X, Position.Y, Radius * 2, Radius * 2);
        }
    }
}
