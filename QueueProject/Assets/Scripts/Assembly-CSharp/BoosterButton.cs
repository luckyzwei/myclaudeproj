using System;
using Balancy.Models.Inventory;
using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.UI;

public abstract class BoosterButton : MonoBehaviour
{
	public enum BoosterButtonType
	{
		NORMAL = 0,
		DIRECT_COIN = 1,
		DIRECT_RV = 2
	}

	private const string ANIM_DISABLED = "Disabled";

	private const string ANIM_AVAILABLE = "Available";

	private const string ANIM_ANIM_BOOSTERBUTTON_LOCKED = "Anim-BoosterButton-Locked";

	private const string ANIM_ANIM_BOOSTERBUTTON_PRESSED = "Anim-BoosterButton-Pressed";

	private const string FREE_KEY = "BoosterFtue.Free";

	private const string UNLOCK_TEXT_KEY = "GameScreen.QueenBoosterUnlockLevelText";

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private BoosterButtonHintBubble m_hint;

	[Space]
	[SerializeField]
	private GameObject m_inventoryBadge;

	[SerializeField]
	private GameObject m_freeBadge;

	[SerializeField]
	private GameObject m_coinsBadge;

	[SerializeField]
	private GameObject m_rvBadge;

	[Space]
	[SerializeField]
	private Text m_inventoryText;

	[SerializeField]
	private Text m_priceText;

	[SerializeField]
	private Text m_unlockLevel;

	[Space]
	[SerializeField]
	private Image m_plusSign;

	protected AnimatorHelper m_helper;

	private Action<string> m_buttonPressedCallback;

	private string m_itemId;

	private BoosterItem m_boosterItem;

	private BoosterButtonType m_boosterButtonType;

	protected bool m_unlocked;

	private bool m_freeBooster;

	private bool m_levelLoaded;

	private float m_loadTime;

	private bool m_isEnabled;

	public bool IsUnlocked => m_unlocked;

	protected virtual void Awake()
	{
		m_helper = GetComponent<AnimatorHelper>();
		if (m_button != null)
			m_button.onClick.AddListener(() => OnButtonPressed());
	}

	protected virtual void OnDestroy()
	{
	}

	private void OnGridIntroDone()
	{
		m_levelLoaded = true;
		m_loadTime = Time.time;
		Refresh();
	}

	private void OnItemCountChange(Item item, int count, int slotindex)
	{
		RefreshInventory();
	}

	private void LevelSolved()
	{
		SetButtonEnabled(false);
	}

	public void Configure(string kwaleeItemId, Action<string> buttonPressedCallback, int unlockLevel, BoosterButtonType type)
	{
		m_itemId = kwaleeItemId;
		m_buttonPressedCallback = buttonPressedCallback;
		m_boosterButtonType = type;

		// Check if booster is unlocked (always unlocked for offline play)
		m_unlocked = true;

		if (!m_unlocked)
		{
			ConfigureLocked(unlockLevel);
			return;
		}

		Refresh();
		ConfigureVisuals();
	}

	private void ConfigureLocked(int unlockLevel)
	{
		m_unlocked = false;
		if (m_button != null)
			m_button.interactable = false;
		if (m_unlockLevel != null)
		{
			m_unlockLevel.gameObject.SetActive(true);
			m_unlockLevel.text = unlockLevel.ToString();
		}
		// Hide all badges
		if (m_inventoryBadge != null) m_inventoryBadge.SetActive(false);
		if (m_freeBadge != null) m_freeBadge.SetActive(false);
		if (m_coinsBadge != null) m_coinsBadge.SetActive(false);
		if (m_rvBadge != null) m_rvBadge.SetActive(false);
	}

	public void Refresh()
	{
		if (!m_unlocked) return;
		RefreshInventory();
		ConfigureVisuals();
	}

	protected virtual void ConfigureVisuals()
	{
		// Show inventory badge by default
		if (m_inventoryBadge != null) m_inventoryBadge.SetActive(true);
		if (m_freeBadge != null) m_freeBadge.SetActive(m_freeBooster);
		if (m_coinsBadge != null) m_coinsBadge.SetActive(false);
		if (m_rvBadge != null) m_rvBadge.SetActive(false);
		if (m_unlockLevel != null) m_unlockLevel.gameObject.SetActive(false);
	}

	public virtual void OnButtonPressed()
	{
		if (!m_unlocked || !m_isEnabled) return;

		if (m_freeBooster)
		{
			m_freeBooster = false;
			TryPerformAction();
			Refresh();
			return;
		}

		ConsumeItemAndPeformAction();
	}

	private int FindFirstPreplacedQueen()
	{
		if (QueensGameController.Instance == null) return -1;
		var grid = QueensGameController.Instance.Grid;
		if (grid == null || grid.LevelData == null) return -1;

		var ld = grid.LevelData;
		for (int i = 0; i < ld.queensGrid.Length; i++)
		{
			if (ld.queensGrid[i] >= 1 && grid.GetPlayerSolution(i) != QueensGrid.QUEEN)
				return i;
		}
		return -1;
	}

	private void RefreshInventory()
	{
		// In offline mode, show unlimited inventory
		if (m_inventoryText != null)
			m_inventoryText.text = "\u221E"; // infinity symbol
	}

	private bool FindBooster(BoosterItem item)
	{
		return item != null;
	}

	private void ConsumeItemAndPeformAction()
	{
		// In offline mode, just perform the action without consuming
		bool success = TryPerformAction();
		if (success)
		{
			m_buttonPressedCallback?.Invoke(m_itemId);
			Refresh();
		}
	}

	protected abstract bool TryPerformAction();

	public abstract void PlayAlertAnimation();

	public void EnableSpeechBubble()
	{
		if (m_hint != null)
			m_hint.gameObject.SetActive(true);
	}

	public void SetFreeBooster()
	{
		m_freeBooster = true;
		if (m_freeBadge != null) m_freeBadge.SetActive(true);
		if (m_inventoryBadge != null) m_inventoryBadge.SetActive(false);
	}

	public void PlayHighlightAnim()
	{
		if (m_helper != null)
			m_helper.Play(ANIM_AVAILABLE);
	}

	public void ClearHighlight()
	{
		if (m_helper != null)
			m_helper.Play(ANIM_DISABLED);
	}

	public void SetButtonEnabled(bool value)
	{
		m_isEnabled = value;
		if (m_button != null)
			m_button.interactable = value;
	}
}
