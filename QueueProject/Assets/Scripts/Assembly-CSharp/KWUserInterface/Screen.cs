using System;
using UnityEngine;

namespace KWUserInterface
{
	public class Screen : MonoBehaviour
	{
		[SerializeField]
		private AnimatorHelper m_animator;

		private Action<Screen> m_onIntroDone;

		private Action<Screen> m_onOutroDone;

		private ScreenTransitionData m_currentTransitionAnims;

		private bool m_isUnloading;

		private string m_screenId;

		public AnimatorHelper Animator => m_animator;

		protected virtual void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public virtual void PreLoad()
		{
		}

		public virtual void Load(Screen prevScreen, Action<Screen> onLoad = null)
		{
			m_screenId = GetType().Name;
			m_isUnloading = false;
			m_onIntroDone = onLoad;
			m_currentTransitionAnims = GetTransition(prevScreen);
			PlayIntro();
		}

		private void PlayIntro()
		{
			if (m_currentTransitionAnims != null && m_currentTransitionAnims.hasIntro && m_animator != null)
			{
				m_animator.Play(m_currentTransitionAnims.introAnimation, IntroDone);
			}
			else
			{
				IntroDone();
			}
		}

		private void IntroDone()
		{
			FireCallback();
		}

		public void Unload(Screen nextScreen, Action<Screen> onUnload = null)
		{
			m_isUnloading = true;
			m_onOutroDone = onUnload;
			m_currentTransitionAnims = GetTransition(nextScreen);

			if (m_currentTransitionAnims != null && m_currentTransitionAnims.hasOutro && m_animator != null)
			{
				m_animator.Play(m_currentTransitionAnims.outroAnimation, OutroDone);
			}
			else
			{
				OutroDone();
			}
		}

		protected ScreenTransitionData GetTransition(Screen screen)
		{
			var transitions = GetComponent<ScreenTransitions>();
			if (transitions != null)
			{
				return transitions.GetTransitionTo(screen);
			}
			return null;
		}

		private void OutroDone()
		{
			var callback = m_onOutroDone;
			m_onOutroDone = null;
			callback?.Invoke(this);
		}

		private void FireCallback()
		{
			var callback = m_onIntroDone;
			m_onIntroDone = null;
			callback?.Invoke(this);
		}

		public virtual void OnBackPressed()
		{
		}

		public virtual void OnBlackClicked()
		{
		}
	}
}
