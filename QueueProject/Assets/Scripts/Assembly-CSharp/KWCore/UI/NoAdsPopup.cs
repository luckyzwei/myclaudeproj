using System;
using System.Collections.Generic;
using KWLocalisation.Localisation;
using UnityEngine;

namespace KWCore.UI
{
	[SortingLayer("NoAdsPopup")]
	public class NoAdsPopup : PopUpBase
	{
		private const string TITLE_KEY = "NoAdsPopup.Title";

		private const string DESCRIPTION_ONE_KEY = "NoAdsPopup.Description1";

		private const string DESCRIPTION_TWO_KEY = "NoAdsPopup.Description2";

		private const string BUTTON_KEY = "NoAdsPopup.Continue";

		[SerializeField]
		private TextWrapper m_titleText;

		[SerializeField]
		private TextWrapper m_descriptionOneText;

		[SerializeField]
		private TextWrapper m_descriptionTwoText;

		[SerializeField]
		private TextWrapper m_buttonText;

		[Header("Pause Settings")]
		[SerializeField]
		private PauseMode m_pauseMode;

		[Header("Valid only if Pause Mode is set to CUSTOM")]
		[SerializeField]
		private bool m_pauseAudio;

		[SerializeField]
		private bool m_pauseAnimation;

		private float m_previousTimeScale;

		private readonly List<AudioSource> m_pausedAudioSources;

		private readonly Dictionary<Animator, float> m_pausedAnimators;

		private Action m_continuePressed;

		private Action m_cancelPressed;

		private void OnEnable()
		{
		}

		private new void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void Init(Action onContinuePressed, Action onCancelPressed)
		{
		}

		public void OnContinuePurchaseButton()
		{
		}

		public void OnClosePopupButton()
		{
		}

		private void HandleProductPurchased()
		{
		}

		private void PauseGame()
		{
		}

		private void ResumeGame()
		{
		}

		private void ApplyTimeScale(float newTimeScale)
		{
		}

		private void PauseAudio()
		{
		}

		private void ResumeAudio()
		{
		}

		private void PauseAnimators()
		{
		}

		private void ResumeAnimators()
		{
		}
	}
}
