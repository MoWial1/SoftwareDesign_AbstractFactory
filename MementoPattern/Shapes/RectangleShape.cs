using System;
using System.Drawing;


namespace MementoPattern.Shapes
{
    public class RectangleShape : IShape
    {
        private Rectangle rect;
        public RectangleShape(Point start, Point end)
        {
            rect = new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(start.X - end.X),
                Math.Abs(start.Y - end.Y));
        }
        public void Draw(Graphics g) => g.DrawRectangle(Pens.Black, rect);
        public IShape Clone() => new RectangleShape(rect.Location, new Point(rect.Right, rect.Bottom));
    }
}
