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
		if (Root == null || Item == null || Rewards == null) return;
		for (int i = 0; i < Rewards.Count; i++)
		{
			var go = Instantiate(Item, Root);
			go.SetActive(true);
		}
	}

	public void SetRouletteRatio(bool isluckydraw)
	{
		Rewards = new List<RewardInfo>();
		DrawList();
	}

	public void SetRouletteSpecialRatio()
	{
		Rewards = new List<RewardInfo>();
		DrawList();
	}

	public void SetRouletteAnniversaryRatio()
	{
		Rewards = new List<RewardInfo>();
		DrawList();
	}
}
