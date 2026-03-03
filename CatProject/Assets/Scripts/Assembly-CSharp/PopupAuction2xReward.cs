using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAuction2xReward", false, false)]
public class PopupAuction2xReward : UIBase
{
	public enum E_PopupType
	{
		TrialStart = 0,
		TrialEnd = 1
	}

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private GameObject Point2xNotiObj;

	public void SetType(E_PopupType type)
	{
	}

	private void SetTrialStart()
	{
	}

	private void SetTrialEnd()
	{
	}
}
