using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupSpecialManagerInfo", false, false)]
public class PopupSpecialManagerInfo : UIBase
{
	[Header("Info Area")]
	[SerializeField]
	private Text ManagerName;

	[SerializeField]
	private Text ManagerLevel;

	[SerializeField]
	private Text UpgradeText;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private Text SSCoinText;

	[SerializeField]
	private GameObject UpgradePossible;

	[SerializeField]
	private GameObject UpgradeNoPossible;

	[SerializeField]
	private GameObject LvUpEffect;

	[Header("Ability")]
	[SerializeField]
	private List<Text> listAbilityNames;

	[SerializeField]
	private List<Text> listAbilityValues;

	[Header("Main Button")]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button UpgradeBtn;

	[Header("ETC")]
	[SerializeField]
	private List<SuperStaffStatComponent> superStats;

	[SerializeField]
	private List<GameObject> totalMainStats;

	[SerializeField]
	private GameObject statRoot;

	private int requireItemCnt;

	private int superStaffIdx;

	private bool isMax;

	private bool bStartLvAction;

	private float deltaTime;

	private CompositeDisposable disposable;

	protected override void Awake()
	{
		base.Awake();
		disposable = new CompositeDisposable();
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickUpgrade);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public override void OnShowBefore()
	{
		bStartLvAction = false;
		deltaTime = 0f;
	}

	public void SetSuper(int _superStaffIdx)
	{
		superStaffIdx = _superStaffIdx;
		isMax = false;
		requireItemCnt = 0;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (UpgradePossible != null) UpgradePossible.SetActive(!isMax);
		if (UpgradeNoPossible != null) UpgradeNoPossible.SetActive(isMax);
		if (LvUpEffect != null) LvUpEffect.SetActive(false);
		if (statRoot != null) statRoot.SetActive(true);
	}

	private void OnDestroy()
	{
		if (disposable != null) { disposable.Dispose(); disposable = null; }
	}

	private void ShowLevelUpEffect()
	{
		bStartLvAction = true;
		deltaTime = 0f;
		if (LvUpEffect != null) LvUpEffect.SetActive(true);
	}

	private void Update()
	{
		if (!bStartLvAction) return;
		deltaTime += Time.deltaTime;
		if (deltaTime >= 1.5f)
		{
			bStartLvAction = false;
			if (LvUpEffect != null) LvUpEffect.SetActive(false);
		}
	}

	private void OnClickUpgrade()
	{
		if (isMax) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		ShowLevelUpEffect();
		SetSuper(superStaffIdx);
	}

	private void OnClickInfo()
	{
	}
}
