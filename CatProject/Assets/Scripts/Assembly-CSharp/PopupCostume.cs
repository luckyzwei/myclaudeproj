using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCostume", false, false)]
public class PopupCostume : UIBase
{
	private enum E_PurchaseType
	{
		InApp = 1,
		Gem = 2
	}

	private enum E_CostumeContentsOpenType
	{
		OneTime = 1,
		OneTime_Bonus = 2
	}

	private static readonly int COSTUME_LIST_BOX_ITEM_COUNT;

	[Header("SelectedCostume")]
	[SerializeField]
	private Text CostumeNameText;

	[SerializeField]
	private Text CostumeDescText;

	[SerializeField]
	private GameObject SelectedCostumeRoot;

	[SerializeField]
	private GameObject CostumeChangeFxObj;

	[Header("Ability")]
	[SerializeField]
	private Text AbilityValueText;

	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private AbilityBubbleTip AbilityBubbleTip;

	[Header("CostumeList")]
	[SerializeField]
	private ScrollRect CostumeScrollRect;

	[SerializeField]
	private GameObject CostumeItemBoxPrefab;

	[Header("Equip")]
	[SerializeField]
	private GameObject EquippedObj;

	[SerializeField]
	private GameObject EquipObj;

	[SerializeField]
	private Button EquipBtn;

	[Header("GemPurchase")]
	[SerializeField]
	private GameObject GemPurchaseObj;

	[SerializeField]
	private Button GemPurchaseBtn;

	[SerializeField]
	private Text GemPurchasePriceText;

	[Header("InAppPurchase")]
	[SerializeField]
	private GameObject InAppPurchaseObj;

	[SerializeField]
	private ButtonInAppPurchase InAppPurchaseBtn;

	[Header("ShortCut")]
	[SerializeField]
	private GameObject ShortCutObj;

	[SerializeField]
	private Button ShortCutBtn;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private Text LockDescText;

	[Header("ETC")]
	[SerializeField]
	private GameObject NotHasDimObj;

	[SerializeField]
	private GameObject PurchaseDoneFxObj;

	private int SelectedCostumeIdx;

	private List<int> SortedCeoCostumeIdxList;

	private E_PurchaseType PurchaseType;

	private int OriginCostumeIdx;

	private int ChangedCostumeIdx;

	private Dictionary<int, GameObject> SelectedCostumeObjMap;

	private List<ItemCostumeList> CachedCostumeItemList;

	protected override void Awake()
	{
		base.Awake();
		SelectedCostumeObjMap = new Dictionary<int, GameObject>();
		CachedCostumeItemList = new List<ItemCostumeList>();
		SortedCeoCostumeIdxList = new List<int>();

		if (EquipBtn != null) EquipBtn.onClick.AddListener(OnClickEquipBtn);
		if (GemPurchaseBtn != null) GemPurchaseBtn.onClick.AddListener(OnClickPurchaseBtn);
		if (ShortCutBtn != null) ShortCutBtn.onClick.AddListener(OnClickShortCutBtn);
	}

	public override void OnShowBefore()
	{
		InitData();
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		int equippedIdx = root.UserData.CeoCostumeData != null ? root.UserData.CeoCostumeData.EquippedCostumeIdx : 0;
		OriginCostumeIdx = equippedIdx;
		ChangedCostumeIdx = equippedIdx;

		SetCostumeList();
		SetSelectedCostume(equippedIdx);
	}

	public override void OnHideBefore()
	{
		if (CostumeChangeFxObj != null) CostumeChangeFxObj.SetActive(false);
	}

	public override void OnHideAfter()
	{
		// Apply costume change if different from original
		if (ChangedCostumeIdx != OriginCostumeIdx)
		{
			// Refresh in-game character appearance
		}
	}

	public override void OnRefresh()
	{
		SetCostumeList();
		SetSelectedCostume(SelectedCostumeIdx);
	}

	private void InitData()
	{
		SortedCeoCostumeIdxList.Clear();
		SelectedCostumeObjMap.Clear();
		CachedCostumeItemList.Clear();
	}

	private void SetSelectedCostume(int costumeIdx)
	{
		SelectedCostumeIdx = costumeIdx;
		if (CostumeNameText != null) CostumeNameText.text = "";
		if (CostumeDescText != null) CostumeDescText.text = "";

		UpdateSelectedCostumeObj();
		UpdateButtonState(costumeIdx, PurchaseType);
	}

	private void SetAbilityInfo(int abilityIdx, int abilityValue)
	{
		if (AbilityValueText != null) AbilityValueText.text = abilityValue.ToString() + "%";
	}

	private void UpdateButtonState(int costumeIdx, E_PurchaseType purchaseType)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		bool isOwned = root.UserData.CeoCostumeData != null && root.UserData.CeoCostumeData.IsHasCostume(costumeIdx);
		bool isEquipped = root.UserData.CeoCostumeData != null && root.UserData.CeoCostumeData.EquippedCostumeIdx == costumeIdx;

		if (EquippedObj != null) EquippedObj.SetActive(isEquipped);
		if (EquipObj != null) EquipObj.SetActive(isOwned && !isEquipped);
		if (GemPurchaseObj != null) GemPurchaseObj.SetActive(!isOwned && purchaseType == E_PurchaseType.Gem);
		if (InAppPurchaseObj != null) InAppPurchaseObj.SetActive(!isOwned && purchaseType == E_PurchaseType.InApp);
		if (NotHasDimObj != null) NotHasDimObj.SetActive(!isOwned);
		if (LockObj != null) LockObj.SetActive(false);
		if (ShortCutObj != null) ShortCutObj.SetActive(false);
	}

	private void UpdateSelectedCostumeObj()
	{
		foreach (var kvp in SelectedCostumeObjMap)
		{
			if (kvp.Value != null) kvp.Value.SetActive(kvp.Key == SelectedCostumeIdx);
		}
	}

	private void SetCostumeList()
	{
		// Populate costume list from CeoCostumeData
	}

	private void OnClickCostumeSelectBtn(int costumeIdx)
	{
		SetSelectedCostume(costumeIdx);
	}

	private void OnClickPurchaseBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Purchase costume via gems
		OnSuccessPurchase(SelectedCostumeIdx, PurchaseType);
	}

	private void OnSuccessPurchase(int costumeIdx, E_PurchaseType purchaseType)
	{
		if (PurchaseDoneFxObj != null)
		{
			PurchaseDoneFxObj.SetActive(false);
			PurchaseDoneFxObj.SetActive(true);
		}
		UpdateButtonState(costumeIdx, purchaseType);
	}

	private void OnClickEquipBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (root.UserData.CeoCostumeData != null)
			root.UserData.CeoCostumeData.ChangeEquippedCostumeIdx(SelectedCostumeIdx);
		ChangedCostumeIdx = SelectedCostumeIdx;

		if (CostumeChangeFxObj != null)
		{
			CostumeChangeFxObj.SetActive(false);
			CostumeChangeFxObj.SetActive(true);
		}
		UpdateButtonState(SelectedCostumeIdx, PurchaseType);
	}

	private void OnClickShortCutBtn()
	{
		// Navigate to content that unlocks the costume
		Hide();
	}

	private int GetContentsOpenType(E_CostumeContentsOpenType costumeContentsOpenType)
	{
		return (int)costumeContentsOpenType;
	}

	private bool IsCostumeOpen(int costumeContentType, int contentIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		// Check if costume unlock condition is met
		return true;
	}
}
