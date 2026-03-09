using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using Spine;
using Spine.Unity;
using UnityEngine;

public class PiggyRewardPopUp : RewardPopupBase
{
	[CompilerGenerated]
	private sealed class _003CShattersHaptics_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiggyRewardPopUp _003C_003E4__this;

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
		public _003CShattersHaptics_003Ed__16(int _003C_003E1__state)
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

	private const string ANIM_PIGGY_INTRO = "Piggy-Intro";

	private const string ANIM_PIGGY_SHATTER = "Piggy-Shatter";

	private const string ANIM_OUTRO = "Outro";

	private const string ANIM_INTRO = "Intro";

	private const string ANIM_ANIM_PIGGYREWARDGIFT = "Anim-PiggyRewardGift";

	public const string PREFAB_NAME = "Prefabs/KWPiggyBank/Popup-PiggyReward";

	[SerializeField]
	protected RewardWidget m_rewardWdiget;

	[SerializeField]
	private SkeletonAnimation m_piggySkeletonAnimation;

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[Header("Haptics")]
	[SerializeField]
	private float m_beforeFirstSoftHapticDelay;

	[SerializeField]
	private float m_beforeSecondSoftHapticDelay;

	[SerializeField]
	private float m_beforeMediumHapticDelay;

	private Action m_rewardGivenCallback;

	private Reward m_reward;

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	public void PlayShatterFlow()
	{
	}

	[IteratorStateMachine(typeof(_003CShattersHaptics_003Ed__16))]
	private IEnumerator ShattersHaptics()
	{
		return null;
	}

	private void StateOnComplete(TrackEntry trackentry)
	{
	}

	protected void GiveRewardActions()
	{
	}

	private void GiveReward()
	{
	}

	private void Finalise()
	{
	}
}
