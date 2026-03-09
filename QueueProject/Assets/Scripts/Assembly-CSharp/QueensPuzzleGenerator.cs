using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QueensPuzzleGenerator : JigsawGenerator
{
	[CompilerGenerated]
	private sealed class _003CMovePiecesAround_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensPuzzleGenerator _003C_003E4__this;

		private List<GameObject> _003CspawnedPieces_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CMovePiecesAround_003Ed__21(int _003C_003E1__state)
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

	[Space]
	[SerializeField]
	private Texture2D m_sampleImage;

	[SerializeField]
	private float m_startWait;

	[SerializeField]
	private float m_movementMultiplier;

	[SerializeField]
	private float m_movementTime;

	[SerializeField]
	private float m_movementDelay;

	[SerializeField]
	private float m_wait;

	[SerializeField]
	private Image m_pictureIntact;

	[SerializeField]
	private TMP_InputField m_width;

	[SerializeField]
	private TMP_InputField m_height;

	[SerializeField]
	private GameObject m_cutButton;

	[SerializeField]
	private TMP_Text m_timeText;

	[SerializeField]
	private RectTransform m_parent;

	private Vector3[] m_originalPositions;

	private Transform m_draggingItem;

	private Vector3 m_offset;

	private SpriteRenderer m_sprite;

	private bool m_isDragging;

	private DateTime m_startTime;

	private void Start()
	{
	}

	public void ButtonClicked()
	{
	}

	private void PiecesGenerated()
	{
	}

	[IteratorStateMachine(typeof(_003CMovePiecesAround_003Ed__21))]
	private IEnumerator MovePiecesAround()
	{
		return null;
	}

	private void Update()
	{
	}

	private Vector3 GetMouseWorldPos(Vector3 mousePosition)
	{
		return default(Vector3);
	}
}
