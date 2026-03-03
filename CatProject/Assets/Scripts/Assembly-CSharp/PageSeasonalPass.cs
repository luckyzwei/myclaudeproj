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
	}

	public override void OnShowBefore()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusToIndexCoroutine_003Ed__15))]
	private IEnumerator FocusToIndexCoroutine()
	{
		return null;
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	private void SetSeasonThemeImage(string imageName)
	{
	}

	private void SetSeasonThemeName(string nameKey)
	{
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
	}

	private void UpdatePurchaseInfo()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickPurchase()
	{
	}
}
