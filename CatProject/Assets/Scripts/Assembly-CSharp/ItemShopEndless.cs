using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopEndless : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayUnlockAnim_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemShopEndless _003C_003E4__this;

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
		public _003CPlayUnlockAnim_003Ed__44(int _003C_003E1__state)
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

	[SerializeField]
	private Image BgImg;

	[SerializeField]
	private GameObject ItemRoot;

	[SerializeField]
	private GameObject ItemObj;

	[SerializeField]
	private GameObject SoldOutObj;

	[SerializeField]
	private List<GameObject> SoldOutDeactiveObjs;

	[SerializeField]
	private GameObject ArrowObj;

	[SerializeField]
	private GameObject RedDotObj;

	[Header("Buy")]
	[SerializeField]
	private GameObject FreeBuyObj;

	[SerializeField]
	private Button FreeBuyBtn;

	[SerializeField]
	private GameObject CommonBuyObj;

	[SerializeField]
	private Text BuyPriceText;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private Animator UnlockAnimator;

	[Header("Sale")]
	[SerializeField]
	private List<GameObject> SaleObjList;

	[SerializeField]
	private Text SalePercentText;

	[SerializeField]
	private Text OriginPriceText;

	private List<ItemArticle> ItemArticles;

	public Action<int, int> OnClickBuyEvent;

	public int EndlessPackageIdx { get; private set; }

	public int OrderIdx { get; private set; }

	public int SlotIdx { get; private set; }

	public List<IRewardItemData> RewardItemList { get; private set; }

	private void Awake()
	{
	}

	public void Set(int packageIdx, int orderIdx)
	{
	}

	public void SetSoldOut(bool isSoldOut)
	{
	}

	public void SetArrowVisibility(bool isShow)
	{
	}

	public void SetRedDot(bool isShow)
	{
	}

	public void SetEmpty()
	{
	}

	public void SetSlotIdx(int slotIdx)
	{
	}

	private void SetRewardItemList(EndlessOfferRewardData endlessRewardTable)
	{
	}

	public void SetIsLock(bool isLock, bool bPlayAnim)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayUnlockAnim_003Ed__44))]
	private IEnumerator PlayUnlockAnim()
	{
		return null;
	}

	private void OnClickBuyBtn()
	{
	}
}
