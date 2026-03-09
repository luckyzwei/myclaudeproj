using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class PlayableAreaCalculator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetCameraSizeCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayableAreaCalculator _003C_003E4__this;

		public int delayFrames;

		private int _003Ci_003E5__2;

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
		public _003CSetCameraSizeCoroutine_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CTestAllValues_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float[] values;

		public int index;

		public PlayableAreaCalculator _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CTestAllValues_003Ed__34(int _003C_003E1__state)
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
	private RectTransform m_screenTransform;

	[SerializeField]
	private RectTransform m_playableAreaTransform;

	[SerializeField]
	private RectTransform m_playableAreaTransformSides;

	[SerializeField]
	private GameObject m_refreshCameraButton;

	private bool m_noSides;

	private LevelData m_levelData;

	private Coroutine m_testCoroutine;

	private List<PlayableAreaBlocker> m_blockers;

	private bool m_calculating;

	private bool m_calculated;

	private Coroutine m_calculateCoroutine;

	private Coroutine m_cameraSizeCoroutine;

	private Tween m_cameraSizeTween;

	private Tween m_cameraPositionTween;

	private float m_prevOrthoSize;

	private Vector2 m_size;

	private Vector2 m_sizeNoSides;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void RegisterBlocker(PlayableAreaBlocker playableAreaBlocker)
	{
	}

	public void UnregisterBlocker(PlayableAreaBlocker itemToRemove)
	{
	}

	private void ListChanged()
	{
	}

	private void StopCalculating()
	{
	}

	public void Calculate()
	{
	}

	[IteratorStateMachine(typeof(_003CSetCameraSizeCoroutine_003Ed__24))]
	private IEnumerator SetCameraSizeCoroutine(int delayFrames = 2)
	{
		return null;
	}

	private void CalculateScenario(RectTransform playableAreaTransform, bool ignoreLeftRight)
	{
	}

	private static Rect FindAvailableSpace(List<PlayableAreaBlocker> blockers, RectTransform parent, bool ignoreLeftRight)
	{
		return default(Rect);
	}

	private static Rect GetWorldRect(RectTransform rt)
	{
		return default(Rect);
	}

	private static Rect WorldRectToLocal(RectTransform parent, Rect worldRect)
	{
		return default(Rect);
	}

	public float GetPlayPercentageAreaW(bool sides)
	{
		return 0f;
	}

	public float GetPlayPercentageAreaH(bool sides)
	{
		return 0f;
	}

	public Vector3 GetPlayAreaCenter(bool sides)
	{
		return default(Vector3);
	}

	private static Vector3 GetRectTransformCenter(RectTransform rt)
	{
		return default(Vector3);
	}

	private void SetCameraSize()
	{
	}

	[IteratorStateMachine(typeof(_003CTestAllValues_003Ed__34))]
	private IEnumerator TestAllValues(int index, params float[] values)
	{
		return null;
	}

	private void SetCameraPosition()
	{
	}

	public void TogglePlayableArea()
	{
	}
}
