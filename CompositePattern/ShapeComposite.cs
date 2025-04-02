using CompositePattern.Shapes;
using System.Collections.Generic;
using System.Drawing;


namespace CompositePattern
{
    public class ShapeComposite : IShape
    {
        private List<IShape> children = new List<IShape>();

        public void Add(IShape shape) => children.Add(shape);
        public void Remove(IShape shape) => children.Remove(shape);

        public void Draw(Graphics g)
        {
            foreach (var shape in children)
                shape.Draw(g);
        }
    }
}
