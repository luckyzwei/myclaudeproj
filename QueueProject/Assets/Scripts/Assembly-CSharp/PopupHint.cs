using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using TMPro;
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

	private const float CELL_SIZE = 1.8f;

	private const float MASK_SIZE = 190f;

	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private TMP_Text m_hintTypeText;

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
	}

	private void MakeButtonAppear()
	{
	}

	public void Config(string text, List<QueensGridCell> interactableCells, List<QueensGridCell> highlightedCells)
	{
	}

	[IteratorStateMachine(typeof(_003CConfigCoroutine_003Ed__17))]
	private IEnumerator ConfigCoroutine(string text, List<QueensGridCell> interactableCells, List<QueensGridCell> highlightedCells)
	{
		return null;
	}

	public void Highlight(QueensGridCell cell, bool addBorder = true)
	{
	}

	public void UnHighlight(QueensGridCell cell)
	{
	}

	[IteratorStateMachine(typeof(_003CDisableMaskWithDelay_003Ed__20))]
	private IEnumerator DisableMaskWithDelay(Image mask)
	{
		return null;
	}

	public void OnAutoDoButtonClick()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void HighlightCells(List<QueensGridCell> cells, bool addBorder)
	{
	}
}
