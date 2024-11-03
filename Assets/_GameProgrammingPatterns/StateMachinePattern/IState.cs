using UnityEngine;

namespace StateMachinePattern
{
    public interface IState 
    {
        void OnEnter();
        void Update();
        void FixedUpdate();
        void HandleTransition();
        void OnExit();
    }
}
