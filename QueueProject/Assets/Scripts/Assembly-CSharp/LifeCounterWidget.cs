using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LifeCounterWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartingSequence_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LifeCounterWidget _003C_003E4__this;

		private int _003CalreadyLostLives_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CStartingSequence_003Ed__14(int _003C_003E1__state)
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
					// Show hearts with intro animation
					if (_003C_003E4__this.m_hearts != null)
					{
						_003Ci_003E5__3 = 0;
						_003C_003E1__state = 1;
						goto case 1;
					}
					return false;
				case 1:
					if (_003Ci_003E5__3 < _003C_003E4__this.m_hearts.Count)
					{
						_003C_003E4__this.m_hearts[_003Ci_003E5__3].Intro();
						_003C_003E2__current = new WaitForSeconds(0.1f);
						_003C_003E1__state = 2;
						return true;
					}
					return false;
				case 2:
					_003C_003E1__state = -1;
					_003Ci_003E5__3++;
					_003C_003E1__state = 1;
					goto case 1;
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

	private const string ANIM_LOST = "Lost";

	private const string ANIM_DEFAULT = "Default";

	[SerializeField]
	private HeartWidget m_heartPrefab;

	[SerializeField]
	private Transform m_heartContainer;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private bool m_configLostHeartsWithLoseAnimation;

	private List<HeartWidget> m_hearts;

	private int m_lifeIndex;

	private AnimatorHelper m_animatorHelper;

	private void Awake()
	{
		m_hearts = new List<HeartWidget>();
		m_animatorHelper = GetComponent<AnimatorHelper>();
	}

	private void OnDestroy()
	{
		QueensGameController.LifeLostEvent -= LifeLostEvent;
	}

	private void Start()
	{
		QueensGameController.LifeLostEvent += LifeLostEvent;
	}

	private void LifeLostEvent()
	{
		if (m_lifeIndex >= 0 && m_lifeIndex < m_hearts.Count)
		{
			m_hearts[m_lifeIndex].LifeLost();
			m_lifeIndex--;
		}
	}

	public void Configure(int nLifes)
	{
		// Clear old hearts
		foreach (var heart in m_hearts)
		{
			if (heart != null)
				Destroy(heart.gameObject);
		}
		m_hearts.Clear();

		m_lifeIndex = nLifes - 1;

		// Create heart widgets
		if (m_heartPrefab != null && m_heartContainer != null)
		{
			for (int i = 0; i < nLifes; i++)
			{
				HeartWidget heart = Instantiate(m_heartPrefab, m_heartContainer);
				m_hearts.Add(heart);
			}
		}

		StartCoroutine(StartingSequence());
	}

	[IteratorStateMachine(typeof(_003CStartingSequence_003Ed__14))]
	private IEnumerator StartingSequence()
	{
		var d = new _003CStartingSequence_003Ed__14(0);
		d._003C_003E4__this = this;
		return d;
	}

	public void Disable()
	{
		if (m_canvasGroup != null)
		{
			m_canvasGroup.alpha = 0f;
			m_canvasGroup.interactable = false;
		}
	}

	public void Hide(float duration = 0f)
	{
		if (m_canvasGroup != null)
			m_canvasGroup.alpha = 0f;
	}

	public void Show(float duration)
	{
		if (m_canvasGroup != null)
			m_canvasGroup.alpha = 1f;
	}
}
