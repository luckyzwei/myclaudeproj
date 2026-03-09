using KWCore.UI;
using KWLocalisation.Localisation;
using UnityEngine;

namespace KWCore
{
	[SortingLayer("TermsOfUsePopup")]
	public class KWTermsOfUsePopup : PopUpBase
	{
		private const float LANDSCAPE_SCALE_FACTOR = 1.5f;

		private const float PORTRAIT_SCALE_FACTOR = 1f;

		private const string TITLE_KEY = "TermsOfUse.Title";

		private const string DESCRIPTION_KEY = "TermsOfUse.Description";

		private const string PRIVACY_POLICY_KEY = "TermsOfUse.PrivacyPolicyText";

		private const string TERMS_OF_SERVICE_KEY = "TermsOfUse.TermsOfServiceText";

		private const string ACCEPT_KEY = "TermsOfUse.Accept";

		private const string POPUP_TYPE = "PopUpTermsOfUse";

		[SerializeField]
		private RectTransform m_popupContentRoot;

		[SerializeField]
		private TextWrapper m_titleText;

		[SerializeField]
		private TextWrapper m_descriptionText;

		[SerializeField]
		private TextWrapper m_privacyPolicyText;

		[SerializeField]
		private TextWrapper m_termsOfServiceText;

		[SerializeField]
		private TextWrapper m_acceptText;

		private void Start()
		{
		}

		private void ScalePopupToScreen()
		{
		}

		public void OnPrivacyPolicyPressed()
		{
		}

		public void TermsOfServicePressed()
		{
		}

		public void OnAcceptPressed()
		{
		}

		private void SendPopUpEvent(string popUpStatus)
		{
		}
	}
}
