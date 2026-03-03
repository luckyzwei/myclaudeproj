using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;

public class EndlessOfferComponent_Scroll : EndlessOfferComponentBase
{
	[CompilerGenerated]
	private sealed class _003CFinishAnimate_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndlessOfferComponent_Scroll _003C_003E4__this;

		private ItemShopEndless _003CslotComp_003E5__2;

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
		public _003CFinishAnimate_003Ed__12(int _003C_003E1__state)
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
	private TimeComponent RemainTimeComp;

	[SerializeField]
	private RecycleScrollRect ScrollRect;

	[SerializeField]
	private int ShowCount;

	[SerializeField]
	private RecycleScrollRect.AnimParams AnimParams;

	private bool IsAnimating;

	private List<EndlessOfferRewardData> RewardTableList;

	private CompositeDisposable Disposables;

	private void OnDestroy()
	{
	}

	public override void Set(int endlessIdx, ShopSystem.InAppPurchaseLocation enterPlace)
	{
	}

	public override void Reset()
	{
	}

	private void OnClickedItemBuyBtn(int orderIdx, int slotIdx)
	{
	}

	private void PlayAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CFinishAnimate_003Ed__12))]
	private IEnumerator FinishAnimate()
	{
		return null;
	}

	private void PurchaseItem(int orderIdx, Action<bool> callback)
	{
	}

	protected void OnPurchaseSuccess(Action callback)
	{
	}

	protected override EndlessOfferRewardData GetTargetRewardTable(int orderIdx)
	{
		return null;
	}
}
