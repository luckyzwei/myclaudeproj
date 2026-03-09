using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;

public class PopUpExtraTutorial : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CMovementCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopUpExtraTutorial _003C_003E4__this;

		private bool _003CrotateClockwise_003E5__2;

		private int _003CcurrentIndex_003E5__3;

		private float _003CspeedMultiplier_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CMovementCoroutine_003Ed__24(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-ExtraTutorial";

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private ExtraTutorialHand m_hand;

	private Vector2Int[] m_values;

	private bool m_interactedWithTheBoard;

	private bool m_isClosing;

	private bool m_isDestroyed;

	private bool m_firstAnimationLoopDone;

	private float m_time;

	private GameScreen m_gameScreen;

	private List<QueensGridCell> m_cells;

	private int m_startIndex;

	private Vector2Int m_queenCoords;

	private QueensGrid m_queensGrid;

	public event Action OnDone
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnQuitGame()
	{
	}

	private void OnLevelSolved()
	{
	}

	private void OnCrossMarked(int obj)
	{
	}

	private void Start()
	{
	}

	public void Config()
	{
	}

	[IteratorStateMachine(typeof(_003CMovementCoroutine_003Ed__24))]
	private IEnumerator MovementCoroutine()
	{
		return null;
	}

	private Vector3 GetPosition(int index)
	{
		return default(Vector3);
	}

	private void HideTutorial()
	{
	}

	private void FadeAway()
	{
	}

	private void FadeOutBubble()
	{
	}

	private void FadeInRules()
	{
	}

	private void FadeInHearts()
	{
	}
}
