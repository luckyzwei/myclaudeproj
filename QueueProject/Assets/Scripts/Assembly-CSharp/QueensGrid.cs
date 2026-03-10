using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Data;
using UnityEngine;

public class QueensGrid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CConfigureAccesibilityBordersRoutine_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public QueensGrid _003C_003E4__this;
		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CConfigureAccesibilityBordersRoutine_003Ed__88(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003Ci_003E5__2 = 0;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.m_cells != null && _003Ci_003E5__2 < _003C_003E4__this.m_cells.Count)
					{
						var cell = _003C_003E4__this.m_cells[_003Ci_003E5__2];
						if (cell != null && _003C_003E4__this.m_borderPrefab != null)
						{
							int config = QueensGridCellBorder.GetConfigFromCell(_003C_003E4__this, cell);
							var border = UnityEngine.Object.Instantiate(_003C_003E4__this.m_borderPrefab, cell.transform);
							border.Configure(config);
						}
						_003Ci_003E5__2++;
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
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
		void IEnumerator.Reset() { }
	}

	[CompilerGenerated]
	private sealed class _003CWaveAnimationRoutine_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public QueensGrid _003C_003E4__this;
		public int cellIndex;
		private int _003CmaxDistance_003E5__2;
		private Dictionary<int, List<QueensGridCell>> _003CcellsByDistance_003E5__3;
		private float _003CdelayBetweenRings_003E5__4;
		private float _003CpunchDuration_003E5__5;
		private Vector3 _003CpunchStrength_003E5__6;
		private int _003Cdistance_003E5__8;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CWaveAnimationRoutine_003Ed__107(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.m_cells == null || _003C_003E4__this.m_levelData == null)
						return false;

					var centerCell = _003C_003E4__this.GetCell(cellIndex);
					if (centerCell == null) return false;

					int cx = centerCell.Coords.x;
					int cy = centerCell.Coords.y;
					_003CmaxDistance_003E5__2 = Mathf.Max(_003C_003E4__this.m_levelData.sizeX, _003C_003E4__this.m_levelData.sizeY);
					_003CcellsByDistance_003E5__3 = new Dictionary<int, List<QueensGridCell>>();
					_003CdelayBetweenRings_003E5__4 = 0.05f;
					_003CpunchDuration_003E5__5 = 0.2f;
					_003CpunchStrength_003E5__6 = new Vector3(0.1f, 0.1f, 0f);

					for (int i = 0; i < _003C_003E4__this.m_cells.Count; i++)
					{
						var c = _003C_003E4__this.m_cells[i];
						int dist = Mathf.Max(Mathf.Abs(c.Coords.x - cx), Mathf.Abs(c.Coords.y - cy));
						if (!_003CcellsByDistance_003E5__3.ContainsKey(dist))
							_003CcellsByDistance_003E5__3[dist] = new List<QueensGridCell>();
						_003CcellsByDistance_003E5__3[dist].Add(c);
					}
					_003Cdistance_003E5__8 = 0;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003Cdistance_003E5__8 <= _003CmaxDistance_003E5__2)
					{
						if (_003CcellsByDistance_003E5__3.ContainsKey(_003Cdistance_003E5__8))
						{
							var ring = _003CcellsByDistance_003E5__3[_003Cdistance_003E5__8];
							for (int j = 0; j < ring.Count; j++)
							{
								if (ring[j] != null && ring[j].transform != null)
								{
									// Punch scale effect
									ring[j].transform.localScale = Vector3.one + _003CpunchStrength_003E5__6;
								}
							}
						}
						_003Cdistance_003E5__8++;
						_003C_003E2__current = new WaitForSeconds(_003CdelayBetweenRings_003E5__4);
						_003C_003E1__state = 1;
						return true;
					}
					// Reset all scales
					for (int k = 0; k < _003C_003E4__this.m_cells.Count; k++)
					{
						if (_003C_003E4__this.m_cells[k] != null)
							_003C_003E4__this.m_cells[k].transform.localScale = Vector3.one;
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
		void IEnumerator.Reset() { }
	}

	public const int NONE = 0;

	public const int QUEEN = 2;

	public const int X = 1;

	public const int BLOCKED = 3;

	private const float PITCH_INCREASE = 0.2f;

	private const int SEED_LEVEL_MULTIPLIER = 37;

	private const string ANIM_INTRO = "Intro";

	public Action<int> QueenMarked;

	public Action<int> CrossMarked;

	public Action<int> CrossRemoved;

	public Action<int> LifeLost;

	public Action<int> GemRevealed;

	public Action GridBuilt;

	public Action Configured;

	[SerializeField]
	private Transform m_cellContainer;

	[SerializeField]
	private QueensGridCell m_gridCellPrefab;

	[SerializeField]
	private QueensGridCell m_gridCellCornerPrefab;

	[SerializeField]
	private float m_cellWidth;

	[SerializeField]
	private Transform m_textureOverlay;

	[SerializeField]
	private SpriteRenderer m_textureSpriteRenderer;

	[SerializeField]
	private QueensGridCellBorder m_borderPrefab;

	private GameObject m_accesiblityParent;

	private List<QueensGridCell> m_cells;

	private LevelData m_levelData;

	private int[] m_playerSolution;

	private int[] m_gemLocations;

	private int m_queenCount;

	private int m_gemCount;

	private bool m_queenEventIsActive;

	private int m_interactionsCount;

	private bool m_looseLifeEnabled;

	private bool m_inputEnabled;

	public bool m_isFTUEActive;

	public List<int> m_ftueTarget;

	private float m_lastClickTime;

	private QueensGridCell m_lastCell;

	private bool m_isBrushX;

	private float m_pitch;

	private Coroutine m_pitchCoroutine;

	private int m_gemsFlying;

	private HashSet<int> m_uniqueColors;

	private List<int> m_colorsArray;

	private bool m_animatingIn;

	public int QueenCount => m_queenCount;

	public bool IsInputEnabled => m_inputEnabled;

	public LevelData LevelData => m_levelData;

	public bool IsGemFlying => m_gemsFlying > 0;

	public int GemCount => m_gemCount;

	private static UserPlayerProfileData SaveData => null;

	public void DisableInput()
	{
		m_inputEnabled = false;
		UnityEngine.Debug.Log($"[QueensGrid] DisableInput called", this);
	}

	public void EnableInput()
	{
		m_inputEnabled = true;
		UnityEngine.Debug.Log($"[QueensGrid] EnableInput called", this);
	}

	public int GetColour(int color)
	{
		if (m_colorsArray != null && color >= 0 && color < m_colorsArray.Count)
			return m_colorsArray[color];
		return color;
	}

	public void EnableLosingLife(bool enabled)
	{
		m_looseLifeEnabled = enabled;
	}

	private void Awake()
	{
		m_cells = new List<QueensGridCell>();
		m_uniqueColors = new HashSet<int>();
		m_colorsArray = new List<int>();
		m_ftueTarget = new List<int>();
		m_inputEnabled = true;
		m_looseLifeEnabled = true;
	}

	private void OnDestroy()
	{
		QueenMarked = null;
		CrossMarked = null;
		CrossRemoved = null;
		LifeLost = null;
		GemRevealed = null;
		GridBuilt = null;
		Configured = null;
	}

	private void OnAllGemsAreClaimed()
	{
		m_queenEventIsActive = false;
	}

	public void Configure(LevelData levelData)
	{
		m_levelData = levelData;
		if (m_levelData == null) { UnityEngine.Debug.LogError("[QueensGrid] LevelData is null!"); return; }

		// Debug: log level data
		int queenTotal = 0;
		if (m_levelData.queensGrid != null)
		{
			for (int i = 0; i < m_levelData.queensGrid.Length; i++)
				if (m_levelData.queensGrid[i] >= 1) queenTotal++;
		}
		UnityEngine.Debug.Log($"[QueensGrid] Configure: {m_levelData.sizeX}x{m_levelData.sizeY}, queensGrid len={m_levelData.queensGrid?.Length ?? -1}, queens={queenTotal}, colors len={m_levelData.gridColours?.Length ?? -1}, usedColors={m_levelData.usedColors?.Length ?? -1}");

		int totalCells = m_levelData.sizeX * m_levelData.sizeY;
		m_playerSolution = new int[totalCells];
		m_queenCount = 0;
		m_interactionsCount = 0;
		m_pitch = 1f;

		m_uniqueColors.Clear();
		m_colorsArray.Clear();
		if (m_levelData.usedColors != null)
		{
			for (int i = 0; i < m_levelData.usedColors.Length; i++)
			{
				m_uniqueColors.Add(m_levelData.usedColors[i]);
				if (!m_colorsArray.Contains(m_levelData.usedColors[i]))
					m_colorsArray.Add(m_levelData.usedColors[i]);
			}
		}

		m_queenEventIsActive = IsQueensEventLive();
		SetupGemLocations();
		CreateGrid();
		SetCellColours();
		PlacePrePlacedQueens();

		Configured?.Invoke();
	}

	private bool IsQueensEventLive()
	{
		return false; // Skip server events
	}

	private void PlacePrePlacedQueens()
	{
		if (m_levelData == null || m_levelData.queensGrid == null) return;
		for (int i = 0; i < m_levelData.queensGrid.Length; i++)
		{
			if (m_levelData.IsPrePlacedQueen(i))
			{
				MarkQueenCell(i, true); // isDefaultQueen=true to bypass input check
				UnityEngine.Debug.Log($"[QueensGrid] Pre-placed queen at index {i} ({m_levelData.GetX(i)},{m_levelData.GetY(i)})");
			}
		}
	}

	private void GridIntroDone()
	{
		m_animatingIn = false;
		EnableInput();
		GridBuilt?.Invoke();
		GameplayEvents.SendGridIntroDone();
	}

	private IEnumerator GridIntroColorReveal()
	{
		// Wave reveal: cells pop in from top-left to bottom-right
		float delay = 0.04f;
		if (m_levelData != null && m_cells != null)
		{
			for (int y = 0; y < m_levelData.sizeY; y++)
			{
				for (int x = 0; x < m_levelData.sizeX; x++)
				{
					int idx = m_levelData.Index(x, y);
					var cell = GetCell(idx);
					if (cell != null)
						cell.transform.localScale = Vector3.one;
				}
				yield return new WaitForSeconds(delay);
			}
		}
		// Wait for rotation animation to finish (~2.5s total, cells took some of that)
		yield return new WaitForSeconds(1.5f);
		GridIntroDone();
	}

	private IEnumerator GridIntroFallback()
	{
		// Fallback: rotate the grid container + wave reveal cells
		if (m_cells != null)
		{
			for (int i = 0; i < m_cells.Count; i++)
				m_cells[i].transform.localScale = Vector3.zero;
		}

		Transform gridTransform = m_cellContainer != null ? m_cellContainer : transform;
		Quaternion startRot = Quaternion.Euler(0, 0, 120f);
		Quaternion endRot = Quaternion.identity;
		float duration = 1.5f;
		float elapsed = 0f;

		gridTransform.localRotation = startRot;

		// Rotate while revealing cells row by row
		int revealedRows = 0;
		int totalRows = m_levelData != null ? m_levelData.sizeY : 0;
		float rowInterval = totalRows > 0 ? duration / totalRows : duration;

		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / duration);
			// Smooth ease-out
			float smooth = 1f - (1f - t) * (1f - t);
			gridTransform.localRotation = Quaternion.Lerp(startRot, endRot, smooth);

			// Reveal rows progressively
			int rowsToShow = Mathf.FloorToInt(t * totalRows);
			while (revealedRows < rowsToShow && m_levelData != null && m_cells != null)
			{
				for (int x = 0; x < m_levelData.sizeX; x++)
				{
					int idx = m_levelData.Index(x, revealedRows);
					var cell = GetCell(idx);
					if (cell != null)
						cell.transform.localScale = Vector3.one;
				}
				revealedRows++;
			}

			yield return null;
		}

		// Ensure everything is visible
		gridTransform.localRotation = endRot;
		if (m_cells != null)
		{
			for (int i = 0; i < m_cells.Count; i++)
				m_cells[i].transform.localScale = Vector3.one;
		}

		GridIntroDone();
	}

	private int GetNumberOfGems()
	{
		if (!m_queenEventIsActive) return 0;
		return Mathf.Min(3, m_levelData != null ? m_levelData.QueenCount() : 0);
	}

	private void SetupGemLocations()
	{
		int numGems = GetNumberOfGems();
		m_gemCount = numGems;
		if (numGems <= 0 || m_levelData == null)
		{
			m_gemLocations = new int[0];
			return;
		}

		m_gemLocations = new int[m_levelData.sizeX * m_levelData.sizeY];
		// Place gems at random queen locations
		var rng = new System.Random(m_levelData.sizeX * SEED_LEVEL_MULTIPLIER);
		var queenIndices = new List<int>();
		for (int i = 0; i < m_levelData.queensGrid.Length; i++)
		{
			if (m_levelData.queensGrid[i] >= 1) queenIndices.Add(i);
		}
		for (int i = 0; i < numGems && queenIndices.Count > 0; i++)
		{
			int idx = rng.Next(queenIndices.Count);
			m_gemLocations[queenIndices[idx]] = 1;
			queenIndices.RemoveAt(idx);
		}
	}

	private bool IsAGemLocation(int cellIndex)
	{
		if (m_gemLocations == null || cellIndex < 0 || cellIndex >= m_gemLocations.Length)
			return false;
		return m_gemLocations[cellIndex] == 1;
	}

	public void SetFtueMode()
	{
		m_isFTUEActive = true;
		m_ftueTarget.Clear();
	}

	public void ClearFtueMode()
	{
		m_isFTUEActive = false;
		m_ftueTarget.Clear();
		// Re-enable all cells
		if (m_cells != null)
		{
			for (int i = 0; i < m_cells.Count; i++)
				m_cells[i].SetColliderEnabled(true);
		}
	}

	public void AddFtueTarget(int x, int y, bool hilight = true)
	{
		if (m_levelData == null) return;
		int idx = m_levelData.Index(x, y);
		if (idx >= 0)
		{
			m_ftueTarget.Add(idx);
			if (hilight)
			{
				var cell = GetCell(idx);
				if (cell != null) cell.Highlight(true);
			}
		}
	}

	public void ClearHighlight(int x, int y)
	{
		if (m_levelData == null) return;
		int idx = m_levelData.Index(x, y);
		var cell = GetCell(idx);
		if (cell != null) cell.Highlight(false);
	}

	public void ClearFtueTargets()
	{
		m_ftueTarget.Clear();
		if (m_cells != null)
		{
			for (int i = 0; i < m_cells.Count; i++)
				m_cells[i].Highlight(false);
		}
	}

	private void RevealGem(Transform t)
	{
		m_gemsFlying++;
		GemRevealed?.Invoke(m_gemsFlying);
	}

	public void MarkQueenCell(int cellIndex, bool isDefaultQueen = false, bool isBoosterUsed = false)
	{
		if (!m_inputEnabled && !isDefaultQueen) return;
		if (m_playerSolution == null || cellIndex < 0 || cellIndex >= m_playerSolution.Length) return;
		if (m_levelData == null) return;

		// Check if this is actually a queen position
		bool isCorrect = m_levelData.GetQueen(cellIndex);
		UnityEngine.Debug.Log($"[QueensGrid] MarkQueenCell({cellIndex}): queensGrid[{cellIndex}]={m_levelData.queensGrid[cellIndex]}, isCorrect={isCorrect}");

		if (isCorrect)
		{
			m_playerSolution[cellIndex] = QUEEN;
			m_queenCount++;
			var cell = GetCell(cellIndex);
			if (cell != null)
			{
				cell.SetAsQueen(!isDefaultQueen);
				cell.DontAcceptX();
			}

			if (AutoXAvailableAndActivated())
				DoAutoXForQueen(cellIndex);

			QueenMarked?.Invoke(cellIndex);
			m_interactionsCount++;

			if (IsAGemLocation(cellIndex) && cell != null)
				RevealGem(cell.transform);

			if (GetRemainingQueens() == 0)
				DoQueensCelebration();
		}
		else
		{
			// Wrong placement - lose a life
			var cell = GetCell(cellIndex);
			if (cell != null)
				cell.SetAsLoseLife();

			if (m_looseLifeEnabled)
				LifeLost?.Invoke(cellIndex);
		}
	}

	private void DoAutoXForQueen(int cellIndex)
	{
		if (m_levelData == null || m_playerSolution == null) return;
		// Mark same row, column, diagonal, and same color as X
		m_levelData.AutomarkQueenSouroundings(cellIndex, ref m_playerSolution);

		// Update cell visuals
		for (int i = 0; i < m_playerSolution.Length; i++)
		{
			if (i == cellIndex) continue;
			var c = GetCell(i);
			if (c != null && c.Value == NONE && m_playerSolution[i] == X)
			{
				c.SetAsX(false, false, m_pitch);
			}
		}
	}

	public void DoAutoXForAllFoundQueens()
	{
		if (m_playerSolution == null) return;
		for (int i = 0; i < m_playerSolution.Length; i++)
		{
			if (m_playerSolution[i] == QUEEN)
				DoAutoXForQueen(i);
		}
	}

	private bool AutoXAvailableAndActivated()
	{
		var controller = QueensGameController.Instance;
		return controller != null && controller.HasPermanentAutoX();
	}

	public void MarkXCell(int cellIndex, bool hint = false, bool sound = true)
	{
		if (!m_inputEnabled && !hint) return;
		if (m_playerSolution == null || cellIndex < 0 || cellIndex >= m_playerSolution.Length) return;
		if (m_playerSolution[cellIndex] != NONE) return;

		m_playerSolution[cellIndex] = X;
		var cell = GetCell(cellIndex);
		if (cell != null)
		{
			m_pitch = Mathf.Min(m_pitch + PITCH_INCREASE, 2f);
			cell.SetAsX(hint, sound, m_pitch);
			if (sound) StartPitchResetCoroutine();
		}

		CrossMarked?.Invoke(cellIndex);
		m_interactionsCount++;
	}

	private void BoardInteracted()
	{
		m_interactionsCount++;
	}

	private void StartPitchResetCoroutine()
	{
		if (m_pitchCoroutine != null)
			StopCoroutine(m_pitchCoroutine);
		m_pitchCoroutine = StartCoroutine(ResetPitchAfterDelay());
	}

	private IEnumerator ResetPitchAfterDelay()
	{
		yield return new WaitForSeconds(0.5f);
		m_pitch = 1f;
	}

	public void ClearCell(int cellIndex)
	{
		if (!m_inputEnabled) return;
		ClearCellSilently(cellIndex);
	}

	public void ClearCellSilently(int cellIndex)
	{
		if (m_playerSolution == null || cellIndex < 0 || cellIndex >= m_playerSolution.Length) return;
		if (m_playerSolution[cellIndex] == QUEEN)
		{
			m_queenCount--;
		}
		bool wasX = m_playerSolution[cellIndex] == X;
		m_playerSolution[cellIndex] = NONE;

		var cell = GetCell(cellIndex);
		if (cell != null)
			cell.Clear(m_pitch);

		if (wasX)
			CrossRemoved?.Invoke(cellIndex);
	}

	private bool IsFTUETarget(int cellIndex)
	{
		if (!m_isFTUEActive) return true;
		return m_ftueTarget != null && m_ftueTarget.Contains(cellIndex);
	}

	private void DoQueensCelebration()
	{
		DisableInput();
		if (m_cells == null) return;
		for (int i = 0; i < m_cells.Count; i++)
		{
			bool left = m_cells[i].Coords.x < m_levelData.sizeX / 2f;
			m_cells[i].Celebrate(left);
		}
	}

	public void Clear()
	{
		if (m_cells != null)
		{
			for (int i = m_cells.Count - 1; i >= 0; i--)
			{
				if (m_cells[i] != null)
					Destroy(m_cells[i].gameObject);
			}
			m_cells.Clear();
		}
		m_playerSolution = null;
		m_queenCount = 0;
		m_levelData = null;
	}

	private void CreateGrid()
	{
		// Clear old cells
		if (m_cells != null)
		{
			for (int i = m_cells.Count - 1; i >= 0; i--)
			{
				if (m_cells[i] != null)
					Destroy(m_cells[i].gameObject);
			}
			m_cells.Clear();
		}
		else
		{
			m_cells = new List<QueensGridCell>();
		}

		if (m_levelData == null || m_gridCellPrefab == null)
		{
			UnityEngine.Debug.LogError($"[QueensGrid] CreateGrid aborted: levelData={m_levelData != null}, cellPrefab={m_gridCellPrefab != null}");
			return;
		}

		float totalWidth = m_levelData.sizeX * m_cellWidth;
		float totalHeight = m_levelData.sizeY * m_cellWidth;
		float startX = -totalWidth / 2f + m_cellWidth / 2f;
		float startY = totalHeight / 2f - m_cellWidth / 2f;

		Transform parent = m_cellContainer != null ? m_cellContainer : transform;
		UnityEngine.Debug.Log($"[QueensGrid] CreateGrid: {m_levelData.sizeX}x{m_levelData.sizeY}, cellWidth={m_cellWidth}, parent={parent.name}, parentPos={parent.position}, gridPos={transform.position}, gridLayer={gameObject.layer}");

		for (int y = 0; y < m_levelData.sizeY; y++)
		{
			for (int x = 0; x < m_levelData.sizeX; x++)
			{
				int index = m_levelData.Index(x, y);
				int color = m_levelData.GetColor(index);

				// Use corner prefab for corner cells if available
				bool isCorner = (x == 0 || x == m_levelData.sizeX - 1) && (y == 0 || y == m_levelData.sizeY - 1);
				QueensGridCell prefab = (isCorner && m_gridCellCornerPrefab != null) ? m_gridCellCornerPrefab : m_gridCellPrefab;

				QueensGridCell cell = Instantiate(prefab, parent);
				cell.transform.localPosition = new Vector3(startX + x * m_cellWidth, startY - y * m_cellWidth, 0f);
				cell.Configure(index, color, x, y);

				// Flip corner cells appropriately
				if (isCorner)
				{
					cell.Flip(x == m_levelData.sizeX - 1, y == 0);
				}

				m_cells.Add(cell);
			}
		}

		UnityEngine.Debug.Log($"[QueensGrid] Created {m_cells.Count} cells. First cell layer={m_cells[0].gameObject.layer}, pos={m_cells[0].transform.position}");

		// Fix: SpriteMask was lost during AssetRipper export.
		// Sprites with VisibleOutsideMask (like Background-Grey) cover the color layer.
		// Set them to None and disable the opaque gray overlay by name.
		for (int i = 0; i < m_cells.Count; i++)
		{
			var renderers = m_cells[i].GetComponentsInChildren<SpriteRenderer>(true);
			foreach (var sr in renderers)
			{
				if (sr.maskInteraction == SpriteMaskInteraction.VisibleOutsideMask)
					sr.maskInteraction = SpriteMaskInteraction.None;
			}
			// Disable the opaque gray background that covers the color
			var greyBg = m_cells[i].transform.Find("Content/Background-Grey");
			if (greyBg != null) greyBg.gameObject.SetActive(false);
		}

		ResizeSpriteToCoverChildren();

		// Accessibility borders disabled - optional feature, not needed for core gameplay
		// ConfigureAccesibilityBorders();

		// Play grid intro animation (rotation + color paint effect)
		m_animatingIn = true;
		DisableInput();
		var animator = GetComponent<Animator>();
		if (animator != null)
		{
			// Hide all cells initially, then reveal with wave delay
			for (int ci = 0; ci < m_cells.Count; ci++)
				m_cells[ci].transform.localScale = Vector3.zero;

			animator.Play(ANIM_INTRO, -1, 0f);
			StartCoroutine(GridIntroColorReveal());
		}
		else
		{
			// No animator — use coroutine-based rotation + wave reveal
			StartCoroutine(GridIntroFallback());
		}
	}

	private void ConfigureAccesibilityBorders()
	{
		if (m_borderPrefab == null) return;
		StartCoroutine(ConfigureAccesibilityBordersRoutine());
	}

	[IteratorStateMachine(typeof(_003CConfigureAccesibilityBordersRoutine_003Ed__88))]
	private IEnumerator ConfigureAccesibilityBordersRoutine()
	{
		var d = new _003CConfigureAccesibilityBordersRoutine_003Ed__88(0);
		d._003C_003E4__this = this;
		return d;
	}

	[ContextMenu("Refresh Colours")]
	public void SetCellColours()
	{
		if (m_cells == null || m_levelData == null) return;
		for (int i = 0; i < m_cells.Count; i++)
		{
			int index = m_cells[i].CellIndex;
			int color = m_levelData.GetColor(index);
			m_cells[i].ReColour(color);
		}
	}

	private int CountAllColoursInLevel(int[] array)
	{
		if (array == null) return 0;
		var colors = new HashSet<int>();
		for (int i = 0; i < array.Length; i++)
			colors.Add(array[i]);
		return colors.Count;
	}

	public void QueenBooster(int forceIndex = -1)
	{
		if (m_levelData == null || m_playerSolution == null) return;

		int targetIndex = forceIndex;
		if (targetIndex < 0)
		{
			// Find a queen position that hasn't been placed yet
			for (int i = 0; i < m_levelData.queensGrid.Length; i++)
			{
				if (m_levelData.queensGrid[i] >= 1 && m_playerSolution[i] != QUEEN)
				{
					targetIndex = i;
					break;
				}
			}
		}

		if (targetIndex >= 0)
		{
			// Clear any X at that position first
			if (m_playerSolution[targetIndex] == X)
				ClearCellSilently(targetIndex);
			MarkQueenCell(targetIndex, false, true);
		}
	}

	public void HintBooster()
	{
		if (m_levelData == null || m_playerSolution == null || m_cells == null) return;

		// Highlight cells where queens should go
		for (int i = 0; i < m_levelData.queensGrid.Length; i++)
		{
			if (m_levelData.queensGrid[i] >= 1 && m_playerSolution[i] != QUEEN)
			{
				var cell = GetCell(i);
				if (cell != null)
					cell.ShowHintHighlight(true);
				break; // Just show one hint
			}
		}
	}

	public int GetEmptyCells()
	{
		if (m_playerSolution == null) return 0;
		int count = 0;
		for (int i = 0; i < m_playerSolution.Length; i++)
		{
			if (m_playerSolution[i] == NONE) count++;
		}
		return count;
	}

	public int GetCrossCells()
	{
		if (m_playerSolution == null) return 0;
		int count = 0;
		for (int i = 0; i < m_playerSolution.Length; i++)
		{
			if (m_playerSolution[i] == X) count++;
		}
		return count;
	}

	public int GetRemainingQueens()
	{
		if (m_levelData == null) return 0;
		return m_levelData.QueenCount() - m_queenCount;
	}

	public int GetPlayerSolution(int cellIndex)
	{
		if (m_playerSolution == null || cellIndex < 0 || cellIndex >= m_playerSolution.Length)
			return NONE;
		return m_playerSolution[cellIndex];
	}

	public bool IsQueenCell(int cellIndex)
	{
		if (m_playerSolution == null || cellIndex < 0 || cellIndex >= m_playerSolution.Length)
			return false;
		return m_playerSolution[cellIndex] == QUEEN;
	}

	public void MarkWrongCell(int cellIndex)
	{
		var cell = GetCell(cellIndex);
		if (cell != null)
			cell.SetAsLoseLife();
	}

	private void ResizeSpriteToCoverChildren()
	{
		if (m_textureSpriteRenderer == null || m_textureOverlay == null || m_levelData == null) return;
		float totalWidth = m_levelData.sizeX * m_cellWidth;
		float totalHeight = m_levelData.sizeY * m_cellWidth;
		m_textureOverlay.localScale = new Vector3(totalWidth, totalHeight, 1f);
	}

	public QueensGridCell GetCell(Vector2Int coords)
	{
		return GetCell(coords.x, coords.y);
	}

	public QueensGridCell GetCell(int x, int y)
	{
		if (m_levelData == null) return null;
		int idx = m_levelData.Index(x, y);
		return GetCell(idx);
	}

	public QueensGridCell GetCell(int index)
	{
		if (m_cells == null || index < 0) return null;
		for (int i = 0; i < m_cells.Count; i++)
		{
			if (m_cells[i].CellIndex == index)
				return m_cells[i];
		}
		return null;
	}

	public List<QueensGridCell> GetAllCells()
	{
		return m_cells;
	}

	public List<int> GetColoursUsed()
	{
		return m_colorsArray;
	}

	public List<QueensGridCell> GetQueensCells()
	{
		if (m_cells == null) return null;
		var result = new List<QueensGridCell>();
		for (int i = 0; i < m_cells.Count; i++)
		{
			if (m_cells[i].Value == QUEEN)
				result.Add(m_cells[i]);
		}
		return result;
	}

	public void WaveAnimationAroundCell(int cellIndex)
	{
		StartCoroutine(WaveAnimationRoutine(cellIndex));
	}

	[IteratorStateMachine(typeof(_003CWaveAnimationRoutine_003Ed__107))]
	private IEnumerator WaveAnimationRoutine(int cellIndex)
	{
		var d = new _003CWaveAnimationRoutine_003Ed__107(0);
		d._003C_003E4__this = this;
		d.cellIndex = cellIndex;
		return d;
	}
}
