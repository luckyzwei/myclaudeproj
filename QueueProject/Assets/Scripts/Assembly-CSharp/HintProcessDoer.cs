using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HintProcessDoer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoAutoActionCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HintProcessDoer _003C_003E4__this;

		public bool setQueen;

		public List<QueensGridCell> cellsList;

		public Action finishCallback;

		private float _003Cdelay_003E5__2;

		private float _003Cmultiplier_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CDoAutoActionCoroutine_003Ed__10(int _003C_003E1__state)
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

	private HintsManager.HintResult m_hintResult;

	private PopupHint m_popupHint;

	private Action m_callback;

	private List<QueensGridCell> m_interactableCells;

	private List<QueensGridCell> m_highlightedCells;

	public void DoHint(HintsManager.HintResult hintResult, Action callback)
	{
	}

	private void OnCrossMarked(int cellIndex)
	{
	}

	private void HintCompleted()
	{
	}

	private static void GetCells(List<int> cellIndexList, List<QueensGridCell> cellsList)
	{
	}

	public void AutoDo(Action finishCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CDoAutoActionCoroutine_003Ed__10))]
	private IEnumerator DoAutoActionCoroutine(List<QueensGridCell> cellsList, bool setQueen, Action finishCallback)
	{
		return null;
	}
}
