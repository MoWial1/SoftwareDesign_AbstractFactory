﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFigures.Shapes
{
    public class SquareShape : Shape
    {
        public override void Draw(Graphics graphics)
        {
            // Врахування границь та товщини пензля
            int offset = (int)Pen.Width;
            Rectangle adjustedBounds = new Rectangle(
                Bounds.X + offset,
                Bounds.Y + offset,
                Bounds.Width - offset * 2,
                Bounds.Height - offset * 2
            );

            graphics.DrawRectangle(Pen, Bounds);
            graphics.FillRectangle(Brush, Bounds);
        }

        public override void Resize(int width, int height)
        {
            // Перевизначаємо зміну розміру: висота та ширина залишаються рівними
            int size = Math.Min(width, height);
            Bounds = new Rectangle(Bounds.X, Bounds.Y, size, size);
        }
    }
}