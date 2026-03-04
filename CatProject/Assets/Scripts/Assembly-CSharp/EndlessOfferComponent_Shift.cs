using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class EndlessOfferComponent_Shift : EndlessOfferComponentBase
{
	[CompilerGenerated]
	private sealed class _003CAnimateItemScaleOut_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemShopEndless item;

		public EndlessOfferComponent_Shift _003C_003E4__this;

		private Vector3 _003CstartScale_003E5__2;

		private Vector3 _003CendScale_003E5__3;

		private float _003CelapsedTime_003E5__4;

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
		public _003CAnimateItemScaleOut_003Ed__25(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAnimateItemShift_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndlessOfferComponent_Shift _003C_003E4__this;

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
		public _003CAnimateItemShift_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAnimateSnakeShift_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndlessOfferComponent_Shift _003C_003E4__this;

		private int _003CtotalItems_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CAnimateSnakeShift_003Ed__26(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CMoveItemToPositionWithOvershoot_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemShopEndless item;

		public EndlessOfferComponent_Shift _003C_003E4__this;

		public Vector3 targetPosition;

		private Vector3 _003CstartPosition_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private Vector3 _003CovershootPosition_003E5__4;

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
		public _003CMoveItemToPositionWithOvershoot_003Ed__27(int _003C_003E1__state)
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
	private Image MainImage;

	[SerializeField]
	private TimeComponent RemainTimeComp;

	[SerializeField]
	private GameObject ItemRoot;

	[SerializeField]
	private float AnimationDuration;

	[SerializeField]
	private float AnimationDelay;

	[SerializeField]
	private float ScaleAnimationDuration;

	[SerializeField]
	private float OvershootStrength;

	[SerializeField]
	private float OvershootDuration;

	[Header("Sound")]
	[SerializeField]
	protected string ItemMoveSound;

	private List<ItemShopEndless> ItemShopEndlessList;

	private List<Vector3> ItemShopEndlessPositionList;

	private bool IsAnimating;

	private List<EndlessOfferRewardData> RewardTableList;

	private List<EndlessOfferRewardData> RepeatRewardTableList;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Set(int endlessIdx, ShopSystem.InAppPurchaseLocation enterPlace)
	{
	}

	public override void Reset()
	{
	}

	private void SetMainImage(EndlessOfferInfoData offerInfo)
	{
	}

	protected override EndlessOfferRewardData GetTargetRewardTable(int orderIdx)
	{
		return null;
	}

	private void OnClickedItemBuyBtn(int orderIdx, int slotIdx)
	{
	}

	private void PurchaseItem(int orderIdx, Action<bool> callback)
	{
	}

	protected void OnPurchaseSuccess(Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateItemShift_003Ed__24))]
	private IEnumerator AnimateItemShift()
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CAnimateItemScaleOut_003Ed__25))]
	private IEnumerator AnimateItemScaleOut(ItemShopEndless item)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CAnimateSnakeShift_003Ed__26))]
	private IEnumerator AnimateSnakeShift()
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CMoveItemToPositionWithOvershoot_003Ed__27))]
	private IEnumerator MoveItemToPositionWithOvershoot(ItemShopEndless item, Vector3 targetPosition)
	{
		yield break;
	}

	private void UpdateItemList()
	{
	}

	private void UpdateRedDot()
	{
	}
}
