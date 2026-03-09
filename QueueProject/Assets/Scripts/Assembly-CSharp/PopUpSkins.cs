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
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void ShowSelectedTab()
	{
	}

	public void PopulateSkinsCells()
	{
	}

	public void PopulateColoursCells()
	{
	}

	private bool CanSkinBeShown(Product product)
	{
		return false;
	}

	private void SpawnSkinCell(QueenSkinIcons icon, Product product = null)
	{
	}

	private void SpawnColorsCell(BoardColorsIcon icon, Product product = null)
	{
	}

	private void OnSkinButtonPressed(QueenSkinIcons icon)
	{
	}

	private void OnBoardColorsButtonPressed(BoardColorsIcon icon)
	{
	}

	public void OnFinishedEditingNameInputField(string text)
	{
	}

	public void OnClosePressed()
	{
	}

	public void OnSkinsTabSelected()
	{
	}

	public void OnColoursTabSelected()
	{
	}

	private void SetSkin()
	{
	}

	private void SetBaseCrownSprite(Sprite sprite)
	{
	}

	private void SetColour()
	{
	}

	private void UpdateSkinsAndColoursSubscription()
	{
	}

	public void ClosePopupSkins()
	{
	}

	private void PurchaseCallback(bool showPopup)
	{
	}

	private void PurchaseFailCallback()
	{
	}

	private static bool HasNoAds()
	{
		return false;
	}
}
