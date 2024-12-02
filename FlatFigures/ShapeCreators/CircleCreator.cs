using FlatFigures.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures.ShapeCreators
{
    public class CircleCreator : ShapeCreator
    {
        public override Shape CreateShape(int x, int y, int size)
        {
            return new CircleShape
            {
                Bounds = new Rectangle(x, y, size, size) // Коло має рівну ширину та висоту
            };
        }
    }
}
