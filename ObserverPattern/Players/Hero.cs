﻿
using System.Collections.Generic;
using System.Drawing;

namespace ObserverPattern.Players
{
    public class Hero
    {
        private List<IEnemyObserver> observers = new List<IEnemyObserver>();
        public Point Position { get; private set; }

        public void MoveTo(Point newPosition)
        {
            Position = newPosition;
            NotifyObservers();
        }

        public void AddObserver(IEnemyObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IEnemyObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.UpdatePosition(Position);
            }
        }
    }
}
