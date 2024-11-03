using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        private Player _player;

        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        private void Start()
        {
            _player = FindAnyObjectByType<Player>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W)) 
                ExecuteCommand(new MoveCommand(_player, Vector3.forward));
            else if (Input.GetKeyDown(KeyCode.S))
                ExecuteCommand(new MoveCommand(_player, Vector3.back));
            else if (Input.GetKeyDown(KeyCode.D))
                ExecuteCommand(new MoveCommand(_player, Vector3.right));
            else if (Input.GetKeyDown(KeyCode.A))
                ExecuteCommand(new MoveCommand(_player, Vector3.left));

            if (Input.GetKeyDown(KeyCode.Z) && _commandHistory.Count > 0)
                UndoCommand(_commandHistory.Pop());
        }

        private void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        private void UndoCommand(ICommand command)
        {
            command.Undo();
        }
    }
}