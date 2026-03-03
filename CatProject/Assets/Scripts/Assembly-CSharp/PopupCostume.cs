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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public override void OnRefresh()
	{
	}

	private void InitData()
	{
	}

	private void SetSelectedCostume(int costumeIdx)
	{
	}

	private void SetAbilityInfo(int abilityIdx, int abilityValue)
	{
	}

	private void UpdateButtonState(int costumeIdx, E_PurchaseType purchaseType)
	{
	}

	private void UpdateSelectedCostumeObj()
	{
	}

	private void SetCostumeList()
	{
	}

	private void OnClickCostumeSelectBtn(int costumeIdx)
	{
	}

	private void OnClickPurchaseBtn()
	{
	}

	private void OnSuccessPurchase(int costumeIdx, E_PurchaseType purchaseType)
	{
	}

	private void OnClickEquipBtn()
	{
	}

	private void OnClickShortCutBtn()
	{
	}

	private int GetContentsOpenType(E_CostumeContentsOpenType costumeContentsOpenType)
	{
		return 0;
	}

	private bool IsCostumeOpen(int costumeContentType, int contentIdx)
	{
		return false;
	}
}
