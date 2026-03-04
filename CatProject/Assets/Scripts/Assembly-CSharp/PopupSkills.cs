using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSkills", false, false)]
public class PopupSkills : UIBase
{
	[SerializeField]
	private GameObject SkillListContentsObj;

	[SerializeField]
	private GameObject SkillBookSlotPrefab;

	[SerializeField]
	private GameObject SkillBookGeneralObj;

	[SerializeField]
	private Image GeneralSkillBookIconImg;

	[SerializeField]
	private Text GeneralSkillBookCountText;

	[Header("PackageBanner")]
	[SerializeField]
	private ItemSeasonalPackageBanner PackageBanner;

	private List<ItemSeasonalSkill> SeasonalSkillSlots;

	[HideInInspector]
	public bool IsSkillLeveledUp;

	private bool bUseGeneralSkillBook;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void Init(E_SkillBookAbilityType focusAbilityType)
	{
	}

	private void SetGeneralSkillBookIconImage(string imgKey)
	{
	}

	private void SetGeneralSkillBookCountText(BigInteger hasValue_PerMile)
	{
	}

	private void SetSkillList(E_SkillBookAbilityType focusAbilityType)
	{
	}

	private void ShowSkillBookPackage()
	{
	}

	public GameObject GetFirstUnlockSkillButton()
	{
		return null;
	}

	private void SetPackageBanner()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
