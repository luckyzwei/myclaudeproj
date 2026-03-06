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
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CFinishAnimate_003Ed__12(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = new WaitForSeconds(0.5f);
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E4__this.IsAnimating = false;
					_003C_003E4__this.OnPlayAnimationEvent?.Invoke(false);
					return false;
				default:
					return false;
			}
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
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public override void Set(int endlessIdx, ShopSystem.InAppPurchaseLocation enterPlace)
	{
		EndlessPackageIdx = endlessIdx;
		EnterPlace = enterPlace;
		Disposables = new CompositeDisposable();
		RewardTableList = new List<EndlessOfferRewardData>();
		IsAnimating = false;
		// Load reward table data for this endless offer
	}

	public override void Reset()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
		IsAnimating = false;
	}

	private void OnClickedItemBuyBtn(int orderIdx, int slotIdx)
	{
		if (IsAnimating) return;
		PurchaseItem(orderIdx, (success) =>
		{
			if (success)
			{
				PlayAnimation();
			}
		});
	}

	private void PlayAnimation()
	{
		IsAnimating = true;
		OnPlayAnimationEvent?.Invoke(true);
		StartCoroutine(FinishAnimate());
	}

	[IteratorStateMachine(typeof(_003CFinishAnimate_003Ed__12))]
	private IEnumerator FinishAnimate()
	{
		var routine = new _003CFinishAnimate_003Ed__12(0);
		routine._003C_003E4__this = this;
		return routine;
	}

	private void PurchaseItem(int orderIdx, Action<bool> callback)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null)
		{
			callback?.Invoke(false);
			return;
		}
		// Process in-app purchase
		callback?.Invoke(false);
	}

	protected void OnPurchaseSuccess(Action callback)
	{
		PlayAnimation();
		callback?.Invoke();
	}

	protected override EndlessOfferRewardData GetTargetRewardTable(int orderIdx)
	{
		if (RewardTableList == null) return default;
		for (int i = 0; i < RewardTableList.Count; i++)
		{
			if (RewardTableList[i].Orderidx == orderIdx)
				return RewardTableList[i];
		}
		return default;
	}
}
