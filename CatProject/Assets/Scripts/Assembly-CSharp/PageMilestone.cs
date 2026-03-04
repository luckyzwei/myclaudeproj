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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusToIndexCoroutine_003Ed__12))]
	private IEnumerator FocusToIndexCoroutine()
	{
		yield break;
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	private void UpdatePurchaseInfo()
	{
	}

	private void OnClickedEnterButton()
	{
	}

	private void OnClickPurchase()
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
}
