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
		base.Awake();
		disposables = new CompositeDisposable();
		plant_disposables = new CompositeDisposable();
		time_disposables = new CompositeDisposable();
		hud_disposables = new CompositeDisposable();

		if (infoBtn != null) infoBtn.onClick.AddListener(OnClickInfo);
		if (PreviewBtn != null) PreviewBtn.onClick.AddListener(OnClickPreview);
		if (BeforeBtn != null) BeforeBtn.onClick.AddListener(OnClickBefore);
		if (AfterBtn != null) AfterBtn.onClick.AddListener(OnClickAfter);
		if (ItemGiveBtn != null) ItemGiveBtn.onClick.AddListener(OnClickGiveItem);
		if (ItemBuyBtn != null) ItemBuyBtn.onClick.AddListener(OnClickBuyItem);
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickLevelUp);
		if (SpecialPlantUpgradeBtn != null) SpecialPlantUpgradeBtn.onClick.AddListener(OnClickLevelUp);
		if (GemRewardBtn != null) GemRewardBtn.onClick.AddListener(OnClickGetGemReward);
	}

	public void Set(int idx)
	{
		Idx = idx;
		CurOrder = 0;
		SelectItem = -1;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		// Set plant display info
		UpdateSelectItem();
	}

	public override void OnShowBefore()
	{
		Set(Idx);
	}

	private void UpdateSpecialPlantLevel(int level)
	{
		if (SpecialBeforeLvText != null) SpecialBeforeLvText.text = level.ToString();
		if (SpecialAfterLvText != null) SpecialAfterLvText.text = (level + 1).ToString();
	}

	private void UpdateLevel(int level)
	{
		if (LevelText != null) LevelText.text = "Lv." + level.ToString();
		if (BeforeLvText != null) BeforeLvText.text = level.ToString();
		if (AfterLvText != null) AfterLvText.text = (level + 1).ToString();
	}

	private void UpdateExp(float exp)
	{
		if (ExpProgress != null && MaxFull > 0)
			ExpProgress.value = exp / MaxFull;
		if (ExpUpValue != null) ExpUpValue.text = ((int)exp).ToString();
	}

	public void UpdateSelectItem()
	{
		if (SelectItem < 0)
		{
			if (SelectItemRoot != null) SelectItemRoot.SetActive(false);
			return;
		}
		if (SelectItemRoot != null) SelectItemRoot.SetActive(true);
	}

	private void OnClickTonicItem(int item)
	{
		SelectItem = item;
		UpdateSelectItem();
	}

	private void OnClickInfo()
	{
		// Show plant info popup
	}

	private void OnClickPreview()
	{
		// Show plant preview
	}

	private void OnClickBefore()
	{
		if (CurOrder > 0)
		{
			CurOrder--;
			Set(Idx);
		}
	}

	private void OnClickAfter()
	{
		CurOrder++;
		Set(Idx);
	}

	private void OnClickGiveItem()
	{
		if (SelectItem < 0) return;
		// Give selected tonic to plant
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickBuyItem()
	{
		// Navigate to tonic purchase
	}

	private void OnClickLevelUp()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Level up the plant
	}

	private void OnClickGetGemReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Claim gem reward from special plant
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
		if (plant_disposables != null) { plant_disposables.Dispose(); plant_disposables = null; }
		if (time_disposables != null) { time_disposables.Dispose(); time_disposables = null; }
		if (hud_disposables != null) { hud_disposables.Dispose(); hud_disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		if (plant_disposables != null) { plant_disposables.Dispose(); plant_disposables = new CompositeDisposable(); }
		if (time_disposables != null) { time_disposables.Dispose(); time_disposables = new CompositeDisposable(); }
		if (hud_disposables != null) { hud_disposables.Dispose(); hud_disposables = new CompositeDisposable(); }
	}
}
