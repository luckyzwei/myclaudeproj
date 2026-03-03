using System;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class SeasonalCoinBankComponent : MonoBehaviour
{
	[SerializeField]
	private SkeletonGraphic PiggyAnim;

	[SerializeField]
	private Text CurLevelText;

	[SerializeField]
	private Text CoinText;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Text MaxText;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private GameObject SaleObj;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private Transform HUDCoin;

	private bool bShop;

	public Action LevelUpCallback;

	private void Awake()
	{
	}

	public void Init(bool isShop)
	{
	}

	private void SetPiggySkin(int level)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickBuyCoinBank()
	{
	}
}
