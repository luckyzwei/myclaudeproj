using System;
using System.Collections.Generic;
using KWCore.SaveData;
using UnityEngine;

namespace KWCore.UI
{
	public class CoreUI
	{
		public interface IDelegate
		{
			GameObject GetInfoPopUp();

			GameObject GetForceConnectionPopUp();

			GameObject GetForceUpgradePopUp();

			Canvas GetCoreCanvas();

			Canvas GetGameplayCanvas();

			void SetGameplayCanvas(Canvas canvas);

			GameObject GetKwlaeeTermsOfUsePopup();

			GameObject GetSocialFollowPopup();

			GameObject GetNoAdsPopup();
		}

		private IDelegate m_delegate;

		protected List<BucketBase> m_buckets;

		protected void Awake()
		{
		}

		public void Initialise(IDelegate del)
		{
		}

		public void ShowInfoPopUp(Action closedCallback, string overrideBodyText)
		{
		}

		public void ShowNoAdsPopup(Action onContinuePressed, Action onCancelPressed)
		{
		}

		public void ShowForceUpgradePopup()
		{
		}

		public Canvas GetCoreCanvas()
		{
			return null;
		}

		public Canvas GetGameplayCanvas()
		{
			return null;
		}

		public void SetGameplayCanvas(Canvas canvas)
		{
		}
	}
}
