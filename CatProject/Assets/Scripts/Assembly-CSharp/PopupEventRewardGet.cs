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
			return rewardData.rewardType == rewardItemData.rewardType && rewardData.rewardIdx == rewardItemData.rewardIdx;
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
		public _003CAnimateRewardSlot_003Ed__11(int _003C_003E1__state)
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
					if (_003C_003E4__this.RewardSlotList == null || _003C_003E4__this.RewardSlotList.Count == 0)
						return false;
					_003Ci_003E5__3 = 0;
					goto case 2;
				case 1:
					_003C_003E1__state = -1;
					_003Ci_003E5__3++;
					goto case 2;
				case 2:
					if (_003Ci_003E5__3 < _003C_003E4__this.RewardSlotList.Count)
					{
						if (_003C_003E4__this.RewardSlotList[_003Ci_003E5__3] != null)
							_003C_003E4__this.RewardSlotList[_003Ci_003E5__3].gameObject.SetActive(true);
						_003C_003E2__current = new WaitForSeconds(0.15f);
						_003C_003E1__state = 1;
						return true;
					}
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
		base.Awake();
		RewardSlotList = new List<ItemArticle>();
		RewardItemDataList = new List<IRewardItemData>();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(OnClickedConfirmBtn);
	}

	public void ShowRewards(List<IRewardItemData> rewardList)
	{
		RewardItemDataList = rewardList ?? new List<IRewardItemData>();
		SetAllRewardSlot();
		Show();
		if (AnimateCoroutine != null) StopCoroutine(AnimateCoroutine);
		AnimateCoroutine = StartCoroutine(AnimateRewardSlot());
	}

	[IteratorStateMachine(typeof(_003CAnimateRewardSlot_003Ed__11))]
	private IEnumerator AnimateRewardSlot()
	{
		var routine = new _003CAnimateRewardSlot_003Ed__11(0);
		routine._003C_003E4__this = this;
		return routine;
	}

	private void SetAllRewardSlot()
	{
		for (int i = 0; i < RewardSlotList.Count; i++)
		{
			if (RewardSlotList[i] != null)
				RewardSlotList[i].gameObject.SetActive(false);
		}

		if (RewardItemDataList == null || RewardSlotPrefab == null || RewardScrollRect == null) return;

		while (RewardSlotList.Count < RewardItemDataList.Count)
		{
			var obj = Instantiate(RewardSlotPrefab, RewardScrollRect.content);
			var article = obj.GetComponent<ItemArticle>();
			if (article != null)
				RewardSlotList.Add(article);
			obj.SetActive(false);
		}

		if (CoinRewardInfo != null) CoinRewardInfo.gameObject.SetActive(false);
		if (CashRewardInfo != null) CashRewardInfo.gameObject.SetActive(false);
	}

	private void OnClickedConfirmBtn()
	{
		Hide();
	}
}
