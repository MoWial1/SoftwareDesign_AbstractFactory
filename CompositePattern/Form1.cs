using CompositePattern.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        private ShapeComposite root = new ShapeComposite();
        private Bitmap canvas;
        private Graphics graphics;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(800, 600);
            graphics = Graphics.FromImage(canvas);
            pictureBox1.Image = canvas;
        }

        private void DrawAll()
        {
            graphics.Clear(Color.White);      // Очистити полотно
            root.Draw(graphics);              // Намалювати всі фігури
            pictureBox1.Invalidate();         // Оновити картинку
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            int x = rand.Next(50, 700);
            int y = rand.Next(50, 500);
            var circle = new Circle(new Point(x, y), 40);

            root.Add(circle);
            DrawAll();
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            int x = rand.Next(50, 700);
            int y = rand.Next(50, 500);
            int w = rand.Next(50, 120);
            int h = rand.Next(40, 100);
            var rect = new RectangleShape(new Rectangle(x, y, w, h));

            root.Add(rect);
            DrawAll();
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            int x1 = rand.Next(50, 700);
            int y1 = rand.Next(50, 500);
            int x2 = rand.Next(50, 700);
            int y2 = rand.Next(50, 500);
            var line = new Line(new Point(x1, y1), new Point(x2, y2));

            root.Add(line);
            DrawAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            root = new ShapeComposite();
            DrawAll();
        }
    }
}
