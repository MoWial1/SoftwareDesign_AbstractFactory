
using System.Drawing;


namespace CompositePattern.Shapes
{
    public class Line : IShape
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Pen Pen { get; set; } = Pens.Black;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
}
