using UnityEngine;
using UnityEngine.UI;

public class ItemManagerInfoOffice : MonoBehaviour
{
	[Header("Level")]
	[SerializeField]
	private Text CardLevelText;

	[SerializeField]
	private SliderTextComponent CardUpgradeSlider;

	[Space(5f)]
	[SerializeField]
	private Button UpgradeBtn;

	[SerializeField]
	private Image UpgradeCardIcon;

	[SerializeField]
	private Text UpgradeText;

	[Space(5f)]
	[SerializeField]
	private GameObject LevelUpArrow;

	[SerializeField]
	private GameObject LevelUpEffect;

	[Header("Value Area")]
	[SerializeField]
	private Image CurAbilityIcon;

	[SerializeField]
	private Text CurAbilityText;

	[SerializeField]
	private GameObject MaxLevelObj;

	[SerializeField]
	private GameObject LockObj;

	[Space(10f)]
	[SerializeField]
	private GameObject CardUpRedDot;

	private int ManagerIdx;

	private bool IsMaxLevel;

	public void Awake()
	{
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickUpgradeBtn);
	}

	public void InitData(int managerIdx)
	{
		ManagerIdx = managerIdx;
		IsMaxLevel = false;
	}

	public void UpdateStatus(ManagerCardData managerData)
	{
		if (managerData == null) return;
		if (MaxLevelObj != null) MaxLevelObj.SetActive(IsMaxLevel);
	}

	private void OnClickUpgradeBtn()
	{
		if (IsMaxLevel) return;
	}

	private void ShowLevelUpEffect()
	{
		if (LevelUpEffect != null) LevelUpEffect.SetActive(true);
	}
}
