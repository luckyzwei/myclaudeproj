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

		public AnimatorHelper Animator => null;

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
		}

		private void PlayIntro()
		{
		}

		private void IntroDone()
		{
		}

		public void Unload(Screen nextScreen, Action<Screen> onUnload = null)
		{
		}

		protected ScreenTransitionData GetTransition(Screen screen)
		{
			return null;
		}

		private void OutroDone()
		{
		}

		private void FireCallback()
		{
		}

		public virtual void OnBackPressed()
		{
		}

		public virtual void OnBlackClicked()
		{
		}
	}
}
