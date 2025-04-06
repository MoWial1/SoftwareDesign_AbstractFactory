using ObserverPattern.Players;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class GameForm : Form
    {
        private Hero hero;
        private Panel heroVisual;
        private Random rand = new Random();
        private Timer gameTimer;

        public GameForm()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            this.Size = new Size(800, 600);
            this.Text = "Observer AI Game";

            hero = new Hero();

            heroVisual = new Panel()
            {
                Size = new Size(20, 20),
                BackColor = Color.Blue,
                Location = new Point(400, 300)
            };
            this.Controls.Add(heroVisual);
            hero.MoveTo(heroVisual.Location);

            for (int i = 0; i < 5; i++)
            {
                Point start = new Point(rand.Next(0, 750), rand.Next(0, 550));
                var enemy = new Enemy(start, this);
                hero.AddObserver(enemy);
            }

            this.MouseClick += GameForm_MouseClick;

            gameTimer = new Timer();
            gameTimer.Interval = 30;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            hero.MoveTo(e.Location);
            heroVisual.Location = e.Location;
            hero.NotifyObservers();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            hero.TickObservers();
        }
    }
}
