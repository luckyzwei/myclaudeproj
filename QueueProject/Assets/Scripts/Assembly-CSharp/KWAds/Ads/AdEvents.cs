using System;
using System.Runtime.CompilerServices;

namespace KWAds.Ads
{
	public class AdEvents
	{
		public static event Action<string> RewardAdShown
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

		public static event Action<string> RewardAdSkipped
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

		public static event Action<string> InterstitialAdShown
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

		public static event Action<string> CrossPromotionAdShown
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

		public static event Action<string> AdShown
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

		public static event Action AdStartedShow
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

		public static event Action AdFailedShow
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

		public static event Action<CoreMediatorImpressionData> OnMediatorRevenuePaidEvent
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

		public static event Action<string> OnFullscreenAdStartedEvent
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

		public static event Action<AdType> OnFullscreenAdFinishedEvent
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

		public static event Action<long> AdBreakFinishedEvent
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

		public static event Action<string, string> AdDisplayFailedRejectionCauseEvent
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

		public static event Action OnBannersStatusChangedEvent
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

		public static void SendRewardAdShownEvent(string location)
		{
		}

		public static void SendRewardAdSkipped(string location)
		{
		}

		public static void SendInterstitialAdShownEvent(string location)
		{
		}

		public static void SendCrossPromotionAdShownEvent(string location)
		{
		}

		public static void SendAdShownEvent(string location)
		{
		}

		public static void SendAdStartedShowEvent()
		{
		}

		public static void SendAdFailedShowEvent()
		{
		}

		public static void SendMediatorRevenuePaidEvent(CoreMediatorImpressionData impressionData)
		{
		}

		public static void SendFullscreenAdStartedEvent(string adsProviderName = null)
		{
		}

		public static void SendFullscreenAdFinishedEvent(AdType adType)
		{
		}

		public static void SendAdBreakFinished(long rewardAmount)
		{
		}

		public static void SendAdDisplayFailedRejectionCauseEvent(string adUnitType, string rejectionCause)
		{
		}

		public static void SendOnBannersStatusChangedEvent()
		{
		}
	}
}
