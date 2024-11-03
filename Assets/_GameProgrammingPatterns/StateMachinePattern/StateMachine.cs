using System;
using System.Collections.Generic;

namespace StateMachinePattern
{
    [System.Serializable]
    public class StateMachine
    {
        public Dictionary<Type, IState> states = new Dictionary<Type, IState>();

        public IState currentState;
        public IState previousState;

        public void SetState(IState state)
        {
            currentState = state;
            currentState.OnEnter();
        }

        private void ChangeState(IState newState)
        {
            if (currentState == newState) return;

            previousState = currentState;
            currentState = newState;

            previousState?.OnExit();
            currentState?.OnEnter();
        }

        public void AddState(IState state)
        {
            if (!states.ContainsKey(state.GetType())) 
                states.Add(state.GetType(), state);
        }

        public void RemoveState(IState state) 
        { 
            if (states.ContainsKey(state.GetType())) 
                states.Remove(state.GetType());
        }

        public void Update()
        {
            currentState?.Update();
        }

        public void FixedUpdate()
        {
            currentState?.FixedUpdate();
        }

        public void HandleTransition()
        {
            currentState?.HandleTransition();
        }
    }
}