using System;
using System.Collections.Generic;

namespace StateMachinePattern
{
    public class StateMachine
    {
        StateNode current;
        Dictionary<Type, StateNode> nodes = new();
        HashSet<ITransition> anyTransitions = new();

        public void Update()
        {
            var transition = GetTransition();
            if (transition != null)
            {
                ChangeState(transition.to);
            } 
                
            current.state?.Update();
        }

        public void FixedUpdate()
        {
            current.state?.FixedUpdate();
        }

        public void SetState(IState state)
        {
            current = nodes[state.GetType()];
            current.state?.OnEnter();
        }

        private void ChangeState(IState state)
        {
            if (current.state == state) return;

            var previousState = current.state;
            var nextState = nodes[state.GetType()].state;

            previousState?.OnExit();
            nextState?.OnExit();
            current = nodes[state.GetType()];
        }

        private ITransition GetTransition()
        {
            foreach (var transition in anyTransitions)
            {
                if (transition.condition.Evaluate())
                    return transition;
            }

            foreach (var transition in current.transitions)
            {
                if (transition.condition.Evaluate())
                    return transition;
            }

            return null;
        }

        public void AddTransition(IState from, IState to, IPredicate condition)
        {
            GetOrAddNode(from).AddTransition(GetOrAddNode(to).state, condition);
        }

        public void AddAnyTransition(IState to, IPredicate condition)
        {
            anyTransitions.Add(new Transition(GetOrAddNode(to).state, condition));
        }

        private StateNode GetOrAddNode(IState state)
        {
            var node = nodes.GetValueOrDefault(state.GetType());

            if (node == null)
            {
                node = new StateNode(state);
                nodes.Add(state.GetType(), node);
            }

            return node;
        }

        private class StateNode
        {
            public IState state;
            public HashSet<ITransition> transitions;

            public StateNode(IState state)
            {
                this.state = state;
                transitions = new HashSet<ITransition>();
            }

            public void AddTransition(IState to, IPredicate condition)
            {
                transitions.Add(new Transition(to, condition));
            }
        }
    }
}