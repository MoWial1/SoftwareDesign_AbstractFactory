
using System.Drawing;


namespace CompositePattern.Shapes
{
    public class RectangleShape : IShape
    {
        public Rectangle Rect { get; set; }
        public Pen Pen { get; set; } = Pens.Black;

        public RectangleShape(Rectangle rect)
        {
            Rect = rect;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Rect);
        }
    }
}
