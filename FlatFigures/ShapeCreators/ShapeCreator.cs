using FlatFigures.Shapes;


namespace FlatFigures.ShapeCreators
{
    public abstract class ShapeCreator
    {
        public abstract Shape CreateShape(int x, int y, int size);
    }
}
