using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryUseItem : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private Button UseBtn;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private GameObject BuffRoot;

	[SerializeField]
	private Text BuffValue;

	[SerializeField]
	private Text TimeValue;

	[Header("Battery")]
	[SerializeField]
	private GameObject ActivateObj;

	[Header("Stopwatch")]
	[SerializeField]
	private GameObject RewardRoot;

	[SerializeField]
	private Text RewardValue;

	[SerializeField]
	private Image RewardIcon;

	[Header("Tutorial Free")]
	[SerializeField]
	private GameObject FreeRoot;

	[SerializeField]
	private Button FreeBtn;

	private int ItemIdx;

	private int FactoryIdx;

	private Config.FactoryUseItem ItemType;

	private BigInteger ItemPrice;

	private bool UseFreeItem;

	private IDisposable BatteryDisposable;

	public Action<int, ItemFactoryUseItem> UseItem;

	public Action RefreshCb;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetSubscribe()
	{
	}

	public void Set(int itemIdx, int factory)
	{
	}

	public void UpdateCount()
	{
	}

	public void UpdateActivate()
	{
	}

	private void OnClickBuyItem()
	{
	}

	private void OnClickUseItem()
	{
	}

	private void OnClickFreeItem()
	{
	}

	private void CheckItemUsable(Action<bool> callback)
	{
	}

	private void BuyAndUseItem(int gemPrice)
	{
	}
}
