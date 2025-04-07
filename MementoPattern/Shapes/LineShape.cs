
using System.Drawing;

namespace MementoPattern.Shapes
{
    public class LineShape : IShape
    {
        private Point start, end;
        public LineShape(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
        public void Draw(Graphics g) => g.DrawLine(Pens.Black, start, end);
        public IShape Clone() => new LineShape(start, end);
    }

}
