using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObserverPattern.Players
{
    public class Enemy : IEnemyObserver
    {
        public Point Position { get; private set; }
        private Panel visual;

        public Enemy(Point start, Control parent)
        {
            Position = start;
            visual = new Panel()
            {
                Size = new Size(20, 20),
                BackColor = Color.Red,
                Location = Position
            };
            parent.Controls.Add(visual);
        }

        public void UpdatePosition(Point heroPosition)
        {
            // Просте переміщення на 10 пікселів у напрямку героя
            int dx = Math.Sign(heroPosition.X - Position.X) * 10;
            int dy = Math.Sign(heroPosition.Y - Position.Y) * 10;
            Position = new Point(Position.X + dx, Position.Y + dy);
            visual.Location = Position;
        }
    }

}
