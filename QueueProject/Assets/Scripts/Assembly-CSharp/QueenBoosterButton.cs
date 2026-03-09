public class QueenBoosterButton : BoosterButton
{
	private const string ANIM_ANIM_BOOSTERBUTTON_ALERT = "Anim-BoosterButton-Alert";

	public const string QUEEN_BOOSTER_CLIENT_ID = "queen_booster";

	public const int QUEEN_BOOSTER_UNNY_ID = 3074;

	protected override bool TryPerformAction()
	{
		return false;
	}

	public override void PlayAlertAnimation()
	{
	}
}
