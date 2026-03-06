using System;
using Treeplla;
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
		Disposables = new CompositeDisposable();

		if (OpenBtn != null) OpenBtn.onClick.AddListener(OnClickOpenSlot);
		if (OpenPurchaseBtn != null) OpenPurchaseBtn.onClick.AddListener(OnClickOpenSlot);
		if (ResetBtn != null) ResetBtn.onClick.AddListener(OnClickResetSlot);
		if (ResetFreeBtn != null) ResetFreeBtn.onClick.AddListener(OnClickResetSlot);
		if (OrderSelectBtn != null) OrderSelectBtn.onClick.AddListener(OnClickSelect);
	}

	public void Set(int slot, bool autoReset)
	{
		SlotIdx = slot;
		AutoReset = autoReset;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		// Get slot data from FactorySystem
		Refresh();
	}

	private void SetUnLockState(FactoryOrderSlotData slotData)
	{
		state = State.UnLock;
		if (NotOpenObj != null) NotOpenObj.SetActive(false);
		if (LockObj != null) LockObj.SetActive(false);
		if (OrderRoot != null) OrderRoot.SetActive(true);

		if (slotData.OrderProduct > 0)
		{
			if (OrderSelectObj != null) OrderSelectObj.SetActive(false);
			if (OrderCount != null) OrderCount.text = slotData.OrderCount.ToString();
			if (SkipRoot != null) SkipRoot.SetActive(true);
		}
		else
		{
			if (OrderSelectObj != null) OrderSelectObj.SetActive(true);
			if (SkipRoot != null) SkipRoot.SetActive(false);
		}

		bool isComplete = slotData.OrderProduct > 0 && slotData.OrderCount <= 0;
		if (EnableOrderCompObj != null) EnableOrderCompObj.SetActive(isComplete);
	}

	private void SetLockState()
	{
		state = State.Lock;
		if (NotOpenObj != null) NotOpenObj.SetActive(true);
		if (LockObj != null) LockObj.SetActive(false);
		if (OrderRoot != null) OrderRoot.SetActive(false);
		if (SkipRoot != null) SkipRoot.SetActive(false);
	}

	public void Refresh()
	{
		RefreshCb?.Invoke();
	}

	public void Reset()
	{
		state = State.None;
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void SetLock()
	{
		if (LockObj != null) LockObj.SetActive(true);
		if (NotOpenObj != null) NotOpenObj.SetActive(false);
		if (OrderRoot != null) OrderRoot.SetActive(false);
	}

	public void SetSelected(bool value)
	{
		if (OrderSelectObj != null) OrderSelectObj.SetActive(!value);
	}

	private void OnClickOpenSlot()
	{
		OpenCb?.Invoke();
		ShowFx();
	}

	public void ShowFx()
	{
		if (FxOpen != null)
		{
			FxOpen.SetActive(false);
			FxOpen.SetActive(true);
		}
	}

	private void OnClickResetSlot()
	{
		// Reset order slot (spend gems or use free reset)
		Refresh();
	}

	private void OnClickSelect()
	{
		SelectCb?.Invoke(SlotIdx);
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}
}
