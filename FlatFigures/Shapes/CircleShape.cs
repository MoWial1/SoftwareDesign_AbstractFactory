using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures.Shapes
{
    public class CircleShape : Shape
    {
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, Bounds);
            graphics.FillEllipse(Brush, Bounds);
        }

        public override void Resize(int width, int height)
        {
            Bounds = new Rectangle(Bounds.X, Bounds.Y, width, height);
        }
    }
}
