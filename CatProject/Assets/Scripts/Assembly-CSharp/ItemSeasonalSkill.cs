using System.Collections.Generic;
using System.Numerics;
using SeasonalDef;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemSeasonalSkill : MonoBehaviour
{
	[SerializeField]
	private Text SkillAbilityDescText;

	[SerializeField]
	private Image SkillIconImage;

	[SerializeField]
	private Text SkillLevelText;

	[SerializeField]
	private Image SkillLevelUpNeedCurrencyIcon;

	[SerializeField]
	private ProgressText SkillLevelUpNeedValueProgressText;

	[SerializeField]
	private Button SkillLevelUpButton;

	[SerializeField]
	private GameObject SkillLockedObj;

	[SerializeField]
	private Button SkillUnlockButton;

	[SerializeField]
	private GameObject LvUpEffect;

	[SerializeField]
	private GameObject SelectFxObj;

	[SerializeField]
	private List<GameObject> MaxLevelHideObj;

	[SerializeField]
	private GameObject MaxLevelObj;

	private CompositeDisposable Disposables;

	private int SkillOrderIdx;

	private E_CurrencyType NeedCurrencyType;

	private int CurSkillLevel;

	private int MaxSkillLevel;

	private bool bSkillOpen;

	private bool bMaxLevel;

	private BigInteger HasValue_PerMile;

	private BigInteger NeedValue_PerMile;

	public Button GetSkillUnlockBtn => null;

	public E_SkillBookAbilityType SkillAbilityType { get; private set; }

	public bool GetMaxLevel => false;

	public bool GetEnoughCost => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitSkillData(SeasonalSkillInfoData skillInfoTable)
	{
	}

	public void SetActiveSelectFx(bool bActive)
	{
	}

	private void OnLevelUpSkill()
	{
	}

	private void SetSkillLevelInfo(SeasonalSkillInfoData skillInfoTable)
	{
	}

	private void UpdateSkillBookCount()
	{
	}

	private void SetSkillLevelText(int level)
	{
	}

	private void SetSkillIconImage(string iconKey)
	{
	}

	private void SetSkillDescText(string descKey, int abilityValue_Per)
	{
	}

	private void SetSkillLevelUpNeedCurrencyIcon(string iconKey)
	{
	}

	private void SetSkillLevelUpNeedValue(BigInteger hasValue_PerMile, BigInteger needValue_PerMile)
	{
	}

	private void SetSkillOpenState(bool bOpen)
	{
	}

	private void OnClickedSkillLevelUpButton()
	{
	}

	private void OnClickedSkillUnlockButton()
	{
	}
}
