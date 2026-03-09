using TMPro;
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
	protected TextMeshProUGUI[] m_nextLevelTexts;

	[SerializeField]
	private GameObject m_adIcon;

	private bool m_showIAPForFreeDC;

	private bool m_shouldConsumeFreeDailyChallenge;

	private bool m_showPopup;

	private int m_suggestIAPCooldownDays;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DisableAllButtons()
	{
	}

	public static GameObject[] AddNextLevelData(LevelDataScriptable nextLevelData, Transform parent, GameObject[] gameObjects = null, string prefix = "")
	{
		return null;
	}

	public void SetInteractable(bool value)
	{
	}

	public void SetActiveButton(bool value)
	{
	}

	private bool CanShowIAPPopup()
	{
		return false;
	}

	private void DailyChallengeRvClicked()
	{
	}

	private int GetDayIndex()
	{
		return 0;
	}

	private void DailyChallengeFreeClicked()
	{
	}
}
