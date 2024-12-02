using FlatFigures.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures.ShapeCreators
{
    public class RectangleCreator : ShapeCreator
    {
        public override Shape CreateShape(int x, int y, int size)
        {
            return new RectangleShape
            {
                Bounds = new Rectangle(x, y, size * 2, size) // Прямокутник ширший за висоту
            };
        }
    }
}
