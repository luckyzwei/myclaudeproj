using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupEventRewardGet", false, false)]
public class PopupEventRewardGet : UIBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public RewardItemData rewardItemData;

		internal bool _003CAnimateRewardSlot_003Eb__0(RewardItemData rewardData)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateRewardSlot_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupEventRewardGet _003C_003E4__this;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		private List<RewardItemData> _003CtotalRewardList_003E5__2;

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
		public _003CAnimateRewardSlot_003Ed__11(int _003C_003E1__state)
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
	private ItemArticle CoinRewardInfo;

	[SerializeField]
	private ItemArticle CashRewardInfo;

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

	[IteratorStateMachine(typeof(_003CAnimateRewardSlot_003Ed__11))]
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
}
