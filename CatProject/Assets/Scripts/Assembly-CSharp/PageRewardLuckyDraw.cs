using System;
using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageRewardLuckyDraw", false, false)]
public class PageRewardLuckyDraw : UIBase
{
	[Serializable]
	private class RewardObj
	{
		[SerializeField]
		public GameObject Root;

		[SerializeField]
		public Image Icon;

		[SerializeField]
		public Text Count;
	}

	private enum AtlasType
	{
		None = 0,
		Dynamic = 1,
		DynamicShop = 2,
		Roulette = 3
	}

	private class RewardItemData
	{
		public int rewardType;

		public int rewardIdx;

		public BigInteger rewardValue;

		public string resImg;

		public AtlasType atlasType;

		public RewardItemData(int _type, int _idx, BigInteger _count, string res = "", AtlasType atlas = AtlasType.None)
		{
		}
	}

	[SerializeField]
	private Image RewardImg;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardName;

	[SerializeField]
	private List<RewardObj> Rewards;

	private Queue<RewardItemData> RemainRewards;

	private int PlantReward;

	private void Show(RewardItemData reward)
	{
	}

	public void ShowRouletteReward(int rouletteIdx, bool isreplaceReward = false)
	{
	}

	public override void Hide()
	{
	}
}
