using MementoPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace MementoPattern
{
    public partial class Form1 : Form
    {
        private enum Tool { Rectangle, Circle, Line }
        private Tool currentTool = Tool.Rectangle;

        private Point startPoint;
        private List<IShape> shapes = new List<IShape>();
        private Stack<CanvasMemento> history = new Stack<CanvasMemento>();
        private Graphics canvasGraphics;

        public Form1()
        {
            InitializeComponent();
            canvasGraphics = canvasPanel.CreateGraphics();
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            SaveState();

            IShape shape = null;
            switch (currentTool)
            {
                case Tool.Rectangle:
                    shape = new RectangleShape(startPoint, e.Location);
                    break;
                case Tool.Circle:
                    shape = new CircleShape(startPoint, e.Location);
                    break;
                case Tool.Line:
                    shape = new LineShape(startPoint, e.Location);
                    break;
            }

            if (shape != null)
            {
                shapes.Add(shape);
                shape.Draw(canvasGraphics); // малювання напряму
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e) => currentTool = Tool.Rectangle;
        private void btnCircle_Click(object sender, EventArgs e) => currentTool = Tool.Circle;
        private void btnLine_Click(object sender, EventArgs e) => currentTool = Tool.Line;

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                shapes = history.Pop().GetState();
                RedrawCanvas();
            }
        }

        private void SaveState()
        {
            var clone = shapes.Select(s => s.Clone()).ToList();
            history.Push(new CanvasMemento(clone));
        }

        private void RedrawCanvas()
        {
            canvasGraphics.Clear(Color.White);
            foreach (var shape in shapes)
            {
                shape.Draw(canvasGraphics);
            }
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
