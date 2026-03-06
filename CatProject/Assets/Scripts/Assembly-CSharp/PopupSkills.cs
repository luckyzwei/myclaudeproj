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
		base.Awake();
		Disposables = new CompositeDisposable();
		SeasonalSkillSlots = new List<ItemSeasonalSkill>();
	}

	public override void OnShowBefore()
	{
		if (Disposables != null) { Disposables.Dispose(); }
		Disposables = new CompositeDisposable();
	}

	public override void OnHideAfter()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void Init(E_SkillBookAbilityType focusAbilityType)
	{
		IsSkillLeveledUp = false;
		SetSkillList(focusAbilityType);
		SetPackageBanner();
	}

	private void SetGeneralSkillBookIconImage(string imgKey)
	{
		if (GeneralSkillBookIconImg == null || string.IsNullOrEmpty(imgKey)) return;
		Sprite sprite = Resources.Load<Sprite>(imgKey);
		if (sprite != null) GeneralSkillBookIconImg.sprite = sprite;
	}

	private void SetGeneralSkillBookCountText(BigInteger hasValue_PerMile)
	{
		if (GeneralSkillBookCountText != null)
			GeneralSkillBookCountText.text = ProjectUtility.GetThousandCommaText(hasValue_PerMile);
	}

	private void SetSkillList(E_SkillBookAbilityType focusAbilityType)
	{
		SeasonalSkillSlots.Clear();
		if (SkillBookGeneralObj != null) SkillBookGeneralObj.SetActive(bUseGeneralSkillBook);
	}

	private void ShowSkillBookPackage()
	{
		if (PackageBanner != null) PackageBanner.gameObject.SetActive(true);
	}

	public GameObject GetFirstUnlockSkillButton()
	{
		for (int i = 0; i < SeasonalSkillSlots.Count; i++)
		{
			if (SeasonalSkillSlots[i] != null && SeasonalSkillSlots[i].GetSkillUnlockBtn != null)
				return SeasonalSkillSlots[i].GetSkillUnlockBtn.gameObject;
		}
		return null;
	}

	private void SetPackageBanner()
	{
		if (PackageBanner != null) PackageBanner.gameObject.SetActive(false);
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}
}
