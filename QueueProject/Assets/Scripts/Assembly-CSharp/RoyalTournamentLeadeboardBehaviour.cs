using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoyalTournamentLeadeboardBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoyalTournamentLeadeboardBehaviour _003C_003E4__this;

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
		public _003CStart_003Ed__8(int _003C_003E1__state)
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
	private RectTransform m_movingBackground;

	[SerializeField]
	private GameObject m_eliminatedLine;

	private LeaderboardWidget m_widget;

	private RectTransform m_rectTrasnsform;

	private LeaderboardCell m_cutCell;

	private int m_cutIndex;

	private bool m_initializedDefaultPlacement;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__8))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnItemRecycled(int recycledIndex, int updatedIndex, LeaderboardCell cell)
	{
	}

	private void OnScrolled(Vector2 _)
	{
	}

	private void OnAutoScrollProgress(float _)
	{
	}

	private void InitialPlacement()
	{
	}

	private void UpdateBackgroundPosition()
	{
	}

	private int GetCutIndex()
	{
		return 0;
	}
}
