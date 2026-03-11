using System;
using KWAnalytics.Analytics;
using KWAudio;
using KWCore.Utils;
using UnityEngine;

namespace KWCore.UI
{
	public abstract class PopUpBase : BaseBehaviour
	{
		private static int s_popupsActive;

		private const string ANIM_INTRO = "Intro";

		private const string ANIM_OUTRO = "Outro";

		private Action m_closedcallback;

		protected UIAnimator m_uiAnimator;

		protected AnimatorHelper m_animatorHelper;

		private bool m_initialised;

		protected int m_analyticSchemaKey;

		public static T ShowPopup<T>(GameObject prefabObject, Action closedCallback = null, bool useCoreCanvas = false) where T : PopUpBase
		{
			if (prefabObject == null) return null;

			// Parent popup to the active Canvas so it renders on screen
			Transform parent = null;
			var sm = KWUserInterface.ScreenManager.Instance;
			if (sm != null && sm.RootCanvas != null)
				parent = sm.RootCanvas.transform;

			GameObject instance = parent != null ? Instantiate(prefabObject, parent) : Instantiate(prefabObject);
			T popup = instance.GetComponent<T>();
			if (popup == null)
			{
				Destroy(instance);
				return null;
			}
			popup.InitialiseBase(closedCallback);
			return popup;
		}

		public static T ShowPopup<T>(string prefabName, Action closedCallback = null, bool useCoreCanvas = false) where T : PopUpBase
		{
			GameObject prefab = Resources.Load<GameObject>(prefabName);
			if (prefab == null)
			{
				Debug.LogWarning($"[PopUpBase] Could not load popup prefab: {prefabName}");
				return null;
			}
			return ShowPopup<T>(prefab, closedCallback, useCoreCanvas);
		}

		private static T InitialisePopup<T>(GameObject model, Action closedCallback, bool useCoreCanvas) where T : PopUpBase
		{
			return ShowPopup<T>(model, closedCallback, useCoreCanvas);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (m_initialised)
			{
				s_popupsActive--;
				if (s_popupsActive < 0) s_popupsActive = 0;
			}
		}

		private void InitialiseBase(Action closedCallback)
		{
			if (m_initialised) return;
			m_initialised = true;
			m_closedcallback = closedCallback;
			s_popupsActive++;

			m_animatorHelper = GetComponent<AnimatorHelper>();
			m_uiAnimator = GetComponent<UIAnimator>();

			// Play popup open sound
			PlayPopupSound();

			PlayAnimation(ANIM_INTRO, FinishedIntroAnimation);
		}

		private static void PlayPopupSound()
		{
			var soundList = Resources.Load<AudioSoundList>("AudioSoundList");
			if (soundList != null && soundList.globalButtonPositive != null &&
				soundList.globalButtonPositive.audioClip != null)
			{
				var clip = soundList.globalButtonPositive;
				var cam = Camera.main;
				Vector3 pos = cam != null ? cam.transform.position : Vector3.zero;
				AudioSource.PlayClipAtPoint(clip.audioClip, pos, clip.volume > 0f ? clip.volume : 1f);
			}
		}

		protected virtual void FinishedIntroAnimation()
		{
		}

		protected void CreateSchema()
		{
			// Analytics schema - skip
		}

		protected PlayerPopupSchema GetSchema()
		{
			return null;
		}

		public static bool IsTherePopupActive()
		{
			return s_popupsActive > 0;
		}

		public static int NumPopupsActive()
		{
			return s_popupsActive;
		}

		public void OnClosedPopUpPressed()
		{
			Close();
		}

		protected void DisableAllButtons()
		{
			var buttons = GetComponentsInChildren<UnityEngine.UI.Button>(true);
			foreach (var btn in buttons)
				btn.interactable = false;
		}

		public void Close(bool playAudio = true)
		{
			PlayAnimation(ANIM_OUTRO, () =>
			{
				m_closedcallback?.Invoke();
				Destroy(gameObject);
			});
		}

		protected virtual bool AllowHardBackButtonPress()
		{
			return false;
		}

		private void HandleBackPressed()
		{
			if (AllowHardBackButtonPress())
				Close();
		}

		private void PlayAnimation(string animation, Action callback)
		{
			if (m_animatorHelper != null && m_animatorHelper.HasAnimationStateWithName(animation))
			{
				m_animatorHelper.Play(animation, callback);
			}
			else
			{
				callback?.Invoke();
			}
		}
	}
}
