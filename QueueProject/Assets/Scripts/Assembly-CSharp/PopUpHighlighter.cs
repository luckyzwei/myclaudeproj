using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpHighlighter : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CSetHandPosition_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopUpHighlighter _003C_003E4__this;

		public Transform objectTransform;

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
		public _003CSetHandPosition_003Ed__24(int _003C_003E1__state)
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

	private const string ANIM_TAP = "Tap";

	private const string ANIM_DOUBLETAP = "DoubleTap";

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-Highlighter";

	private const string ANIM_ANIM_INTRO = "Anim-Intro";

	private const string ANIM_ANIM_OUTRO = "Anim-Outro";

	private const float FADE_TIME = 0.5f;

	[SerializeField]
	private Transform m_parent;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private RectTransform m_hand;

	[SerializeField]
	private AnimatorHelper m_handAnimator;

	[SerializeField]
	private Button m_button;

	private Transform m_item;

	private Transform m_defaultParent;

	private int m_defaultSiblingIndex;

	private List<Transform> m_highlightedObjects;

	private List<Transform> m_defaultParents;

	private List<GameObject> m_placeholders;

	private List<int> m_siblingIndexes;

	private Action m_doneCallback;

	private bool m_isHighlighting;

	private bool m_isHandPositionSet;

	private Vector3 m_handOffset;

	public void Config(Transform item, bool useHand = true, bool allowTapAnywhere = false)
	{
	}

	[IteratorStateMachine(typeof(_003CSetHandPosition_003Ed__24))]
	private IEnumerator SetHandPosition(Transform objectTransform)
	{
		return null;
	}

	public void CloseAndPutItemsBack()
	{
	}

	public void SetRaycastTarget(bool value)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void Highlight(bool useHand = true, params GameObject[] objectsToHighlight)
	{
	}

	public void Deactivate(bool immediately = false)
	{
	}

	private void PutEverythingBack(bool disable = true)
	{
	}

	public void SetHandAngle(float angle)
	{
	}

	public void SetHandOffset(Vector3 offset)
	{
	}

	public void ShowHand()
	{
	}

	public void SetHandScale(float scale)
	{
	}
}
