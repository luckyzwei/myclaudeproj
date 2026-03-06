using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/Popup/PopupSeasonalSlotRankStart", false, false)]
public class PopupSeasonalSlotRankStart : UIBase
{
	[SerializeField]
	private SeasonalCoinRankReward RankReward;

	[SerializeField]
	private Button btnMove;

	protected override void Awake()
	{
		base.Awake();
	}

	private void OnClickMove()
	{
		Hide();
	}
}
