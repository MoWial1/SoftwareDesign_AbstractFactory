using System;
using System.Drawing;


namespace MementoPattern.Shapes
{
    public class CircleShape : IShape
    {
        private Rectangle bounds;
        public CircleShape(Point start, Point end)
        {
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            bounds = new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                width, height);
        }
        public void Draw(Graphics g) => g.DrawEllipse(Pens.Black, bounds);
        public IShape Clone() => new CircleShape(bounds.Location, new Point(bounds.Right, bounds.Bottom));
    }
}
