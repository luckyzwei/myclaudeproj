using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpSkins : PopUpBase
{
	private enum WhichTab
	{
		SKINS = 0,
		BOARD_COLOURS = 1
	}

	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-Skins";

	public const string VIP_SKIN = "Skin_E";

	public const string QUEENS_SKIN = "Skin_H";

	public const string ALL_SKINS_BUNDLE = "all_skins_bundle";

	public const string VIP_COLOUR = "BoardColors_D";

	[Header("Close")]
	[SerializeField]
	private GameObject m_closeButton;

	[Header("Tabs")]
	[SerializeField]
	private Button m_skinsTabButton;

	[SerializeField]
	private Button m_coloursTabButton;

	[SerializeField]
	private GameObject m_skinsPanel;

	[SerializeField]
	private GameObject m_coloursPanel;

	[SerializeField]
	private QueenSkinCell m_skinButtonPrefab;

	[SerializeField]
	private QueenSkinCell m_skinVipButtonPrefab;

	[SerializeField]
	private QueenSkinCell m_skinLimitedOfferButtonPrefab;

	[SerializeField]
	private RectTransform m_skinsContainer;

	[SerializeField]
	private BoardColoursCell m_coloursButtonPrefab;

	[SerializeField]
	private BoardColoursCell m_vipColoursButtonPrefab;

	[SerializeField]
	private BoardColoursCell m_limitedOfferColoursButtonPrefab;

	[SerializeField]
	private RectTransform m_coloursContainer;

	[SerializeField]
	private Image m_textureOverlay;

	[Header("Preview")]
	[SerializeField]
	private Image m_queenSprite;

	[Header("Preview")]
	[SerializeField]
	private Image[] m_cellColors;

	[Header("Preview")]
	[SerializeField]
	private int[] m_colorPattern;

	[SerializeField]
	private string m_startingSkin;

	[SerializeField]
	private string m_startingColour;

	private int m_amountOfUnownedSkins;

	private bool m_showAllSkinsPopup;

	private static WhichTab m_selectedTab;

	public static void Open()
	{
		ShowPopup<PopUpSkins>("prefabs/popups/PopUp-Skins", null);
	}

	private void Start()
	{
		// Wire up tab buttons
		if (m_skinsTabButton != null)
			m_skinsTabButton.onClick.AddListener(OnSkinsTabSelected);
		if (m_coloursTabButton != null)
			m_coloursTabButton.onClick.AddListener(OnColoursTabSelected);

		ShowSelectedTab();
		PopulateSkinsCells();
		PopulateColoursCells();
		SetSkin();
		SetColour();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	private void ShowSelectedTab()
	{
		bool showSkins = m_selectedTab == WhichTab.SKINS;
		if (m_skinsPanel != null) m_skinsPanel.SetActive(showSkins);
		if (m_coloursPanel != null) m_coloursPanel.SetActive(!showSkins);
	}

	public void PopulateSkinsCells()
	{
		if (m_skinsContainer == null || m_skinButtonPrefab == null) return;

		var skins = CosmeticsManager.GetAllSkins();
		if (skins == null) return;

		for (int i = 0; i < skins.Count; i++)
		{
			SpawnSkinCell(skins[i]);
		}
	}

	public void PopulateColoursCells()
	{
		if (m_coloursContainer == null || m_coloursButtonPrefab == null) return;

		var colors = CosmeticsManager.GetAllBoardColorsIcons();
		if (colors == null) return;

		for (int i = 0; i < colors.Count; i++)
		{
			SpawnColorsCell(colors[i]);
		}
	}

	private bool CanSkinBeShown(Product product)
	{
		return true; // Show all skins in offline mode
	}

	private void SpawnSkinCell(QueenSkinIcons icon, Product product = null)
	{
		if (m_skinButtonPrefab == null || m_skinsContainer == null) return;
		var cell = Instantiate(m_skinButtonPrefab, m_skinsContainer);
		cell.Configure(icon, OnSkinButtonPressed, PurchaseCallback, PurchaseFailCallback, product);
	}

	private void SpawnColorsCell(BoardColorsIcon icon, Product product = null)
	{
		if (m_coloursButtonPrefab == null || m_coloursContainer == null) return;
		var cell = Instantiate(m_coloursButtonPrefab, m_coloursContainer);
		cell.Configure(icon, OnBoardColorsButtonPressed, product);
	}

	private void OnSkinButtonPressed(QueenSkinIcons icon)
	{
		if (icon == null) return;
		CosmeticsManager.ChangeQueenSkin(icon.ClientId);
		SetSkin();
	}

	private void OnBoardColorsButtonPressed(BoardColorsIcon icon)
	{
		if (icon == null) return;
		CosmeticsManager.ChangeBoardColors(icon.ClientId);
		SetColour();
	}

	public void OnFinishedEditingNameInputField(string text)
	{
		// Name editing not needed for core gameplay
	}

	public void OnClosePressed()
	{
		Close();
	}

	public void OnSkinsTabSelected()
	{
		m_selectedTab = WhichTab.SKINS;
		ShowSelectedTab();
	}

	public void OnColoursTabSelected()
	{
		m_selectedTab = WhichTab.BOARD_COLOURS;
		ShowSelectedTab();
	}

	private void SetSkin()
	{
		// Update preview with current skin
		CosmeticsManager.ApplyCurrentSkin(
			flourishSprite => { if (m_queenSprite != null && flourishSprite != null) m_queenSprite.sprite = flourishSprite; },
			baseSprite => { /* base sprite */ },
			null
		);
	}

	private void SetBaseCrownSprite(Sprite sprite)
	{
		if (m_queenSprite != null && sprite != null)
			m_queenSprite.sprite = sprite;
	}

	private void SetColour()
	{
		// Update preview colors
		if (m_cellColors == null || m_colorPattern == null) return;
		var cm = CosmeticsManager.Instance;
		if (cm == null) return;
		var config = cm.GetCurrentColorConfig();
		if (config == null || config.colors == null) return;

		for (int i = 0; i < m_cellColors.Length && i < m_colorPattern.Length; i++)
		{
			if (m_cellColors[i] != null)
			{
				int idx = m_colorPattern[i];
				if (idx >= 0 && idx < config.colors.Count)
					m_cellColors[i].color = config.colors[idx];
			}
		}
	}

	private void UpdateSkinsAndColoursSubscription()
	{
		// Skip - subscription features
	}

	public void ClosePopupSkins()
	{
		Close();
	}

	private void PurchaseCallback(bool showPopup)
	{
		// Refresh after purchase
		SetSkin();
		SetColour();
	}

	private void PurchaseFailCallback()
	{
		// No action needed
	}

	private static bool HasNoAds()
	{
		return true; // Always no ads in offline mode
	}
}
