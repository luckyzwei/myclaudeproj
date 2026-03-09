using System;

public class StateMachine
{
	public delegate void Function();

	private int m_currentState;

	private int m_NextState;

	private int m_lastState;

	private bool m_debug;

	private Function[] m_onEnterFunc;

	private Function[] m_onExitFunc;

	private Function[] m_onUpdateFunc;

	private Function[] m_onFixedUpdateFunc;

	private float m_time;

	private float m_timeFixed;

	public StateMachine(Enum nStates)
	{
	}

	public StateMachine(int nStates, bool debug = false)
	{
	}

	public void RegisterState(Enum State, Function OnEnter = null, Function OnUpdate = null, Function OnExit = null, Function OnFixedUpdate = null)
	{
	}

	public void RegisterState(Enum state, IState stateInterface)
	{
	}

	public void SetState(Enum state)
	{
	}

	public bool IsState(Enum state)
	{
		return false;
	}

	public int GetState()
	{
		return 0;
	}

	public int GetLastState()
	{
		return 0;
	}

	public float GetStateTime()
	{
		return 0f;
	}

	public float GetStateTimeFixed()
	{
		return 0f;
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void Execute(Function f)
	{
	}
}
