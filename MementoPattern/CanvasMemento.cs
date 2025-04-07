
using MementoPattern.Shapes;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    public class CanvasMemento
    {
        private List<IShape> state;
        public CanvasMemento(List<IShape> shapes)
        {
            state = shapes;
        }
        public List<IShape> GetState() => state.Select(s => s.Clone()).ToList();
    }
}
