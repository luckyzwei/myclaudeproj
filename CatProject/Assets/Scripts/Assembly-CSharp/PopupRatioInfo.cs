using System.Collections.Generic;
using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupRatioInfo", false, false)]
public class PopupRatioInfo : UIBase
{
	private class RewardInfo
	{
		public Sprite img;

		public string name;

		public float ratio;

		public int type;

		public int idx;

		public bool isSpecialReward;
	}

	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GameObject Item;

	private List<RewardInfo> Rewards;

	private void DrawList()
	{
	}

	public void SetRouletteRatio(bool isluckydraw)
	{
	}

	public void SetRouletteSpecialRatio()
	{
	}

	public void SetRouletteAnniversaryRatio()
	{
	}
}
