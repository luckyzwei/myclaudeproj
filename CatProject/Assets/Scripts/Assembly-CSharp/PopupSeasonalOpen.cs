using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalOpen", false, false)]
public class PopupSeasonalOpen : UIBase
{
	[CompilerGenerated]
	private sealed class _003CPlaySeasonalStartHUDEffect_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupSeasonalOpen _003C_003E4__this;

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
		public _003CPlaySeasonalStartHUDEffect_003Ed__15(int _003C_003E1__state)
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
	private Text TitleText;

	[SerializeField]
	private Image ThemeImage;

	[SerializeField]
	private Image BgColorImage;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Text RemainTimeText;

	private int SeasonInfoIdx;

	private int SeasonResourceIdx;

	private DateTime SeasonEndDateTime;

	public void Init(int seasonInfoIdx)
	{
	}

	private void Update()
	{
	}

	private void SetTitleText(string titleStr)
	{
	}

	private void SetDescriptionText(string descStr)
	{
	}

	private void SetThemeImage(string imageKey)
	{
	}

	private void SetRemainTimeText(int remainTimeSec)
	{
	}

	private void SetBgColor(int seasonThemeIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CPlaySeasonalStartHUDEffect_003Ed__15))]
	public IEnumerator PlaySeasonalStartHUDEffect()
	{
		return null;
	}

	public override void OnHideAfter()
	{
	}
}
