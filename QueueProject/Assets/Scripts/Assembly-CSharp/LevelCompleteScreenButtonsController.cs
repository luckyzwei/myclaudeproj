using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteScreenButtonsController : MonoBehaviour
{
	private const string NEXT_LEVEL_KEY = "PopupLevelComplete.NextLevelButton";

	[SerializeField]
	private Button[] m_playButtons;

	[SerializeField]
	private Button m_expertModePlayButton;

	[SerializeField]
	private Button m_expertModePurchaseButton;

	[SerializeField]
	private Button m_dailyChallengeButtonFree;

	[SerializeField]
	private Button m_dailyChallengeButtonRv;

	[SerializeField]
	private DateButtonLabel[] m_dailyChallengeDates;

	[SerializeField]
	protected Text[] m_nextLevelTexts;

	[SerializeField]
	private GameObject m_adIcon;

	private bool m_showIAPForFreeDC;

	private bool m_shouldConsumeFreeDailyChallenge;

	private bool m_showPopup;

	private int m_suggestIAPCooldownDays;

	private void Awake()
	{
		// Hide ad-related UI
		if (m_adIcon != null) m_adIcon.SetActive(false);
		if (m_dailyChallengeButtonRv != null) m_dailyChallengeButtonRv.gameObject.SetActive(false);
		if (m_expertModePurchaseButton != null) m_expertModePurchaseButton.gameObject.SetActive(false);
	}

	private void Start()
	{
		// Set next level text
		string nextText = Kwalee.GetLocalisedText(NEXT_LEVEL_KEY);
		if (!string.IsNullOrEmpty(nextText) && m_nextLevelTexts != null)
		{
			for (int i = 0; i < m_nextLevelTexts.Length; i++)
			{
				if (m_nextLevelTexts[i] != null)
					m_nextLevelTexts[i].text = nextText;
			}
		}
	}

	public void DisableAllButtons()
	{
		if (m_playButtons != null)
		{
			for (int i = 0; i < m_playButtons.Length; i++)
			{
				if (m_playButtons[i] != null)
					m_playButtons[i].interactable = false;
			}
		}
	}

	public static GameObject[] AddNextLevelData(LevelDataScriptable nextLevelData, Transform parent, GameObject[] gameObjects = null, string prefix = "")
	{
		return gameObjects;
	}

	public void SetInteractable(bool value)
	{
		if (m_playButtons != null)
		{
			for (int i = 0; i < m_playButtons.Length; i++)
			{
				if (m_playButtons[i] != null)
					m_playButtons[i].interactable = value;
			}
		}
	}

	public void SetActiveButton(bool value)
	{
		gameObject.SetActive(value);
	}

	private bool CanShowIAPPopup()
	{
		return false;
	}

	private void DailyChallengeRvClicked()
	{
		// Skip - ads
	}

	private int GetDayIndex()
	{
		return (int)System.DateTime.Now.DayOfWeek;
	}

	private void DailyChallengeFreeClicked()
	{
		// Skip - daily challenge
	}
}
