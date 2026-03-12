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
		Debug.Log("[ButtonsController] Start()");

		// Determine next level number (index in levelOrder + 1 for display)
		int nextLevel = 1;
		if (GameManager.Instance != null && GameManager.Instance.LevelOrder != null
			&& GameManager.Instance.LevelOrder.levelOrder != null
			&& GameManager.Instance.LevelOrder.levelOrder.levels != null)
		{
			var levels = GameManager.Instance.LevelOrder.levelOrder.levels;
			var current = GameManager.Instance.CurrentLevelScriptable;
			for (int idx = 0; idx < levels.Count; idx++)
			{
				if (levels[idx] == current)
				{
					nextLevel = idx + 2; // current is idx, next is idx+1, display as 1-based
					break;
				}
			}
		}

		// Set next level text with formatted level number
		string nextText = Kwalee.GetLocalisedText(NEXT_LEVEL_KEY);
		if (m_nextLevelTexts != null)
		{
			string displayText;
			if (!string.IsNullOrEmpty(nextText) && nextText.Contains("{0}"))
				displayText = string.Format(nextText, nextLevel);
			else if (!string.IsNullOrEmpty(nextText))
				displayText = nextText;
			else
				displayText = "下一关";

			for (int i = 0; i < m_nextLevelTexts.Length; i++)
			{
				if (m_nextLevelTexts[i] != null)
					m_nextLevelTexts[i].text = displayText;
			}
		}

		// Wire up button click handlers directly (prefab events may target missing LevelCompleteScreen)
		BindButtonsByName();

		// Fix raycast blockers — find screen root and clean up anything blocking button clicks
		FixRaycastBlockers();
	}

	private void BindButtonsByName()
	{
		// Find Button-Next and Button-Home as siblings
		var buttonsParent = transform;
		Debug.Log($"[ButtonsController] BindButtonsByName — parent={buttonsParent.name}, childCount={buttonsParent.childCount}");

		for (int i = 0; i < buttonsParent.childCount; i++)
		{
			var child = buttonsParent.GetChild(i);
			var btn = child.GetComponent<Button>();
			if (btn == null) continue;

			if (child.name == "Button-Next" || child.name == "Button-Home")
			{
				// 不覆盖 onClick —— 由 LevelCompleteScreen.OnNextPressed/OnHomePressed 统一处理
				btn.interactable = true;
				var texts = child.GetComponentsInChildren<Text>(true);
				for (int t = 0; t < texts.Length; t++)
					if (texts[t] != null) texts[t].alignment = TextAnchor.MiddleCenter;
				Debug.Log($"[ButtonsController] Enabled {child.name}");
			}
		}
	}

	private void FixRaycastBlockers()
	{
		// Walk up to the Screen root (Screen-LevelComplete)
		Transform screenRoot = transform;
		while (screenRoot.parent != null && !screenRoot.name.Contains("Screen-"))
			screenRoot = screenRoot.parent;

		Debug.Log($"[ButtonsController] FixRaycastBlockers — screenRoot={screenRoot.name}");

		// 1) Ensure all parent CanvasGroups allow raycasts
		var parentCGs = GetComponentsInParent<CanvasGroup>(true);
		for (int i = 0; i < parentCGs.Length; i++)
		{
			if (!parentCGs[i].blocksRaycasts)
			{
				Debug.Log($"[ButtonsController] Fixed CanvasGroup blocksRaycasts on '{parentCGs[i].gameObject.name}'");
				parentCGs[i].blocksRaycasts = true;
			}
			if (!parentCGs[i].interactable)
			{
				Debug.Log($"[ButtonsController] Fixed CanvasGroup interactable on '{parentCGs[i].gameObject.name}'");
				parentCGs[i].interactable = true;
			}
		}

		// 2) Deactivate sibling objects that render ON TOP of our Panel
		//    (later siblings in hierarchy = rendered on top = receive raycasts first)
		Transform panelParent = screenRoot;
		Transform panel = null;
		for (int i = 0; i < panelParent.childCount; i++)
		{
			if (panelParent.GetChild(i).name.Contains("Panel-"))
			{
				panel = panelParent.GetChild(i);
				break;
			}
		}

		if (panel != null)
		{
			int panelIndex = panel.GetSiblingIndex();
			for (int i = panelIndex + 1; i < panelParent.childCount; i++)
			{
				var sibling = panelParent.GetChild(i);
				if (sibling.gameObject.activeSelf)
				{
					Debug.Log($"[ButtonsController] Deactivating blocker: '{sibling.name}' (sibling index {i}, after Panel at {panelIndex})");
					sibling.gameObject.SetActive(false);
				}
			}
		}

		// 3) Also check siblings BEFORE Panel that might have fullscreen raycast-blocking images
		//    (like "Background" with Image raycastTarget, "TopUI", "BeatingPlayersContainer")
		if (panel != null)
		{
			int panelIndex = panel.GetSiblingIndex();
			string[] safeNames = { "Background" }; // Background overlay is expected, keep but disable raycast
			for (int i = 0; i < panelIndex; i++)
			{
				var sibling = panelParent.GetChild(i);
				// Disable raycastTarget on any Images in non-essential siblings
				var images = sibling.GetComponentsInChildren<UnityEngine.UI.Image>(true);
				for (int j = 0; j < images.Length; j++)
				{
					if (images[j].raycastTarget)
					{
						images[j].raycastTarget = false;
						Debug.Log($"[ButtonsController] Disabled raycastTarget on '{images[j].gameObject.name}' under '{sibling.name}'");
					}
				}
				var rawImages = sibling.GetComponentsInChildren<UnityEngine.UI.RawImage>(true);
				for (int j = 0; j < rawImages.Length; j++)
				{
					if (rawImages[j].raycastTarget)
					{
						rawImages[j].raycastTarget = false;
					}
				}
			}
		}

		// 4) Ensure the Canvas has a GraphicRaycaster
		var canvas = GetComponentInParent<Canvas>();
		if (canvas != null)
		{
			var raycaster = canvas.GetComponent<UnityEngine.UI.GraphicRaycaster>();
			if (raycaster == null)
			{
				raycaster = canvas.gameObject.AddComponent<UnityEngine.UI.GraphicRaycaster>();
				Debug.Log($"[ButtonsController] Added GraphicRaycaster to '{canvas.name}'");
			}
			Debug.Log($"[ButtonsController] Canvas='{canvas.name}' raycaster={raycaster != null} enabled={raycaster.enabled}");
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
