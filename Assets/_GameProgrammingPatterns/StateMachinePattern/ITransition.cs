namespace StateMachinePattern
{
    public interface ITransition
    {
        IState to { get; }
        IPredicate condition { get; }
    }
}