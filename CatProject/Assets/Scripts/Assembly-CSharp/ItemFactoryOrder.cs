using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryOrder : MonoBehaviour
{
	public enum State
	{
		None = -1,
		Lock = 0,
		UnLock = 1
	}

	[Header("NotOpen")]
	[SerializeField]
	private GameObject NotOpenObj;

	[SerializeField]
	private Image OpenPriceImg;

	[SerializeField]
	private Text OpenPriceText;

	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private Button OpenPurchaseBtn;

	[SerializeField]
	private Text OpenPurchasePriceText;

	[SerializeField]
	private Text OpenPurchaseBeforePriceText;

	[SerializeField]
	private Text OpenPurchaseBeforeSaleText;

	[Header("Skip")]
	[SerializeField]
	private GameObject SkipRoot;

	[SerializeField]
	private Text RemainResetText;

	[SerializeField]
	private Text ResetPriceText;

	[SerializeField]
	private Button ResetBtn;

	[SerializeField]
	private Button ResetFreeBtn;

	[SerializeField]
	private Text ResetFreeText;

	[Header("Order")]
	[SerializeField]
	private GameObject OrderRoot;

	[SerializeField]
	private GameObject OrderSelectObj;

	[SerializeField]
	private Button OrderSelectBtn;

	[SerializeField]
	private Image OrderIcon;

	[SerializeField]
	private Text OrderCount;

	[SerializeField]
	private GameObject EnableOrderCompObj;

	[Header("Character")]
	[SerializeField]
	private Image CharacterIcon;

	[Header("Lock")]
	[SerializeField]
	private GameObject LockObj;

	[Header("Etc")]
	[SerializeField]
	private GameObject FxOpen;

	public Action<int> SelectCb;

	public Action OpenCb;

	public Action RefreshCb;

	private State state;

	private int SlotResetCost;

	private CompositeDisposable Disposables;

	private bool AutoReset;

	public int SlotIdx { get; private set; }

	private void Awake()
	{
	}

	public void Set(int slot, bool autoReset)
	{
	}

	private void SetUnLockState(FactoryOrderSlotData slotData)
	{
	}

	private void SetLockState()
	{
	}

	public void Refresh()
	{
	}

	public void Reset()
	{
	}

	public void SetLock()
	{
	}

	public void SetSelected(bool value)
	{
	}

	private void OnClickOpenSlot()
	{
	}

	public void ShowFx()
	{
	}

	private void OnClickResetSlot()
	{
	}

	private void OnClickSelect()
	{
	}

	private void OnDisable()
	{
	}
}
