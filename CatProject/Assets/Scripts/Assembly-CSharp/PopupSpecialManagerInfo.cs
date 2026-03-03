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
	}

	public override void OnShowBefore()
	{
	}

	public void SetSuper(int _superStaffIdx)
	{
	}

	private void OnDestroy()
	{
	}

	private void ShowLevelUpEffect()
	{
	}

	private void Update()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickInfo()
	{
	}
}
