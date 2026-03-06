using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupOvertime", false, false)]
public class PopupOvertime : UIBase
{
	[SerializeField]
	private Text OvertimeCostText;

	[SerializeField]
	private Button OvertimeBtn;

	protected override void Awake()
	{
		base.Awake();
		if (OvertimeBtn != null) OvertimeBtn.onClick.AddListener(OnClickedOvertimeButton);
	}

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}

	private void OnClickedOvertimeButton()
	{
		Hide();
	}
}
