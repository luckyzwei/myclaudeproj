using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Data;
using UnityEngine;
using UnityEngine.UI.Extensions.EasingCore;

public class QueensGrid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CConfigureAccesibilityBordersRoutine_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensGrid _003C_003E4__this;

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
		public _003CConfigureAccesibilityBordersRoutine_003Ed__88(int _003C_003E1__state)
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

		private EasingFunction _003CquadEase_003E5__7;

		private int _003Cdistance_003E5__8;

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
		public _003CWaveAnimationRoutine_003Ed__107(int _003C_003E1__state)
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

	public int QueenCount => 0;

	public bool IsInputEnabled => false;

	public LevelData LevelData => null;

	public bool IsGemFlying => false;

	public int GemCount => 0;

	private static UserPlayerProfileData SaveData => null;

	public void DisableInput()
	{
	}

	public void EnableInput()
	{
	}

	public int GetColour(int color)
	{
		return 0;
	}

	public void EnableLosingLife(bool enabled)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnAllGemsAreClaimed()
	{
	}

	public void Configure(LevelData levelData)
	{
	}

	private bool IsQueensEventLive()
	{
		return false;
	}

	private void GridIntroDone()
	{
	}

	private int GetNumberOfGems()
	{
		return 0;
	}

	private void SetupGemLocations()
	{
	}

	private bool IsAGemLocation(int cellIndex)
	{
		return false;
	}

	public void SetFtueMode()
	{
	}

	public void ClearFtueMode()
	{
	}

	public void AddFtueTarget(int x, int y, bool hilight = true)
	{
	}

	public void ClearHighlight(int x, int y)
	{
	}

	public void ClearFtueTargets()
	{
	}

	private void RevealGem(Transform t)
	{
	}

	public void MarkQueenCell(int cellIndex, bool isDefaultQueen = false, bool isBoosterUsed = false)
	{
	}

	private void DoAutoXForQueen(int cellIndex)
	{
	}

	public void DoAutoXForAllFoundQueens()
	{
	}

	private bool AutoXAvailableAndActivated()
	{
		return false;
	}

	public void MarkXCell(int cellIndex, bool hint = false, bool sound = true)
	{
	}

	private void BoardInteracted()
	{
	}

	private void StartPitchResetCoroutine()
	{
	}

	public void ClearCell(int cellIndex)
	{
	}

	public void ClearCellSilently(int cellIndex)
	{
	}

	private bool IsFTUETarget(int cellIndex)
	{
		return false;
	}

	private void DoQueensCelebration()
	{
	}

	public void Clear()
	{
	}

	private void CreateGrid()
	{
	}

	private void ConfigureAccesibilityBorders()
	{
	}

	[IteratorStateMachine(typeof(_003CConfigureAccesibilityBordersRoutine_003Ed__88))]
	private IEnumerator ConfigureAccesibilityBordersRoutine()
	{
		return null;
	}

	[ContextMenu("Refresh Colours")]
	public void SetCellColours()
	{
	}

	private int CountAllColoursInLevel(int[] array)
	{
		return 0;
	}

	public void QueenBooster(int forceIndex = -1)
	{
	}

	public void HintBooster()
	{
	}

	public int GetEmptyCells()
	{
		return 0;
	}

	public int GetCrossCells()
	{
		return 0;
	}

	public int GetRemainingQueens()
	{
		return 0;
	}

	public int GetPlayerSolution(int cellIndex)
	{
		return 0;
	}

	public bool IsQueenCell(int cellIndex)
	{
		return false;
	}

	public void MarkWrongCell(int cellIndex)
	{
	}

	private void ResizeSpriteToCoverChildren()
	{
	}

	public QueensGridCell GetCell(Vector2Int coords)
	{
		return null;
	}

	public QueensGridCell GetCell(int x, int y)
	{
		return null;
	}

	public QueensGridCell GetCell(int index)
	{
		return null;
	}

	public List<QueensGridCell> GetAllCells()
	{
		return null;
	}

	public List<int> GetColoursUsed()
	{
		return null;
	}

	public List<QueensGridCell> GetQueensCells()
	{
		return null;
	}

	public void WaveAnimationAroundCell(int cellIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CWaveAnimationRoutine_003Ed__107))]
	private IEnumerator WaveAnimationRoutine(int cellIndex)
	{
		return null;
	}
}
