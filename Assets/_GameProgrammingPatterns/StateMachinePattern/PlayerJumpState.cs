using UnityEngine;

namespace StateMachinePattern
{
    public class PlayerJumpState : BaseState
    {
        public PlayerJumpState(Player player) : base(player)
        {
        }

        public override void OnEnter()
        {
            Debug.Log("Entered " + this.GetType().Name);
        }

        public override void Update()
        {
            player.HandleJump();
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