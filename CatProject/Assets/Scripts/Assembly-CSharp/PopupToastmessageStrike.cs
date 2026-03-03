using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupToastmessageStrike", false, false)]
public class PopupToastmessageStrike : UIBase
{
	[Header("PopupToastmessageStrike")]
	[SerializeField]
	private GameObject RemainTimeObj;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button ConfirmBtn;

	private bool isShowRemainTime;

	private float timer;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void SetActiveTime(bool isShow)
	{
	}

	private void Update()
	{
	}

	public void OnClickConfirm()
	{
	}
}
