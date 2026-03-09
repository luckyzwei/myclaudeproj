using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class PopupJigsawPastEvent : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CSpawnPuzzlesWithDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupJigsawPastEvent _003C_003E4__this;

		private List<string>.Enumerator _003C_003E7__wrap1;

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
		public _003CSpawnPuzzlesWithDelay_003Ed__8(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-PastEvent";

	[SerializeField]
	private TextMeshProUGUI m_titleTMP;

	[SerializeField]
	private JigsawPuzzleCompletedCell m_cellPrefab;

	[SerializeField]
	private Transform m_cellsParent;

	[SerializeField]
	private float m_spawnDelay;

	private List<JigsawPuzzleCompletedCell> m_cells;

	private List<string> m_puzzlesIds;

	public void Config(string eventId)
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnPuzzlesWithDelay_003Ed__8))]
	private IEnumerator SpawnPuzzlesWithDelay()
	{
		return null;
	}

	private JigsawPuzzleCompletedCell SpawnCell(string clientId)
	{
		return null;
	}
}
