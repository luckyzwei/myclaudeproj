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
	}

	public void Init(Config.E_FactoryEnterType placeType)
	{
	}

	public void SetSlotOpen()
	{
	}

	private void ShowNextOrder()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusOrderSlot_003Ed__32))]
	private IEnumerator FocusOrderSlot()
	{
		yield break;
	}

	private void UpdateOrder()
	{
	}

	private void UpdateSelect()
	{
	}

	public void RefreshSlot()
	{
	}

	private void OnClickSelect(int slot)
	{
	}

	private void OnClickCompOrder()
	{
	}

	private void OnClickResetOrder()
	{
	}

	private void OnClickProductShortCut()
	{
	}

	private void OnClickInfo()
	{
	}

	private void InitDailyReward()
	{
	}

	public void UpdateDailyRewards()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
