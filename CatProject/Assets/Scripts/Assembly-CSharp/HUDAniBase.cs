using Treeplla;
using UnityEngine;

public class HUDAniBase : UIBase
{
	[SerializeField]
	protected HUDType anitype;

	[SerializeField]
	protected HUDType toptype;

	protected bool showUIAni;

	private bool originAniEnalbe;

	private bool originTopEnalbe;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}
}
