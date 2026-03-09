using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

[SortingLayer("RateUsPopUp")]
public class PopUpRateUsSoft : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CAnimateStars_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopUpRateUsSoft _003C_003E4__this;

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
		public _003CAnimateStars_003Ed__18(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/PopUps/Popup-RateUsSoft";

	[SerializeField]
	protected RatingStarWidget[] m_stars;

	[SerializeField]
	protected Button m_confirmRateButton;

	[SerializeField]
	protected Button m_feedbackButton;

	[SerializeField]
	protected Button m_closeButton;

	[SerializeField]
	protected Button m_noThanksButton;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[Space]
	[SerializeField]
	private float m_starsAnimationStartDelay;

	[SerializeField]
	private float m_starsAnimationDelay;

	protected int m_rating;

	protected bool m_rated;

	private bool m_initialised;

	protected Coroutine m_showButtonsCoroutine;

	private bool m_leftFeedback;

	private int m_reviewThreshold;

	private Action<int> m_callback;

	protected void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateStars_003Ed__18))]
	private IEnumerator AnimateStars()
	{
		return null;
	}

	public void OnNoThanksClicked()
	{
	}

	public void Config(int starThreshold, Action<int> callback)
	{
	}

	public void OnStarsTouched(int number)
	{
	}

	public void OnNotNowPressed()
	{
	}

	public void OnConfirmPressed()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void PlayPopupSFX()
	{
	}

	private void PlayStarSFX()
	{
	}
}
