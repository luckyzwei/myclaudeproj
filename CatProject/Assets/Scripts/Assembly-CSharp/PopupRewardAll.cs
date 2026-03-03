using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRewardAll", false, false)]
public class PopupRewardAll : UIBase
{
	[CompilerGenerated]
	private sealed class _003CAnimateRewardSlot_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupRewardAll _003C_003E4__this;

		private int _003Ci_003E5__2;

		private ItemArticle _003CrewardSlot_003E5__3;

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
		public _003CAnimateRewardSlot_003Ed__9(int _003C_003E1__state)
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

	[IteratorStateMachine(typeof(_003CAnimateRewardSlot_003Ed__9))]
	private IEnumerator AnimateRewardSlot()
	{
		return null;
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
