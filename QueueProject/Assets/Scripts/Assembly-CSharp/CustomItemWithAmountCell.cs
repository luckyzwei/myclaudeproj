using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using UnityEngine;

public class CustomItemWithAmountCell : ItemWithAmountCell
{
	[CompilerGenerated]
	private sealed class _003CDoTallyAnimationWithStartValue_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int startAmount;

		public CustomItemWithAmountCell _003C_003E4__this;

		public int targetAmount;

		private float _003Ctimer_003E5__2;

		private int _003Camount_003E5__3;

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
		public _003CDoTallyAnimationWithStartValue_003Ed__15(int _003C_003E1__state)
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

	private const string NEW_SKIN_KEY = "QueenEvent.RewardNewSkin";

	private const string NEW_BOARD_COLOR_KEY = "QueenEvent.RewardNewBoardColour";

	private const string SKIN_ID_START = "skin";

	private const string BOARD_COLOR_ID_START = "boardcolors";

	private const string SCORE_MULTIPLIER_ID = "score_multiplier_timer";

	private const string FOREVER_KEY = "NoAds.Forever";

	private const string WEEK_KEY = "Time.Week";

	private const string WEEKS_KEY = "Time.Weeks";

	[SerializeField]
	private bool m_showNegativeValue;

	[SerializeField]
	private GameObject m_multiplierText;

	private int m_amountCopy;

	protected override void HandleAmountDisplay(int amount, KwaleeItem kwaleeItem)
	{
	}

	private string FormatTime(int seconds)
	{
		return null;
	}

	public void Double()
	{
	}

	public void MakeZero()
	{
	}

	[IteratorStateMachine(typeof(_003CDoTallyAnimationWithStartValue_003Ed__15))]
	private IEnumerator DoTallyAnimationWithStartValue(int startAmount, int targetAmount, string format)
	{
		return null;
	}
}
