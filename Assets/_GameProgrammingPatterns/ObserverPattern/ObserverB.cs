using UnityEngine;

namespace ObserverPattern
{
    public class ObserverB : MonoBehaviour, IObserver
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
            Debug.Log("ObserverB event triggered as well");
        }
    }
}