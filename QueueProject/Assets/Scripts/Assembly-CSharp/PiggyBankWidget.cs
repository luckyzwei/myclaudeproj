using KWUserInterface;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBankWidget : CoinWidget
{
	private const float TALLY_UP_TIME = 0.5f;

	[SerializeField]
	private string m_fullText;

	[Header("Button")]
	[SerializeField]
	private bool m_openPopUpOnPress;

	[SerializeField]
	[Autohook]
	private Button m_button;

	[Header("Optional - Fill Bar")]
	[SerializeField]
	private Image m_fillBar;

	[Header("Lock/Unlock")]
	[SerializeField]
	private GameObject[] m_lockedGameobjects;

	[SerializeField]
	private GameObject[] m_unlockedGameobjects;

	[Header("Lock Text")]
	[SerializeField]
	private TextMeshProUGUI m_lockText;

	[SerializeField]
	private string m_prefix;

	[SerializeField]
	private string m_postfix;

	private bool m_isUnlocked;

	private void Start()
	{
	}

	public void PiggyBankFull()
	{
	}

	private bool IsFull()
	{
		return false;
	}

	protected override void SetMoney()
	{
	}

	private void UpdateFillBar()
	{
	}

	protected override void OnEnable()
	{
	}

	private void SetupPiggyWidget()
	{
	}

	private void OnButtonPressed()
	{
	}

	private static void ToggleGameObject(GameObject[] gameObjects, bool toggle)
	{
	}
}
