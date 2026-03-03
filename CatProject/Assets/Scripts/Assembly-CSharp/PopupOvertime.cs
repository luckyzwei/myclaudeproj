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
	}

	public override void OnShowBefore()
	{
	}

	private void OnClickedOvertimeButton()
	{
	}
}
