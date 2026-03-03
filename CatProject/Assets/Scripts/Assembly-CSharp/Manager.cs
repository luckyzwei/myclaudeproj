using System;

public class Manager : Worker
{
	private InGameManagerUI ManagerUI;

	private int curMessageCoolTime;

	private int maxMessageCoolTime;

	private float realtime_dtime;

	public int OfficeIdx { get; private set; }

	public int ManagerIdx { get; private set; }

	public void Init(E_AppearType appearType, int managerIdx, int officeIdx, int officeOrder)
	{
	}

	public override void WorkOut(int order, bool outcompany)
	{
	}

	public void WorkOutImmediate()
	{
	}

	private void GotoWorkOffReturn()
	{
	}

	private void LoadChar(Action LoadComp)
	{
	}

	private void UserManagerUI(Action action)
	{
	}

	private void LoadManagerUI(Action action)
	{
	}

	private void ReturnManagerUI()
	{
	}

	private void ShowMessage()
	{
	}

	protected override void Update()
	{
	}

	private void GetRandomCooltime()
	{
	}
}
