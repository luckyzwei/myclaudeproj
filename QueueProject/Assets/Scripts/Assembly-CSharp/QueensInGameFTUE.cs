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
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CFtue_003Ed__16(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					// Get grid reference
					if (QueensGameController.Instance != null)
						_003Cgrid_003E5__2 = QueensGameController.Instance.Grid;
					if (_003Cgrid_003E5__2 == null)
						return false;

					// Hide UI elements during FTUE
					if (_003C_003E4__this.m_hideOnFtue != null)
					{
						for (int i = 0; i < _003C_003E4__this.m_hideOnFtue.Length; i++)
						{
							if (_003C_003E4__this.m_hideOnFtue[i] != null)
								_003C_003E4__this.m_hideOnFtue[i].SetActive(false);
						}
					}

					// Set FTUE mode on grid
					_003Cgrid_003E5__2.SetFtueMode();

					// Step 1: Welcome
					if (_003C_003E4__this.m_ftue1_welcome != null)
						_003C_003E4__this.m_ftue1_welcome.Play();
					_003C_003E4__this.m_continue = false;
					_003C_003E1__state = 1;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 1:
					// Step 2: Add first queen
					_003C_003E4__this.m_continue = false;
					if (_003C_003E4__this.m_ftue2_addQueen != null)
						_003C_003E4__this.m_ftue2_addQueen.Play();
					// Subscribe to queen events
					_003Cgrid_003E5__2.QueenMarked += _003C_003E4__this.QueenMarked;
					_003C_003E1__state = 2;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 2:
					_003Cgrid_003E5__2.QueenMarked -= _003C_003E4__this.QueenMarked;
					_003C_003E4__this.m_continue = false;
					// Step 3: Each colour explanation
					if (_003C_003E4__this.m_ftue3_eachColour != null)
						_003C_003E4__this.m_ftue3_eachColour.Play();
					_003C_003E1__state = 3;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 3:
					_003C_003E4__this.m_continue = false;
					// Step 4: Tap once
					if (_003C_003E4__this.m_ftue4_inTapOnce != null)
						_003C_003E4__this.m_ftue4_inTapOnce.Play();
					_003Cgrid_003E5__2.CrossMarked += _003C_003E4__this.CrossMarked;
					_003C_003E1__state = 4;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 4:
					_003Cgrid_003E5__2.CrossMarked -= _003C_003E4__this.CrossMarked;
					_003C_003E4__this.m_continue = false;
					// Step 5: Column/rows
					if (_003C_003E4__this.m_ftue5_inColumnRows != null)
						_003C_003E4__this.m_ftue5_inColumnRows.Play();
					_003C_003E1__state = 5;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 5:
					_003C_003E4__this.m_continue = false;
					// Step 6: Only space left
					if (_003C_003E4__this.m_ftue6_inOnlySpaceLeft != null)
						_003C_003E4__this.m_ftue6_inOnlySpaceLeft.Play();
					_003C_003E1__state = 6;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 6:
					_003C_003E4__this.m_continue = false;
					// Step 7: Can you figure out?
					if (_003C_003E4__this.m_ftue7_inCanYouFigureOut != null)
						_003C_003E4__this.m_ftue7_inCanYouFigureOut.Play();
					_003Cgrid_003E5__2.QueenMarked += _003C_003E4__this.QueenMarked;
					_003Cgrid_003E5__2.LifeLost += _003C_003E4__this.LifeLost;
					_003C_003E1__state = 7;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 7:
					_003Cgrid_003E5__2.QueenMarked -= _003C_003E4__this.QueenMarked;
					_003Cgrid_003E5__2.LifeLost -= _003C_003E4__this.LifeLost;
					// Step 9: You did it!
					if (_003C_003E4__this.m_ftue9_youDidIt != null)
						_003C_003E4__this.m_ftue9_youDidIt.Play();
					_003C_003E4__this.m_continue = false;
					_003C_003E1__state = 8;
					_003C_003E2__current = new WaitUntil(() => _003C_003E4__this.m_continue);
					return true;

				case 8:
					// Restore UI
					_003Cgrid_003E5__2.ClearFtueMode();
					if (_003C_003E4__this.m_hideOnFtue != null)
					{
						for (int i = 0; i < _003C_003E4__this.m_hideOnFtue.Length; i++)
						{
							if (_003C_003E4__this.m_hideOnFtue[i] != null)
								_003C_003E4__this.m_hideOnFtue[i].SetActive(true);
						}
					}
					return false;

				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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
		StartCoroutine(Ftue());
	}

	[IteratorStateMachine(typeof(_003CFtue_003Ed__16))]
	private IEnumerator Ftue()
	{
		return new _003CFtue_003Ed__16(0) { _003C_003E4__this = this };
	}

	private void LifeLost(int index)
	{
		// Show hint on life lost
		if (m_ftue8_badLuck != null)
			m_ftue8_badLuck.Play();
		if (m_hintButton != null)
			m_hintButton.SetActive(true);
	}

	private void QueenMarked(int index)
	{
		m_continue = true;
	}

	private void CrossMarked(int index)
	{
		m_crossCount++;
		m_continue = true;
	}

	public void OnContinuePressed()
	{
		m_continue = true;
	}
}
