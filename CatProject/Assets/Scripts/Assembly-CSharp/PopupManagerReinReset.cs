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
	}

	public void Set(int managerIdx)
	{
	}

	private void SetHudTopInfo()
	{
	}

	private void OnClickReinforceResetBtn()
	{
	}
}
