using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageRewardSpecial", false, false)]
public class PageRewardSpecial : UIBase
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

	private class RewardItemData
	{
		public int rewardType;

		public int rewardIdx;

		public int rewardRegion;

		public BigInteger rewardValue;

		public string resImg;

		public Config.AtlasType atlasType;

		public bool skipOffline;

		public RewardItemData(int _type, int _idx, int _region, BigInteger _count, string res = "", Config.AtlasType atlas = Config.AtlasType.None, bool _skipoffline = false)
		{
		}
	}

	[Header("PageRewardSpecial")]
	[SerializeField]
	private Text Title;

	[SerializeField]
	private Image RewardImg;

	[SerializeField]
	private Text RewardName;

	[SerializeField]
	private List<RewardObj> Rewards;

	[Space(5f)]
	[SerializeField]
	private Button TextBtn;

	[SerializeField]
	private Button EquipBtn;

	[SerializeField]
	private GameObject EquipCompObj;

	[Header("SpecialDay Theme")]
	[SerializeField]
	private Image TileImg;

	[SerializeField]
	private Image TileBgImg;

	private Queue<RewardItemData> RemainRewards;

	private int PlantRewardIdx;

	private int BuffObjectRewardIdx;

	private int NormalKeyRewardCount;

	private int PremiumKeyRewardCount;

	private int CarIdx;

	private bool WaitShow;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnShowAfter()
	{
	}

	private void Show(RewardItemData reward)
	{
	}

	public void ShowSpecialDayReward(int onetimeIdx)
	{
	}

	public void ShowSpecialDayRouletteReward(int rouletteIdx, bool isreplaceReward = false)
	{
	}

	public void ShowSpecialDayLuckyDraw(int plantIdx)
	{
	}

	public void ShowSpecialDayDecoReward(int specialdayIdx)
	{
	}

	private void UpdateSpecialTheme()
	{
	}

	private void InitHideData()
	{
	}

	public override void Hide()
	{
	}

	private void OnClickEquipCar()
	{
	}
}
