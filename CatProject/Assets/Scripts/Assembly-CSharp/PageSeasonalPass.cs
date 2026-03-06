using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageSeasonalPass", false, false)]
public class PageSeasonalPass : UIBase
{
	[CompilerGenerated]
	private sealed class _003CFocusToIndexCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageSeasonalPass _003C_003E4__this;

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
		public _003CFocusToIndexCoroutine_003Ed__15(int _003C_003E1__state)
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
	private ItemMilestoneProgressList MilestoneProgressList;

	[SerializeField]
	private ButtonInAppPurchase PurchaseBtn;

	[SerializeField]
	private GameObject PurchaseDoneObj;

	[SerializeField]
	private GameObject PremiumRewardObj;

	[SerializeField]
	private GameObject PremiumRewardObjRoot;

	[SerializeField]
	private GameObject PremiumRewardObjPrefab;

	[SerializeField]
	private Button InfoBtn;

	private DateTime SeasonEndDateTime;

	private bool IsPremiumPassActive;

	private bool bEndSeasonTime;

	protected override void Awake()
	{
		base.Awake();
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (PurchaseBtn != null) PurchaseBtn.OnClickBuyEvent += OnClickPurchase;
	}

	public override void OnShowBefore()
	{
		Init();
		StartCoroutine(FocusToIndexCoroutine());
	}

	[IteratorStateMachine(typeof(_003CFocusToIndexCoroutine_003Ed__15))]
	private IEnumerator FocusToIndexCoroutine()
	{
		yield return null;
		// Focus scroll to current milestone index
	}

	private void Update()
	{
		if (bEndSeasonTime) return;
		var now = DateTime.Now;
		if (now >= SeasonEndDateTime)
		{
			bEndSeasonTime = true;
			SetSeasonRemainTimeText(0);
			return;
		}
		int remainSec = (int)(SeasonEndDateTime - now).TotalSeconds;
		SetSeasonRemainTimeText(remainSec);
	}

	public void Init()
	{
		bEndSeasonTime = false;
		UpdatePurchaseInfo();
	}

	private void SetSeasonThemeImage(string imageName)
	{
		if (SeasonThemeImage != null && !string.IsNullOrEmpty(imageName))
		{
			Sprite sprite = Resources.Load<Sprite>(imageName);
			if (sprite != null) SeasonThemeImage.sprite = sprite;
		}
	}

	private void SetSeasonThemeName(string nameKey)
	{
		if (SeasonThemeNameText != null)
			SeasonThemeNameText.text = nameKey;
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
		if (SeasonEndRemainTimeText != null)
			SeasonEndRemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
	}

	private void UpdatePurchaseInfo()
	{
		if (PurchaseBtn != null) PurchaseBtn.gameObject.SetActive(!IsPremiumPassActive);
		if (PurchaseDoneObj != null) PurchaseDoneObj.SetActive(IsPremiumPassActive);
		if (PremiumRewardObj != null) PremiumRewardObj.SetActive(IsPremiumPassActive);
	}

	private void OnClickInfo()
	{
	}

	private void OnClickPurchase()
	{
	}
}
