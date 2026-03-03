using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupExpAccelerate", false, false)]
public class PopupExpAccelerate : UIBase
{
	[CompilerGenerated]
	private sealed class _003CDelayEndAction_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action action;

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
		public _003CDelayEndAction_003Ed__41(int _003C_003E1__state)
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
	private GameObject UseItemObj;

	[SerializeField]
	private GameObject ItemNavigateRoot;

	[SerializeField]
	private Button UseItemButton;

	[SerializeField]
	private Button UseGemButton;

	[SerializeField]
	private Text UseGemNeedText;

	[Header("Company Exp")]
	[SerializeField]
	private Text CompanyExpText;

	[SerializeField]
	private Text CompanyAddExpText;

	[SerializeField]
	private Slider CompanyExpSlider;

	[SerializeField]
	private Image CompanyExpTotalFill;

	[SerializeField]
	private GameObject LevelUpNotiObj;

	[Header("Item")]
	[SerializeField]
	private GameObject ItemRoot;

	[SerializeField]
	private GameObject ItemArticle;

	[SerializeField]
	private SliderControlsComponent ItemControls;

	private List<ItemCompanyExpTicket> ItemExpTicketList;

	[Header("Guide")]
	[SerializeField]
	private ItemRewardGetGuideList GuideList;

	[SerializeField]
	private Button BoostShortcutButton;

	private int CompanyIdx;

	private int SelectedItemIdx;

	private int UseItemCnt;

	private BigInteger UseItemExp;

	private List<(Config.ItemIdx itemIdx, int hasValue)> HasItemList;

	private BigInteger CompanyCurExp;

	private BigInteger CompanyNeedExp;

	private BigInteger TicketAddExp;

	private ActionQueue ActionQueue;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	public void Init(int companyIdx)
	{
	}

	private void Reset()
	{
	}

	private void SetHasItemInfo()
	{
	}

	private void SetCompanyInfo(int companyIdx)
	{
	}

	private void UpdateCompanyExpInfo()
	{
	}

	private void UpdateCompanyLevelUpCashText()
	{
	}

	private void SetSelectedItemInfo(int itemIdx)
	{
	}

	private void UpdateUseItemCount(int useCnt)
	{
	}

	private void OnSelectItemButtonClick(int itemIdx)
	{
	}

	private void OnClickUseItem()
	{
	}

	private void EndActionQueue(Action action)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayEndAction_003Ed__41))]
	private IEnumerator DelayEndAction(Action action)
	{
		return null;
	}

	private void OnClickUseGem()
	{
	}

	private void OpenExpTicketReturnPopup(Dictionary<Config.ItemIdx, int> returnItemList, Action onComplete)
	{
	}

	private void CheckAndOpenExpPackage(Action onComplete)
	{
	}

	private void OnItemControlsValueChanged(int value)
	{
	}

	private void OnClickBoostShortcut()
	{
	}
}
