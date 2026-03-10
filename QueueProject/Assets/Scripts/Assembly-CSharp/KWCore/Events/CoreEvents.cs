using System;
using System.Runtime.CompilerServices;
using KWCore.UI;

namespace KWCore.Events
{
	public class CoreEvents
	{
		private static Action _OnSdkInitialised;
		public static event Action OnSdkInitialised
		{
			add { _OnSdkInitialised += value; }
			remove { _OnSdkInitialised -= value; }
		}

		private static Action _OnSplashScreenCompleted;
		public static event Action OnSplashScreenCompleted
		{
			add { _OnSplashScreenCompleted += value; }
			remove { _OnSplashScreenCompleted -= value; }
		}

		private static Action _SystemBackPressed;
		public static event Action SystemBackPressed
		{
			add { _SystemBackPressed += value; }
			remove { _SystemBackPressed -= value; }
		}

		private static Action<PopUpBase> _PopupShown;
		public static event Action<PopUpBase> PopupShown
		{
			add { _PopupShown += value; }
			remove { _PopupShown -= value; }
		}

		private static Action<PopUpBase> _PopupClosed;
		public static event Action<PopUpBase> PopupClosed
		{
			add { _PopupClosed += value; }
			remove { _PopupClosed -= value; }
		}

		private static Action<bool> _highPriorityOnApplicationPause;
		public static event Action<bool> highPriorityOnApplicationPause
		{
			add { _highPriorityOnApplicationPause += value; }
			remove { _highPriorityOnApplicationPause -= value; }
		}

		private static Action<bool> _lowPriorityOnApplicationPause;
		public static event Action<bool> lowPriorityOnApplicationPause
		{
			add { _lowPriorityOnApplicationPause += value; }
			remove { _lowPriorityOnApplicationPause -= value; }
		}

		private static Action _highPriorityOnApplicationQuit;
		public static event Action highPriorityOnApplicationQuit
		{
			add { _highPriorityOnApplicationQuit += value; }
			remove { _highPriorityOnApplicationQuit -= value; }
		}

		private static Action _lowPriorityOnApplicationQuit;
		public static event Action lowPriorityOnApplicationQuit
		{
			add { _lowPriorityOnApplicationQuit += value; }
			remove { _lowPriorityOnApplicationQuit -= value; }
		}

		private static Action _newPlayRecorded;
		public static event Action newPlayRecorded
		{
			add { _newPlayRecorded += value; }
			remove { _newPlayRecorded -= value; }
		}

		private static Action _LevelCompleted;
		public static event Action LevelCompleted
		{
			add { _LevelCompleted += value; }
			remove { _LevelCompleted -= value; }
		}

		private static Action _OnIDFACompleted;
		public static event Action OnIDFACompleted
		{
			add { _OnIDFACompleted += value; }
			remove { _OnIDFACompleted -= value; }
		}

		private static Action _OnGameplayCanvasSet;
		public static event Action OnGameplayCanvasSet
		{
			add { _OnGameplayCanvasSet += value; }
			remove { _OnGameplayCanvasSet -= value; }
		}

		private static Action _PlayerCreated;
		public static event Action PlayerCreated
		{
			add { _PlayerCreated += value; }
			remove { _PlayerCreated -= value; }
		}

		private static Action _PlayerUpdated;
		public static event Action PlayerUpdated
		{
			add { _PlayerUpdated += value; }
			remove { _PlayerUpdated -= value; }
		}

		private static Action<string> _OnIAPStoreInitialized;
		public static event Action<string> OnIAPStoreInitialized
		{
			add { _OnIAPStoreInitialized += value; }
			remove { _OnIAPStoreInitialized -= value; }
		}

		private static Action _OnProductPurchased;
		public static event Action OnProductPurchased
		{
			add { _OnProductPurchased += value; }
			remove { _OnProductPurchased -= value; }
		}

		private static Action _OnAppsflyerInitialised;
		public static event Action OnAppsflyerInitialised
		{
			add { _OnAppsflyerInitialised += value; }
			remove { _OnAppsflyerInitialised -= value; }
		}

		private static Action<float> _OnRevenuePaidEvent;
		public static event Action<float> OnRevenuePaidEvent
		{
			add { _OnRevenuePaidEvent += value; }
			remove { _OnRevenuePaidEvent -= value; }
		}

		private static Action<float> _OnCombinedRevenuePaidEvent;
		public static event Action<float> OnCombinedRevenuePaidEvent
		{
			add { _OnCombinedRevenuePaidEvent += value; }
			remove { _OnCombinedRevenuePaidEvent -= value; }
		}

		private static Action<string> _OnCountryCodeReceived;
		public static event Action<string> OnCountryCodeReceived
		{
			add { _OnCountryCodeReceived += value; }
			remove { _OnCountryCodeReceived -= value; }
		}

		private static Action _OnTermsOfUseAccepted;
		public static event Action OnTermsOfUseAccepted
		{
			add { _OnTermsOfUseAccepted += value; }
			remove { _OnTermsOfUseAccepted -= value; }
		}

		private static Action _OnSessionChanged;
		public static event Action OnSessionChanged
		{
			add { _OnSessionChanged += value; }
			remove { _OnSessionChanged -= value; }
		}

		private static Action _NoAdsPopUpOpened;
		public static event Action NoAdsPopUpOpened
		{
			add { _NoAdsPopUpOpened += value; }
			remove { _NoAdsPopUpOpened -= value; }
		}

		private static Action _NoAdsPopUpClosed;
		public static event Action NoAdsPopUpClosed
		{
			add { _NoAdsPopUpClosed += value; }
			remove { _NoAdsPopUpClosed -= value; }
		}

		public static void SendOnSdkInitialisedEvent()
		{
			_OnSdkInitialised?.Invoke();
		}

		public static void SendOnSplashScreenCompleted()
		{
			_OnSplashScreenCompleted?.Invoke();
		}

		public static void SendSystemBackPressedEvent()
		{
			_SystemBackPressed?.Invoke();
		}

		public static void SendPopupShownEvent(PopUpBase popUpBase)
		{
			_PopupShown?.Invoke(popUpBase);
		}

		public static void SendPopupClosedEvent(PopUpBase popUpBase)
		{
			_PopupClosed?.Invoke(popUpBase);
		}

		public static void SendHighPriorityOnApplicationPauseEvent(bool pause)
		{
			_highPriorityOnApplicationPause?.Invoke(pause);
		}

		public static void SendLowPriorityOnApplicationPauseEvent(bool pause)
		{
			_lowPriorityOnApplicationPause?.Invoke(pause);
		}

		public static void SendHighPriorityOnApplicationQuitEvent()
		{
			_highPriorityOnApplicationQuit?.Invoke();
		}

		public static void SendLowPriorityOnApplicationQuitEvent()
		{
			_lowPriorityOnApplicationQuit?.Invoke();
		}

		public static void SendNewPlayRecordedEvent()
		{
			_newPlayRecorded?.Invoke();
		}

		public static void SendLevelCompletedEvent()
		{
			_LevelCompleted?.Invoke();
		}

		public static void SendOnIDFACompleted()
		{
			_OnIDFACompleted?.Invoke();
		}

		public static void SendOnGameplayCanvasSetEvent()
		{
			_OnGameplayCanvasSet?.Invoke();
		}

		public static void SendPlayerCreated()
		{
			_PlayerCreated?.Invoke();
		}

		public static void SendPlayerUpdated()
		{
			_PlayerUpdated?.Invoke();
		}

		public static void SendOnIAPStoreInitialized(string currencyCode)
		{
			_OnIAPStoreInitialized?.Invoke(currencyCode);
		}

		public static void SendProductPurchasedEvent()
		{
			_OnProductPurchased?.Invoke();
		}

		public static void SendAppsflyerInitialised()
		{
			_OnAppsflyerInitialised?.Invoke();
		}

		public static void SendOnRevenuePaidEvent(float priceUsd)
		{
			_OnRevenuePaidEvent?.Invoke(priceUsd);
		}

		public static void SendOnCombinedRevenuePaidEvent(float priceUsd)
		{
			_OnCombinedRevenuePaidEvent?.Invoke(priceUsd);
		}

		public static void SendOnCountryCodeReceived(string countryCode)
		{
			_OnCountryCodeReceived?.Invoke(countryCode);
		}

		public static void SendOnTermsOfUseAccepted()
		{
			_OnTermsOfUseAccepted?.Invoke();
		}

		public static void SendSessionChanged()
		{
			_OnSessionChanged?.Invoke();
		}

		public static void SendNoAdsPopUpOpenedEvent()
		{
			_NoAdsPopUpOpened?.Invoke();
		}

		public static void SendNoAdsPopUpClosedEvent()
		{
			_NoAdsPopUpClosed?.Invoke();
		}
	}
}
