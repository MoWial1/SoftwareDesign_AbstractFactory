using FlatFigures.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures.ShapeCreators
{
    public abstract class ShapeCreator
    {
        public abstract Shape CreateShape(int x, int y, int size);
    }
}
