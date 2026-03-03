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
	}

	public void SetManager(int grade)
	{
	}

	private int GetGrade(int idx)
	{
		return 0;
	}
}
