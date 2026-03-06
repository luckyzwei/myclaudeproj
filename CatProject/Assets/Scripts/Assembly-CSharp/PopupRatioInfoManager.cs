using System.Collections.Generic;
using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupRatioInfoManager", false, false)]
public class PopupRatioInfoManager : UIBase
{
	private class RewardInfo
	{
		public Sprite img;

		public string name;

		public float ratio;

		public int type;

		public int idx;
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
			var obj = Instantiate(Item, Root);
			obj.SetActive(true);
		}
	}

	public void SetManager(int grade)
	{
		if (Rewards == null) Rewards = new List<RewardInfo>();
		Rewards.Clear();
		DrawList();
	}

	private int GetGrade(int idx)
	{
		return 0;
	}
}
