using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		if (UseBtn != null) UseBtn.onClick.AddListener(OnClickUseItem);
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickBuyItem);
		if (FreeBtn != null) FreeBtn.onClick.AddListener(OnClickFreeItem);
	}

	private void OnDisable()
	{
		ResetSubscribe();
	}

	private void ResetSubscribe()
	{
		if (BatteryDisposable != null) { BatteryDisposable.Dispose(); BatteryDisposable = null; }
	}

	public void Set(int itemIdx, int factory)
	{
		ItemIdx = itemIdx;
		FactoryIdx = factory;
		UseFreeItem = false;
		UpdateCount();
		UpdateActivate();
	}

	public void UpdateCount()
	{
		if (Count != null) Count.text = "0";
		if (PriceText != null) PriceText.text = ProjectUtility.GetThousandCommaText(ItemPrice);
	}

	public void UpdateActivate()
	{
		if (ActivateObj != null) ActivateObj.SetActive(false);
		if (FreeRoot != null) FreeRoot.SetActive(UseFreeItem);
	}

	private void OnClickBuyItem()
	{
		int gemPrice = (int)ItemPrice;
		BuyAndUseItem(gemPrice);
	}

	private void OnClickUseItem()
	{
		CheckItemUsable((usable) =>
		{
			if (usable)
			{
				UseItem?.Invoke(ItemIdx, this);
				RefreshCb?.Invoke();
			}
		});
	}

	private void OnClickFreeItem()
	{
		UseFreeItem = true;
		UseItem?.Invoke(ItemIdx, this);
		RefreshCb?.Invoke();
	}

	private void CheckItemUsable(Action<bool> callback)
	{
		callback?.Invoke(true);
	}

	private void BuyAndUseItem(int gemPrice)
	{
		UseItem?.Invoke(ItemIdx, this);
		RefreshCb?.Invoke();
	}
}
