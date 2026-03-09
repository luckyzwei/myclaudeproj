using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GridPlayback : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CConfigCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelData levelData;

		public GridPlayback _003C_003E4__this;

		public string colorClientId;

		public string skinClientId;

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
		public _003CConfigCoroutine_003Ed__16(int _003C_003E1__state)
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

	private const float PITCH_INCREASE = 0.05f;

	[SerializeField]
	private GridLayoutGroup m_layoutGroup;

	[SerializeField]
	private MiniGridCell m_cellPrefab;

	[SerializeField]
	private MiniGridCell m_cellPrefabCorner;

	[SerializeField]
	private bool m_autoLoadCurrentLevel;

	[SerializeField]
	private int m_channel;

	private List<MiniGridCell> m_cells;

	private Sprite m_baseSprite;

	private Sprite m_crossSprite;

	private int m_loadedItems;

	private List<int> m_queenCells;

	private string m_loadedLevelClientId;

	private bool m_isConfigured;

	private float m_pitch;

	private void Awake()
	{
	}

	public void Config(LevelData levelData, string skinClientId, string colorClientId)
	{
	}

	[IteratorStateMachine(typeof(_003CConfigCoroutine_003Ed__16))]
	private IEnumerator ConfigCoroutine(LevelData levelData, string skinClientId, string colorClientId)
	{
		return null;
	}

	public void MarkCell(int cellIndex, UserActionType value)
	{
	}

	public void PlayCompleteRoutine()
	{
	}
}
