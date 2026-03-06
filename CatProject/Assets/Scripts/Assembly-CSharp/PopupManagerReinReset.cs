using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupManagerReinReset", false, false)]
public class PopupManagerReinReset : UIBase
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private Text ReinforceLevelText;

	[SerializeField]
	private Text ReturnReinforceCountText;

	[SerializeField]
	private TimeComponent ReinforceResetCoolTime;

	[SerializeField]
	private Button ReinforceResetBtn;

	[SerializeField]
	private Text ResetCostText;

	private int ManagerIdx;

	private bool IsFreeReset;

	protected override void Awake()
	{
		base.Awake();
		if (ReinforceResetBtn != null) ReinforceResetBtn.onClick.AddListener(OnClickReinforceResetBtn);
	}

	public void Set(int managerIdx)
	{
		ManagerIdx = managerIdx;
		SetHudTopInfo();
	}

	private void SetHudTopInfo()
	{
		if (HUDTopInfo != null) HUDTopInfo.UpdateCurrencyInfos();
	}

	private void OnClickReinforceResetBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}
}
