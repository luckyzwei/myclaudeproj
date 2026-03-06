using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using EndlessOfferRewardData = Treeplla.Data.EndlessOfferRewardData;
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
		Disposables = new CompositeDisposable();
		ItemShopEndlessList = new List<ItemShopEndless>();
		ItemShopEndlessPositionList = new List<Vector3>();
		RewardTableList = new List<EndlessOfferRewardData>();
		RepeatRewardTableList = new List<EndlessOfferRewardData>();
		IsAnimating = false;
	}

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

		if (ItemRoot != null)
		{
			ItemShopEndlessList.Clear();
			ItemShopEndlessPositionList.Clear();
			var items = ItemRoot.GetComponentsInChildren<ItemShopEndless>(true);
			for (int i = 0; i < items.Length; i++)
			{
				ItemShopEndlessList.Add(items[i]);
				ItemShopEndlessPositionList.Add(items[i].transform.localPosition);
			}
		}

		UpdateItemList();
		UpdateRedDot();
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

	private void SetMainImage(EndlessOfferInfoData offerInfo)
	{
		if (MainImage == null) return;
	}

	protected override EndlessOfferRewardData GetTargetRewardTable(int orderIdx)
	{
		if (RewardTableList != null)
		{
			for (int i = 0; i < RewardTableList.Count; i++)
			{
				if (RewardTableList[i].Orderidx == orderIdx)
					return RewardTableList[i];
			}
		}
		if (RepeatRewardTableList != null && RepeatRewardTableList.Count > 0)
		{
			int repeatIdx = orderIdx % RepeatRewardTableList.Count;
			return RepeatRewardTableList[repeatIdx];
		}
		return default;
	}

	private void OnClickedItemBuyBtn(int orderIdx, int slotIdx)
	{
		if (IsAnimating) return;
		PurchaseItem(orderIdx, (success) =>
		{
			if (success)
			{
				OnPurchaseSuccess(() =>
				{
					UpdateItemList();
					UpdateRedDot();
				});
			}
		});
	}

	private void PurchaseItem(int orderIdx, Action<bool> callback)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null)
		{
			callback?.Invoke(false);
			return;
		}
		callback?.Invoke(false);
	}

	protected void OnPurchaseSuccess(Action callback)
	{
		if (ItemShopEndlessList == null || ItemShopEndlessList.Count == 0)
		{
			callback?.Invoke();
			return;
		}
		IsAnimating = true;
		OnPlayAnimationEvent?.Invoke(true);
		StartCoroutine(AnimateItemShift());
		Observable.Timer(TimeSpan.FromSeconds(AnimationDuration + AnimationDelay * ItemShopEndlessList.Count))
			.Subscribe(_ =>
			{
				IsAnimating = false;
				OnPlayAnimationEvent?.Invoke(false);
				callback?.Invoke();
			}).AddTo(Disposables);
	}

	[IteratorStateMachine(typeof(_003CAnimateItemShift_003Ed__24))]
	private IEnumerator AnimateItemShift()
	{
		if (ItemShopEndlessList == null || ItemShopEndlessList.Count == 0) yield break;
		var firstItem = ItemShopEndlessList[0];
		yield return StartCoroutine(AnimateItemScaleOut(firstItem));
		yield return StartCoroutine(AnimateSnakeShift());
	}

	[IteratorStateMachine(typeof(_003CAnimateItemScaleOut_003Ed__25))]
	private IEnumerator AnimateItemScaleOut(ItemShopEndless item)
	{
		if (item == null) yield break;
		Vector3 startScale = item.transform.localScale;
		Vector3 endScale = Vector3.zero;
		float elapsedTime = 0f;
		while (elapsedTime < ScaleAnimationDuration)
		{
			elapsedTime += Time.deltaTime;
			float t = Mathf.Clamp01(elapsedTime / ScaleAnimationDuration);
			item.transform.localScale = Vector3.Lerp(startScale, endScale, t);
			yield return null;
		}
		item.transform.localScale = endScale;
		item.gameObject.SetActive(false);
	}

	[IteratorStateMachine(typeof(_003CAnimateSnakeShift_003Ed__26))]
	private IEnumerator AnimateSnakeShift()
	{
		int totalItems = ItemShopEndlessList != null ? ItemShopEndlessList.Count : 0;
		for (int i = 1; i < totalItems; i++)
		{
			if (ItemShopEndlessList[i] == null) continue;
			Vector3 targetPos = ItemShopEndlessPositionList[i - 1];
			StartCoroutine(MoveItemToPositionWithOvershoot(ItemShopEndlessList[i], targetPos));
			yield return new WaitForSeconds(AnimationDelay);
		}
	}

	[IteratorStateMachine(typeof(_003CMoveItemToPositionWithOvershoot_003Ed__27))]
	private IEnumerator MoveItemToPositionWithOvershoot(ItemShopEndless item, Vector3 targetPosition)
	{
		if (item == null) yield break;
		Vector3 startPosition = item.transform.localPosition;
		float elapsedTime = 0f;
		Vector3 overshootPosition = targetPosition + (targetPosition - startPosition).normalized * OvershootStrength;

		while (elapsedTime < AnimationDuration)
		{
			elapsedTime += Time.deltaTime;
			float t = Mathf.Clamp01(elapsedTime / AnimationDuration);
			item.transform.localPosition = Vector3.Lerp(startPosition, overshootPosition, t);
			yield return null;
		}

		elapsedTime = 0f;
		while (elapsedTime < OvershootDuration)
		{
			elapsedTime += Time.deltaTime;
			float t = Mathf.Clamp01(elapsedTime / OvershootDuration);
			item.transform.localPosition = Vector3.Lerp(overshootPosition, targetPosition, t);
			yield return null;
		}
		item.transform.localPosition = targetPosition;
	}

	private void UpdateItemList()
	{
		if (ItemShopEndlessList == null) return;
		for (int i = 0; i < ItemShopEndlessList.Count; i++)
		{
			if (ItemShopEndlessList[i] == null) continue;
			ItemShopEndlessList[i].gameObject.SetActive(true);
			ItemShopEndlessList[i].transform.localScale = Vector3.one;
			if (i < ItemShopEndlessPositionList.Count)
				ItemShopEndlessList[i].transform.localPosition = ItemShopEndlessPositionList[i];
		}
	}

	private void UpdateRedDot()
	{
	}
}
