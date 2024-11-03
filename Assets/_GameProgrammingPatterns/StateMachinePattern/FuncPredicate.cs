using System;
using UnityEngine;

namespace StateMachinePattern
{
    public class FuncPredicate : IPredicate
    {
        Func<bool> func;
        public FuncPredicate(Func<bool> func)
        {
            this.func = func;
        }

        public bool Evaluate() => func.Invoke();
    }
}