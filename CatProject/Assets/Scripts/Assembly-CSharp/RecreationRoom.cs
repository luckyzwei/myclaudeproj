public class RecreationRoom : WaitingRoom
{
	public override void CallNextEmployee()
	{
		callNextEmployee();
	}

	private void callNextEmployee()
	{
		base.CallNextEmployee();
	}

	public override void ResetInUseItem()
	{
		base.ResetInUseItem();
	}
}
