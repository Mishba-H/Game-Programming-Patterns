using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace ObserverPattern
{
    public class Subject : MonoBehaviour
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.OnEvent();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                NotifyObservers();
        }
    }
}