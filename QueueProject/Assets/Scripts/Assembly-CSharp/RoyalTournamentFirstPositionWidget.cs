using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RoyalTournamentFirstPositionWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTryToShow_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float completeTime;

		public RoyalTournamentFirstPositionWidget _003C_003E4__this;

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
		public _003CTryToShow_003Ed__8(int _003C_003E1__state)
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
	private Text m_name;

	[SerializeField]
	private Text m_time;

	[SerializeField]
	private Image m_avatar;

	[SerializeField]
	private Text m_youFinishedTMP;

	private LeaderboardData.User m_user;

	private void Start()
	{
	}

	private void SetupEmpty()
	{
	}

	private void SetupPlayer(bool animateIn = false)
	{
	}

	[IteratorStateMachine(typeof(_003CTryToShow_003Ed__8))]
	private IEnumerator TryToShow(float completeTime)
	{
		return null;
	}

	private static string GetOrdinal(int number)
	{
		return null;
	}
}
