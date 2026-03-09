using UnityEngine;

public class HintBoosterButton : BoosterButton
{
	private const string ANIM_ANIM_BOOSTERBUTTON_ALERT = "Anim-BoosterButton-Alert";

	public const string HINT_BOOSTER_CLIENT_ID = "hint_booster";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	protected override bool TryPerformAction()
	{
		return false;
	}

	public override void PlayAlertAnimation()
	{
	}
}
