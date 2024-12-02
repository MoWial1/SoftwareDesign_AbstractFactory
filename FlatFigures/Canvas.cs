using FlatFigures.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures
{
    public class Canvas
    {
        public List<Shape> Shapes { get; private set; } = new List<Shape>();

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void Draw(Graphics graphics)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(graphics);
            }
        }
    }
}
