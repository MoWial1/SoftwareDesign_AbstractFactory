using FlatFigures.ShapeCreators;
using FlatFigures.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatFigures
{
    public partial class Form1 : Form
    {
        private Canvas canvas;
        private ShapeCreator squareCreator = new SquareCreator();
        private ShapeCreator rectangleCreator = new RectangleCreator();
        private ShapeCreator circleCreator = new CircleCreator();

        private Shape selectedShape;
        private bool isResizing = false;
        private Point lastMousePosition;

        private Color selectedPenColor = Color.Black; 
        private Color selectedBrushColor = Color.White; 

        private bool isCreatingShape = false; // Режим створення фігури
        private ShapeCreator currentCreator = null; // Поточна фабрика для створення фігури
        private int newShapeSize = 100; 

        public Form1()
        {
            InitializeComponent();

            canvas = new Canvas();
            pictureBoxCanvas.Image = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
        }
        
        // ==========================================================================================
        private void btnAddSquare_Click(object sender, EventArgs e)
        {
            Shape square = squareCreator.CreateShape(50, 50, 100); 
            square.Pen = new Pen(selectedPenColor, 2); 
            square.Brush = new SolidBrush(selectedBrushColor); 

            currentCreator = new SquareCreator();
            isCreatingShape = true;

            //canvas.AddShape(square);
            //Redraw();
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            Shape rectangle = rectangleCreator.CreateShape(150, 50, 100); 
            rectangle.Pen = new Pen(selectedPenColor, 2);
            rectangle.Brush = new SolidBrush(selectedBrushColor); 

            currentCreator = new RectangleCreator();
            isCreatingShape = true;

            //canvas.AddShape(rectangle);
            //Redraw();
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            Shape circle = circleCreator.CreateShape(250, 50, 100); 
            circle.Pen = new Pen(selectedPenColor, 2); 
            circle.Brush = new SolidBrush(selectedBrushColor); 

            currentCreator = new CircleCreator();
            isCreatingShape = true;

            //canvas.AddShape(circle);
            //Redraw();
        }
        // ==========================================================================================

        // ==========================================================================================
        private void Redraw()
        {
            var bmp = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(Color.White);
                canvas.Draw(graphics);
            }
            pictureBoxCanvas.Image = bmp;
        }
        // ==========================================================================================

        // ==========================================================================================
        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (isCreatingShape && currentCreator != null)
            {
                // Створюємо нову фігуру на основі вибраної фабрики
                Shape newShape = currentCreator.CreateShape(e.X, e.Y, newShapeSize);
                newShape.Pen = new Pen(selectedPenColor, 2); 
                newShape.Brush = new SolidBrush(selectedBrushColor);

                // Додаємо фігуру на канву
                canvas.AddShape(newShape);

                // Вимикаємо режим створення
                isCreatingShape = false;
                currentCreator = null;

                // Перемальовуємо канву
                Redraw();
            }

            // Шукаємо фігуру, яка містить точку натискання
            selectedShape = canvas.Shapes.FirstOrDefault(shape => shape.Bounds.Contains(e.Location));
            if (selectedShape != null)
            {
                isResizing = true; // Активуємо режим зміни розміру
                lastMousePosition = e.Location; // Запам'ятовуємо початкову точку
            }
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing && selectedShape != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                // Змінюємо розмір фігури
                selectedShape.Resize(selectedShape.Bounds.Width + deltaX, selectedShape.Bounds.Height + deltaY);

                // Оновлюємо останню позицію миші
                lastMousePosition = e.Location;

                // Перемальовуємо канву
                Redraw();
            }
        }

        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false; // Вихід із режиму зміни розміру
        }
        // ==========================================================================================

        // ==========================================================================================

        private void pbPenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPenColor.BackColor = colorDialog1.Color;
                selectedPenColor = colorDialog1.Color;

                // Якщо є обрана фігура, змінюємо її колір контуру
                if (selectedShape != null)
                {
                    selectedShape.Pen.Color = selectedPenColor;
                    Redraw();
                }
            }
        }

        private void pbBrushColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbBrushColor.BackColor = colorDialog1.Color;
                selectedBrushColor = colorDialog1.Color;

                // Якщо є обрана фігура, змінюємо її колір заливки
                if (selectedShape != null)
                {
                    selectedShape.Brush = new SolidBrush(selectedBrushColor);
                    Redraw();
                }
            }
        }
    }
}
