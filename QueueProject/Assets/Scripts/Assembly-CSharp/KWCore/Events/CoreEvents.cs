using System;
using System.Runtime.CompilerServices;
using KWCore.UI;

namespace KWCore.Events
{
	public class CoreEvents
	{
		public static event Action OnSdkInitialised
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

		public static event Action SystemBackPressed
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

		public static event Action<PopUpBase> PopupShown
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

		public static event Action<PopUpBase> PopupClosed
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

		public static event Action<bool> highPriorityOnApplicationPause
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

		public static event Action<bool> lowPriorityOnApplicationPause
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

		public static event Action highPriorityOnApplicationQuit
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

		public static event Action lowPriorityOnApplicationQuit
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

		public static event Action newPlayRecorded
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

		public static event Action OnIDFACompleted
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

		public static event Action OnGameplayCanvasSet
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

		public static event Action PlayerCreated
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

		public static event Action PlayerUpdated
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

		public static event Action<string> OnIAPStoreInitialized
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

		public static event Action OnProductPurchased
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

		public static event Action OnAppsflyerInitialised
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

		public static event Action<float> OnRevenuePaidEvent
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

		public static event Action<float> OnCombinedRevenuePaidEvent
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

		public static event Action<string> OnCountryCodeReceived
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

		public static event Action OnTermsOfUseAccepted
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

		public static event Action OnSessionChanged
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

		public static event Action NoAdsPopUpOpened
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

		public static event Action NoAdsPopUpClosed
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

		public static void SendOnSdkInitialisedEvent()
		{
		}

		public static void SendSystemBackPressedEvent()
		{
		}

		public static void SendPopupShownEvent(PopUpBase popUpBase)
		{
		}

		public static void SendPopupClosedEvent(PopUpBase popUpBase)
		{
		}

		public static void SendHighPriorityOnApplicationPauseEvent(bool pause)
		{
		}

		public static void SendLowPriorityOnApplicationPauseEvent(bool pause)
		{
		}

		public static void SendHighPriorityOnApplicationQuitEvent()
		{
		}

		public static void SendLowPriorityOnApplicationQuitEvent()
		{
		}

		public static void SendNewPlayRecordedEvent()
		{
		}

		public static void SendOnIDFACompleted()
		{
		}

		public static void SendOnGameplayCanvasSetEvent()
		{
		}

		public static void SendPlayerCreated()
		{
		}

		public static void SendPlayerUpdated()
		{
		}

		public static void SendOnIAPStoreInitialized(string currencyCode)
		{
		}

		public static void SendProductPurchasedEvent()
		{
		}

		public static void SendAppsflyerInitialised()
		{
		}

		public static void SendOnRevenuePaidEvent(float priceUsd)
		{
		}

		public static void SendOnCombinedRevenuePaidEvent(float priceUsd)
		{
		}

		public static void SendOnCountryCodeReceived(string countryCode)
		{
		}

		public static void SendOnTermsOfUseAccepted()
		{
		}

		public static void SendSessionChanged()
		{
		}

		public static void SendNoAdsPopUpOpenedEvent()
		{
		}

		public static void SendNoAdsPopUpClosedEvent()
		{
		}
	}
}
