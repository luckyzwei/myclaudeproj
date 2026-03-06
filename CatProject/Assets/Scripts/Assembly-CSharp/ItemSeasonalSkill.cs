using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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

	public Button GetSkillUnlockBtn { get { return SkillUnlockButton; } }

	public E_SkillBookAbilityType SkillAbilityType { get; private set; }

	public bool GetMaxLevel { get { return bMaxLevel; } }

	public bool GetEnoughCost { get { return HasValue_PerMile >= NeedValue_PerMile; } }

	private void Awake()
	{
		Disposables = new CompositeDisposable();

		if (SkillLevelUpButton != null) SkillLevelUpButton.onClick.AddListener(OnClickedSkillLevelUpButton);
		if (SkillUnlockButton != null) SkillUnlockButton.onClick.AddListener(OnClickedSkillUnlockButton);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void InitSkillData(SeasonalSkillInfoData skillInfoTable)
	{
		if (skillInfoTable == null) return;
		SkillAbilityType = skillInfoTable.AbilityType;
		MaxSkillLevel = skillInfoTable.MaxLevel;

		SetSkillLevelInfo(skillInfoTable);
		SetSkillIconImage(skillInfoTable.SkillIcon);
	}

	public void SetActiveSelectFx(bool bActive)
	{
		if (SelectFxObj != null) SelectFxObj.SetActive(bActive);
	}

	private void OnLevelUpSkill()
	{
		if (LvUpEffect != null)
		{
			LvUpEffect.SetActive(false);
			LvUpEffect.SetActive(true);
		}
	}

	private void SetSkillLevelInfo(SeasonalSkillInfoData skillInfoTable)
	{
		if (skillInfoTable == null) return;
		CurSkillLevel = 0; // Read from user data
		bMaxLevel = CurSkillLevel >= MaxSkillLevel;

		SetSkillLevelText(CurSkillLevel);
		SetSkillOpenState(bSkillOpen);

		if (MaxLevelObj != null) MaxLevelObj.SetActive(bMaxLevel);
		if (MaxLevelHideObj != null)
		{
			for (int i = 0; i < MaxLevelHideObj.Count; i++)
			{
				if (MaxLevelHideObj[i] != null) MaxLevelHideObj[i].SetActive(!bMaxLevel);
			}
		}
	}

	private void UpdateSkillBookCount()
	{
		SetSkillLevelUpNeedValue(HasValue_PerMile, NeedValue_PerMile);
	}

	private void SetSkillLevelText(int level)
	{
		if (SkillLevelText != null) SkillLevelText.text = "Lv." + level.ToString();
	}

	private void SetSkillIconImage(string iconKey)
	{
		if (SkillIconImage == null || string.IsNullOrEmpty(iconKey)) return;
		Sprite sprite = Resources.Load<Sprite>(iconKey);
		if (sprite != null) SkillIconImage.sprite = sprite;
	}

	private void SetSkillDescText(string descKey, int abilityValue_Per)
	{
		if (SkillAbilityDescText != null)
			SkillAbilityDescText.text = descKey;
	}

	private void SetSkillLevelUpNeedCurrencyIcon(string iconKey)
	{
		if (SkillLevelUpNeedCurrencyIcon == null || string.IsNullOrEmpty(iconKey)) return;
		Sprite sprite = Resources.Load<Sprite>(iconKey);
		if (sprite != null) SkillLevelUpNeedCurrencyIcon.sprite = sprite;
	}

	private void SetSkillLevelUpNeedValue(BigInteger hasValue_PerMile, BigInteger needValue_PerMile)
	{
		HasValue_PerMile = hasValue_PerMile;
		NeedValue_PerMile = needValue_PerMile;

		if (SkillLevelUpNeedValueProgressText != null)
		{
			string text = ProjectUtility.GetThousandCommaText(hasValue_PerMile) + "/" + ProjectUtility.GetThousandCommaText(needValue_PerMile);
			SkillLevelUpNeedValueProgressText.SetText(text);
		}

		if (SkillLevelUpButton != null)
			SkillLevelUpButton.interactable = hasValue_PerMile >= needValue_PerMile;
	}

	private void SetSkillOpenState(bool bOpen)
	{
		bSkillOpen = bOpen;
		if (SkillLockedObj != null) SkillLockedObj.SetActive(!bOpen);
		if (SkillLevelUpButton != null) SkillLevelUpButton.gameObject.SetActive(bOpen && !bMaxLevel);
	}

	private void OnClickedSkillLevelUpButton()
	{
		if (bMaxLevel) return;
		if (HasValue_PerMile < NeedValue_PerMile) return;
		OnLevelUpSkill();
	}

	private void OnClickedSkillUnlockButton()
	{
	}
}
