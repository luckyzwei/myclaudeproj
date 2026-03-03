public class MeetingRoom : WaitingRoom
{
	private bool isOpen;

	public int EarnExp { get; private set; }

	public override void Init(int office)
	{
	}

	protected override void SetOpened(bool value)
	{
	}

	public override void CallNextEmployee()
	{
	}

	public override void ResetInUseItem()
	{
	}

	private void SubscribeItems()
	{
	}

	private void UpdateEarnExp()
	{
	}

	public override bool isInUse()
	{
		return false;
	}
}
