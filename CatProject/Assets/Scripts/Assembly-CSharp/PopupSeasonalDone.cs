using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalDone", false, false)]
public class PopupSeasonalDone : UIBase
{
	[SerializeField]
	private Text SeasonDoneDescText;

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private Button RewardPopupShortCutBtn;

	[SerializeField]
	private GameObject ThemeBgParentsObj;

	private GameObject AddressableLoadBgObj;

	private bool bTryLoadAddressableObj;

	private int SeasonInfoIdx;

	protected override void Awake()
	{
		base.Awake();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(() => Hide());
		if (RewardPopupShortCutBtn != null) RewardPopupShortCutBtn.onClick.AddListener(() => Hide());
	}

	private void OnDestroy()
	{
		if (AddressableLoadBgObj != null)
		{
			Destroy(AddressableLoadBgObj);
			AddressableLoadBgObj = null;
		}
	}

	public override void OnShowBefore()
	{
		bTryLoadAddressableObj = false;
	}

	public void Init(int seasonInfoIdx, bool showShortcutBtn)
	{
		SeasonInfoIdx = seasonInfoIdx;
		if (RewardPopupShortCutBtn != null) RewardPopupShortCutBtn.gameObject.SetActive(showShortcutBtn);
		Load_ItemSeasonalThemeResource();
		Show();
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void Load_ItemSeasonalThemeResource()
	{
		bTryLoadAddressableObj = true;
	}
}
