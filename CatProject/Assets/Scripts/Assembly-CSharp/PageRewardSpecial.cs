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
		base.Awake();
		RemainRewards = new Queue<RewardItemData>();

		if (TextBtn != null) TextBtn.onClick.AddListener(() => Hide());
		if (EquipBtn != null) EquipBtn.onClick.AddListener(OnClickEquipCar);
	}

	public override void OnShowBefore()
	{
		WaitShow = false;
		if (EquipCompObj != null) EquipCompObj.SetActive(false);
		if (EquipBtn != null) EquipBtn.gameObject.SetActive(false);
		UpdateSpecialTheme();
	}

	public override void OnShowAfter()
	{
	}

	private void Show(RewardItemData reward)
	{
		if (reward == null) return;

		// Clear existing reward display
		if (Rewards != null)
		{
			for (int i = 0; i < Rewards.Count; i++)
			{
				if (Rewards[i] != null && Rewards[i].Root != null)
					Rewards[i].Root.SetActive(false);
			}
		}
	}

	public void ShowSpecialDayReward(int onetimeIdx)
	{
		// Show one-time event reward
	}

	public void ShowSpecialDayRouletteReward(int rouletteIdx, bool isreplaceReward = false)
	{
		// Show roulette reward
	}

	public void ShowSpecialDayLuckyDraw(int plantIdx)
	{
		PlantRewardIdx = plantIdx;
		// Show lucky draw plant reward
	}

	public void ShowSpecialDayDecoReward(int specialdayIdx)
	{
		// Show special day decoration reward
	}

	private void UpdateSpecialTheme()
	{
		// Update tile images for special day theme
	}

	private void InitHideData()
	{
		PlantRewardIdx = 0;
		BuffObjectRewardIdx = 0;
		NormalKeyRewardCount = 0;
		PremiumKeyRewardCount = 0;
		CarIdx = 0;
		RemainRewards.Clear();
	}

	public override void Hide()
	{
		if (RemainRewards.Count > 0)
		{
			var next = RemainRewards.Dequeue();
			Show(next);
			return;
		}
		InitHideData();
		base.Hide();
	}

	private void OnClickEquipCar()
	{
		if (CarIdx <= 0) return;
		// Equip the car reward
		if (EquipCompObj != null) EquipCompObj.SetActive(true);
		if (EquipBtn != null) EquipBtn.gameObject.SetActive(false);
	}
}
