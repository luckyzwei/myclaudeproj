using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RewardDoubler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLerpValue_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RewardDoubler _003C_003E4__this;

		public int startValue;

		public Text text;

		public int targetValue;

		public bool fireCallback;

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
		public _003CLerpValue_003Ed__25(int _003C_003E1__state)
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

	private const string ANIM_REWARD_NOMOVE = "Reward-NoMove";

	private const string ANIM_REWARDS_START_X2 = "Rewards-Start-X2";

	private const string ANIM_REWARDS_START_X3 = "Rewards-Start-X3";

	private const string ANIM_REWARDS_START_X5 = "Rewards-Start-X5";

	private const string ANIM_REWARDMULTIPLIER_INTRO = "RewardMultiplier-Intro";

	private const string ANIM_REWARD_DOUBLE = "Reward-Double";

	private const string ANIM_REWARD_DOUBLED = "Reward-Doubled";

	private const string ANIM_ANIM_REWARD_MULTIPLIERADDED = "Anim-Reward-MultiplierAdded";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private float m_countingDuration;

	[SerializeField]
	private Text m_2xText;

	[SerializeField]
	private Text m_2xTextSmall;

	[SerializeField]
	private string m_2xFormatKey;

	[SerializeField]
	private Image[] m_colorImages;

	private Action m_finishCallback;

	private bool m_noMovement;

	private bool m_showDouble;

	private int m_multiplier;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void SetMultiplier(int multiplier)
	{
	}

	public void DoubleRewardsImmediately()
	{
	}

	public void DoubleRewards(Action finishCallback, int multiplier)
	{
	}

	public void ShowIntro()
	{
	}

	private void DoubleNumbers()
	{
	}

	[IteratorStateMachine(typeof(_003CLerpValue_003Ed__25))]
	private IEnumerator LerpValue(Text text, int startValue, int targetValue, bool fireCallback)
	{
		return null;
	}

	public void ShowNoMovement()
	{
	}
}
