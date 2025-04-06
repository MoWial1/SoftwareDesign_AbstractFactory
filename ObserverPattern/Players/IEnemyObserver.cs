
using System.Drawing;


namespace ObserverPattern.Players
{
    public interface IEnemyObserver
    {
        void UpdatePosition(Point heroPosition);
        void Tick();
    }
}
