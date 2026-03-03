using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PagePlantManage", false, false)]
public class PagePlantManage : UIBase
{
	[SerializeField]
	private Button infoBtn;

	[SerializeField]
	private Button PreviewBtn;

	[SerializeField]
	private Button BeforeBtn;

	[SerializeField]
	private Button AfterBtn;

	[SerializeField]
	private Image PlantImg;

	[SerializeField]
	private Text NameText;

	[SerializeField]
	private Text LevelText;

	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private Text AbilityDesc;

	[SerializeField]
	private DoTweenScriptComponent PlantLvUpTween;

	[SerializeField]
	private GameObject PlantLvUpEffect;

	[SerializeField]
	private GameObject AbilityRoot;

	[SerializeField]
	private Text BeforeAbilityValue;

	[SerializeField]
	private Text AfterAbilityValue;

	[SerializeField]
	private GameObject MsgRoot;

	[SerializeField]
	private Text MsgText;

	[SerializeField]
	private GameObject NeedTonicMsgRoot;

	[Header("HUD")]
	[SerializeField]
	private GameObject HudRoot;

	[SerializeField]
	private GameObject PowerRoot;

	[SerializeField]
	private GameObject CashRoot;

	[SerializeField]
	private Text PowerText;

	[SerializeField]
	private Text CashText;

	[Header("SpecialPlant")]
	[SerializeField]
	private GameObject SpecialPlantRoot;

	[SerializeField]
	private GameObject SpecialPlantUpgradeRoot;

	[SerializeField]
	private Image SpecialPlantImg;

	[SerializeField]
	private Text SpecialPlantName;

	[SerializeField]
	private Text SpecialPlantCount;

	[SerializeField]
	private Button SpecialPlantUpgradeBtn;

	[SerializeField]
	private Text SpecialBeforeLvText;

	[SerializeField]
	private Text SpecialAfterLvText;

	[SerializeField]
	private Text SpecialBuffText;

	[SerializeField]
	private Text SpecialBeforeBuff;

	[SerializeField]
	private Text SpecialAfterBuff;

	[SerializeField]
	private GameObject SpecialMaxBtn;

	[Header("Gem Special Plant")]
	[SerializeField]
	private GameObject GemRewardRoot;

	[SerializeField]
	private Text GemRewardCount;

	[SerializeField]
	private Button GemRewardBtn;

	[SerializeField]
	private GameObject GemRewardReddot;

	[SerializeField]
	private Text GemRewardTime;

	[SerializeField]
	private Text GemRewardRemainTime;

	[Header("Upgrade")]
	[SerializeField]
	private GameObject UpgradeRoot;

	[SerializeField]
	private Button UpgradeBtn;

	[SerializeField]
	private Text BeforeLvText;

	[SerializeField]
	private Text AfterLvText;

	[SerializeField]
	private Text BuffText;

	[SerializeField]
	private Text BeforeBuff;

	[SerializeField]
	private Text AfterBuff;

	[SerializeField]
	private GameObject MaxBtn;

	[Header("Stat")]
	[SerializeField]
	private GameObject ProgressRoot;

	[SerializeField]
	private Slider ExpProgress;

	[SerializeField]
	private Image ExpProgressFill;

	[SerializeField]
	private Text ExpUpValue;

	[SerializeField]
	private Text ExpPerValue;

	[SerializeField]
	private GameObject ExpMaxObj;

	[SerializeField]
	private Slider FullProgress;

	[SerializeField]
	private Text FullValue;

	[SerializeField]
	private Text FullPerValue;

	[SerializeField]
	private GameObject FullMaxObj;

	[Header("Items")]
	[SerializeField]
	private GameObject SelectItemRoot;

	[SerializeField]
	private List<ItemPlantTonic> Items;

	[SerializeField]
	private Image SelectItemIcon;

	[SerializeField]
	private Text SelectItemName;

	[SerializeField]
	private Text SelectItemDesc;

	[SerializeField]
	private Text SelectItemFullValue;

	[SerializeField]
	private Text SelectItemExpUpValue;

	[SerializeField]
	private Button ItemGiveBtn;

	[SerializeField]
	private Button ItemBuyBtn;

	private int Idx;

	private int CurOrder;

	private int SelectItem;

	private float MaxFull;

	private CompositeDisposable plant_disposables;

	private CompositeDisposable disposables;

	private CompositeDisposable time_disposables;

	private CompositeDisposable hud_disposables;

	protected override void Awake()
	{
	}

	public void Set(int idx)
	{
	}

	public override void OnShowBefore()
	{
	}

	private void UpdateSpecialPlantLevel(int level)
	{
	}

	private void UpdateLevel(int level)
	{
	}

	private void UpdateExp(float exp)
	{
	}

	public void UpdateSelectItem()
	{
	}

	private void OnClickTonicItem(int item)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickPreview()
	{
	}

	private void OnClickBefore()
	{
	}

	private void OnClickAfter()
	{
	}

	private void OnClickGiveItem()
	{
	}

	private void OnClickBuyItem()
	{
	}

	private void OnClickLevelUp()
	{
	}

	private void OnClickGetGemReward()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
