using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;
using UnityEngine;

public class LeaderboardCellPlayerAdditions : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLerpScoreCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public int oldScore;

		public int newScore;

		public float duration;

		public LeaderboardCellPlayerAdditions _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CLerpScoreCoroutine_003Ed__7(int _003C_003E1__state)
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

	private const string ANIM_ANIM_PROMOTION_IN = "Anim-Promotion-In";

	private const string ANIM_ANIM_PROMOTION_OUT = "Anim-Promotion-Out";

	[SerializeField]
	private GameObject m_upIcon;

	[SerializeField]
	private Text m_scoreText;

	[SerializeField]
	private AnimatorHelper m_promotionAnimator;

	public void ToggleUpIcon(bool value)
	{
	}

	public void LerpScore(int oldScore, int newScore, float duration, float delay)
	{
	}

	[IteratorStateMachine(typeof(_003CLerpScoreCoroutine_003Ed__7))]
	private IEnumerator LerpScoreCoroutine(int oldScore, int newScore, float duration, float delay)
	{
		return null;
	}

	public void PlayPromotionIn()
	{
	}

	public void PlayPromotionOut()
	{
	}
}
