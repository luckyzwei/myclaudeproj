using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Ump.Api;
using KWCore;
using KWCore.Utils;

namespace KWGDPR.GDPR
{
	public class GDPRManager
	{
		[CompilerGenerated]
		private sealed class _003CDelaySetConsent_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool canTrack;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelaySetConsent_003Ed__35(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string PRIVACY_POLICY = "PopUpSettings.PrivacyPolicy";

		private const string AD_PREFERENCES = "PopUpSettings.AdPreferences";

		private const string DEVICE_CONSENT = "device_constent";

		private const string VERSION = "1.0";

		private const string POPUP_TYPE = "PopUpGoogleGDPR";

		private const string IABTCF_KEY = "IABTCF_PurposeConsents";

		private bool m_trackingEnabled;

		private bool m_consentGiven;

		private bool m_euCountry;

		private bool m_hasGameSettings;

		private DeviceSettingsManager m_deviceSettingsManager;

		private ConsentForm m_consentForm;

		private Action m_callback;

		private List<ServerInterface> m_serverInterface;

		[EventsQueuePriority(QueueId = "GDPRManager.TryShowGDPRPopUp", Priority = 100)]
		public void Initialise(DeviceSettingsManager deviceSettingManager, List<ServerInterface> serverInterface = null)
		{
		}

		public string GetConsentCTString()
		{
			return null;
		}

		public void DoOnApplicationPause(bool pause)
		{
		}

		public bool HasGivenConsent()
		{
			return false;
		}

		public bool HasAnsweredGDPR()
		{
			return false;
		}

		public bool DoesGDPRApply()
		{
			return false;
		}

		public string GetPrivacyButtonText()
		{
			return null;
		}

		public string GetAdPreferencesButtonText()
		{
			return null;
		}

		public void OnPrivacyButtonClicked()
		{
		}

		public void OnAdPreferencesButtonClicked()
		{
		}

		public void OnTermsAndConditionsButtonClicked()
		{
		}

		private void HandleOnPlayerUpdated()
		{
		}

		public void RevokeConsent(string consentID = null)
		{
		}

		private void HandleIDFAReceived(bool trackingEnabled)
		{
		}

		private void GotAdvertisingIdentifier(string advertisingId, bool trackingEnabled)
		{
		}

		private void TryShowGDPRPopUp()
		{
		}

		private void OnGoogleGDPRCompleted()
		{
		}

		private void HandleGameSettingsUpdated()
		{
		}

		private void CheckEUCountry()
		{
		}

		private void UpdateRecord()
		{
		}

		private void UpdateConsent()
		{
		}

		[IteratorStateMachine(typeof(_003CDelaySetConsent_003Ed__35))]
		private IEnumerator DelaySetConsent(bool canTrack)
		{
			return null;
		}

		public void RequestConsentForm(Action callback, List<ServerInterface> serverInterface)
		{
		}

		public void ShowConsentForm()
		{
		}

		private void OnConsentInfoUpdated(FormError error)
		{
		}

		private void LoadConsentForm()
		{
		}

		private void OnLoadConsentForm(ConsentForm consentForm, FormError error)
		{
		}

		private void OnFormDismissedOnMainThread(FormError error)
		{
		}

		private void OnFormDismissed(FormError error)
		{
		}

		private string GetConsentResult()
		{
			return null;
		}

		private void SendPopUpEvent(string popUpStatus)
		{
		}
	}
}
