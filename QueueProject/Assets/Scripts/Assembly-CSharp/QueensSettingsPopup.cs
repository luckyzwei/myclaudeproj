using KWCore.UI;
using KWUserInterface;
using UnityEngine;

public class QueensSettingsPopup : SettingsPopUp
{
	[Header("Queens specific")]
	[Header("Accesibility")]
	[SerializeField]
	private UIAnimator m_accesibilityToggle;

	private const string ANIM_SLIDEON = "SlideOn";

	private const string ANIM_SLIDEOFF = "SlideOff";

	private const string ANIM_ON = "On";

	private const string ANIM_OFF = "Off";

	private void Awake()
	{
	}

	public void OnAccesiblityPressed()
	{
	}

	public void OnFeedbackPressed()
	{
	}
}
