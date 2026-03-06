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
		if (type == E_PopupType.TrialStart)
			SetTrialStart();
		else
			SetTrialEnd();
	}

	private void SetTrialStart()
	{
		if (Point2xNotiObj != null) Point2xNotiObj.SetActive(true);
	}

	private void SetTrialEnd()
	{
		if (Point2xNotiObj != null) Point2xNotiObj.SetActive(false);
	}
}
