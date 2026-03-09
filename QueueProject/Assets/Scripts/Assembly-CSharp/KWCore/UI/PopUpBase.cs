using System;
using KWAnalytics.Analytics;
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
			return null;
		}

		public static T ShowPopup<T>(string prefabName, Action closedCallback = null, bool useCoreCanvas = false) where T : PopUpBase
		{
			return null;
		}

		private static T InitialisePopup<T>(GameObject model, Action closedCallback, bool useCoreCanvas) where T : PopUpBase
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		private void InitialiseBase(Action closedCallback)
		{
		}

		protected virtual void FinishedIntroAnimation()
		{
		}

		protected void CreateSchema()
		{
		}

		protected PlayerPopupSchema GetSchema()
		{
			return null;
		}

		public static bool IsTherePopupActive()
		{
			return false;
		}

		public static int NumPopupsActive()
		{
			return 0;
		}

		public void OnClosedPopUpPressed()
		{
		}

		protected void DisableAllButtons()
		{
		}

		public void Close(bool playAudio = true)
		{
		}

		protected virtual bool AllowHardBackButtonPress()
		{
			return false;
		}

		private void HandleBackPressed()
		{
		}

		private void PlayAnimation(string animation, Action callback)
		{
		}
	}
}
