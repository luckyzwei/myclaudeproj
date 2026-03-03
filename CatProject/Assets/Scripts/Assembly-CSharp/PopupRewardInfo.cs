using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRewardInfo", false, false)]
public class PopupRewardInfo : UIBase
{
	[SerializeField]
	private Image RewardImg;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text CarDescText;

	[SerializeField]
	private Text TarotDescText;

	public void SetOneTimeCar(int idx)
	{
	}
}
