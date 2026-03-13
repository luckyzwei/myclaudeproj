using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupHint : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public Image mask;

		internal void _003CDisableMaskWithDelay_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CConfigCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupHint _003C_003E4__this;

		public string text;

		public List<QueensGridCell> interactableCells;

		public List<QueensGridCell> highlightedCells;

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
		public _003CConfigCoroutine_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CDisableMaskWithDelay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Image mask;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

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
		public _003CDisableMaskWithDelay_003Ed__20(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-HintBooster";

	public static bool IsShowing { get; private set; }

	private const float CELL_SIZE = 1.8f;

	private const float MASK_SIZE = 190f;

	[SerializeField]
	private Text m_text;

	[SerializeField]
	private Text m_hintTypeText;

	[SerializeField]
	private Image[] m_masks;

	[SerializeField]
	private Transform m_masksParent;

	[SerializeField]
	private Sprite m_gridCellSprite;

	[SerializeField]
	private Sprite m_cornerGridCellSprite;

	[SerializeField]
	private Button m_autoDoButton;

	private bool m_isAutoDoing;

	private int m_index;

	private float m_maskScale;

	private Dictionary<QueensGridCell, Image> m_cellMasks;

	private void OnEnable()
	{
		IsShowing = true;
		m_isAutoDoing = false;
		m_index = 0;
		m_maskScale = 0f;
		m_cellMasks = new Dictionary<QueensGridCell, Image>();

		// Deactivate all masks initially (they write to stencil buffer,
		// so active masks at default positions would create wrong cutouts)
		if (m_masks != null)
		{
			for (int i = 0; i < m_masks.Length; i++)
			{
				if (m_masks[i] != null)
					m_masks[i].gameObject.SetActive(false);
			}
		}

		if (m_autoDoButton != null)
			m_autoDoButton.gameObject.SetActive(false);
	}

	private void MakeButtonAppear()
	{
		if (m_autoDoButton != null)
			m_autoDoButton.gameObject.SetActive(true);
	}

	public void Config(string text, List<QueensGridCell> interactableCells, List<QueensGridCell> highlightedCells)
	{
		if (m_text != null)
		{
			m_text.text = text ?? "";
			m_text.alignment = TextAnchor.MiddleCenter;
		}

		// Hide hint type label (it's just a placeholder in the prefab)
		if (m_hintTypeText != null)
			m_hintTypeText.gameObject.SetActive(false);

		// Highlight cells on the popup mask overlay (creates cutout windows)
		StartCoroutine(ConfigCoroutine(text, interactableCells, highlightedCells));
	}

	private void DoHighlightCells(List<QueensGridCell> interactableCells, List<QueensGridCell> highlightedCells)
	{
		// Masks MUST render BEFORE BGOverlay (stencil write before stencil read)
		// Ensure Masks is first sibling
		if (m_masksParent != null)
			m_masksParent.SetAsFirstSibling();

		// Build a set of interactable cell indices for quick lookup
		HashSet<int> interactableSet = new HashSet<int>();
		if (interactableCells != null)
		{
			for (int i = 0; i < interactableCells.Count; i++)
			{
				if (interactableCells[i] != null)
					interactableSet.Add(interactableCells[i].CellIndex);
			}
		}

		// Highlight all cells through the dark overlay, but dim reference-only cells
		// so the player can clearly see which cells "快速应用" will act on
		if (highlightedCells != null)
		{
			for (int i = 0; i < highlightedCells.Count; i++)
			{
				var cell = highlightedCells[i];
				if (cell == null) continue;
				bool isActionable = interactableSet.Contains(cell.CellIndex);
				Highlight(cell, true);
				// Dim reference cells so actionable cells stand out
				if (!isActionable && m_cellMasks != null && m_cellMasks.TryGetValue(cell, out var mask) && mask != null)
					mask.color = new Color(1f, 1f, 1f, 0.45f);
			}
		}

		MakeButtonAppear();
	}

	[IteratorStateMachine(typeof(_003CConfigCoroutine_003Ed__17))]
	private IEnumerator ConfigCoroutine(string text, List<QueensGridCell> interactableCells, List<QueensGridCell> highlightedCells)
	{
		// Wait one frame for layout to complete before positioning masks
		yield return null;
		DoHighlightCells(interactableCells, highlightedCells);
	}

	public void Highlight(QueensGridCell cell, bool addBorder = true)
	{
		if (cell == null || m_masksParent == null) return;
		if (m_cellMasks == null) m_cellMasks = new Dictionary<QueensGridCell, Image>();
		if (m_cellMasks.ContainsKey(cell)) return;

		// Create a mask image for this cell
		if (m_masks != null && m_index < m_masks.Length && m_masks[m_index] != null)
		{
			var mask = m_masks[m_index];
			mask.gameObject.SetActive(true);

			// Calculate mask scale to match grid cell size on first use
			if (m_maskScale <= 0f)
				CalculateMaskScale();

			// Position the mask over the cell (world position)
			var rt = mask.rectTransform;
			rt.position = cell.transform.position;

			// Scale mask to match cell size
			if (m_maskScale > 0f)
				rt.localScale = new Vector3(m_maskScale, m_maskScale, 1f);

			m_cellMasks[cell] = mask;
			m_index++;
		}
	}

	private void CalculateMaskScale()
	{
		// mask world size = MASK_SIZE * localScale * parent.lossyScale
		// We want mask world size = cellWorldSize
		// So localScale = cellWorldSize / (MASK_SIZE * parent.lossyScale)
		float parentScale = m_masksParent != null ? m_masksParent.lossyScale.x : 1f;
		if (parentScale <= 0f) parentScale = 1f;

		float cellWorldSize = CELL_SIZE;

		// Try to measure actual cell spacing from the grid
		var grid = QueensGameController.Instance?.Grid;
		if (grid != null)
		{
			var allCells = grid.GetAllCells();
			if (allCells != null && allCells.Count >= 2)
			{
				float dist = Mathf.Abs(allCells[1].transform.position.x - allCells[0].transform.position.x);
				if (dist > 0f)
					cellWorldSize = dist;
			}
		}

		m_maskScale = cellWorldSize / (MASK_SIZE * parentScale);
	}

	public void UnHighlight(QueensGridCell cell)
	{
		if (cell == null || m_cellMasks == null) return;
		if (m_cellMasks.TryGetValue(cell, out var mask))
		{
			if (mask != null)
				StartCoroutine(DisableMaskWithDelay(mask));
			m_cellMasks.Remove(cell);
		}
	}

	[IteratorStateMachine(typeof(_003CDisableMaskWithDelay_003Ed__20))]
	private IEnumerator DisableMaskWithDelay(Image mask)
	{
		yield return new WaitForSeconds(0.2f);
		if (mask != null)
			mask.gameObject.SetActive(false);
	}

	public void OnAutoDoButtonClick()
	{
		if (m_isAutoDoing) return;
		m_isAutoDoing = true;

		if (m_autoDoButton != null)
			m_autoDoButton.interactable = false;

		// Trigger auto-do on HintProcessDoer
		// HintProcessDoer.AutoDo → coroutine marks cells → HintCompleted() closes this popup
		if (HintsManager.Instance != null)
			HintsManager.Instance.AutoDoHint(null);
	}

	private void OnDisable()
	{
		IsShowing = false;
	}

	protected override void OnDestroy()
	{
		IsShowing = false;
		base.OnDestroy();
		m_cellMasks?.Clear();
		m_cellMasks = null;
	}

	public void HighlightCells(List<QueensGridCell> cells, bool addBorder)
	{
		if (cells == null) return;
		for (int i = 0; i < cells.Count; i++)
		{
			Highlight(cells[i], addBorder);
		}
	}
}
