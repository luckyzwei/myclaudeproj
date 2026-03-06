using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupTutoReward", false, false)]
public class PopupTutoReward : UIBase
{
	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardValue;

	private bool isGetReward;

	public int TutoNum { get; private set; }

	public void Set(int idx)
	{
		TutoNum = idx;
		isGetReward = false;
	}

	public override void OnHideAfter()
	{
		if (!isGetReward)
		{
			isGetReward = true;
		}
	}

	private void OnDestroy()
	{
		// Cleanup
	}
}
