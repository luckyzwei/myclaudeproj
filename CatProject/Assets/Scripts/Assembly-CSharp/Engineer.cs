using System;

public class Engineer : Worker
{
	private bool EnableWork;

	public int SeatIdx { get; private set; }

	public bool IsNotWork()
	{
		return false;
	}

	public void Init(E_AppearType appearType, int seat, int order)
	{
	}

	private void SubscribeSeatLevel()
	{
	}

	private void UpdateRepairTime()
	{
	}

	private void LoadChar(Action LoadComp)
	{
	}

	public override void Return()
	{
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
	}
}
