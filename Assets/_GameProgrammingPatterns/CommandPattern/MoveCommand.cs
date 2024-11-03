using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class MoveCommand : ICommand
    {
        private Player _player;
        private Vector3 _direction;
        private Stack<Vector3> _stack = new Stack<Vector3>();

        public MoveCommand(Player player, Vector3 direction)
        {
            _player = player;
            _direction = direction;
        }

        public void Execute()
        {
            _stack.Push(_direction);
            _player.Move(_direction);
        }

        public void Undo()
        {
            if (_stack.Count > 0)
                _player.Move(-_stack.Pop());
        }
    }
}

