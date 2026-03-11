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
		m_blockers = new List<PlayableAreaBlocker>();
	}

	private void Start()
	{
		Calculate();
	}

	public void RegisterBlocker(PlayableAreaBlocker playableAreaBlocker)
	{
		if (playableAreaBlocker == null || m_blockers == null) return;
		if (!m_blockers.Contains(playableAreaBlocker))
		{
			m_blockers.Add(playableAreaBlocker);
			ListChanged();
		}
	}

	public void UnregisterBlocker(PlayableAreaBlocker itemToRemove)
	{
		if (itemToRemove == null || m_blockers == null) return;
		if (m_blockers.Remove(itemToRemove))
			ListChanged();
	}

	private void ListChanged()
	{
		if (m_calculated)
			Calculate();
	}

	private void StopCalculating()
	{
		m_calculating = false;
		if (m_calculateCoroutine != null)
		{
			StopCoroutine(m_calculateCoroutine);
			m_calculateCoroutine = null;
		}
	}

	public void Calculate()
	{
		m_calculating = true;
		CalculateScenario(m_playableAreaTransform, false);
		CalculateScenario(m_playableAreaTransformSides, true);
		m_calculated = true;
		m_calculating = false;

		if (m_cameraSizeCoroutine != null)
			StopCoroutine(m_cameraSizeCoroutine);
		m_cameraSizeCoroutine = StartCoroutine(SetCameraSizeCoroutine());
	}

	[IteratorStateMachine(typeof(_003CSetCameraSizeCoroutine_003Ed__24))]
	private IEnumerator SetCameraSizeCoroutine(int delayFrames = 2)
	{
		for (int i = 0; i < delayFrames; i++)
			yield return null;
		SetCameraSize();
		SetCameraPosition();
		GameplayEvents.SendCameraRepositionedDone();
	}

	private void CalculateScenario(RectTransform playableAreaTransform, bool ignoreLeftRight)
	{
		if (playableAreaTransform == null || m_screenTransform == null) return;

		Rect available = FindAvailableSpace(m_blockers, m_screenTransform, ignoreLeftRight);

		playableAreaTransform.anchorMin = new Vector2(available.xMin / m_screenTransform.rect.width,
			available.yMin / m_screenTransform.rect.height);
		playableAreaTransform.anchorMax = new Vector2(available.xMax / m_screenTransform.rect.width,
			available.yMax / m_screenTransform.rect.height);
		playableAreaTransform.offsetMin = Vector2.zero;
		playableAreaTransform.offsetMax = Vector2.zero;

		if (ignoreLeftRight)
			m_sizeNoSides = new Vector2(available.width, available.height);
		else
			m_size = new Vector2(available.width, available.height);
	}

	private static Rect FindAvailableSpace(List<PlayableAreaBlocker> blockers, RectTransform parent, bool ignoreLeftRight)
	{
		Rect parentRect = parent.rect;
		float left = parentRect.xMin;
		float right = parentRect.xMax;
		float top = parentRect.yMax;
		float bottom = parentRect.yMin;

		if (blockers != null)
		{
			for (int i = 0; i < blockers.Count; i++)
			{
				if (blockers[i] == null || !blockers[i].isActiveAndEnabled) continue;
				var blockerRT = blockers[i].GetComponent<RectTransform>();
				if (blockerRT == null) continue;

				Rect blockerRect = WorldRectToLocal(parent, GetWorldRect(blockerRT));

				if (ignoreLeftRight) continue;

				// Shrink available space based on blocker position
				if (blockerRect.yMin <= parentRect.yMin + 1)
					bottom = Mathf.Max(bottom, blockerRect.yMax);
				if (blockerRect.yMax >= parentRect.yMax - 1)
					top = Mathf.Min(top, blockerRect.yMin);
			}
		}

		return Rect.MinMaxRect(left, bottom, right, top);
	}

	private static Rect GetWorldRect(RectTransform rt)
	{
		Vector3[] corners = new Vector3[4];
		rt.GetWorldCorners(corners);
		float xMin = corners[0].x;
		float yMin = corners[0].y;
		float xMax = corners[2].x;
		float yMax = corners[2].y;
		return Rect.MinMaxRect(xMin, yMin, xMax, yMax);
	}

	private static Rect WorldRectToLocal(RectTransform parent, Rect worldRect)
	{
		Vector3 localMin = parent.InverseTransformPoint(new Vector3(worldRect.xMin, worldRect.yMin, 0));
		Vector3 localMax = parent.InverseTransformPoint(new Vector3(worldRect.xMax, worldRect.yMax, 0));
		return Rect.MinMaxRect(localMin.x, localMin.y, localMax.x, localMax.y);
	}

	public float GetPlayPercentageAreaW(bool sides)
	{
		if (m_screenTransform == null) return 1f;
		float totalWidth = m_screenTransform.rect.width;
		if (totalWidth <= 0) return 1f;
		float areaWidth = sides ? m_sizeNoSides.x : m_size.x;
		return areaWidth / totalWidth;
	}

	public float GetPlayPercentageAreaH(bool sides)
	{
		if (m_screenTransform == null) return 1f;
		float totalHeight = m_screenTransform.rect.height;
		if (totalHeight <= 0) return 1f;
		float areaHeight = sides ? m_sizeNoSides.y : m_size.y;
		return areaHeight / totalHeight;
	}

	public Vector3 GetPlayAreaCenter(bool sides)
	{
		RectTransform rt = sides ? m_playableAreaTransformSides : m_playableAreaTransform;
		if (rt == null) return Vector3.zero;
		return GetRectTransformCenter(rt);
	}

	private static Vector3 GetRectTransformCenter(RectTransform rt)
	{
		Vector3[] corners = new Vector3[4];
		rt.GetWorldCorners(corners);
		return (corners[0] + corners[2]) * 0.5f;
	}

	private void SetCameraSize()
	{
		if (GameManager.Instance == null || GameManager.Instance.Camera == null) return;
		var cam = GameManager.Instance.Camera;

		float playW = GetPlayPercentageAreaW(m_noSides);
		float playH = GetPlayPercentageAreaH(m_noSides);
		float minPercent = Mathf.Min(playW, playH);

		if (minPercent <= 0) return;
		float newSize = cam.m_Lens.OrthographicSize / minPercent;

		if (Mathf.Abs(newSize - m_prevOrthoSize) > 0.01f)
		{
			m_prevOrthoSize = cam.m_Lens.OrthographicSize;
			cam.m_Lens.OrthographicSize = newSize;
			GameplayEvents.SendCameraResized(newSize);
		}
	}

	[IteratorStateMachine(typeof(_003CTestAllValues_003Ed__34))]
	private IEnumerator TestAllValues(int index, params float[] values)
	{
		if (values == null) yield break;
		for (int i = 0; i < values.Length; i++)
		{
			if (GameManager.Instance != null && GameManager.Instance.Camera != null)
				GameManager.Instance.Camera.m_Lens.OrthographicSize = values[i];
			yield return new WaitForSeconds(1f);
		}
	}

	private void SetCameraPosition()
	{
		if (GameManager.Instance == null || GameManager.Instance.Camera == null) return;
		Vector3 center = GetPlayAreaCenter(m_noSides);
		var cam = GameManager.Instance.Camera;
		var camTransform = cam.transform;
		camTransform.position = new Vector3(center.x, center.y, camTransform.position.z);
	}

	public void TogglePlayableArea()
	{
		m_noSides = !m_noSides;
		Calculate();
	}
}
