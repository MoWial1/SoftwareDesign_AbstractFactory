using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures.Shapes
{
    public abstract class Shape
    {
        public Rectangle Bounds { get; set; } // Координати та розмір фігури
        public Pen Pen { get; set; } = new Pen(Color.Black, 1); // Колір контуру за замовчуванням
        public Brush Brush { get; set; } = new SolidBrush(Color.White); // Колір заливки за замовчуванням
        public abstract void Draw(Graphics graphics); // Метод малювання
        public abstract void Resize(int width, int height); // Метод зміни розміру
    }
}
