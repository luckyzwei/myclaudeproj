using System;

public class Engineer : Worker
{
	private bool EnableWork;

	public int SeatIdx { get; private set; }

	public bool IsNotWork()
	{
		return !EnableWork || IsState(E_State.None) || IsState(E_State.Workoff);
	}

	public void Init(E_AppearType appearType, int seat, int order)
	{
		SeatIdx = seat;
		WorkerType = E_WorkerType.Engineer;
		WorkerInit();
		EnableWork = true;
		SubscribeSeatLevel();
	}

	private void SubscribeSeatLevel()
	{
		// Subscribe to seat level changes to update engineer appearance
	}

	private void UpdateRepairTime()
	{
		// Update repair progress display
	}

	private void LoadChar(Action LoadComp)
	{
		// Load engineer character model and invoke callback when done
		LoadComp?.Invoke();
	}

	public override void Return()
	{
		ChangeState(E_State.Idle);
		EnableWork = true;
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
		EnableWork = false;
		ChangeState(E_State.Workoff);
	}
}
