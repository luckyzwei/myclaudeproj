using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		Disposables = new CompositeDisposable();
		ItemExpTicketList = new List<ItemCompanyExpTicket>();
		HasItemList = new List<(Config.ItemIdx, int)>();
		ActionQueue = new ActionQueue();

		if (UseItemButton != null) UseItemButton.onClick.AddListener(OnClickUseItem);
		if (UseGemButton != null) UseGemButton.onClick.AddListener(OnClickUseGem);
		if (BoostShortcutButton != null) BoostShortcutButton.onClick.AddListener(OnClickBoostShortcut);
	}

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}

	public override void OnHideBefore()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	public override void OnRefresh()
	{
		UpdateCompanyExpInfo();
		SetHasItemInfo();
	}

	public void Init(int companyIdx)
	{
		CompanyIdx = companyIdx;
		SelectedItemIdx = 0;
		UseItemCnt = 0;
		UseItemExp = BigInteger.Zero;
		Reset();
		SetCompanyInfo(companyIdx);
		SetHasItemInfo();
		UpdateCompanyExpInfo();
	}

	private void Reset()
	{
		UseItemCnt = 0;
		UseItemExp = BigInteger.Zero;
		TicketAddExp = BigInteger.Zero;
		if (LevelUpNotiObj != null) LevelUpNotiObj.SetActive(false);
		if (ItemControls != null) ItemControls.gameObject.SetActive(false);
	}

	private void SetHasItemInfo()
	{
		HasItemList.Clear();
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void SetCompanyInfo(int companyIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateCompanyExpInfo();
	}

	private void UpdateCompanyExpInfo()
	{
		if (CompanyExpText != null)
			CompanyExpText.text = ProjectUtility.GetThousandCommaText(CompanyCurExp) + "/" + ProjectUtility.GetThousandCommaText(CompanyNeedExp);

		float progress = CompanyNeedExp > 0 ? (float)((double)CompanyCurExp / (double)CompanyNeedExp) : 0f;
		if (CompanyExpSlider != null) CompanyExpSlider.value = Mathf.Clamp01(progress);

		float totalProgress = CompanyNeedExp > 0 ? (float)((double)(CompanyCurExp + UseItemExp) / (double)CompanyNeedExp) : 0f;
		if (CompanyExpTotalFill != null) CompanyExpTotalFill.fillAmount = Mathf.Clamp01(totalProgress);

		if (CompanyAddExpText != null)
		{
			CompanyAddExpText.gameObject.SetActive(UseItemExp > 0);
			CompanyAddExpText.text = "+" + ProjectUtility.GetThousandCommaText(UseItemExp);
		}

		bool willLevelUp = CompanyCurExp + UseItemExp >= CompanyNeedExp;
		if (LevelUpNotiObj != null) LevelUpNotiObj.SetActive(willLevelUp);

		UpdateCompanyLevelUpCashText();
	}

	private void UpdateCompanyLevelUpCashText()
	{
		if (UseGemNeedText == null) return;
		UseGemNeedText.text = "0";
	}

	private void SetSelectedItemInfo(int itemIdx)
	{
		SelectedItemIdx = itemIdx;
		if (ItemControls != null) ItemControls.gameObject.SetActive(true);
	}

	private void UpdateUseItemCount(int useCnt)
	{
		UseItemCnt = useCnt;
		UseItemExp = TicketAddExp * useCnt;
		UpdateCompanyExpInfo();
	}

	private void OnSelectItemButtonClick(int itemIdx)
	{
		SetSelectedItemInfo(itemIdx);
	}

	private void OnClickUseItem()
	{
		if (UseItemCnt <= 0) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		EndActionQueue(() =>
		{
			OnRefresh();
		});
	}

	private void EndActionQueue(Action action)
	{
		StartCoroutine(DelayEndAction(action));
	}

	[IteratorStateMachine(typeof(_003CDelayEndAction_003Ed__41))]
	private IEnumerator DelayEndAction(Action action)
	{
		yield return new WaitForSeconds(0.5f);
		action?.Invoke();
	}

	private void OnClickUseGem()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OpenExpTicketReturnPopup(Dictionary<Config.ItemIdx, int> returnItemList, Action onComplete)
	{
		if (returnItemList == null || returnItemList.Count == 0)
		{
			onComplete?.Invoke();
			return;
		}
		onComplete?.Invoke();
	}

	private void CheckAndOpenExpPackage(Action onComplete)
	{
		onComplete?.Invoke();
	}

	private void OnItemControlsValueChanged(int value)
	{
		UpdateUseItemCount(value);
	}

	private void OnClickBoostShortcut()
	{
		Hide();
	}
}
