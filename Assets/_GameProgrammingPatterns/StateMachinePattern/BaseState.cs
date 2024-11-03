using UnityEngine;

namespace StateMachinePattern
{
    public abstract class BaseState : IState
    {
        protected readonly Player player;

        protected BaseState(Player player)
        {
            this.player = player;
        }

        public virtual void OnEnter()
        {
        }

        public virtual void Update()
        {
        }

        public virtual void FixedUpdate()
        {
        }

        public virtual void HandleTransition()
        {
        }

        public virtual void OnExit()
        {
        }
    }
}