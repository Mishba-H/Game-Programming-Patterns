using UnityEngine;

namespace StateMachinePattern
{
    public abstract class BaseState : IState
    {
        protected readonly Player player;
        protected readonly Animator anim;

        protected BaseState(Player player, Animator anim)
        {
            this.player = player;
            this.anim = anim;
        }

        public virtual void FixedUpdate()
        {
        }

        public virtual void OnEnter()
        {
        }

        public virtual void OnExit()
        {
        }

        public virtual void Update()
        {
        }
    }
}