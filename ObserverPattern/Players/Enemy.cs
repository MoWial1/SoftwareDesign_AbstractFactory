using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObserverPattern.Players
{
    public class Enemy : IEnemyObserver
    {
        public Point Position { get; private set; }
        private Panel visual;
        private Point heroTarget;

        public Enemy(Point start, Control parent)
        {
            Position = start;
            heroTarget = start;
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
            heroTarget = heroPosition;
        }

        public void Tick()
        {
            int dx = Math.Sign(heroTarget.X - Position.X) * 2;
            int dy = Math.Sign(heroTarget.Y - Position.Y) * 2;

            Position = new Point(Position.X + dx, Position.Y + dy);
            visual.Location = Position;
        }
    }

}
