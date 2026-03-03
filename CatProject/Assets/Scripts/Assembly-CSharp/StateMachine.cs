public class StateMachine<TState> where TState : StateBase
{
	public TState CurrentState { get; private set; }

	public void ChangeState(TState newState)
	{
	}

	public void Update()
	{
	}
}
