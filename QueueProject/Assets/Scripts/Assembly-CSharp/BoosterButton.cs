using System;
using Balancy.Models.Inventory;
using Balancy.Models.SmartObjects;
using TMPro;
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
	private TextMeshProUGUI m_inventoryText;

	[SerializeField]
	private TextMeshProUGUI m_priceText;

	[SerializeField]
	private TextMeshProUGUI m_unlockLevel;

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

	public bool IsUnlocked => false;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void OnGridIntroDone()
	{
	}

	private void OnItemCountChange(Item item, int count, int slotindex)
	{
	}

	private void LevelSolved()
	{
	}

	public void Configure(string kwaleeItemId, Action<string> buttonPressedCallback, int unlockLevel, BoosterButtonType type)
	{
	}

	private void ConfigureLocked(int unlockLevel)
	{
	}

	public void Refresh()
	{
	}

	protected virtual void ConfigureVisuals()
	{
	}

	public virtual void OnButtonPressed()
	{
	}

	private int FindFirstPreplacedQueen()
	{
		return 0;
	}

	private void RefreshInventory()
	{
	}

	private bool FindBooster(BoosterItem item)
	{
		return false;
	}

	private void ConsumeItemAndPeformAction()
	{
	}

	protected abstract bool TryPerformAction();

	public abstract void PlayAlertAnimation();

	public void EnableSpeechBubble()
	{
	}

	public void SetFreeBooster()
	{
	}

	public void PlayHighlightAnim()
	{
	}

	public void ClearHighlight()
	{
	}

	public void SetButtonEnabled(bool value)
	{
	}
}
