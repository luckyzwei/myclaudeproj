using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/Page/PageMilestone", false, false)]
public class PageMilestone : UIBase
{
	[CompilerGenerated]
	private sealed class _003CFocusToIndexCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageMilestone _003C_003E4__this;

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
		public _003CFocusToIndexCoroutine_003Ed__12(int _003C_003E1__state)
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
	private Text SeasonThemeNameText;

	[SerializeField]
	private Text SeasonEndRemainTimeText;

	[SerializeField]
	private Image SeasonThemeImage;

	[SerializeField]
	private Button EnterButton;

	[SerializeField]
	private ButtonInAppPurchase PurchaseBtn;

	[SerializeField]
	private GameObject PurchaseDoneObj;

	[SerializeField]
	private ItemMilestoneProgressList MilestoneProgressList;

	private DateTime SeasonEndDateTime;

	private bool bEndSeasonTime;

	protected override void Awake()
	{
		base.Awake();
		if (EnterButton != null) EnterButton.onClick.AddListener(OnClickedEnterButton);
	}

	public override void OnShowBefore()
	{
		Init();
	}

	public override void OnHideBefore()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusToIndexCoroutine_003Ed__12))]
	private IEnumerator FocusToIndexCoroutine()
	{
		yield return null;
	}

	private void Update()
	{
		if (bEndSeasonTime) return;
		if (SeasonEndDateTime <= DateTime.MinValue) return;

		int remainSec = (int)(SeasonEndDateTime - DateTime.UtcNow).TotalSeconds;
		if (remainSec <= 0)
		{
			bEndSeasonTime = true;
			SetSeasonRemainTimeText(0);
			return;
		}
		SetSeasonRemainTimeText(remainSec);
	}

	public void Init()
	{
		bEndSeasonTime = false;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdatePurchaseInfo();
		StartCoroutine(FocusToIndexCoroutine());
	}

	private void UpdatePurchaseInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		bool isPurchased = false;
		if (PurchaseBtn != null) PurchaseBtn.gameObject.SetActive(!isPurchased);
		if (PurchaseDoneObj != null) PurchaseDoneObj.SetActive(isPurchased);
	}

	private void OnClickedEnterButton()
	{
		Hide();
	}

	private void OnClickPurchase()
	{
	}

	private void SetSeasonThemeImage(string imageName)
	{
		if (SeasonThemeImage == null) return;
		Sprite sprite = Resources.Load<Sprite>(imageName);
		if (sprite != null) SeasonThemeImage.sprite = sprite;
	}

	private void SetSeasonThemeName(string nameKey)
	{
		if (SeasonThemeNameText != null) SeasonThemeNameText.text = nameKey;
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
		if (SeasonEndRemainTimeText != null)
			SeasonEndRemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
	}
}
