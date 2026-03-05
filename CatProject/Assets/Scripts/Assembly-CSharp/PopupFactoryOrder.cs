using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFactoryOrder", false, false)]
public class PopupFactoryOrder : UIBase
{
	[CompilerGenerated]
	private sealed class _003CFocusOrderSlot_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupFactoryOrder _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFocusOrderSlot_003Ed__32(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("SelectOrder")]
	[SerializeField]
	private Image OrderIcon;

	[SerializeField]
	private Text OrderItemName;

	[SerializeField]
	private Text OrderCount;

	[SerializeField]
	private Text OrderReward;

	[SerializeField]
	private Button OrderCompBtn;

	[SerializeField]
	private Button OrderResetBtn;

	[SerializeField]
	private GameObject OrderWaitObj;

	[SerializeField]
	private GameObject OrderInfoObj;

	[SerializeField]
	private Button ProductShortCutBtn;

	[SerializeField]
	private GameObject OrderCompRedDotObj;

	[Header("Character")]
	[SerializeField]
	private Image OrderCharacterIcon;

	[SerializeField]
	private Text OrderCharacterTalkText;

	[Header("List")]
	[SerializeField]
	private ScrollRect SlotScrollRect;

	[SerializeField]
	private List<ItemFactoryOrder> Slots;

	[Space(5f)]
	[Header("DailyOrderReward")]
	[SerializeField]
	private Slider DailyRewardProgressSlider;

	[SerializeField]
	private Transform ItemFactoryDailyRewardContent;

	[SerializeField]
	private ItemFactoryDailyReward ItemFactoryDailyRewardLast;

	[SerializeField]
	private List<ItemFactoryDailyReward> ItemFactoryDailyRewards;

	[SerializeField]
	private GameObject ItemFactoryDailyRewardPrefab;

	[SerializeField]
	private Text RemainResetTimeText;

	[SerializeField]
	private Text CurOrderCountText;

	[SerializeField]
	private Button InfoButton;

	private int SelectOrder;

	private float MaxOrder;

	private bool SlotOpen;

	private CompositeDisposable product_disposables;

	private CompositeDisposable disposable;

	private Config.E_FactoryEnterType EnterType;

	protected override void Awake()
	{
		base.Awake();
		product_disposables = new CompositeDisposable();
		disposable = new CompositeDisposable();
		SelectOrder = 0;
		SlotOpen = false;

		if (OrderCompBtn != null) OrderCompBtn.onClick.AddListener(OnClickCompOrder);
		if (OrderResetBtn != null) OrderResetBtn.onClick.AddListener(OnClickResetOrder);
		if (ProductShortCutBtn != null) ProductShortCutBtn.onClick.AddListener(OnClickProductShortCut);
		if (InfoButton != null) InfoButton.onClick.AddListener(OnClickInfo);
	}

	public void Init(Config.E_FactoryEnterType placeType)
	{
		EnterType = placeType;
		SelectOrder = 0;
		SlotOpen = false;
		if (Slots != null)
		{
			for (int i = 0; i < Slots.Count; i++)
			{
				int slotIdx = i;
				// Bind slot click callbacks
			}
		}
		UpdateOrder();
		UpdateSelect();
		InitDailyReward();
	}

	public void SetSlotOpen()
	{
		SlotOpen = true;
	}

	private void ShowNextOrder()
	{
		if (Slots == null || Slots.Count == 0) return;
		int nextSlot = (SelectOrder + 1) % Slots.Count;
		OnClickSelect(nextSlot);
	}

	[IteratorStateMachine(typeof(_003CFocusOrderSlot_003Ed__32))]
	private IEnumerator FocusOrderSlot()
	{
		yield return null;
		if (SlotScrollRect != null && Slots != null && SelectOrder >= 0 && SelectOrder < Slots.Count)
		{
			float normalizedPos = (float)SelectOrder / Mathf.Max(1, Slots.Count - 1);
			SlotScrollRect.horizontalNormalizedPosition = Mathf.Clamp01(normalizedPos);
		}
	}

	private void UpdateOrder()
	{
		if (Slots == null) return;
		for (int i = 0; i < Slots.Count; i++)
		{
			if (Slots[i] != null)
			{
				// Refresh each slot order data
			}
		}
		UpdateSelect();
	}

	private void UpdateSelect()
	{
		if (Slots == null || SelectOrder < 0 || SelectOrder >= Slots.Count) return;
		if (OrderInfoObj != null) OrderInfoObj.SetActive(true);
		if (OrderWaitObj != null) OrderWaitObj.SetActive(false);
		if (OrderCompRedDotObj != null) OrderCompRedDotObj.SetActive(false);
		// Update selected order detail info
	}

	public void RefreshSlot()
	{
		UpdateOrder();
		UpdateDailyRewards();
	}

	private void OnClickSelect(int slot)
	{
		if (slot < 0 || Slots == null || slot >= Slots.Count) return;
		SelectOrder = slot;
		UpdateSelect();
		StartCoroutine(FocusOrderSlot());
	}

	private void OnClickCompOrder()
	{
		// Complete current order and grant reward
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		// Complete factory order
	}

	private void OnClickResetOrder()
	{
		// Reset/refresh the current order
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		// Reset factory order
	}

	private void OnClickProductShortCut()
	{
		// Navigate to product production
		Hide();
	}

	private void OnClickInfo()
	{
		// Show order info popup
	}

	private void InitDailyReward()
	{
		if (ItemFactoryDailyRewards == null) return;
		// Initialize daily reward items
		UpdateDailyRewards();
	}

	public void UpdateDailyRewards()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Update daily order reward progress
		if (DailyRewardProgressSlider != null)
		{
			// Set progress based on completed orders today
		}
	}

	private void OnDisable()
	{
		if (product_disposables != null)
		{
			product_disposables.Dispose();
			product_disposables = new CompositeDisposable();
		}
	}

	private void OnDestroy()
	{
		if (disposable != null)
		{
			disposable.Dispose();
			disposable = null;
		}
		if (product_disposables != null)
		{
			product_disposables.Dispose();
			product_disposables = null;
		}
	}
}
