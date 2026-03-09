using KWCore.UI;
using UnityEngine;

namespace KWUserInterface
{
	public class SettingsPopUp : PopUpBase
	{
		public const string PREFAB_NAME = "Prefabs/Popups/PopUp-Settings";

		private const string ANIM_SLIDEON = "SlideOn";

		private const string ANIM_SLIDEOFF = "SlideOff";

		private const string ANIM_ON = "On";

		private const string ANIM_OFF = "Off";

		[SerializeField]
		private GameObject m_restorePurchasesButton;

		[SerializeField]
		private UIAnimator m_soundToggle;

		[SerializeField]
		private UIAnimator m_musicToggle;

		[SerializeField]
		private GameObject m_hapticToggleGroup;

		[SerializeField]
		private UIAnimator m_hapticToggle;

		[SerializeField]
		private GameObject m_feedbackButton;

		[SerializeField]
		private GameObject m_privacyPolicyButton;

		[SerializeField]
		private GameObject m_subscriptionLink;

		[SerializeField]
		private GameObject m_termsAndConditionsButton;

		[SerializeField]
		private GameObject m_adPreferencesButton;

		private void Start()
		{
		}

		private void ConfigureSubscriptionLink()
		{
		}

		private void ConfigurePrivacyPolicy()
		{
		}

		private void ConfigureAdPreferences()
		{
		}

		private void ConfigureTermsAndConditionsButton()
		{
		}

		private void ConfigureFeedback()
		{
		}

		public void ConfigureHaptic()
		{
		}

		public void ConfigureSound()
		{
		}

		public void OnHapticTogglePressed()
		{
		}

		public void OnSoundTogglePressed()
		{
		}

		public void OnMusicTogglePressed()
		{
		}

		public void OnClosePressed()
		{
		}

		public void InitRestorePurchasesButton()
		{
		}

		public void OnEmailPressed()
		{
		}

		public void OnRestorePurchases()
		{
		}

		private string CreateEmailUrl()
		{
			return null;
		}

		private string MyEscapeURL(string url)
		{
			return null;
		}

		public void OnPrivacyPolicyPressed()
		{
		}

		public void OnAdPreferencesPressed()
		{
		}

		public void OnTermsAndConditionsPressed()
		{
		}

		public void OnSubscriptionLinkPressed()
		{
		}
	}
}
