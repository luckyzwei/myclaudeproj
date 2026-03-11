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
		public _003CMovementCoroutine_003Ed__24(int _003C_003E1__state)
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
					_003CrotateClockwise_003E5__2 = true;
					_003CspeedMultiplier_003E5__4 = 200f;
					_003CcurrentIndex_003E5__3 = _003C_003E4__this.m_startIndex;
					goto case 1;
				case 1:
					if (_003C_003E4__this.m_isClosing || _003C_003E4__this.m_isDestroyed)
						return false;

					if (_003C_003E4__this.m_values == null || _003C_003E4__this.m_values.Length == 0)
						return false;

					// Move hand through positions
					int nextIndex = _003CrotateClockwise_003E5__2
						? (_003CcurrentIndex_003E5__3 + 1) % _003C_003E4__this.m_values.Length
						: (_003CcurrentIndex_003E5__3 - 1 + _003C_003E4__this.m_values.Length) % _003C_003E4__this.m_values.Length;

					Vector3 from = _003C_003E4__this.GetPosition(_003CcurrentIndex_003E5__3);
					Vector3 to = _003C_003E4__this.GetPosition(nextIndex);

					if (_003C_003E4__this.m_hand != null)
					{
						_003C_003E4__this.m_hand.PointerDown();
						float duration = _003C_003E4__this.m_hand.Drag(from, to, _003CspeedMultiplier_003E5__4);
						_003C_003E2__current = new WaitForSeconds(duration + 0.2f);
					}
					else
					{
						_003C_003E2__current = new WaitForSeconds(0.5f);
					}

					_003CcurrentIndex_003E5__3 = nextIndex;
					_003C_003E4__this.m_firstAnimationLoopDone = true;
					_003C_003E1__state = 1;
					return true;
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

	private Action _onDone;
	public event Action OnDone
	{
		add { _onDone += value; }
		remove { _onDone -= value; }
	}

	private void Awake()
	{
		m_isClosing = false;
		m_isDestroyed = false;
		m_firstAnimationLoopDone = false;
		m_interactedWithTheBoard = false;
	}

	protected override void OnDestroy()
	{
		m_isDestroyed = true;
		GameplayEvents.LevelSolved -= OnLevelSolved;
		if (m_queensGrid != null)
			m_queensGrid.CrossMarked -= OnCrossMarked;
		base.OnDestroy();
	}

	private void OnQuitGame()
	{
		m_isClosing = true;
		HideTutorial();
	}

	private void OnLevelSolved()
	{
		HideTutorial();
	}

	private void OnCrossMarked(int obj)
	{
		m_interactedWithTheBoard = true;
		HideTutorial();
	}

	private void Start()
	{
		GameplayEvents.LevelSolved += OnLevelSolved;
		// Auto-config when the popup is instantiated
		Config();
	}

	public void Config()
	{
		if (QueensGameController.Instance != null)
		{
			m_queensGrid = QueensGameController.Instance.Grid;
		}

		if (m_queensGrid == null)
			return;

		m_queensGrid.CrossMarked += OnCrossMarked;

		// Find the first queen on the grid to animate around
		var queenCells = m_queensGrid.GetQueensCells();
		if (queenCells != null && queenCells.Count > 0)
		{
			m_queenCoords = queenCells[0].Coords;
		}
		else
		{
			// No queen found yet — use center of grid
			var allCells = m_queensGrid.GetAllCells();
			if (allCells == null || allCells.Count == 0)
				return;
			int mid = allCells.Count / 2;
			m_queenCoords = allCells[mid].Coords;
		}

		// Collect neighbor cells around the queen (up, right, down, left, and diagonals)
		Vector2Int[] offsets = new Vector2Int[]
		{
			new Vector2Int(0, -1),  // up
			new Vector2Int(1, -1),  // up-right
			new Vector2Int(1, 0),   // right
			new Vector2Int(1, 1),   // down-right
			new Vector2Int(0, 1),   // down
			new Vector2Int(-1, 1),  // down-left
			new Vector2Int(-1, 0),  // left
			new Vector2Int(-1, -1), // up-left
		};

		m_cells = new List<QueensGridCell>();
		var valuesList = new List<Vector2Int>();

		for (int i = 0; i < offsets.Length; i++)
		{
			int nx = m_queenCoords.x + offsets[i].x;
			int ny = m_queenCoords.y + offsets[i].y;
			var cell = m_queensGrid.GetCell(nx, ny);
			if (cell != null)
			{
				m_cells.Add(cell);
				valuesList.Add(new Vector2Int(nx, ny));
			}
		}

		m_values = valuesList.ToArray();
		m_startIndex = 0;

		if (m_values.Length > 0)
		{
			// Position hand at the first cell
			if (m_hand != null)
			{
				m_hand.transform.position = GetPosition(0);
			}
			StartCoroutine(MovementCoroutine());
		}
	}

	[IteratorStateMachine(typeof(_003CMovementCoroutine_003Ed__24))]
	private IEnumerator MovementCoroutine()
	{
		return new _003CMovementCoroutine_003Ed__24(0) { _003C_003E4__this = this };
	}

	private Vector3 GetPosition(int index)
	{
		if (m_cells == null || index < 0 || index >= m_cells.Count)
			return transform.position;
		return m_cells[index].transform.position;
	}

	private void HideTutorial()
	{
		m_isClosing = true;
		StopAllCoroutines();
		if (m_hand != null)
			m_hand.gameObject.SetActive(false);
		FadeAway();
		_onDone?.Invoke();
		Close();
	}

	private void FadeAway()
	{
		if (m_canvasGroup != null)
			m_canvasGroup.alpha = 0f;
	}

	private void FadeOutBubble()
	{
		if (m_canvasGroup != null)
			m_canvasGroup.alpha = 0f;
	}

	private void FadeInRules()
	{
		if (m_canvasGroup != null)
			m_canvasGroup.alpha = 1f;
	}

	private void FadeInHearts()
	{
		if (m_canvasGroup != null)
			m_canvasGroup.alpha = 1f;
	}
}
