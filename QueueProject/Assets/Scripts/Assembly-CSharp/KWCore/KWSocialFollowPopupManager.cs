using System;
using System.Runtime.CompilerServices;
using KWCore.UI;

namespace KWCore
{
	public class KWSocialFollowPopupManager
	{
		private enum RewardType
		{
			FIXED = 0,
			PERCENTAGE = 1
		}

		private CoreUI.IDelegate m_coreUiInterface;

		private SocialFollowPopup m_socialFollowPopup;

		private long m_followClickTimeStamp;

		private int m_cachedRewardAmount;

		private bool m_isSocialPlatformBanned;

		private SocialPlatformBanCheckerBase m_socialPlatformBanChecker;

		public static event Action<long> OnRewardGranted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public KWSocialFollowPopupManager(CoreUI.IDelegate del)
		{
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		private void TryShowSocialFollowPopupOnLoadComplete()
		{
		}

		private void TryShowSocialFollowPopup(int stageNumber, bool hasStages)
		{
		}

		private bool ShouldShowSocialFollowPopup()
		{
			return false;
		}

		private void OnFollowClicked()
		{
		}

		private void OnCloseButtonPressed()
		{
		}

		private void CloseRewardPopup()
		{
		}

		private void OnSocialFollowPopupClosed()
		{
		}

		private void GrantReward()
		{
		}

		private void SendSocialPopupClickEvent(string interactionName)
		{
		}

		private int CalculateRewardAmount()
		{
			return 0;
		}

		private bool IsSocialPlatformBanned()
		{
			return false;
		}

		private bool HasShownSocialFollowPopup()
		{
			return false;
		}

		private void MarkSocialFollowPopupAsShown()
		{
		}
	}
}
