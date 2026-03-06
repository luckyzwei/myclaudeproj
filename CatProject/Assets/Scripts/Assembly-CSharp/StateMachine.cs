public class StateMachine<TState> where TState : StateBase
{
	public TState CurrentState { get; private set; }

	public void ChangeState(TState newState)
	{
		if (CurrentState != null)
			CurrentState.OnExit();
		CurrentState = newState;
		if (CurrentState != null)
			CurrentState.OnEnter();
	}

	public void Update()
	{
		if (CurrentState != null)
			CurrentState.OnUpdate();
	}
}
