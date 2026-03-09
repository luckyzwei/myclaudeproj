using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QueensInGameFTUE : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFtue_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensInGameFTUE _003C_003E4__this;

		private QueensGrid _003Cgrid_003E5__2;

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
		public _003CFtue_003Ed__16(int _003C_003E1__state)
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
	private PlayableDirectorHelper m_ftue1_welcome;

	[SerializeField]
	private PlayableDirectorHelper m_ftue2_addQueen;

	[SerializeField]
	private PlayableDirectorHelper m_ftue2_addQueen2;

	[SerializeField]
	private PlayableDirectorHelper m_ftue3_eachColour;

	[SerializeField]
	private PlayableDirectorHelper m_ftue4_inTapOnce;

	[SerializeField]
	private PlayableDirectorHelper m_ftue5_inColumnRows;

	[SerializeField]
	private PlayableDirectorHelper m_ftue6_inOnlySpaceLeft;

	[SerializeField]
	private PlayableDirectorHelper m_ftue7_inCanYouFigureOut;

	[SerializeField]
	private PlayableDirectorHelper m_ftue8_badLuck;

	[SerializeField]
	private PlayableDirectorHelper m_ftue8_hint;

	[SerializeField]
	private PlayableDirectorHelper m_ftue9_youDidIt;

	[SerializeField]
	private GameObject[] m_hideOnFtue;

	[SerializeField]
	private GameObject m_hintButton;

	private bool m_continue;

	private int m_crossCount;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CFtue_003Ed__16))]
	private IEnumerator Ftue()
	{
		return null;
	}

	private void LifeLost(int index)
	{
	}

	private void QueenMarked(int index)
	{
	}

	private void CrossMarked(int index)
	{
	}

	public void OnContinuePressed()
	{
	}
}
