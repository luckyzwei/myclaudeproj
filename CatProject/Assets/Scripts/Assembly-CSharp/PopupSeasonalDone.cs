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
	}

	private void OnDestroy()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void Init(int seasonInfoIdx, bool showShortcutBtn)
	{
	}

	public override void Hide()
	{
	}

	private void Load_ItemSeasonalThemeResource()
	{
	}
}
