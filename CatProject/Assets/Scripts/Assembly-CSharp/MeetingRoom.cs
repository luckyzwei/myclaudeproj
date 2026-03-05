public class MeetingRoom : WaitingRoom
{
	private bool isOpen;

	public int EarnExp { get; private set; }

	public override void Init(int office)
	{
		base.Init(office);
		isOpen = false;
		EarnExp = 0;
		SubscribeItems();
	}

	protected override void SetOpened(bool value)
	{
		isOpen = value;
	}

	public override void CallNextEmployee()
	{
		if (!isOpen) return;
		base.CallNextEmployee();
	}

	public override void ResetInUseItem()
	{
		base.ResetInUseItem();
	}

	private void SubscribeItems()
	{
		UpdateEarnExp();
	}

	private void UpdateEarnExp()
	{
		// Calculate earned experience from meeting room level
	}

	public override bool isInUse()
	{
		return isOpen && base.isInUse();
	}
}
