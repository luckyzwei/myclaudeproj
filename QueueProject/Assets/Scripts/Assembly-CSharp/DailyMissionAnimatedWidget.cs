using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class DailyMissionAnimatedWidget : DailyMissionWidget
{
	[CompilerGenerated]
	private sealed class _003CComeInAndShowProgress_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyMissionAnimatedWidget _003C_003E4__this;

		public float targetValue;

		public float startValue;

		public bool isCompleted;

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
		public _003CComeInAndShowProgress_003Ed__22(int _003C_003E1__state)
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

	private const string ANIM_ANIM_DAILYMISSIONS_REROLLMISSION = "Anim-DailyMissions-RerollMission";

	[SerializeField]
	private Transform m_giftIcon;

	[SerializeField]
	private bool m_onlyComeInIfMissionWasComplete;

	[SerializeField]
	private RectTransform m_rectTransform;

	[SerializeField]
	private Vector2 m_outPosition;

	[SerializeField]
	private Vector2 m_inPosition;

	[Header("Timing")]
	[SerializeField]
	private float m_comeInDelay;

	[SerializeField]
	private float m_comeInTime;

	[SerializeField]
	private float m_afterComeInDelay;

	[SerializeField]
	private float m_progressTime;

	[SerializeField]
	private float m_afterProgressDelay;

	[SerializeField]
	private float m_afterNewMissionDelay;

	[SerializeField]
	private float m_goOutTime;

	[SerializeField]
	private float m_giftMoveTime;

	[SerializeField]
	private float m_delayAfterGiftMove;

	private PopUpHighlighter m_popupHighlighter;

	private bool m_initialized;

	private bool m_isRewardAvailable;

	private bool m_isAllowedToShow;

	protected override void SetupWidget()
	{
	}

	public override void Config(BaseMission mission, Reward reward)
	{
	}

	protected override void OnRewardClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CComeInAndShowProgress_003Ed__22))]
	private IEnumerator ComeInAndShowProgress(float startValue, float targetValue, bool isCompleted)
	{
		return null;
	}

	public void RefreshMission()
	{
	}

	private void GoOut()
	{
	}

	public void TryToShow()
	{
	}
}
