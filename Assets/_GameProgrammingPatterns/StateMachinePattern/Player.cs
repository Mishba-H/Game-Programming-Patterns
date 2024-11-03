using UnityEngine;

namespace StateMachinePattern
{
    public class Player : MonoBehaviour
    {
        StateMachine stateMachine;

        private void Awake()
        {
            stateMachine = new StateMachine();

            stateMachine.AddState(new PlayerIdleState(this));
            stateMachine.AddState(new PlayerWalkState(this));
            stateMachine.AddState(new PlayerJumpState(this));

            stateMachine.SetState(stateMachine.states[typeof(PlayerIdleState)]);
        }

        public void HandleMovement()
        {
            //Handle player movement
        }

        public void HandleJump()
        {
            //Handle player jump
        }
    }
}