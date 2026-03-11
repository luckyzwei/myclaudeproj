using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class RoyalTouranmentJoinPopup : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CReduceTimeSequence_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoyalTouranmentJoinPopup _003C_003E4__this;

		public int timeBefore;

		public int timeAfter;

		private float _003CscaleTime_003E5__2;

		private float _003CtextTime_003E5__3;

		private Color _003CorginalColor_003E5__4;

		private float _003Celapsed_003E5__5;

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
		public _003CReduceTimeSequence_003Ed__23(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUpdateTime_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoyalTouranmentJoinPopup _003C_003E4__this;

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
		public _003CUpdateTime_003Ed__16(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-RoyalTournamentJoin";

	private const string PLAY_NOW_KEY = "RoyalTournament.PlayNow";

	[SerializeField]
	private RewardWidget m_rewardWidget;

	[SerializeField]
	private Text m_timerText;

	[SerializeField]
	private GameObject m_bestWidget;

	[SerializeField]
	private Text m_bestText;

	[Header("Reduce time")]
	[SerializeField]
	private Text m_reduceTimeText;

	[SerializeField]
	private Text m_timerBigText;

	[SerializeField]
	private GameObject m_reduceTimePanel;

	[SerializeField]
	private Button m_reduceTimeButton;

	[SerializeField]
	private KwaleePriceWidget m_reduceTimePriceWidget;

	[SerializeField]
	private GameObject m_banksPanel;

	private bool m_updateTime;

	public static RoyalTouranmentJoinPopup Show()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void ConfigureUI()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTime_003Ed__16))]
	private IEnumerator UpdateTime()
	{
		return null;
	}

	public void OnReduceTimePressed()
	{
	}

	private void ReduceTime(bool finishCooldown)
	{
	}

	public void OnPlayPressed()
	{
	}

	public void Play()
	{
	}

	public void OnCustomClosePressed()
	{
	}

	public void OnInfoPressed()
	{
	}

	[IteratorStateMachine(typeof(_003CReduceTimeSequence_003Ed__23))]
	private IEnumerator ReduceTimeSequence(int timeBefore, int timeAfter)
	{
		return null;
	}
}
