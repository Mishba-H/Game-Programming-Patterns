using Unity.VisualScripting;
using UnityEngine;

namespace ObserverPattern
{
    public class ObserverA : MonoBehaviour, IObserver
    {
        Subject subject;

        private void Awake()
        {
            subject = GameObject.FindFirstObjectByType<Subject>();
        }

        private void OnEnable()
        {
            subject.AddObserver(this);
        }

        private void OnDisable()
        {
            subject.RemoveObserver(this);
        }

        public void OnEvent()
        {
            Debug.Log("ObserverA event triggered");
        }
    }
}