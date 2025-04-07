
using System.Drawing;


namespace MementoPattern.Shapes
{
    public interface IShape
    {
        void Draw(Graphics g);
        IShape Clone();
    }
}
