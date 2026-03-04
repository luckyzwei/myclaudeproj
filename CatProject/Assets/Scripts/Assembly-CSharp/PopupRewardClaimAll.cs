using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRewardClaimAll", false, false)]
public class PopupRewardClaimAll : UIBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public RewardItemData rewardItemData;

		internal bool _003CAnimateRewardSlot_003Eb__0(RewardItemData rewardData)
		{
			return false;
		}

		internal bool _003CAnimateRewardSlot_003Eb__1(ItemArticle item)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateRewardSlot_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupRewardClaimAll _003C_003E4__this;

		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		private List<RewardItemData> _003CtotalRewardList_003E5__2;

		private int _003Ci_003E5__3;

		private ItemArticle _003CrewardSlot_003E5__4;

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
		public _003CAnimateRewardSlot_003Ed__10(int _003C_003E1__state)
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
	private ScrollRect RewardScrollRect;

	[SerializeField]
	private GameObject RewardSlotPrefab;

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private List<ItemArticle> RewardResultItemList;

	[SerializeField]
	protected string RewardGetSoundName;

	private List<ItemArticle> RewardSlotList;

	private List<IRewardItemData> RewardItemDataList;

	private Coroutine AnimateCoroutine;

	protected override void Awake()
	{
	}

	public void ShowRewards(List<IRewardItemData> rewardList)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateRewardSlot_003Ed__10))]
	private IEnumerator AnimateRewardSlot()
	{
		yield break;
	}

	private void SetAllRewardSlot()
	{
	}

	private void OnClickedConfirmBtn()
	{
	}

	public override void OnHideBefore()
	{
	}
}
