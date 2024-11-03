using UnityEngine;

namespace StateMachinePattern
{
    public class PlayerIdleState : BaseState
    {
        public PlayerIdleState(Player player) : base(player)
        {
        }

        public override void OnEnter()
        {
            Debug.Log("Entered " + this.GetType().Name);
        }

        public override void Update()
        {
            player.HandleMovement();
        }

        public override void FixedUpdate()
        {
            
        }

        public override void HandleTransition()
        {
            
        }

        public override void OnExit()
        {

        }
    }
}